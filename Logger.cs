using System;
using System.IO;

namespace ACFAParamEditor
{
    internal static class Logger
    {
        // Create log files, overwrite them if they already exist
        public static void createLog() 
        {
            if (!File.Exists(Util.paramEditorLog))
            {
                using StreamWriter sw = File.CreateText(Util.paramEditorLog);
            }
            else
            {
                File.WriteAllText(Util.paramEditorLog, String.Empty);
            }

            if (!File.Exists(Util.stacktraceLog))
            {
                using StreamWriter sw = File.CreateText(Util.stacktraceLog);
            }
            else
            {
                File.WriteAllText(Util.stacktraceLog, String.Empty);
            }
        }

        // Log when an exception has occurred with logs for the user and the dev
        public static void LogExceptionWithDate(Exception ex, string description) 
        {
            using (StreamWriter sw = File.AppendText(Util.paramEditorLog))
            {
                sw.WriteLine($"{description} on {DateTime.Now}");
            }

            using (StreamWriter sw = File.AppendText(Util.stacktraceLog))
            {
                sw.WriteLine($"Description: \"{description}\" on {DateTime.Now}\nException: {ex.Message}\nStacktrace: {ex}");
            }
        }

        // Log when a issue has occurred in a log for the user, no need for stacktrace log here
        public static void LogErrorWithDate(string description) 
        {
            using (StreamWriter sw = File.AppendText(Util.paramEditorLog))
            {
                sw.WriteLine($"{description} on {DateTime.Now}");
            }
        }
    }
}
