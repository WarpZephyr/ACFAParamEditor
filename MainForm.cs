using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using ACFAParamEditor.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using SoulsFormats;

namespace ACFAParamEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        // On Form Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            ParamDGV.Columns.Add("param", "Param");
            RowDGV.Columns.Add("rowid", "Row ID");
            RowDGV.Columns.Add("name", "Name");
            CellDGV.Columns.Add("name", "Name");
            CellDGV.Columns.Add("value", "Value");
        }

        // When Edit Params button is pressed
        private void EditParamsBtn_click(object sender, EventArgs e)
        {
            // Prompt the user for folders containing files
            CommonOpenFileDialog binFolderPathDialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true,
                Title = "Select the Folder containing your Params"
            };

            /*CommonOpenFileDialog defFolderPathDialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true,
                Title = "Select the Folder containing your Defs - Temporary until I make them into XMLs"
            };*/

            if (binFolderPathDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            var binFolderPath = binFolderPathDialog.FileName;
            var defResFolderPath = $"{Environment.CurrentDirectory}/res/def/";


            // Create lists and add data to lists
            List <PARAMDEF> defList = new List<PARAMDEF>();

            string[] defFiles = Directory.GetFiles(defResFolderPath, "*.xml");
            foreach (string defPath in defFiles)
            {
                try
                {
                    defList.Add(PARAMDEF.XmlDeserialize(defPath));
                }
                catch
                {
                    Debug.WriteLine($"Failed to parse Paramdef at {defPath}");
                }
            }

            List <PARAM> paramList = new List<PARAM>();

            string[] binFiles = Directory.GetFiles(binFolderPath, "*.*");
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
                string[] newParamRow = {$"{param.ParamType}"};
                ParamDGV.Rows.Add(newParamRow);
                foreach (var row in param.Rows)
                {
                    string[] newRowRow = { $"{row.ID}", $"{row.Name}" };
                    RowDGV.Rows.Add(newRowRow);
                    try
                    {
                        if (row.Cells == null)
                            Debug.WriteLine($"Cell at {row} is null");
                        if (row.Cells != null)
                            try
                            {
                                foreach (var cell in row.Cells)
                                {
                                    string[] newCellRow = { $"{cell.Def.DisplayName}", $"{cell.Value}" };
                                    CellDGV.Rows.Add(newCellRow);
                                }
                            }
                            catch
                            {
                                Debug.WriteLine($"DataGridView adding failed");
                            }
                    }
                    catch
                    {
                        Debug.WriteLine($"Failed to parse cell at {row.ID}");
                    }
                }
            }
        }

        private void ConvertDefsBtn_Click(object sender, EventArgs e)
        {
            // Prompt the user for folders containing files
            CommonOpenFileDialog defFolderPathDialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true,
                Title = "Select the Folder containing your Defs to convert them into XMLs"
            };

            if (defFolderPathDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            var defResFolderPath = $"{Environment.CurrentDirectory}/res/def/";
            var defUserFolderPath = defFolderPathDialog.FileName;

            string[] defFiles = Directory.GetFiles(defUserFolderPath, "*.*");
            foreach (string defPath in defFiles)
            {
                try
                {
                    var paramdef = PARAMDEF.Read(defPath);
                    foreach (var field in paramdef.Fields)
                    {
                        field.InternalName = field.DisplayName;
                    }
                    paramdef.XmlSerialize($"{defResFolderPath}/{Path.GetFileNameWithoutExtension(defPath)}.xml");
                }
                catch
                {
                    Debug.WriteLine($"Failed to parse Paramdef at {defPath}");
                }
            }
        }

        private void ConvertParamsTSVBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ParamDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("You clicked on a cell!");
        }


    }
}
