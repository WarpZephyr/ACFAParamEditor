using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using SoulsFormats;

namespace ACFAParamEditor
{
    public partial class MainForm : Form
    {
        // Initialize global variables
        private List<PARAMDEF> defList = new List<PARAMDEF>();
        private RowWrapper rowStore;
        private object[] rowPaste;
        private ParamWrapper rowPasteParam;
        private object cellValueStore;

        // MainForm Constructor
        public MainForm()
        {
            InitializeComponent();
            // Use override to change colors of selected Strip items to dark mode and disable shadows
            var toolStripOverrideRenderer = new OverrideToolStripRenderer();
            MainFormMenuStrip.Renderer = toolStripOverrideRenderer;
            RowDGVContextMenu.Renderer = toolStripOverrideRenderer;
            ParamDGVContextMenu.Renderer = toolStripOverrideRenderer;

            // Disable Shadows on Dropdowns
            //FileMS.DropDown.DropShadowEnabled= false; // TODO: Fix random location changing when shadow is disabled
            ExportFMS.DropDown.DropShadowEnabled = false;
            EditMS.DropDown.DropShadowEnabled = false;
            OptionsMS.DropDown.DropShadowEnabled = false;
            HelpMS.DropDown.DropShadowEnabled = false;

            // Disable image beside menu strip sub items
            ((ToolStripDropDownMenu)FileMS.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)ExportFMS.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)EditMS.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)HelpMS.DropDown).ShowImageMargin = false;
            RowDGVContextMenu.ShowImageMargin=false;
            ParamDGVContextMenu.ShowImageMargin=false;
        }

        // On Main Form Load, add the defs to the global def list
        private void MainForm_Load(object sender, EventArgs e)
        {
            Logger.createLog();
            Directory.CreateDirectory($"{Util.resFolderPath}/def/");

            // Create def list on form load
            string[] defFiles = Directory.GetFiles($"{Util.resFolderPath}/def/", "*.def");
            foreach (string defPath in defFiles)
            {
                try
                {
                    defList.Add(PARAMDEF.Read(defPath));
                    //defList.Add(PARAMDEF.XmlDeserialize(defPath));
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
                AddParamFMS.Enabled = false;
                string description = "WARNING: No defs found in resource folder";
                TSSLDefReading.Text = description;
                Debug.WriteLine(description);
                Logger.LogErrorWithDate(description);
            }
        }

        // Open Params
        private void OpenParamsFMS_click(object sender, EventArgs e)
        {
            string paramFolderPath = Util.GetParamFiles("params");
            if (paramFolderPath == null) { return; }

            ParamDGV.Rows.Clear();
            string[] paramFiles = Directory.GetFiles(paramFolderPath, "*.*");
            foreach (string paramPath in paramFiles)
            {
                if (Path.GetExtension(paramPath) == ".bak") { continue; }
                if (Util.CheckIfParam(paramPath))
                {
                    object[] newParam = MakeObjectArray.MakeParamObject(paramPath, defList);
                    if (newParam == null ) { continue; }
                    ParamDGV.Rows.Add(newParam);
                }
            }

            if (ParamDGV.Rows.Count == 0)
            {
                RowDGV.Rows.Clear();
                CellDGV.Rows.Clear();
            }
        }

        // Open and add one param
        private void AddParamFMS_Click(object sender, EventArgs e)
        {
            string paramFilePath = Util.GetParamFile();
            if (paramFilePath == null) { return; }
            if (Path.GetExtension(paramFilePath) == ".bak") { MessageBox.Show("Cannot load backup file"); return; }
            object[] newParam = MakeObjectArray.MakeParamObject(paramFilePath, defList);
            if (newParam == null) { return; }
            ParamDGV.Rows.Add(newParam);
        }

        // Remove all params
        private void ClearParamFMS_Click(object sender, EventArgs e)
        {
            if (ParamDGV.CurrentRow == null) { return; }
            if (VerifyParamRemovalOMS.Checked == true)
            {
                DialogResult saveDialog = MessageBox.Show("Are you sure you want to clear all params?", "Clear all Params", MessageBoxButtons.YesNo);
                if (saveDialog != DialogResult.Yes) { return; }
            }
            ParamDGV.Rows.Clear();
            RowDGV.Rows.Clear();
            CellDGV.Rows.Clear();
        }

        // Remove the currently selected param
        private void RemoveParamFMS_Click(object sender, EventArgs e)
        {
            if (ParamDGV.CurrentRow == null) { return; }
            if (VerifyParamRemovalOMS.Checked == false) { return; }
            DialogResult saveDialog = MessageBox.Show("Are you sure you want to remove the currently selected param?", "Remove Selected Param", MessageBoxButtons.YesNo);
            if (saveDialog != DialogResult.Yes) { return; }
            if (ParamDGV.Rows.Count == 1) { RowDGV.Rows.Clear(); CellDGV.Rows.Clear(); }
            ParamDGV.Rows.Remove(ParamDGV.CurrentRow);
        }

        // Save the currently open param
        private void SaveFMS_Click(object sender, EventArgs e)
        {
            if (ParamDGV.CurrentRow == null) { return; }
            if (VerifySaveFileOMS.Checked == true) {
                DialogResult saveDialog = MessageBox.Show("Are you sure you want to save this param?", "Save Param", MessageBoxButtons.YesNo);
                if (saveDialog != DialogResult.Yes) { return; }
            }
            ParamWrapper param = ParamDGV.CurrentRow.Cells[0].Value as ParamWrapper;
            if (BackupParamOMS.Checked == true)
            {
                if (!File.Exists($"{param.ParamPath}/{param.ParamName}.original.bak")) 
                { 
                    param.Param.Write($"{param.ParamPath}/{param.ParamName}.original.bak");
                }
                param.Param.Write($"{param.ParamPath}/{param.ParamName}.bak");
            }
            param.Param.Write($"{param.ParamPath}/{param.ParamName}");
        }

        // Save all params
        private void SaveAllFMS_Click(object sender, EventArgs e)
        {
            if (ParamDGV.Rows.Count == 0) { return; }
            if (VerifySaveFileOMS.Checked == true)
            {
                DialogResult saveDialog = MessageBox.Show("Are you sure you want to save all params?", "Save all Params", MessageBoxButtons.YesNo);
                if (saveDialog != DialogResult.Yes) { return; }
            }
            foreach (DataGridViewRow row in ParamDGV.Rows) 
            {
                ParamWrapper param = row.Cells[0].Value as ParamWrapper;
                if (BackupParamOMS.Checked == true)
                {
                    if (!File.Exists($"{param.ParamPath}/{param.ParamName}.original.bak"))
                    {
                        param.Param.Write($"{param.ParamPath}/{param.ParamName}.original.bak");
                    }
                    param.Param.Write($"{param.ParamPath}/{param.ParamName}.bak");
                }
                param.Param.Write($"{param.ParamPath}/{param.ParamName}");
            }
        }

        // TODO: Fix def to xml conversion - Convert defs to xmls
        private void ConvertDefXmlEFMS_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory($"{Util.resFolderPath}/xml/");
            string defUserFolderPath = Util.GetParamFiles("defs");
            if (defUserFolderPath == null) { return; }
            string defsPath = defUserFolderPath;

            // Convert defs to xmls
            string[] defFiles = Directory.GetFiles(defsPath, "*.*");
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

        // Duplicate the currently selected row
        private void DuplicateRowEMS_Click(object sender, EventArgs e)
        {
            if (RowDGV.CurrentRow == null) { return; }
            ParamWrapper selectedParam = ParamDGV.CurrentRow.Cells[0].Value as ParamWrapper;
            RowWrapper selectedRow = RowDGV.CurrentRow.Cells[1].Value as RowWrapper;
            PARAM.Row newRowObject = new PARAM.Row(selectedRow.Row.ID, selectedRow.Row.Name, selectedParam.Param.AppliedParamdef);
            object[] newRow = MakeObjectArray.MakeRowObject(newRowObject);
            RowWrapper newRowWrapper = newRow[1] as RowWrapper;
            int MaxID = RowDGV.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells[0].Value));
            newRowWrapper.Row.ID = MaxID + 1;
            newRow[0] = MaxID + 1;
            selectedParam.Param.Rows.Add(newRowWrapper.Row);
            RowDGV.Rows.Add(newRow);
        }

        // Copy currently selected row
        private void CopyRowEMS_Click(object sender, EventArgs e)
        {
            if (RowDGV.CurrentRow == null) { return; }
            ParamWrapper selectedParam = ParamDGV.CurrentRow.Cells[0].Value as ParamWrapper;
            RowWrapper selectedRow = RowDGV.CurrentRow.Cells[1].Value as RowWrapper;
            object[] newRowObject = Util.CopyRow(selectedParam, selectedRow);
            rowPasteParam = selectedParam;
            rowPaste = newRowObject;
        }

        // Paste copied row
        private void PasteRowEMS_Click(object sender, EventArgs e)
        {
            if (rowPaste == null) { return; }
            ParamWrapper selectedParam = ParamDGV.CurrentRow.Cells[0].Value as ParamWrapper;
            RowWrapper selectedRow = RowDGV.CurrentRow.Cells[1].Value as RowWrapper;

            CopyObject newCopyObject = new CopyObject();

            object[] newRow = newCopyObject.CopyRow((RowWrapper)rowPaste[1], rowPasteParam);
            RowWrapper newRowWrapper = newRow[1] as RowWrapper;

            if (CellDGV.Rows.Count != newRowWrapper.Row.Cells.Count) { return; }
            if (!Util.CheckNameMatch(newRowWrapper.Row, selectedRow.Row)) { return; }

            int MaxID = RowDGV.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells[0].Value));
            newRowWrapper.Row.ID = MaxID + 1;
            rowPaste[0] = MaxID + 1;
            selectedParam.Param.Rows.Add(newRowWrapper.Row); 
            RowDGV.Rows.Add(rowPaste);
        }

        // TODO: Delete the currently selected row
        private void DeleteRowEMS_Click(object sender, EventArgs e)
        {
            if (RowDGV.CurrentRow == null) { return; }
            ParamWrapper selectedParam = ParamDGV.CurrentRow.Cells[0].Value as ParamWrapper;
            RowWrapper selectedRow = RowDGV.CurrentRow.Cells[1].Value as RowWrapper;
            if (VerifyDeleteRowOMS.Checked == true) 
            {
                DialogResult deleteDialog = MessageBox.Show("Are you sure you want to delete this row?", "Delete Row", MessageBoxButtons.YesNo);
                if (deleteDialog != DialogResult.Yes) { return; } 
            }
            if (RowDGV.Rows.Count == 1)
            {
                DialogResult deleteDialog = MessageBox.Show("This will also delete the currently selected param, are you sure you wish to continue?", "Delete Param", MessageBoxButtons.YesNo);
                if (deleteDialog != DialogResult.Yes) { return; }
                if (ParamDGV.Rows.Count == 1) 
                {
                    RowDGV.Rows.Clear();
                    CellDGV.Rows.Clear();
                }
                ParamDGV.Rows.Remove(ParamDGV.CurrentRow);
                return;
            }
            selectedParam.Param.Rows.Remove(selectedRow.Row);
            RowDGV.Rows.Remove(RowDGV.CurrentRow);
        }

        // TODO: Show About form message
        private void AboutHMS_Click(object sender, EventArgs e)
        {

        }

        // Show newly selected Param's Rows when Param DataGridView selection changes
        // TODO: Make error messages on status strip disappear when switching params
        private void ParamDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (ParamDGV.CurrentRow == null) { return; }
            RowDGV.Rows.Clear();
            CellDGV.Rows.Clear();
            ParamWrapper selectedParam = ParamDGV.CurrentRow.Cells[0].Value as ParamWrapper;

            foreach (PARAM.Row row in selectedParam.Param.Rows)
            {
                object[] newRow = MakeObjectArray.MakeRowObject(row);
                RowDGV.Rows.Add(newRow);
            }
        }

        // Show newly selected Row's Cells when Row DataGridView selection changes
        // TODO: Make error messages on status strip disappear when switching rows
        private void RowDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (RowDGV.CurrentRow == null) { return; }
            CellDGV.Rows.Clear();
            RowWrapper selectedRow = RowDGV.CurrentRow.Cells[1].Value as RowWrapper;
            rowStore = selectedRow;
            if (selectedRow.Row.Cells == null) { return; }
            foreach (var cell in selectedRow.Row.Cells)
            {
                object[] newCell = MakeObjectArray.MakeCellObject(cell);
                CellDGV.Rows.Add(newCell);
            }    
        }

        private void CellDGV_SelectionChanged(object sender, EventArgs e)
        {
            cellValueStore = CellDGV.CurrentRow.Cells[2].Value;
        }

        // TODO: Make error messages on status strip disappear when switching cells

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
            try
            {
                if (CellDGV.CurrentRow != null)
                {
                    object dgvValue = CellDGV.CurrentRow.Cells[2].Value;
                    CellWrapper selectedCell = CellDGV.CurrentRow.Cells[1].Value as CellWrapper;
                    selectedCell.Cell.Value = dgvValue;
                }
            }
            catch (OverflowException OFe) 
            {
                CellWrapper selectedCell = CellDGV.CurrentRow.Cells[1].Value as CellWrapper;
                selectedCell.Cell.Value = cellValueStore;
                CellDGV.CurrentRow.Cells[2].Value = cellValueStore;
                ReaderStatusStrip.Items.Clear();
                string description = $"Value too high or too low for {selectedCell.Cell.Def.DisplayName}";
                TSSLDefReading.Text = $"DEBUG: {description}, see parameditor.log";
                Debug.WriteLine($"{description}");
                Logger.LogExceptionWithDate(OFe, description);
            }
        }

        // When someone attempts to drag a file into the window's Param viewing area
        private void SplitContainerA_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        // Check the dropped item
        private void SplitContainerA_DragDrop(object sender, DragEventArgs e)
        {
            string[] filepaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string path in filepaths)
            {
                if (Directory.Exists(path))
                {
                    ParamDGV.Rows.Clear();
                    string[] paramFiles = Directory.GetFiles(path, "*.*");
                    foreach (string paramPath in paramFiles)
                    {
                        if (Util.CheckIfParam(paramPath))
                        {
                            if (Path.GetExtension(paramPath) == ".bak") { continue; }
                            object[] newParam = MakeObjectArray.MakeParamObject(paramPath, defList);
                            if (newParam == null) { continue; }
                            ParamDGV.Rows.Add(newParam);
                        }
                    }
                }
                else
                {
                    if (Path.GetExtension(path) == ".bak") { continue; }
                    object[] newParam = MakeObjectArray.MakeParamObject(path, defList);
                    if (newParam == null) { MessageBox.Show("Invalid file, not a usable param"); return; }
                    ParamDGV.Rows.Add(newParam);
                }
            }
        }

        private void RowDGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteRowEMS_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.C)
            {
                CopyRowEMS_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.V)
            {
                PasteRowEMS_Click(sender, e);
            }
        }

        private void RowDGV_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void ParamDGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                RemoveParamFMS_Click(sender, e);
            }
        } 
    }
}
