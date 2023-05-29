using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using SoulsFormats;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Linq;

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
                return filePathDialog.FileNames.ToArray();
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
        /// Backup a file or folder on a path if it exists by adding .bak to its extension.
        /// </summary>
        /// <param name="path">A string representing the path to a file to backup.</param>
        public static void Backup(string path)
        {
            if (File.Exists(path) && !File.Exists($"{path}.bak"))
                File.Move(path, $"{path}.bak");

            else if (Directory.Exists(path) && !Directory.Exists($"{path}-bak"))
                Directory.Move(path, $"{path}-bak");
        }

        /// <summary>
        /// Restore a backup from a backup file or folder on a path if it exists by overwriting the current version of the file or folder with the backup.
        /// </summary>
        /// <param name="path">A string representing the path to a backup file to restore.</param>
        public static void Restore(string path)
        {
            if (File.Exists(path))
                File.Move(path, Path.GetFileNameWithoutExtension(path));

            else if (Directory.Exists(path))
                Directory.Move(path, path.Remove(path.Length - 4));
        }

        /// <summary>
        /// Copies a file if it exists and the new file does not yet exist to the specified path as a new file.
        /// </summary>
        /// <param name="path">A string representing the path to a file to copy.</param>
        /// <param name="newPath">A string representing the path to copy the selected file to.</param>
        public static void CopyFile(string path, string newPath, bool overwrite)
        {
            if (File.Exists(path) && !File.Exists(newPath))
            {
                File.Copy(path, newPath);
            }
            else if (File.Exists(path) && File.Exists(newPath) && overwrite)
            {
                File.Delete(newPath);
                File.Copy(path, newPath);
            }
        }

        /// <summary>
        /// Clones a file on a path if it exists and deletes or backups the original.
        /// </summary>
        /// <param name="path">A string representing the path to a file to clone.</param>
        /// <param name="backup">Whether or not to retain the original with .bak added to its extension.</param>
        public static void Clone(string path, bool backup)
        {
            byte[] fileBytes = File.ReadAllBytes(path);

            if (backup)
                Backup(path);

            if (File.Exists(path))
                File.Delete(path);

            File.WriteAllBytes(path, fileBytes);
        }

        /// <summary>
        /// Clones files on paths if they exist and deletes or backups the originals.
        /// </summary>
        /// <param name="paths">A string array representing the paths to files to clone.</param>
        /// <param name="backup">Whether or not to retain the original with .bak added to its extension.</param>
        public static void Clone(string[] paths, bool backup)
        {
            foreach (string path in paths)
            {
                Clone(path, backup);
            }
        }

        /// <summary>
        /// Verifies if the user wants to do something or not and returns true or false.
        /// </summary>
        /// <param name="context">The message to show in the dialog</param>
        /// <param name="caption">The caption to give this dialog</param>
        /// <returns>Whether or not the user pressed yes</returns>
        public static bool Verify(string context = null, string caption = null)
        {
            DialogResult saveDialog = ShowQuestionDialog(context ?? "Are you sure you want to do this?", caption ?? @"Question");
            if (saveDialog == DialogResult.Yes) return true;
            return false;
        }

        /// <summary>
        /// Shows an information dialog
        /// </summary>
        /// <param name="context">The message to show in the dialog</param>
        public static void ShowInformationDialog(string context = null, string caption = null)
        {
            MessageBox.Show(context ?? "There is something you should know.", caption ?? @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Shows an error dialog
        /// </summary>
        /// <param name="context">The message to show in the dialog</param>
        /// <param name="caption">The caption to give this dialog</param>
        public static void ShowErrorDialog(string context = null, string caption = null)
        {
            MessageBox.Show(context ?? "An error has occurred.", caption ?? @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Shows a question dialog
        /// </summary>
        /// <param name="context">The message to show in the dialog</param>
        /// <param name="caption">The caption to give this dialog</param>
        /// <returns>Whether or not the user pressed yes</returns>
        public static DialogResult ShowQuestionDialog(string context = null, string caption = null)
        {
            return MessageBox.Show(context ?? "Are you sure you want to do this?", caption ?? @"Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        /// Shows an input dialog
        /// </summary>
        /// <param name="text">The message to show in the dialog</param>
        /// <param name="caption">The caption to give this dialog</param>
        /// <returns>What the user inputted or an empty string if cancelled</returns>
        public static string ShowInputDialog(string text = null, string caption = null)
        {
            var prompt = new Form
            {
                Width = 240,
                Height = 125,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption ?? "Input Dialog",
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false
            };

            var textLabel = new Label { Left = 8, Top = 8, Width = 200, Text = text ?? "Input something." };
            var textBox = new TextBox { Left = 10, Top = 28, Width = 200 };

            var cancelButton = new Button { Text = @"Cancel", Left = 9, Width = 100, Top = 55, DialogResult = DialogResult.Cancel };
            cancelButton.Click += (sender, e) => { prompt.Close(); };
            var confirmation = new Button { Text = @"OK", Left = 112, Width = 100, Top = 55, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(cancelButton);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        /// <summary>
        /// Writes a file overwriting if it exists and if specified to do so.
        /// </summary>
        /// <param name="path">A string representing a path to where the file is to be written or overwritten.</param>
        /// <param name="bytes">Bytes to write to the chosen file path.</param>
        /// <param name="overwrite">Whether or not to overwrite file if it already exists.</param>
        public static void Write(string path, byte[] bytes, bool overwrite = false)
        {
            if (!File.Exists(path))
                File.WriteAllBytes(path, bytes);

            else if (File.Exists(path) && overwrite)
                File.WriteAllBytes(path, bytes);
        }

        /// <summary>
        /// Copy a directory and all of its files and subdirectories.
        /// </summary>
        /// <param name="path">A string representing a path to the folder to copy.</param>
        /// <param name="newPath">A string representing a path to copy the selected folder to.</param>
        /// <param name="overwrite">Whether or not to delete folder if it already exists.</param>
        public static void CopyDirectory(string path, string newPath, bool overwrite = false)
        {
            if (!Directory.Exists(path))
            {
                foreach (var directory in Directory.GetDirectories(path))
                {
                    //Get the path of the new directory
                    var newDirectory = Path.Combine(newPath, Path.GetFileName(directory));
                    //Create the directory if it doesn't already exist
                    Directory.CreateDirectory(newDirectory);
                    //Recursively copy the directory
                    CopyDirectory(directory, newDirectory);
                }

                foreach (var file in Directory.GetFiles(path))
                {
                    File.Copy(file, Path.Combine(newPath, Path.GetFileName(file)));
                }
            }
            else if (Directory.Exists(path) && overwrite)
            {
                foreach (var directory in Directory.GetDirectories(path))
                {
                    //Get the path of the new directory
                    string newDirectory = Path.Combine(newPath, Path.GetFileName(directory));
                    // Delete, then copy directory.
                    Directory.Delete(path);
                    Directory.CreateDirectory(newDirectory);
                    //Recursively copy the directory
                    CopyDirectory(directory, newDirectory);
                }

                foreach (var file in Directory.GetFiles(path))
                {
                    File.Copy(file, Path.Combine(newPath, Path.GetFileName(file)));
                }
            }
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
