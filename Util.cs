using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using SoulsFormats;
using System.Windows.Forms;

namespace ACFAParamEditor
{
    internal static class Util
    {
        public static string envFolderPath = $"{Environment.CurrentDirectory}/";
        public static string resFolderPath = $"{Environment.CurrentDirectory}/res/";
        public static string paramEditorLog = $"{envFolderPath}/parameditor.log";
        public static string stacktraceLog = $"{envFolderPath}/stacktrace.log";

        public static string GetParamFile()
        {
            // Prompt the user for folders containing param files
            CommonOpenFileDialog paramFilePathDialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = false,
                Title = "Select your Param to add"
            };

            if (paramFilePathDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return paramFilePathDialog.FileName;
            }

            return null;
        }

        public static string GetFiles(string context)
        {
            // Prompt the user for folders containing param files
            CommonOpenFileDialog paramFolderPathDialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true,
                Title = $"Select the Folder containing your {context}"
            };

            if (paramFolderPathDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return paramFolderPathDialog.FileName;
            }

            return null;
        }

        public static bool CheckIfParam(string paramFilePath)
        {
            try
            {
                try
                {
                    PARAM.Read(paramFilePath);
                    return true;
                }
                catch (InvalidDataException IDEx)
                {
                    string description = $"Failed to parse Param {paramFilePath}";
                    //TSSLParamReading.Text = $"DEBUG: {description}, see parameditor.log";
                    Debug.WriteLine($"{description}");
                    Logger.LogExceptionWithDate(IDEx, description);
                    return false;
                }
            }
            catch (EndOfStreamException EOSe)
            {
                string description = $"Failed to parse Param at {paramFilePath}";
                //TSSLParamReading.Text = $"DEBUG: {description}, see parameditor.log";
                Debug.WriteLine($"{description}");
                Logger.LogExceptionWithDate(EOSe, description);
                return false;
            }
        }

        // Used to check if a drag and dropped file is a param, def, or neither
        // TODO: Add drag and drop
        /*public static string CheckFile(object file) 
        {
            
        }*/
    }
}
