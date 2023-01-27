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

            if (binFolderPathDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }


            var defResFolderPath = $"{Environment.CurrentDirectory}/res/def/";
            //var xmlResFolderPath = $"{Environment.CurrentDirectory}/res/xml/";
            var binFolderPath = binFolderPathDialog.FileName;

            // Create lists and add data to lists
            List<PARAMDEF> defList = new List<PARAMDEF>();

            string[] defFiles = Directory.GetFiles(defResFolderPath, "*.def");
            foreach (string defPath in defFiles)
            {
                try
                {
                    defList.Add(PARAMDEF.Read(defPath));
                    //defList.Add(PARAMDEF.XmlDeserialize(defPath));
                }
                catch
                {
                    Debug.WriteLine($"Failed to parse Paramdef at {defPath}");
                    throw;
                }
            }

            List<PARAM> paramList = new List<PARAM>();
            List<string> paramNameList = new List<string>();

            string[] binFiles = Directory.GetFiles(binFolderPath, "*.*");
            foreach (string binPath in binFiles)
            {
                try
                {
                    var paramName = Path.GetFileNameWithoutExtension(binPath);
                    paramNameList.Add(paramName);

                    var param = PARAM.Read(binPath);
                    param.ApplyParamdefCarefully(defList);
                    paramList.Add(param);
                }
                catch 
                {
                    Debug.WriteLine($"Failed to parse Param at {binPath}");
                    throw;
                }
            }

            // Process gathered data
            ParamDGV.Columns.Add("paramname", "Param Name");
            ParamDGV.Columns.Add("paramtype", "Param Type");
            RowDGV.Columns.Add("rowid", "Row ID");
            RowDGV.Columns.Add("name", "Name");
            CellDGV.Columns.Add("name", "Name");
            CellDGV.Columns.Add("value", "Value");

            var paramNameCounter = 0;
            foreach (PARAM param in paramList) 
            {
                string[] newParamRow = { $"{paramNameList[paramNameCounter]}", $"{param.ParamType}"};
                paramNameCounter++;
                ParamDGV.Rows.Add(newParamRow);
                foreach (var row in param.Rows)
                {
                    string[] newRowRow = { $"{row.ID}", $"{row.Name}" };
                    RowDGV.Rows.Add(newRowRow);
                    try
                    {
                        if (row.Cells == null)
                            Debug.WriteLine($"Cell at {row} is null in {param.ParamType}");
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
                                throw;
                            }
                    }
                    catch
                    {
                        Debug.WriteLine($"Failed to parse cell at {row.ID}");
                        throw;
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
                    throw;
                }
            }
        }

        private void ConvertParamsTSVBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void ParamDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ParamDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(ParamDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
        }
    }
}
