﻿using System;
using System.IO;

namespace ACFAParamEditor
{
    internal static class Logger
    {
        /// <summary>
        /// Create log files and overwrite them if they already exist.
        /// </summary>
        public static void CreateLog() 
        {
            File.WriteAllText(Util.log, String.Empty);
            File.WriteAllText(Util.stacktraceLog, String.Empty);
        }

        /// <summary>
        /// Log something with an exception, date, and time.
        /// </summary>
        /// <param name="ex">The exception to log</param>
        /// <param name="description">The description of what to log</param>
        public static void LogExceptionWithDate(Exception ex, string description = null) 
        {
            using StreamWriter swLog = File.AppendText(Util.log);
            swLog.WriteLine($"{description} on {DateTime.Now}");
            swLog.Close();

            using StreamWriter swStacktrace = File.AppendText(Util.stacktraceLog);
            swStacktrace.WriteLine($"Description: \"{description ?? "Unknown Error"}\" on {DateTime.Now}\nException: {ex.Message}\nStacktrace: {ex}");
            swStacktrace.Close();
        }

        /// <summary>
        /// Log something with the date and time.
        /// </summary>
        /// <param name="description">The description of what to log</param>
        public static void LogWithDate(string description = null) 
        {
            using StreamWriter sw = File.AppendText(Util.log);
            sw.WriteLine($"{description ?? "Log with date was called"} on {DateTime.Now}");
            sw.Close();
        }

        /// <summary>
        /// Log something.
        /// </summary>
        /// <param name="description">The description of what to log</param>
        public static void Log(string description = null)
        {
            using StreamWriter sw = File.AppendText(Util.log);
            sw.WriteLine($"{description ?? "Log was called"}");
            sw.Close();
        }
    }
}
