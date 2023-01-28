using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using Microsoft.WindowsAPICodePack.Dialogs;
using SoulsFormats;

namespace ACFAParamEditor
{
    public partial class MainForm : Form
    {
        private Dictionary<string, PARAM> paramDict = new Dictionary<string, PARAM>();
        private Dictionary<string, PARAM.Row> rowDict = new Dictionary<string, PARAM.Row>();
        private List<PARAMDEF> defList = new List<PARAMDEF>();
        internal GetParamData getParamData { get; private set; } = new GetParamData();
        public MainForm()
        {
            InitializeComponent();
        }

        // On Form Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            ParamDGV.Columns.Add("paramname", "Param Name");
            ParamDGV.Columns.Add("paramtype", "Param Type");
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
                    throw;
                }
            }

            string[] binFiles = Directory.GetFiles(binFolderPath, "*.*");
            foreach (string binPath in binFiles)
            {
                try
                {
                    var param = PARAM.Read(binPath);
                    var paramName = Path.GetFileNameWithoutExtension(binPath);

                    param.ApplyParamdefCarefully(defList);
                    paramDict.Add(paramName, param);
                }
                catch
                {
                    Debug.WriteLine($"Failed to parse Param at {binPath}");
                    throw;
                }
            }

            // Create Param Rows
            foreach (string param in paramDict.Keys) 
            {
                string[] newParamRow = { $"{param}", $"{paramDict[param].ParamType}" };
                ParamDGV.Rows.Add(newParamRow);
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
                CellDGV.Rows.Clear();
                RowDGV.Rows.Clear();
                var selectedDGVCellIndex = ParamDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                var retrievedRowDict = getParamData.GetRow(paramDict[selectedDGVCellIndex]);
                rowDict = retrievedRowDict;
                foreach (var row in rowDict.Values)
                {
                    string[] newRow = { $"{row.ID}", $"{row.Name}"};
                    RowDGV.Rows.Add(newRow);
                }
            }
        }
        private void RowDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RowDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                CellDGV.Rows.Clear();
                var selectedDGVCellIndex = RowDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                var cellList = getParamData.GetCell(rowDict[selectedDGVCellIndex]);
                foreach (var cell in cellList)
                {
                    string[] newCellRow = { $"{cell.Def.DisplayName}", $"{cell.Value}" };
                    CellDGV.Rows.Add(newCellRow);
                }
            }
        }

        private void ParamDGV_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
