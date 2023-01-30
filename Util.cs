using System;

namespace ACFAParamEditor
{
    internal static class Util
    {
        public static string envFolderPath = $"{Environment.CurrentDirectory}/";
        public static string resFolderPath = $"{Environment.CurrentDirectory}/res/";
        public static string paramEditorLog = $"{envFolderPath}/parameditor.log";
        public static string stacktraceLog = $"{envFolderPath}/stacktrace.log";

        // Used to check if a drag and dropped file is a param, def, or neither - Not yet implemented
        /*public static string CheckFile(object file) 
        {
            
        }*/
    }
}
