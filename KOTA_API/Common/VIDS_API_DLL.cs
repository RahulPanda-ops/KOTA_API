using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Text;

namespace KOTA_API.Common
{
    internal class VIDS_API_DLL
    {

        //public string InsertVIDSEvents(VIDSEntity vIDSEntity, int ProcessType)
        //{
        //    string strReturnValue = "";
        //    try
        //    {

        //        using (NpgsqlConnection connection = new NpgsqlConnection(DBF.DBConnection.ConnectionString()))
        //        {
        //            connection.Open();

        //            using (NpgsqlCommand cmd = new NpgsqlCommand("public.update_events_status", connection))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("outputparam", NpgsqlTypes.NpgsqlDbType.Varchar).Direction = System.Data.ParameterDirection.Output;
        //                cmd.Parameters.AddWithValue("p_incident_id", Convert.ToString(vIDSEntity.incedent_id));
        //                cmd.Parameters.AddWithValue("p_success", vIDSEntity.Success);                        
        //                cmd.Parameters.AddWithValue("p_errorcode", vIDSEntity.ErrorCode);
        //                cmd.Parameters.AddWithValue("p_message", vIDSEntity.Message);

        //                cmd.ExecuteNonQuery();
        //                string result = outParam.Value?.ToString();
        //                strReturnValue = cmd.Parameters["@p_outputparam"].Value.ToString();
        //                connection.Close();
        //            }

        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        Log.Write("Exception in TrafikCityDLL  InsertTrafikCity  " + ex.Message, Log.ErrorLogModule.City);
        //    }
        //    return strReturnValue;
        //}

        public string InsertVIDSEvents(VIDSEntity vIDSEntity, int ProcessType)
        {
            try
            {
                using (var connection = new NpgsqlConnection(DBF.DBConnection.ConnectionString()))
                {
                    connection.Open();

                    using (var cmd = new NpgsqlCommand("public.update_events_status", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        var outParam = new NpgsqlParameter("p_outputparam", NpgsqlTypes.NpgsqlDbType.Varchar)
                        {
                            Direction = ParameterDirection.InputOutput,
                            Value = ""
                        };

                        cmd.Parameters.Add(outParam);

                        cmd.Parameters.AddWithValue("p_incident_id", vIDSEntity.incedent_id);
                        cmd.Parameters.AddWithValue("p_success", Convert.ToString(vIDSEntity.Success));
                        cmd.Parameters.AddWithValue("p_errorcode", Convert.ToString(vIDSEntity.ErrorCode));
                        cmd.Parameters.AddWithValue("p_message", Convert.ToString(vIDSEntity.Message));

                        cmd.ExecuteNonQuery();

                        return outParam.Value?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Serilog.Log.Logger.Error("Exception in InsertVIDSEvents : {errorMessage}", ex.Message);
                return ex.Message;
            }
        }
        public ObservableCollection<VIDSEntity> GetVIDSEvents()
        {
            DataTable dt = new DataTable();

            ObservableCollection<VIDSEntity> events = new ObservableCollection<VIDSEntity>();

            try
            {
                string query = "SELECT * FROM public.retreive_vids_events(@ProcessType)";
                int ProcessType = 1;
                using (var conn = new NpgsqlConnection(DBF.DBConnection.ConnectionString()))
                {
                    conn.Open();
                 
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProcessType", ProcessType);
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                            events = ConvertDataTableToCollectionOC(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Serilog.Log.Logger.Error("Exception in GetEvents : {errorMessage}", ex.Message);
            }

            return events;
        }

        private static ObservableCollection<VIDSEntity> ConvertDataTableToCollectionOC(DataTable dt)
        {
            ObservableCollection<VIDSEntity> events = new ObservableCollection<VIDSEntity>();

            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    VIDSEntity obj = new VIDSEntity();

                    if (row["incident_id"] != DBNull.Value)
                        obj.incedent_id = Convert.ToInt32(row["incident_id"]);

                    if (row["ctype"] != DBNull.Value)
                        obj.CType = row["ctype"].ToString();

                    if (row["location"] != DBNull.Value)
                        obj.Location = row["location"].ToString();

                    if (row["lane"] != DBNull.Value)
                        obj.Lane = row["lane"].ToString();

                    if (row["datetime"] != DBNull.Value)
                        obj.DateTime = row["datetime"].ToString();

                    if (row["fullimage"] != DBNull.Value)
                        obj.FullImage = row["fullimage"].ToString();

                    if (row["videourl"] != DBNull.Value)
                        obj.VideoUrl = row["videourl"].ToString();

                    if (row["category"] != DBNull.Value)
                        obj.Category = row["category"].ToString();

                    if (row["ipaddresscam"] != DBNull.Value)
                        obj.IpAddressCam = row["ipaddresscam"].ToString();

                    if (row["ipaddresssystem"] != DBNull.Value)
                        obj.IpAddressSystem = row["ipaddresssystem"].ToString();

                    if (row["eventname"] != DBNull.Value)
                        obj.EventName = row["eventname"].ToString();

                    if (row["generatedby"] != DBNull.Value)
                        obj.GeneratedBy = row["generatedby"].ToString();

                    if (row["latitude"] != DBNull.Value)
                        obj.Latitude = row["latitude"].ToString();

                    if (row["longitude"] != DBNull.Value)
                        obj.Longitude = row["longitude"].ToString();

                    if (row["packagenumber"] != DBNull.Value)
                        obj.PackageNumber = row["packagenumber"].ToString();

                    events.Add(obj);
                }
            }
            catch (Exception ex)
            {
                Serilog.Log.Logger.Error("Exception in ConvertDataTableToCollectionOC : {errorMessage}", ex.Message);
            }

            return events;
        }
    }
}
