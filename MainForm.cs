using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using SoulsFormats;

namespace ArmoredCorePDR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void EditParamsBtn_click(object sender, EventArgs e)
        {
            // Prompt the user for folders containing files
            CommonOpenFileDialog binFolderPathDialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true,
                Title = "Select the Folder containing your Params"
            };

            CommonOpenFileDialog defFolderPathDialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true,
                Title = "Select the Folder containing your Defs - Temporary until I make them into XMLs"
            };

            if (binFolderPathDialog.ShowDialog() != CommonFileDialogResult.Ok || defFolderPathDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            var binFolderPath = binFolderPathDialog.FileName;
            var defFolderPath = defFolderPathDialog.FileName;


            // Create lists and add data to lists
            List <PARAMDEF> defList = new List<PARAMDEF>();

            string[] defFiles = Directory.GetFiles(defFolderPath, "*.def");
            foreach (string defPath in defFiles)
            {
                try
                {
                    defList.Add(PARAMDEF.Read(defPath));
                }
                catch
                {
                    Debug.WriteLine($"Failed to parse Paramdef at {defPath}");
                }
            }

            List <PARAM> paramList = new List<PARAM>();

            string[] binFiles = Directory.GetFiles(binFolderPath, "*.bin");
            foreach (string binPath in binFiles)
            {
                try
                {
                    var param = PARAM.Read(binPath);
                    param.ApplyParamdefCarefully(defList);
                    paramList.Add(param);
                }
                catch 
                {
                    Debug.WriteLine($"Failed to parse Param at {binPath}");
                }
            }

            // Process gathered data
            foreach (PARAM param in paramList) 
            {
                ParamRichTextBox.AppendText("\r\n");
                ParamRichTextBox.AppendText($"Param: {param}");
                ParamRichTextBox.AppendText("\r\n");
                foreach (var row in param.Rows)
                {
                    ParamRichTextBox.AppendText("\r\n");
                    ParamRichTextBox.AppendText($"Row ID: {row.ID} Row Name: {row.Name}");
                    ParamRichTextBox.AppendText("\r\n");
                    try 
                    {
                        if (row.Cells == null)
                            Debug.WriteLine($"Cell at {row} is null");
                        if (row.Cells != null)
                            foreach (var cell in row.Cells)
                            {
                                //ParamDGV.Rows.Add(cell.Value);
                                ParamRichTextBox.AppendText($"{cell.Def.DisplayName}: {cell.Value}");
                                ParamRichTextBox.AppendText("\r\n");
                            }
                    }
                    catch
                    {
                        Debug.WriteLine($"Failed to parse cell at {row.ID} in {param}");
                    }
                }
            }
        }
    }
}
