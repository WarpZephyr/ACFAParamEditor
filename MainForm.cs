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
        // Initialize global def list
        private List<PARAMDEF> defList = new List<PARAMDEF>();
        private RowWrapper rowStore;
        private object cellValueStore;
        private string paramPath;
        public MainForm()
        {
            InitializeComponent();
            // Use override to change colors of selected Menu Strip items to dark mode and disable shadows
            MainFormMenuStrip.Renderer = new OverrideToolStripRenderer();

            // Disable Shadows on Dropdowns
            //FileMS.DropDown.DropShadowEnabled= false; // TODO: Fix random location changing when shadow is disabled
            ExportFMS.DropDown.DropShadowEnabled = false;
            RowMS.DropDown.DropShadowEnabled = false;
            HelpMS.DropDown.DropShadowEnabled = false;

            // Disable image beside menu strip sub items
            ((ToolStripDropDownMenu)FileMS.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)ExportFMS.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)RowMS.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)HelpMS.DropDown).ShowImageMargin = false;
        }

        // On Main Form Load, add the defs to the global def list
        private void MainForm_Load(object sender, EventArgs e)
        {
            Logger.createLog();
            Directory.CreateDirectory($"{Util.resFolderPath}/def/");

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

            // If the def resource folder is empty for some reason
            if (defList.Count == 0)
            {
                OpenParamsFMS.Enabled = false;
                string description = "WARNING: No defs found in resource folder";
                TSSLDefReading.Text = description;
                Debug.WriteLine(description);
                Logger.LogErrorWithDate(description);
            }
        }

        #region MenuItems
        // Open Params
        private void OpenParamsFMS_click(object sender, EventArgs e)
        {
            // Prompt the user for folders containing param files
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

            string binFolderPath = binFolderPathDialog.FileName;
            paramPath = binFolderPath;

            // Apply defs to params
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
                            ParamName = Path.GetFileName(binPath),
                            Param = PARAM.Read(binPath)
                        };

                        var applyDef = param.Param.ApplyParamdefCarefully(defList);
                        if (applyDef == true)
                        {
                            object[] newParamRow = { param, param.Param.ParamType };
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

            if (ParamDGV.Rows.Count == 0)
            {
                RowDGV.Rows.Clear();
                CellDGV.Rows.Clear();
            }
        }

        // TODO: Save the user's changes to params when they press save
        private void SaveFMS_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ParamDGV.Rows) 
            {
                ParamWrapper param = row.Cells[0].Value as ParamWrapper;
                param.Param.Write($"{paramPath}/{param.ParamName}");
            }
        }

        // Convert defs to xmls - Does not convert properly yet and leads to more null cells
        // TODO: Fix def to xml conversion
        private void ConvertDefXmlEFMS_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory($"{Util.resFolderPath}/xml/");

            // Prompt the user for folders containing def files to be serialized into Paramdef Xmls
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

            // Convert defs to xmls
            var defUserFolderPath = defFolderPathDialog.FileName;
            string[] defFiles = Directory.GetFiles(defUserFolderPath, "*.*");
            foreach (string defPath in defFiles)
            {
                try
                {
                    PARAMDEF paramdef = PARAMDEF.Read(defPath);
                    paramdef.XmlSerialize($"{Util.resFolderPath}/xml/{Path.GetFileNameWithoutExtension(defPath)}.xml");
                }
                catch (InvalidDataException IDEx)
                {
                    ReaderStatusStrip.Items.Clear();
                    string description = $"Failed to serialize file into Paramdef Xml at {defPath}";
                    TSSLDefReading.Text = $"DEBUG: {description}, see parameditor.log";
                    Debug.WriteLine($"{description}");
                    Logger.LogExceptionWithDate(IDEx, description);
                }
            }
        }

        // TODO: Convert Params to CSVs
        private void ConvertParamCsvEFMS_Click(object sender, EventArgs e)
        {

        }

        // TODO: Convert CSVs to Params
        private void ConvertCsvParamEFMS_Click(object sender, EventArgs e)
        {

        }

        // TODO: Convert Params to TSVs
        private void ConvertParamTsvEFMS_Click(object sender, EventArgs e)
        {

        }

        // TODO: Convert TSVs to Params
        private void ConvertTsvParamEFMS_Click(object sender, EventArgs e)
        {

        }

        // TODO: Copy the currently selected row
        private void CopyRowRMS_Click(object sender, EventArgs e)
        {

        }

        // TODO: Delete the currently selected row
        private void DeleteRowRMS_Click(object sender, EventArgs e)
        {

        }

        // TODO: Show About form message
        private void AboutHMS_Click(object sender, EventArgs e)
        {

        }
        #endregion MenuItems

        #region DataGridViewSelectionChanges
        // Show newly selected Param's Rows when Param DataGridView selection changes
        // TODO: Make error messages on status strip disappear when switching params
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

        // Show newly selected Row's Cells when Row DataGridView selection changes
        // TODO: Make error messages on status strip disappear when switching rows
        private void RowDGV_SelectionChanged(object sender, EventArgs e)
        {
            CellDGV.Rows.Clear();
            RowWrapper selectedRow = RowDGV.CurrentRow.Cells[1].Value as RowWrapper;
            rowStore = selectedRow;

            if (selectedRow.Row.Cells != null)
            {
                foreach (var cell in selectedRow.Row.Cells)
                {
                    var cellWrapper = new CellWrapper()
                    {
                        Cell = cell
                    };

                    object[] newCellRow = { cellWrapper.Cell.Def.DisplayType, cellWrapper, cellWrapper.Cell.Value };
                    CellDGV.Rows.Add(newCellRow);
                }
            }
            else 
            {
                ReaderStatusStrip.Items.Clear();
                string description = $"Row {selectedRow.Row.ID} in {ParamDGV.CurrentRow.Cells[0].Value} has Null Cells";
                TSSLCellReading.Text = description;
                Logger.LogErrorWithDate(description);
                return;
            }        
        }
        
        // TODO: Make error messages on status strip disappear when switching cells
        #endregion DataGridViewSelectionChanges

        #region DataGridViewSaveState
        private void RowDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (RowDGV.CurrentRow != null)
            {
                RowWrapper previousRow = rowStore;
                RowWrapper newRowValue = RowDGV.CurrentRow.Cells[1].Value as RowWrapper;
                switch (e.ColumnIndex)
                {
                    case 0:
                        string id = (string)RowDGV.CurrentRow.Cells[0].Value;
                        int idInt = Int32.Parse(id);
                        newRowValue.Row.ID = idInt;
                        break;
                    case 1:
                        string name = RowDGV.CurrentRow.Cells[1].Value.ToString();
                        previousRow.Row.Name = name;
                        RowDGV.Rows[e.RowIndex].Cells[1].Value = (previousRow);
                        break;
                }
            }
        }

        // Saves a cell's state
        private void CellDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (CellDGV.CurrentRow != null)
            {
                object dgvValue = CellDGV.CurrentRow.Cells[2].Value;
                CellWrapper selectedCell = CellDGV.CurrentRow.Cells[1].Value as CellWrapper;
                selectedCell.Cell.Value = dgvValue;
            }
        }
        #endregion DataGridViewSaveState

        // TODO: When someone attempts to drag a file into the window's Param viewing area
        private void SplitContainerA_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        // TODO: Check the dropped item
        private void SplitContainerA_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
