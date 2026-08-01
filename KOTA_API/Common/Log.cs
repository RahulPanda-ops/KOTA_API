using System;
using System.Collections.Generic;
using System.Text;

namespace KOTA_API.Common
{
    internal class Log
    {
        public enum ErrorLogModule
        {
            #region Variable Declaration
            DatabaseConnectrion,
            InsertGetComputerdetails,
            LOGIN,
            DashBoard,
            UserPannel,
            Country,
            State,
            City,
            Project,
            SubHighway,
            Highway,
            CompanyDetails,
            Designation,
            Location,
            LandMark,
            StretchDetails,
            ERSFactor,
            ERSSubFactor,
            SubSystemType,
            SubSystemBrand,
            SubSystem,
            SubSystemDetails,
            PermissionMaster,
            SubHighwayRoleAssign,
            UserDetails,
            UserType,
            Channel,
            Chainage,
            Holiday,
            LogoMaster,
            ChangePassword,
            Position,
            HandHeld,
            AssetManagement,
            ERS,
            Lane,
            VehicleClass,
            HandHeldIssue,
            Fare,
            ForgetPassWord,
            VSDetailMaster,
            UserShiftAssign,
            ShiftRecord,
            RFIDConfigurationMaster,
            SVDSVerification,
            SVDSAudit,
            SVDSPayment,
            SVDSChallanGenerate,
            TTES,
            AccidentType,
            VehicleCombination,
            EmergencyVehicle,
            AccidentMonitoringPerson,
            VASDMaster,
            VASDSpeedAllowed,
            CustomMessage,
            ATCCReport,
            CpPlusVS,
            SubSysMaintanence,
            StepTaken, //Used for Step Taken
            EVENTLOG, // Used for Empower Card 
            ShiftType,// Used for Shift Type Master MT 25-02-2021 
            IncicentManagement, // Used for Incident Managemet MT 26-03-2021
            VIDS,
            Anpr,
            VDSDiagnosis,
            CPPlusNVRRecording,
            cpuutilization,
            alarmdetails,
            weather,
            VTS,
            employee,
            vendor,
            streetview,
            Schedulerecord,
            reportadminmodule,
            PortableWIM,
            #endregion
        }

        public enum OperationLogModule
        {
            #region Variable Declaration

            LOGIN,
            DashBoard,
            UserPannel,
            Country,
            State,
            City,
            Project,
            SubHighway,
            Highway,
            CompanyDetails,
            Designation,
            Location,
            LandMark,
            StretchDetails,
            ERSFactor,
            ERSSubFactor,
            SubSystemType,
            SubSystemBrand,
            SubSystem,
            SubSystemDetails,
            PermissionMaster,
            UserDetails,
            UserType,
            SubHighwayRoleAssign,
            Channel,
            Chainage,
            Holiday,
            LogoMaster,
            ChangePassword,
            Position,
            HandHeld,
            AssetManagement,
            ERS,
            Lane,
            VehicleClass,
            HandHeldIssue,
            Fare,
            ForgetPassWord,
            VSDetailMaster,
            UserShiftAssign,
            ShiftRecord,
            RFIDConfigurationMaster,
            SVDSVerification,
            SVDSAudit,
            SVDSPayment,
            SVDSChallanGenerate,
            TTES,
            AccidentType,
            VehicleCombination,
            EmergencyVehicle,
            AccidentMonitoringPerson,
            VASDMaster,
            VASDSpeedAllowed,
            CustomMessage,
            ATCCReport,
            SubSysMaintanence,
            StepTaken, //Used for StepTaken
            EVENTLOG, // Used for Empower Card 
            ShiftType,// Used for Shift Type Master MT 25-02-2021 
            IncicentManagement, // Used for Incident Managemet MT 26-03-2021
            #endregion

        }

