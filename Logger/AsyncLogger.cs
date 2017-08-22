using System.IO;
using System.Threading.Tasks;

namespace Logger
{
    public class AsyncLogger
    {
        public static TextWriter twWaitingToBeFetched;
        public static StreamWriter sw;
        static object locker = new object();

        public static void initWriterStream(StreamWriter s)
        {
            sw = s;
            twWaitingToBeFetched = TextWriter.Synchronized(sw);
        }

        static AsyncLogger()
        {
            if (sw != null)
                twWaitingToBeFetched = TextWriter.Synchronized(sw);
        }

        public static void LogMessage(string line)
        {
            lock (locker)
            {
                if (twWaitingToBeFetched == null)
                    twWaitingToBeFetched = TextWriter.Synchronized(sw);

                twWaitingToBeFetched.WriteLine(line);
                twWaitingToBeFetched.Flush();
            }
        }

        public static void LogMessageAsync(string line)
        {
            Task.Factory.StartNew(() => LogMessage(line));
        }
    }
}
