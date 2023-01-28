using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using SoulsFormats;

namespace ACFAParamEditor
{
    public partial class MainForm : Form
    {
        
        private List<PARAMDEF> defList = new List<PARAMDEF>();
        public MainForm()
        {
            InitializeComponent();
        }

        // On Form Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            ParamDGV.Columns.Add("paramname", "Param Name");
            ParamDGV.Columns.Add("paramtype", "Param Type");
            ParamDGV.Columns[0].ReadOnly = true;
            ParamDGV.Columns[1].ReadOnly = true;
            RowDGV.Columns.Add("rowid", "Row ID");
            RowDGV.Columns.Add("name", "Name");
            CellDGV.Columns.Add("celltype", "Cell Type");
            CellDGV.Columns.Add("name", "Name");
            CellDGV.Columns[0].ReadOnly = true;
            CellDGV.Columns[1].ReadOnly = true;
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

            if (binFolderPathDialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            //var xmlResFolderPath = $"{Environment.CurrentDirectory}/res/xml/";    // Comment/Uncomment this line to test xml
            var defResFolderPath = $"{Environment.CurrentDirectory}/res/def/";      // Comment/Uncomment this line to test Def
            var binFolderPath = binFolderPathDialog.FileName;

            // Add data to lists
            string[] defFiles = Directory.GetFiles(defResFolderPath, "*.def");      // Switch to *.xml to test xml, *.def to test def
            foreach (string defPath in defFiles)
            {
                try
                {
                    defList.Add(PARAMDEF.Read(defPath));                            // Comment/Uncomment this line to test Def
                    //defList.Add(PARAMDEF.XmlDeserialize(defPath));                // Comment/Uncomment this line to test xml
                }
                catch
                {
                    Debug.WriteLine($"Failed to parse Paramdef at {defPath}");
                    //throw;
                }
            }



            string[] binFiles = Directory.GetFiles(binFolderPath, "*.*");
            foreach (string binPath in binFiles)
            {
                try
                {  
                    var param = new ParamWrapper()
                    {
                        ParamName = Path.GetFileNameWithoutExtension(binPath),
                        Param = PARAM.Read(binPath)
                    };

                    param.Param.ApplyParamdefCarefully(defList);
                    object[] newParamRow = {param, $"{param.Param.ParamType}" };
                    ParamDGV.Rows.Add(newParamRow);
                }
                catch
                {
                    Debug.WriteLine($"Failed to parse Param at {binPath}");
                    //throw;
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

        private void ParamDGV_SelectionChanged(object sender, EventArgs e)
        {
            RowDGV.Rows.Clear();
            CellDGV.Rows.Clear();
            var selectedParam = ParamDGV.CurrentRow.Cells[0].Value as ParamWrapper;

            foreach (var row in selectedParam.Param.Rows)
            {
                var rowWrapper = new RowWrapper()
                {      
                    Row = row
                };

                object[] newRow = {rowWrapper.Row.ID, rowWrapper};
                RowDGV.Rows.Add(newRow);
            }
        }

        private void RowDGV_SelectionChanged(object sender, EventArgs e)
        {
            CellDGV.Rows.Clear();
            var selectedRow = RowDGV.CurrentRow.Cells[1].Value as RowWrapper;
            foreach (var cell in selectedRow.Row.Cells)
            {
                string[] newCellRow = { $"{cell.Def.DisplayType}", $"{cell.Def.DisplayName}", $"{cell.Value}" };
                CellDGV.Rows.Add(newCellRow);
            }
        }

        private void CellDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
