using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Diagnostics;

namespace SecurityLab1_Starter.Models
{
    public class LogUtil
    {
        public void LogToEventViewer(EventLogEntryType type, String txt) {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Application";
                eventLog.WriteEntry(txt, EventLogEntryType.Error, 101, 1);
            }
        }

        public void LogToFile(String text)
        {
            using (var writer = new StreamWriter("c:\\Temp\\ErrorLog.txt"))
            {
                var currentDate = new DateTime();
                writer.WriteLine("[{0}] {1}", currentDate.ToString(), text);
            }
        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }

        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }

}