using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using SoulsFormats;

namespace ACFAParamEditor
{
    internal static class Util
    {
        public static string envFolderPath = $"{Environment.CurrentDirectory}/";
        public static string resFolderPath = $"{Environment.CurrentDirectory}/res/";
        public static string log = $"{envFolderPath}/parameditor.log";
        public static string stacktraceLog = $"{envFolderPath}/stacktrace.log";

        /// <summary>
        /// Get a single file from the user.
        /// </summary>
        /// <param name="context">An optional argument of a string containing context of what file you want to ask the user to open</param>
        /// <returns>A string containing the path to a file the user selects</returns>
        public static string GetFilePath(string context = null)
        {
            CommonOpenFileDialog filePathDialog = new()
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = false,
                Title = $"Select your {context ?? "file"} to open"
            };

            if (filePathDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return filePathDialog.FileName;
            }

            return null;
        }

        /// <summary>
        /// Get a single folder from the user.
        /// </summary>
        /// <param name="context">An optional argument of a string containing context of what folder you want to ask the user to open</param>
        /// <returns>A string containing the path to a folder the user selects</returns>
        public static string GetFolderPath(string context = null)
        {
            CommonOpenFileDialog folderPathDialog = new()
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true,
                Title = $"Select the folder containing your {context ?? "files"}"
            };

            if (folderPathDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return folderPathDialog.FileName;
            }

            return null;
        }

        /// <summary>
        /// Get a multiple files from the user.
        /// </summary>
        /// <param name="context">An optional argument of a string containing context of what files you want to ask the user to open</param>
        /// <returns>A string array containing all the paths the user selects</returns>
        public static string[] GetFilePaths(string context = null)
        {
            CommonOpenFileDialog filePathDialog = new()
            {
                InitialDirectory = "C:\\Users",
                Multiselect = true,
                Title = $"Select your {context ?? "files"}"
            };

            if (filePathDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return (string[])filePathDialog.FileNames;
            }

            return null;
        }

        /// <summary>
        /// Get a save path from the user.
        /// </summary>
        /// <param name="context">An optional argument of a string containing context of what you want to ask the user to save</param>
        /// <returns>A string containing the path where the user wants to save a file</returns>
        public static string GetSavePath(string context = null)
        {
            CommonSaveFileDialog saveFileDialog = new()
            {
                InitialDirectory = "C:\\Users",
                Title = $"Choose where to save {context ?? "files"}"
            };

            if (saveFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return saveFileDialog.FileName;
            }

            return null;
        }

        /// <summary>
        /// Check if copied row cells names match location's row cell names
        /// </summary>
        /// <param name="copiedRow">The copied param row</param>
        /// <param name="locationRow">A param row in the location the copied param row is trying to be pasted</param>
        /// <returns>Whether or not a row or rows can be pasted into the selected param</returns>
        public static bool CheckNameMatch(PARAM.Row copiedRow, PARAM.Row locationRow)
        {
            foreach (PARAM.Cell pasteCell in copiedRow.Cells)
            {
                foreach (PARAM.Cell paramCell in locationRow.Cells)
                {
                    if (pasteCell.Def.DisplayName == paramCell.Def.DisplayName)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
