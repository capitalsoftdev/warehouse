using System;
using System.IO;
using System.Threading;

namespace Logger
{
    /// <summary>
    /// File logger
    /// </summary>
    public class FileLogger : ILogger
    {
        #region Fields

        private readonly StreamWriter _fileStream;
        private readonly string _loggerName;
        private static object lockObject = new object();
        private LogLevel loggingLevel;

        #endregion

        #region .CTORS

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="sw"></param>
        /// <param name="loggerName"></param>
        public FileLogger(StreamWriter sw, string loggerName)
        {
            _fileStream = sw;
            _loggerName = loggerName;
            LoggingLevel = LogLevel.WARN;
            AsyncLogger.sw = _fileStream;
        }
               
        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="sw"></param>
        /// <param name="loggerName"></param>
        /// <param name="logLevel"></param>
        public FileLogger(StreamWriter sw, string loggerName, int logLevel)
        {
            _fileStream = sw;
            _loggerName = loggerName;
            try
            {
                LoggingLevel = (LogLevel)logLevel;
                AsyncLogger.sw = _fileStream;
            }
            catch { }
        }

        #endregion

        #region properties

        /// <summary>
        /// Logging level
        /// </summary>                       
        public LogLevel LoggingLevel
        {
            get { return loggingLevel; }
            set { loggingLevel = value; }
        }
        
        /// <summary>
        /// Logger name
        /// </summary>
        public string Name
        {
            get { return _loggerName; }
        }

        #endregion

        #region logger methods

        public void Error(Exception ex, string message)
        {
            if (LoggingLevel >= LogLevel.ERROR)
            {
                string exception = ex != null ? $", Exception: {ex.ToString()}" : "";
                AddToLog("ERROR:{0,3}: ({1}) {2}{3}", Thread.CurrentThread.ManagedThreadId, _loggerName, message, exception);
            }
        }

        public void Error(string message)
        {           
           Error(null, message);            
        }

        public void Warn(Exception ex, string message)
        {
            if (LoggingLevel >= LogLevel.WARN)
            {
                string exception = ex != null ? $", Exception: {ex.ToString()}":"";
                AddToLog("WARN :{0,3}: ({1}) {2}{3}", Thread.CurrentThread.ManagedThreadId, _loggerName, message, exception);
            }
        }

        public void Warn(string message)
        {
            Warn(null, message);
        }

        public void Info(string message)
        {
            if (LoggingLevel >= LogLevel.INFO)
            {
                AddToLog("INFO :{0,3}: ({1}) {2}", Thread.CurrentThread.ManagedThreadId, _loggerName, message);
            }
        }

        public void Debug(string message)
        {
            if (LoggingLevel >= LogLevel.DEBUG)
            {
                AddToLog("DEBUG:{0,3}: ({1}) {2}", Thread.CurrentThread.ManagedThreadId, _loggerName, message);
            }
        }

        public void Trace(string message)
        {
            if (LoggingLevel >= LogLevel.TRACE)
            {
                AddToLog("TRACE:{0,3}: ({1}) {2}", Thread.CurrentThread.ManagedThreadId, _loggerName, message);
            }
        }

        #endregion

        #region async logger

        private delegate void AddToLogDelegate(string text, object[] args);

        private void AddToLog(string message, params object[] args)
        {
            try
            {
                AsyncLoggerQueue.Current.Enqueue($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}: {string.Format(message, args)}");
            }
            catch (Exception ex)
            {
                File.AppendAllText(Path.Combine(Path.GetTempPath(), _loggerName, "WAREHOUSE_UEX.log"),
                    $"{ message}; { ex.Message} { ex.StackTrace} { Environment.NewLine}");
            }
        }

        #endregion
    }
}
