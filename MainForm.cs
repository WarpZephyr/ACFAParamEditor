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
            Logger.createLog();

            // Create def list on form load
            string[] defFiles = Directory.GetFiles($"{Util.resFolderPath}/def/", "*.def");      // Switch xml/def to test either
            foreach (string defPath in defFiles)
            {
                try
                {
                    defList.Add(PARAMDEF.Read(defPath));                            // Comment/Uncomment this line to test Def
                    //defList.Add(PARAMDEF.XmlDeserialize(defPath));                // Comment/Uncomment this line to test xml
                }
                catch (InvalidDataException IDEx)
                {
                    string description = $"Failed to parse Paramdef at {defPath}";
                    TSSLDefReading.Text = $"DEBUG: {description}, see parameditor.log";
                    Debug.WriteLine($"{description}");
                    Logger.LogExceptionWithDate(IDEx, description);
                }
            }
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

            var binFolderPath = binFolderPathDialog.FileName;

            ParamDGV.Rows.Clear();
            string[] binFiles = Directory.GetFiles(binFolderPath, "*.*");
            foreach (string binPath in binFiles)
            {
                try
                {
                    try
                    {
                        var param = new ParamWrapper()
                        {
                            ParamName = Path.GetFileNameWithoutExtension(binPath),
                            Param = PARAM.Read(binPath)
                        };

                        var applyDef = param.Param.ApplyParamdefCarefully(defList);
                        if (applyDef == true)
                        {
                            object[] newParamRow = { param, $"{param.Param.ParamType}" };
                            ParamDGV.Rows.Add(newParamRow);
                        }
                    }
                    catch (EndOfStreamException EOSe)
                    {
                        string description = $"Failed to parse Param at {binPath}";
                        TSSLParamReading.Text = $"DEBUG: {description}, see parameditor.log";
                        Debug.WriteLine($"{description}");
                        Logger.LogExceptionWithDate(EOSe, description);
                    }
                }
                catch (InvalidDataException IDEx)
                {
                    string description = $"Failed to parse Param at {binPath}";
                    TSSLParamReading.Text = $"DEBUG: {description}, see parameditor.log";
                    Debug.WriteLine($"{description}");
                    Logger.LogExceptionWithDate(IDEx, description);
                }

            }

            
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
            if (selectedRow.Row.Cells != null)
            {
                foreach (var cell in selectedRow.Row.Cells)
                {
                    string[] newCellRow = { $"{cell.Def.DisplayType}", $"{cell.Def.DisplayName}", $"{cell.Value}" };
                    CellDGV.Rows.Add(newCellRow);
                }
            }
            else 
            {
                ReaderStatusStrip.Items.Clear();
                TSSLCellReading.Text = $"Row {selectedRow.Row.ID} in {ParamDGV.CurrentRow.Cells[0].Value} has Null Cells";
                Logger.LogErrorWithDate(TSSLCellReading.Text);
                return;
            }        
        }

        private void CellDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

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
                    paramdef.XmlSerialize($"{Util.resFolderPath}/xml/{Path.GetFileNameWithoutExtension(defPath)}.xml");
                }
                catch(InvalidDataException IDEx)
                {
                    ReaderStatusStrip.Items.Clear();
                    string description = $"Failed to parse Paramdef at {defPath}";
                    TSSLDefReading.Text = $"DEBUG: {description}, see parameditor.log";
                    Debug.WriteLine($"{description}");
                    Logger.LogExceptionWithDate(IDEx, description);
                }
            }
        }

        private void ConvertParamsTSVBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
