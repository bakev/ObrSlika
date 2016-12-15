using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ObrSlika
{
    public static class LogFile
    {
        public static string sSource = "ObrSlika";
        public static string sLog = "Application";

        public static void WriteInformationLog(String EventToWrite)
        {
            CheckIfLogExixts();
            EventLog.WriteEntry(sSource, EventToWrite, EventLogEntryType.Information);
        }
        public static void WriteWarningLog(String EventToWrite)
        {
            CheckIfLogExixts();
            EventLog.WriteEntry(sSource, EventToWrite, EventLogEntryType.Warning);
        }
        public static void WriteErrorLog(String EventToWrite)
        {
            CheckIfLogExixts();
            EventLog.WriteEntry(sSource, EventToWrite, EventLogEntryType.Error);
        }
        public static void CheckIfLogExixts()
        {
            if (!EventLog.SourceExists(sSource))
            {
                EventLog.CreateEventSource(sSource, sLog);
            }
        }
    }
}
