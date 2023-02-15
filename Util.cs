using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using SoulsFormats;
using System.Collections.Generic;

namespace ACFAParamEditor
{
    internal static class Util
    {
        public static string envFolderPath = $"{Environment.CurrentDirectory}/";
        public static string resFolderPath = $"{Environment.CurrentDirectory}/res/";
        public static string paramEditorLog = $"{envFolderPath}/parameditor.log";
        public static string stacktraceLog = $"{envFolderPath}/stacktrace.log";

        public static string GetFilePath(string context)
        {
            // Prompt the user for file
            CommonOpenFileDialog filePathDialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = false,
                Title = $"Select your {context} to add"
            };

            if (filePathDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return filePathDialog.FileName;
            }

            return null;
        }

        public static string GetFolderPath(string context)
        {
            // Prompt the user for folder containing files
            CommonOpenFileDialog folderPathDialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true,
                Title = $"Select the folder containing your {context}"
            };

            if (folderPathDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return folderPathDialog.FileName;
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
                    string description = $"Failed to parse Param because of InvalidDataException at {paramFilePath}";
                    //TSSLParamReading.Text = $"DEBUG: {description}, see parameditor.log";
                    Debug.WriteLine($"{description}");
                    Logger.LogExceptionWithDate(IDEx, description);
                    return false;
                }
            }
            catch (EndOfStreamException EOSe)
            {
                string description = $"Failed to parse Param because of EndOfStreamException at {paramFilePath}";
                //TSSLParamReading.Text = $"DEBUG: {description}, see parameditor.log";
                Debug.WriteLine($"{description}");
                Logger.LogExceptionWithDate(EOSe, description);
                return false;
            }
        }

        public static bool CheckNameMatch(PARAM.Row pasteRow, PARAM.Row paramRow)
        {
            foreach (PARAM.Cell pasteCell in pasteRow.Cells)
            {
                foreach (PARAM.Cell paramCell in paramRow.Cells)
                {
                    if (pasteCell.Def.DisplayName == paramCell.Def.DisplayName)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Not currently used
        /*public static bool CheckTypeMatch(PARAM.Row pasteRow, PARAM.Row paramRow)
        {
            foreach (PARAM.Cell pasteCell in pasteRow.Cells)
            {
                foreach (PARAM.Cell paramCell in paramRow.Cells)
                {
                    if (pasteCell.Def.DisplayType == paramCell.Def.DisplayType)
                    {
                        return true;
                    }
                }
            }
            return false;
        }*/
    }
}
