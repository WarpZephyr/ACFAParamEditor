using System;
using System.IO;
using System.Text;

namespace ACFAParamEditor
{
    internal static class Logger
    {
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
        }

        public static void LogExceptionWithDate(Exception ex, string description) 
        {
            using (StreamWriter sw = File.AppendText(Util.paramEditorLog))
            {
                sw.WriteLine($"{description} on {DateTime.Now}");
                //sw.WriteLine($"Exception: \"{ex.Message}\", Time: {DateTime.Today}, Description: \"{description}\"");
                //sw.WriteLine($"Stacktrace: {ex}");
            }
        }

        public static void LogErrorWithDate(string description) 
        {
            using (StreamWriter sw = File.AppendText(Util.paramEditorLog))
            {
                sw.WriteLine($"{description} on {DateTime.Now}");
            }
        }
    }
}
