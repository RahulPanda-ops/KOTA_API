using KOTA_API.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace KOTA_API.DBF
{
    internal class DBConnection
    {
        #region DBConnection
        public static string ConnectionString()
        {
            string Connectionstr = string.Empty;
            try
            {
                 Connectionstr = CommonVariables.ConnectionString;
                 //Connectionstr = "Host=172.16.3.4;Username=postgres;Password=manpreet@123;Database=vids_events";
            }
            catch (Exception ex)
            {
                Connectionstr = ex.Message;
                Serilog.Log.Logger.Error("Database connection error: {errorMessage}", ex.Message);
            }

            return Connectionstr;
        }
        #endregion
    }
}
