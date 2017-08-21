using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.IO;
using System.Threading;

namespace Logger
{
    public class AsyncLoggerQueue
    {
        //create singleton instance of logger queue
        public static AsyncLoggerQueue Current = new AsyncLoggerQueue();
        private BlockingCollection<string> _LogEntryQueue = new BlockingCollection<string>();       
        private BackgroundWorker _Logger = new BackgroundWorker();
        private CancellationTokenSource cts;

        private AsyncLoggerQueue()
        {
            cts = new CancellationTokenSource();
            //configure background worker
            _Logger.WorkerSupportsCancellation = false;
            _Logger.DoWork += new DoWorkEventHandler(_Logger_DoWork);
        }

        public void Enqueue(string le)
        {
            _LogEntryQueue.Add(le);

            //while locked check to see if the BW is running, if not start it
            if (!_Logger.IsBusy)
                _Logger.RunWorkerAsync();

        }

        private void _Logger_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var data in _LogEntryQueue.GetConsumingEnumerable(cts.Token))
            {
                try
                {
                    AsyncLogger.LogMessageAsync(data);
                }
                catch (Exception ex)
                {
                    File.AppendAllText(Path.Combine(Path.GetTempPath(), "logger", "WAREHOUSE_EX.log"), 
                        $"{data};{ex.Message} {ex.StackTrace}{Environment.NewLine}");
                }
            }
        }
    }
}