        /// <summary>
        /// This method is used to Write Error Log to the file
        /// </summary>
        /// <param name="message"></param>
        /// <param name="logModule"></param>
        public static void Write(string message, ErrorLogModule logModule)
        {
            try
            {
                string path = string.Empty;
                DateTime dt = DateTime.Now;

                //Create folder name
                switch (logModule)
                {
                    case ErrorLogModule.DatabaseConnectrion:
                        {
                            path = CheckDirectory("ERROR//DatabaseConnectrion//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.InsertGetComputerdetails:
                        {
                            path = CheckDirectory("ERROR//InsertGetComputerdetails//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }


                    case ErrorLogModule.LOGIN:
                        {
                            path = CheckDirectory("ERROR//LOGIN//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.DashBoard:
                        {
                            path = CheckDirectory("ERROR//DashBoard//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.streetview:
                        {
                            path = CheckDirectory("ERROR//streetview//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.vendor:
                        {
                            path = CheckDirectory("ERROR//vendor//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.reportadminmodule:
                        {
                            path = CheckDirectory("ERROR//reportadminmodule//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.PortableWIM:
                        {
                            path = CheckDirectory("ERROR//PortableWIM//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.UserPannel:
                        {
                            path = CheckDirectory("ERROR//DashBoard//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.Country:
                        {
                            path = CheckDirectory("ERROR//Country//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.State:
                        {
                            path = CheckDirectory("ERROR//State//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.City:
                        {
                            path = CheckDirectory("ERROR//City//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.Project:
                        {
                            path = CheckDirectory("ERROR//Project//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.Highway:
                        {
                            path = CheckDirectory("ERROR//Highway//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.SubHighway:
                        {
                            path = CheckDirectory("ERROR//SubHighway//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.Designation:
                        {
                            path = CheckDirectory("ERROR//Designation//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.Location:
                        {
                            path = CheckDirectory("ERROR//Location//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.LandMark:
                        {
                            path = CheckDirectory("ERROR//LandMark//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.StretchDetails:
                        {
                            path = CheckDirectory("ERROR//StretchDetails//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.ERSFactor:
                        {
                            path = CheckDirectory("ERROR//ERSFactor//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.ERSSubFactor:
                        {
                            path = CheckDirectory("ERROR//ERSSubFactor//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.SubSystemType:
                        {
                            path = CheckDirectory("ERROR//SubSystemType//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.SubSystemBrand:
                        {
                            path = CheckDirectory("ERROR//SubSystemBrand//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.SubSystem:
                        {
                            path = CheckDirectory("ERROR//SubSystem//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.SubSystemDetails:
                        {
                            path = CheckDirectory("ERROR//SubSystemDetails//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.PermissionMaster:
                        {
                            path = CheckDirectory("ERROR//PermissionMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.UserDetails:
                        {
                            path = CheckDirectory("ERROR//UserDetails//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.UserType:
                        {
                            path = CheckDirectory("ERROR//UserType//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.SubHighwayRoleAssign:
                        {
                            path = CheckDirectory("ERROR//SubHighwayRoleAssign//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.Channel:
                        {
                            path = CheckDirectory("ERROR//Channel//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.Chainage:
                        {
                            path = CheckDirectory("ERROR//Chainage//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.CompanyDetails:
                        {
                            path = CheckDirectory("ERROR//CompanyDetails//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.Holiday:
                        {
                            path = CheckDirectory("ERROR//Holiday//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.LogoMaster:
                        {
                            path = CheckDirectory("ERROR//LogoMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.ChangePassword:
                        {
                            path = CheckDirectory("ERROR//ChangePasswordMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.Position:
                        {
                            path = CheckDirectory("ERROR//PositionMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.HandHeld:
                        {
                            path = CheckDirectory("ERROR//HandHeldMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.AssetManagement:
                        {
                            path = CheckDirectory("ERROR//AssetManagement//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }


                    case ErrorLogModule.VehicleClass:
                        {
                            path = CheckDirectory("ERROR//VehicleClass//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.Schedulerecord:
                        {
                            path = CheckDirectory("ERROR//Schedulerecord//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.HandHeldIssue:
                        {
                            path = CheckDirectory("ERROR//HandHeldIssueMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }


                    case ErrorLogModule.Fare:
                        {
                            path = CheckDirectory("ERROR//FareMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.Lane:
                        {
                            path = CheckDirectory("ERROR//HighwayLaneMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.VSDetailMaster:
                        {
                            path = CheckDirectory("ERROR//VSDetailMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.UserShiftAssign:
                        {
                            path = CheckDirectory("ERROR//UserShiftAssign//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.ShiftRecord:
                        {
                            path = CheckDirectory("ERROR//ShiftRecord//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.RFIDConfigurationMaster:
                        {
                            path = CheckDirectory("ERROR//RFIDConfigurationMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.SVDSVerification:
                        {
                            path = CheckDirectory("ERROR//SVDSVerification//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.SVDSAudit:
                        {
                            path = CheckDirectory("ERROR//SVDSAudit//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.SVDSPayment:
                        {
                            path = CheckDirectory("ERROR//SVDSPayment//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.SVDSChallanGenerate:
                        {
                            path = CheckDirectory("ERROR//SVDSChallanGenerate//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.TTES:
                        {
                            path = CheckDirectory("ERROR//TTESMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.AccidentType:
                        {
                            path = CheckDirectory("ERROR//AccidentTypeMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.VehicleCombination:
                        {
                            path = CheckDirectory("ERROR//VehicleCombinationMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.EmergencyVehicle:
                        {
                            path = CheckDirectory("ERROR//EmergencyVehicleMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.AccidentMonitoringPerson:
                        {
                            path = CheckDirectory("ERROR//AccidentMonitoringPersonMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.VASDMaster:
                        {
                            path = CheckDirectory("ERROR//VASDMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.VASDSpeedAllowed:
                        {
                            path = CheckDirectory("ERROR//TrafikViewVASDLaneSpeedAllowedMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.CustomMessage:
                        {
                            path = CheckDirectory("ERROR//VMSCustomMessageMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.ATCCReport:
                        {
                            path = CheckDirectory("ERROR//ATCCTirtleReport//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.CpPlusVS:
                        {
                            path = CheckDirectory("ERROR//CpPlusVideoSurvillance//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.SubSysMaintanence:
                        {
                            path = CheckDirectory("ERROR//SubSystemMaintanence//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.EVENTLOG:
                        {
                            path = CheckDirectory("ERROR//EmpowerCard//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.ShiftType:
                        {
                            path = CheckDirectory("ERROR//ShiftTypeMaster//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    //Used for step taken master in incident mangment .shaifali verma 15-03-2021
                    case ErrorLogModule.StepTaken:
                        {
                            path = CheckDirectory("ERROR//StepTaken Master//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    //Used for  incident mangment .MT 26-03-2021
                    case ErrorLogModule.IncicentManagement:
                        {
                            path = CheckDirectory("ERROR//Incicent Management//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.VIDS:
                        {
                            path = CheckDirectory("ERROR//VIDS//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.ERS:
                        {
                            path = CheckDirectory("ERROR//ERS//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case ErrorLogModule.Anpr:
                        {
                            path = CheckDirectory("ERROR//ANPR//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.VDSDiagnosis:
                        {
                            path = CheckDirectory("ERROR//VDSDiagnosis//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.CPPlusNVRRecording:
                        {
                            path = CheckDirectory("ERROR//CPPlusNVRRecording//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.cpuutilization:
                        {
                            path = CheckDirectory("ERROR//cpuutilization//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.alarmdetails:
                        {
                            path = CheckDirectory("ERROR//alarmdetails//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.weather:
                        {
                            path = CheckDirectory("ERROR//weather//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.VTS:
                        {
                            path = CheckDirectory("ERROR//VTS//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case ErrorLogModule.employee:
                        {
                            path = CheckDirectory("ERROR//employee//") + "ErrorLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                }

                //Write log to file.
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(WriteLogMessage(message));
                }
            }
            catch
            {
                //Ignore error
            }
        }

        /// <summary>
        /// This method is used to Write Operation Log to the file
        /// </summary>
        /// <param name="message"></param>
        /// <param name="logModule"></param>
        public static void Write(string message, OperationLogModule logModule)
        {
            try
            {
                string path = string.Empty;
                DateTime dt = DateTime.Now;

                //Create folder name
                switch (logModule)
                {

                    case OperationLogModule.LOGIN:
                        {
                            path = CheckDirectory("OPERATION//LOGIN//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.DashBoard:
                        {
                            path = CheckDirectory("OPERATION//DashBoard//") + "OperationLog_" + dt.ToString("ddMMyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.UserPannel:
                        {
                            path = CheckDirectory("OPERATION//DashBoard//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case OperationLogModule.Country:
                        {
                            path = CheckDirectory("OPERATION//Country//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.State:
                        {
                            path = CheckDirectory("OPERATION//State//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.City:
                        {
                            path = CheckDirectory("OPERATION//City//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.Project:
                        {
                            path = CheckDirectory("OPERATION//Project//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.Highway:
                        {
                            path = CheckDirectory("OPERATION//Highway//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.SubHighway:
                        {
                            path = CheckDirectory("OPERATION//SubHighway//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.Designation:
                        {
                            path = CheckDirectory("OPERATION//Designation//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.Location:
                        {
                            path = CheckDirectory("OPERATION//Location//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.LandMark:
                        {
                            path = CheckDirectory("OPERATION//LandMark//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.StretchDetails:
                        {
                            path = CheckDirectory("OPERATION//StretchDetails//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.ERSFactor:
                        {
                            path = CheckDirectory("OPERATION//ERSFactor//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.ERSSubFactor:
                        {
                            path = CheckDirectory("OPERATION//ERSSubFactor//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.SubSystemType:
                        {
                            path = CheckDirectory("OPERATION//SubSystemType//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.SubSystemBrand:
                        {
                            path = CheckDirectory("OPERATION//SubSystemBrand//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.SubSystem:
                        {
                            path = CheckDirectory("OPERATION//SubSystem//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.SubSystemDetails:
                        {
                            path = CheckDirectory("OPERATION//SubSystemDetails//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.PermissionMaster:
                        {
                            path = CheckDirectory("OPERATION//PermissionMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.UserDetails:
                        {
                            path = CheckDirectory("OPERATION//UserDetails//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.UserType:
                        {
                            path = CheckDirectory("OPERATION//UserType//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.SubHighwayRoleAssign:
                        {
                            path = CheckDirectory("OPERATION//SubHighwayRoleAssign//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case OperationLogModule.Channel:
                        {
                            path = CheckDirectory("OPERATION//Channel//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case OperationLogModule.Chainage:
                        {
                            path = CheckDirectory("OPERATION//Chainage//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case OperationLogModule.CompanyDetails:
                        {
                            path = CheckDirectory("OPERATION//CompanyDetails//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.Holiday:
                        {
                            path = CheckDirectory("OPERATION//Holiday//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.LogoMaster:
                        {
                            path = CheckDirectory("OPERATION//LogoMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case OperationLogModule.ChangePassword:
                        {
                            path = CheckDirectory("OPERATION//ChangePasswordMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case OperationLogModule.Position:
                        {
                            path = CheckDirectory("OPERATION//Position//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }


                    case OperationLogModule.HandHeld:
                        {
                            path = CheckDirectory("OPERATION//HandHeldMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case OperationLogModule.AssetManagement:
                        {
                            path = CheckDirectory("OPERATION//AssetManagement//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }


                    case OperationLogModule.Lane:
                        {
                            path = CheckDirectory("OPERATION//HighwayLaneMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.VehicleClass:
                        {
                            path = CheckDirectory("OPERATION//VehicleClass//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case OperationLogModule.HandHeldIssue:
                        {
                            path = CheckDirectory("OPERATION//HandHeldIssueMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }


                    case OperationLogModule.Fare:
                        {
                            path = CheckDirectory("OPERATION//FareMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case OperationLogModule.VSDetailMaster:
                        {
                            path = CheckDirectory("OPERATION//VSDetailMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case OperationLogModule.UserShiftAssign:
                        {
                            path = CheckDirectory("OPERATION//UserShiftAssign//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case OperationLogModule.ShiftRecord:
                        {
                            path = CheckDirectory("OPERATION//ShiftRecord//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.RFIDConfigurationMaster:
                        {
                            path = CheckDirectory("OPERATION//RFIDConfigurationMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.SVDSVerification:
                        {
                            path = CheckDirectory("OPERATION//SVDSVerification//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.SVDSAudit:
                        {
                            path = CheckDirectory("OPERATION//SVDSAudit//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.SVDSPayment:
                        {
                            path = CheckDirectory("OPERATION//SVDSPayment//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.SVDSChallanGenerate:
                        {
                            path = CheckDirectory("OPERATION//SVDSChallanGenerate//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.TTES:
                        {
                            path = CheckDirectory("OPERATION//TTESMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    //For Operation  Log
                    case OperationLogModule.AccidentType:
                        {
                            path = CheckDirectory("OPERATION//AccidentTypeMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.VehicleCombination:
                        {
                            path = CheckDirectory("OPERATION//VehicleCombinationMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.EmergencyVehicle:
                        {
                            path = CheckDirectory("OPERATION//EmergencyVehicleMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.AccidentMonitoringPerson:
                        {
                            path = CheckDirectory("OPERATION//AccidentMonitoringPersonMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.VASDMaster:
                        {
                            path = CheckDirectory("OPERATION//VASDMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.VASDSpeedAllowed:
                        {
                            path = CheckDirectory("OPERATION//TrafikViewVASDLaneSpeedAllowedMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.CustomMessage:
                        {
                            path = CheckDirectory("OPERATION//VMSCustomMessageMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.SubSysMaintanence:
                        {
                            path = CheckDirectory("OPERATION//SubSystemMaintanence//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }
                    case OperationLogModule.EVENTLOG:
                        {
                            path = CheckDirectory("OPERATION//EmpowerCard//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    case OperationLogModule.ShiftType:
                        {
                            path = CheckDirectory("OPERATION//ShiftTypeMaster//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    //Used for step taken master in incident mangment .shaifali verma 15-03-2021
                    case OperationLogModule.StepTaken:
                        {
                            path = CheckDirectory("OPERATION// StepTaken Master//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                    //Used for incident mangment .MT 26-03-2021
                    case OperationLogModule.IncicentManagement:
                        {
                            path = CheckDirectory("OPERATION// Incicent Management//") + "OperationLog_" + dt.ToString("ddMMyyyy") + ".log";
                            break;
                        }

                }


                //Write log to file.
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(WriteLogMessage(message));
                }
            }
            catch
            {
                //Ignore error
            }
        }

        /// <summary>
        /// This method is used to Check and create directory
        /// </summary>
        /// <param name="RepositoryName"></param>
        /// <returns></returns>
        public static string CheckDirectory(string RepositoryName)
        {
            string directory = CommonVariables.DriveName + @"\" + @"\TrafikView\Log\" + RepositoryName;

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            return directory;
        }

        public static void CheckandCreateDirectory(string FolderPath)
        {
            if (!System.IO.Directory.Exists(FolderPath))
            {
                System.IO.Directory.CreateDirectory(FolderPath);
            }
        }


        /// <summary>
        /// This method is used to write content on Log File.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>string</returns>

        private static string WriteLogMessage(string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt") + ": ");
            sb.Append(message);
            sb.AppendLine();
            sb.AppendLine("==========================================================================================================================================");

            return sb.ToString();
        }

        /// <summary>
        /// This method is used to create folder. 
        /// </summary>
        /// <param name="folderPathName"></param>
        public static void CreateFolder(string folderPathName)
        {
            try
            {
                if (!System.IO.Directory.Exists(folderPathName))
                {
                    System.IO.Directory.CreateDirectory(folderPathName);
                }
            }
            catch
            {

            }
        }

    }
}
