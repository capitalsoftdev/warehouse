using Logger;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceProcess;
using WarehouseWebService;

namespace WarehouseServiceHoster
{
    public partial class WarehouseWinService : ServiceBase
    {
        private static ServiceHost serviceHost;
        public static EventLog eventLog;    //  event log object 
        static Dictionary<string, string> appParams = new Dictionary<string, string>();
        static ILogger _log;

        public WarehouseWinService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            AppDomain currDomain = AppDomain.CurrentDomain;
            currDomain.UnhandledException += new UnhandledExceptionEventHandler(currDomain_UnhandledException);
            string warehouseSrcName = "WarehouseAPI";
            string strServiceDir = AppDomain.CurrentDomain.BaseDirectory;

            if (!EventLog.SourceExists(warehouseSrcName))
            {
                EventLog.CreateEventSource(warehouseSrcName, "WAREHOUSE");
            }

            // Create an EventLog instance and assign default source (log-Application)
            eventLog = new EventLog();
            eventLog.Source = warehouseSrcName;

            try
            {
                Type type = typeof(WarehouseService);
                serviceHost = new ServiceHost(type);
                serviceHost.Faulted += new EventHandler(Host_Faulted);
                serviceHost.Open();


                appParams.Clear();

                string[] names = ConfigurationManager.AppSettings.AllKeys;

                NameValueCollection appStgs = ConfigurationManager.AppSettings;

                for (int i = 0; i < appStgs.Count; i++)
                {
                    appParams.Add(names[i], appStgs[i].ToString());
                }

                WarehouseDAL.ConnectionParameters.ConnectionString =
                    ConfigurationManager.ConnectionStrings["DB_CONN_STRING"].ConnectionString;

                DirectoryInfo rootLogDirectory = Directory.CreateDirectory(appParams["LOG_DIR"]);
                FileStream logFileStream = File.Open(Path.Combine(rootLogDirectory.FullName,
                                                DateTime.Now.ToString("yyyy_MM_dd_") + appParams["WAREHOUSE_LOG"]),
                                                FileMode.OpenOrCreate | FileMode.Append, FileAccess.Write,
                                                FileShare.ReadWrite);
                StreamWriter logStream = new StreamWriter(logFileStream);
                logStream.AutoFlush = true;

                _log = new FileLogger(logStream, warehouseSrcName,
                    Convert.ToInt32(ConfigurationManager.AppSettings["LOGGING_LEVEL"].ToString()));

                WarehouseService.SetLogger(_log);
            }
            catch(Exception e)
            {
                eventLog.WriteEntry(e.Message, EventLogEntryType.Error);
                throw;
            }
        }

        private void Host_Faulted(object sender, EventArgs e)
        {
            try
            {
                serviceHost.Abort();
                serviceHost = null;

                Type type = typeof(WarehouseService);
                serviceHost = new ServiceHost(type);
                serviceHost.Faulted += new EventHandler(Host_Faulted);
                serviceHost.Open();
            }
            catch
            {

            }
        }

        private void currDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception eUnhandled = (Exception)e.ExceptionObject;
            try
            {
                eventLog.WriteEntry("UnhandledException : " +
                        eUnhandled.Message + " TRACE: " +
                        eUnhandled.StackTrace, EventLogEntryType.Error);
            }
            catch (Exception ex)
            {
               //TODO
            }
        }

        protected override void OnStop()
        {
            try
            {

                if (serviceHost != null)
                {
                    if (serviceHost.State == CommunicationState.Opened || serviceHost.State == CommunicationState.Opening)
                    {
                        serviceHost.Close();
                    }
                    else
                    {
                        serviceHost.Abort();
                    }

                    serviceHost = null;
                }
            }
            catch (Exception ex)
            {
                eventLog.WriteEntry($@"Problems while OnStop : 
                    {ex.Message} TRACE: 
                    {ex.StackTrace}", EventLogEntryType.Error);
            }
        }

        public static string GetClientIP()
        {
            string retVal = null;

            try
            {
                OperationContext context = OperationContext.Current;
                MessageProperties messageProperties = context.IncomingMessageProperties;
                RemoteEndpointMessageProperty endpointProperty =
                messageProperties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;

                retVal = endpointProperty.Address;// +":" + endpointProperty.Port;
            }
            catch (Exception e)
            {
                retVal = string.Empty;
            }

            return retVal;
        }
    }
}
