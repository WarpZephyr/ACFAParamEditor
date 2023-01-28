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
        private Dictionary<string, PARAM> paramDict = new Dictionary<string, PARAM>();
        private List<PARAMDEF> defList = new List<PARAMDEF>();
        internal GetParamData getParamData { get; private set; } = new GetParamData();
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
                    var param = new ParamWrapper() 
                    { 
                        Param = PARAM.Read(binPath),
                        ParamName = Path.GetFileNameWithoutExtension(binPath)
                    };

                    var paramName = Path.GetFileNameWithoutExtension(binPath);

                    param.Param.ApplyParamdefCarefully(defList);
                    paramDict.Add(paramName, param);
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
            foreach (ParamWrapper param in paramDict.Values) 
            {
                string[] newParamRow = { $"{param.ParamName}", $"{param.Param.ParamType}" };
                ParamDGV.Rows.Add(newParamRow);

                paramNameCounter++;
                foreach (var row in param.Param.Rows)
                {
                    string[] newRowRow = { $"{row.ID}", $"{row.Name}" };
                    RowDGV.Rows.Add(newRowRow);
                    try
                    {
                        if (row.Cells == null)
                            Debug.WriteLine($"Cell at {row} is null in {param.Param.ParamType}");
                        if (row.Cells != null)
                            foreach (var cell in row.Cells)
                            {
                                string[] newCellRow = { $"{cell.Def.DisplayName}", $"{cell.Value}" };
                                CellDGV.Rows.Add(newCellRow);
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
                var selectedDGVCellIndex = ParamDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                var rowList = getParamData.GetRow(paramDict[selectedDGVCellIndex].Param);
                foreach (var row in rowList)
                {
                    RowDGV.Rows.Add(row);
                }
            }
        }
        private void RowDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RowDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                var selectedDGVCellIndex = RowDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                var cellList = getParamData.GetRow(paramDict[selectedDGVCellIndex].Param);
                foreach (var cell in cellList)
                {
                    CellDGV.Rows.Add(cell);
                }
            }
        }

        private void ParamDGV_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
