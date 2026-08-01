using KOTA_API.Common;
using KOTA_API.DBF;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.WebRequestMethods;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace KOTA_API
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _configuration;

        public Worker(ILogger<Worker> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            CommonVariables.ConnectionString = _configuration["PostgresqlConn"];
            CommonVariables.VIDS_API_KEY = _configuration["VIDS_API_KEY"];
            CommonVariables.VIDS_API_URL = _configuration["VIDS_API_URL"];
            CommonVariables.Http_URL = _configuration["Http_URL"];
            CommonVariables.DriveName = _configuration["DriveName"];
            VIDSEventService();
            //while (!stoppingToken.IsCancellationRequested)
            //{
            //    if (_logger.IsEnabled(LogLevel.Information))
            //    {
            //        _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            //    }
            //    await Task.Delay(1000, stoppingToken);
            //}
        }
        private bool _isVIDSEventInProgress = true;

        private async Task VIDSEventService()
        {
            while (true)
            {
                try
                {
                    if (_isVIDSEventInProgress)
                    {
                        _isVIDSEventInProgress = false;
                        VIDS_API_DLL vIDS_API_DLL = new VIDS_API_DLL();

                        ObservableCollection<VIDSEntity> events = vIDS_API_DLL.GetVIDSEvents();

                        if (events == null || events.Count == 0)
                            return;

                        using (HttpClient client = new HttpClient())
                        {
                            client.Timeout = TimeSpan.FromSeconds(30);

                            foreach (var item in events)
                            {
                                try
                                {
                                    VIDSEntity request = new VIDSEntity
                                    {
                                        incedent_id = item.incedent_id,
                                        CType = item.CType,
                                        Location = item.Location,
                                        Lane = item.Lane,
                                        DateTime = item.DateTime,
                                        FullImage = CommonVariables.Http_URL + item.FullImage,
                                        VideoUrl = CommonVariables.Http_URL + item.VideoUrl,
                                        Category = item.Category,
                                        IpAddressCam = item.IpAddressCam,
                                        IpAddressSystem = item.IpAddressSystem,
                                        EventName = item.EventName,
                                        GeneratedBy = item.GeneratedBy,
                                        Latitude = item.Latitude,
                                        Longitude = item.Longitude,
                                        PackageNumber = item.PackageNumber
                                    };

                                    List<VIDSEntity> requestList = new List<VIDSEntity>();
                                    requestList.Add(request);

                                    string json = JsonConvert.SerializeObject(requestList, Newtonsoft.Json.Formatting.Indented);

                                    Log.Write("Request JSON : " + json, Log.ErrorLogModule.VIDS);

                                    client.DefaultRequestHeaders.Clear();

                                    client.DefaultRequestHeaders.Accept.Add(
                                        new MediaTypeWithQualityHeaderValue("application/json"));

                                    client.DefaultRequestHeaders.Add(
                                        "x-api-key",
                                        CommonVariables.VIDS_API_KEY);




                                    StringContent content = new StringContent(
                                        json,
                                        Encoding.UTF8,
                                        "application/json");

                                    HttpResponseMessage response = await client.PostAsync(CommonVariables.VIDS_API_URL, content);

                                    string responseBody =
                                        await response.Content.ReadAsStringAsync();

                                    Log.Write("Response : " + responseBody,
                                        Log.ErrorLogModule.VIDS);

                                    if (response.IsSuccessStatusCode)
                                    {
                                        Log.Write("Incident Sent Successfully : "
                                            + item.incedent_id,
                                            Log.ErrorLogModule.VIDS);

                                        VIDSEntity vIDSEntity = JsonConvert.DeserializeObject<VIDSEntity>(responseBody);
                                        //EntryTransactionEntity sendEntry = JsonConvert.DeserializeObject<EntryTransactionEntity>(responseBody);

                                        string outputmsg2 = string.Empty;
                                        vIDSEntity.incedent_id = request.incedent_id;
                                        vIDSEntity.Success = vIDSEntity.Success;
                                        vIDSEntity.ErrorCode = vIDSEntity.ErrorCode;
                                        vIDSEntity.Message = vIDSEntity.Message;
                                        outputmsg2 = Convert.ToString(vIDS_API_DLL.InsertVIDSEvents(vIDSEntity, 2));

                                        if (!outputmsg2.Contains("updated"))
                                        {
                                            Log.Write(vIDSEntity.incedent_id + ": Reuploaded Transaction", Log.ErrorLogModule.VIDS);
                                            await Task.Delay(TimeSpan.FromMilliseconds(1000));
                                            outputmsg2 = Convert.ToString(vIDS_API_DLL.InsertVIDSEvents(vIDSEntity, 2));
                                            _isVIDSEventInProgress = true;
                                        }
                                        if (outputmsg2.Contains("updated"))
                                        {
                                            Log.Write("Data Updated Suceessfully", Log.ErrorLogModule.VIDS);
                                            outputmsg2 = string.Empty;
                                            _isVIDSEventInProgress = true;
                                        }
                                        // Update database here if required
                                    }
                                    else
                                    {
                                        _isVIDSEventInProgress = true;
                                        Log.Write("Failed : " + response.StatusCode + " " + responseBody, Log.ErrorLogModule.VIDS);
                                    }

                                    await Task.Delay(250);
                                }
                                catch (Exception ex)
                                {
                                    _isVIDSEventInProgress = true;
                                    Log.Write("Exception sending Incident " + item.incedent_id + " : " + ex.Message, Log.ErrorLogModule.VIDS);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _isVIDSEventInProgress = true;
                    Log.Write("Exception in VIDSEventService : "
                        + ex.Message,
                        Log.ErrorLogModule.VIDS);
                }
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }
    }
}
