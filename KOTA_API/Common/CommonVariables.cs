using System;
using System.Collections.Generic;
using System.Text;

namespace KOTA_API.Common
{
    public class CommonVariables
    {

        #region Common Variables Declaration

        public static string DriveName { get; set; }
        public static string ConnectionString { get; set; }
        public static string VIDS_API_KEY { get; set; }
        public static string VIDS_API_URL { get; set; }

        public static string CompanyName { get; set; }
        public static string AboutCompany { get; set; }
        public static string OfficeAddress { get; set; }
        public static string BillingPhoneNo { get; set; }

        public static string VideoCompressSize { get; set; }
        //Retrieve End Point and Start Point of Project Master
        public static decimal ProjectEndPoint { get; set; }
        public static decimal ProjectStartPoint { get; set; }

        public static string CentralServerVDSIP { get; set; }

        public static string CentralServerVDSUser { get; set; }
        public static string CentralServerVDSPassword { get; set; }

        public static string CentralServerVIDSIP { get; set; }

        public static string CentralServerVIDSUser { get; set; }
        public static string CentralServerVIDSPassword { get; set; }

        //These variables are used for route start and end position.
        public static string RouteStart { get; set; }
        public static string RouteEnd { get; set; }
        //This variable is used to set map view degree.
        public static string Bearing { get; set; }
        /* start, Used for Weather Data on DashBoard, 
         * if Weather Type is true into TrafikViewStructure then retrieve Virtual Weather Data on DashBoard  
         * If Weather Type is false into TrafikViewStructure then retrieve Physical Weather Data on DashBoard 
         * Date:-21-01-2021 , Mohit Tyagi
         */
        public static string WeatherType { get; set; }
        //End WeatherType decleation  , 21-01-2021 ,Mohit Tyagi 

        /* start, Used for Weather Speed Data on all Weather Modules, 
         * if WeatherSpeed is true into TrafikViewStructure then retrieve Speed in MPS on all Weather Modules  
         * If WeatherSpeed is false into TrafikViewStructure then retrieve Speed in KPS on all Weather Modules 
         * Date:-05-02-2021 , Mohit Tyagi
         */
        public static bool WeatherSpeed { get; set; }
        //End WeatherSpeed decleation  , 05-02-2021 ,Mohit Tyagi 
        #endregion

        #region Display Time on Required Program.
        public static List<ComboData> GetValue()
        {
            List<ComboData> ListData = new List<ComboData>();
            ListData.Add(new ComboData { Id = -1, Value = "--Select--" });
            ListData.Add(new ComboData { Id = 0, Value = "Highest" });
            ListData.Add(new ComboData { Id = 1, Value = "High" });
            ListData.Add(new ComboData { Id = 2, Value = "Medium" });
            ListData.Add(new ComboData { Id = 3, Value = "Normal" });
            ListData.Add(new ComboData { Id = 4, Value = "Low" });
            ListData.Add(new ComboData { Id = 5, Value = "Lowest" });

            return ListData;
        }

        public static List<ComboData> GetPattern()
        {
            List<ComboData> ListData = new List<ComboData>();
            ListData.Add(new ComboData { Id = -1, Value = "--Select--" });
            ListData.Add(new ComboData { Id = 0, Value = "0" });
            ListData.Add(new ComboData { Id = 1, Value = "1" });
            ListData.Add(new ComboData { Id = 2, Value = "2" });
            ListData.Add(new ComboData { Id = 3, Value = "3" });

            return ListData;
        }
        public static List<ComboData> GetTime(int cmbcase)
        {
            List<ComboData> ListData = new List<ComboData>();
            switch (cmbcase)
            {

                case 1:

                    for (int i = 0; i <= 23; i = i + 1)
                    {
                        ListData.Add(new ComboData { Id = i, Value = i <= 9 ? "0" + i.ToString() : i.ToString() });
                    }
                    break;
                case 2:
                    for (int i = 0; i <= 59; i = i + 1)
                    {
                        ListData.Add(new ComboData { Id = i, Value = i <= 9 ? "0" + i.ToString() : i.ToString() });
                    }
                    break;

            }
            return ListData;
        }

        #endregion
        // To Display Status
        public static List<ComboData> GetStatus()
        {
            List<ComboData> ListData = new List<ComboData>();
            ListData.Add(new ComboData { Id = 0, Value = "--Select--" });
            ListData.Add(new ComboData { Id = 1, Value = "Open" });
            ListData.Add(new ComboData { Id = 2, Value = "Closed" });

            return ListData;
        }

        // To Display Message is Scheduled or Instant
        public static List<ComboData> GetMessageFormat()
        {
            List<ComboData> ListData = new List<ComboData>();
            ListData.Add(new ComboData { Id = 2, Value = "--Select--" });
            ListData.Add(new ComboData { Id = 1, Value = "Scheduled Message" });
            ListData.Add(new ComboData { Id = 0, Value = "Instant Message" });

            return ListData;
        }
    }
    /// <summary>
    /// This Method used for Combobox 
    /// </summary>
    public class ComboData
    {
        #region Variable Declaration

        public int Id { get; set; }
        public string Value { get; set; }

        #endregion
    }

}
