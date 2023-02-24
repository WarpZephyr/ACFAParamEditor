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
        // Initialize stacks
        //Stack<Action> undoStack = new();
        //Stack<Action> redoStack = new();

        // Initialize global variables
        private List<PARAMDEF> defs = new();
        private List<object[]> rowPasteList = new();
        private RowWrapper rowStore;
        private object cellValueStore;
        internal static List<ParamWrapper> modifiedParams = new();

        // MainForm Constructor
        public MainForm()
        {
            InitializeComponent();
            // Use override to change colors of selected Strip items to dark mode and disable shadows
            OverrideToolStripRenderer toolStripOverrideRenderer = new();
            MainFormMenuStrip.Renderer = toolStripOverrideRenderer;
            RowDGVContextMenu.Renderer = toolStripOverrideRenderer;
            ParamDGVContextMenu.Renderer = toolStripOverrideRenderer;

            // Disable Shadows on Dropdowns
            //FileMS.DropDown.DropShadowEnabled = false; // TODO: Fix random location changing when shadow is disabled
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

            // Load defs
            ACFAParamEditor.Load.LoadDefs(defs);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        // Add params
        private void OpenParamsFMS_click(object sender, EventArgs e)
        {
            string[] path = Util.GetFilePaths("params");
            ACFAParamEditor.Load.LoadParams(path, defs, ParamDGV);
            if (ParamDGV.Rows.Count == 0)
            {
                RowDGV.Rows.Clear();
                CellDGV.Rows.Clear();
            }
        }

        // Remove all params
        private void ClearParamFMS_Click(object sender, EventArgs e)
        {
            if (ParamDGV.CurrentRow == null) return;
            if (VerifyParamRemovalOMS.Checked == true)
            {
                DialogResult saveDialog = MessageBox.Show("Are you sure you want to clear all params?", "Clear all Params", MessageBoxButtons.YesNo);
                if (saveDialog != DialogResult.Yes) return;
            }
            ParamDGV.Rows.Clear();
            RowDGV.Rows.Clear();
            CellDGV.Rows.Clear();
        }

        // Remove the currently selected param
        private void RemoveParamFMS_Click(object sender, EventArgs e)
        {
            if (ParamDGV.CurrentRow == null) return;
            if (VerifyParamRemovalOMS.Checked == false) return;
            DialogResult saveDialog = MessageBox.Show("Are you sure you want to remove the currently selected param?", "Remove Selected Param", MessageBoxButtons.YesNo);
            if (saveDialog != DialogResult.Yes) return;
            if (ParamDGV.Rows.Count == 1) { RowDGV.Rows.Clear(); CellDGV.Rows.Clear(); }
            ParamDGV.Rows.Remove(ParamDGV.CurrentRow);
        }

        // Save the currently open param
        private void SaveFMS_Click(object sender, EventArgs e)
        {
            if (ParamDGV.CurrentRow == null) return;
            ParamWrapper param = ParamDGV.CurrentRow.Cells[0].Value as ParamWrapper;
            Save.SaveParam(param, BackupParamOMS.Checked, VerifySaveFileOMS.Checked);
        }

        // Save all params
        private void SaveAllFMS_Click(object sender, EventArgs e)
        {
            if (ParamDGV.Rows.Count == 0) return;

            Save.SaveParams(ParamDGV, BackupParamOMS.Checked, VerifySaveFileOMS.Checked);
        }

        // TODO: Fix def to xml conversion - Convert defs to xmls
        private void ConvertDefXmlEFMS_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory($"{Util.resFolderPath}/xml/");
            string defUserFolderPath = Util.GetFolderPath("defs");
            if (defUserFolderPath == null) return;

            // Convert defs to xmls
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
                    MainFormStatus.Text = "";
                    string description = $"Failed to serialize file into Paramdef Xml at {defPath}";
                    MainFormStatus.Text = $"DEBUG: {description}, see parameditor.log";
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
            CopyRowEMS_Click(sender, e);
            PasteRowEMS_Click(sender, e);
        }

        // Copy currently selected row
        private void CopyRowEMS_Click(object sender, EventArgs e)
        {
            if (RowDGV.CurrentRow == null) return;
            rowPasteList.Clear();
            ParamWrapper selectedParam = ParamDGV.CurrentRow.Cells[0].Value as ParamWrapper;

            foreach (DataGridViewRow dgvRow in RowDGV.SelectedRows)
            {
                RowWrapper currentRow = dgvRow.Cells[1].Value as RowWrapper;
                CopyObject newCopyObject = new();
                object[] newRowObject = newCopyObject.CopyRow(selectedParam, currentRow);
                rowPasteList.Insert(0, newRowObject);
            }
        }

        // Paste copied row
        private void PasteRowEMS_Click(object sender, EventArgs e)
        {
            if (rowPasteList.Count == 0) return;
            ParamWrapper selectedParam = ParamDGV.CurrentRow.Cells[0].Value as ParamWrapper;
            RowWrapper selectedRow = RowDGV.CurrentRow.Cells[1].Value as RowWrapper;
            bool success = false;

            foreach (object[] row in rowPasteList)
            {
                RowWrapper newRowWrapper = row[1] as RowWrapper;

                if (CellDGV.Rows.Count != newRowWrapper.Row.Cells.Count || !Util.CheckNameMatch(newRowWrapper.Row, selectedRow.Row)) return;

                int MaxID = RowDGV.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells[0].Value));
                newRowWrapper.Row.ID = MaxID + 1;
                row[0] = MaxID + 1;
                selectedParam.Param.Rows.Add(newRowWrapper.Row);
                success = true;
                RowDGV.Rows.Add(row);
            }

            if (!modifiedParams.Contains(selectedParam) && success) modifiedParams.Add(selectedParam);
            //undoStack.Push(Undo.UndoRowPaste(selectedParam, RowDGV, ParamDGV));
        }

        // Delete the currently selected row
        private void DeleteRowEMS_Click(object sender, EventArgs e)
        {
            if (RowDGV.CurrentRow == null) return;
            ParamWrapper selectedParam = ParamDGV.CurrentRow.Cells[0].Value as ParamWrapper;
            RowWrapper selectedRow = RowDGV.CurrentRow.Cells[1].Value as RowWrapper;
            bool success = false;

            if (VerifyDeleteRowOMS.Checked)
            {
                DialogResult deleteDialog = MessageBox.Show("Are you sure you want to delete the selected rows?", "Delete Selected Rows", MessageBoxButtons.YesNo);
                if (deleteDialog != DialogResult.Yes) return; 
            }

            //undoStack.Push(Undo.UndoRowDelete(selectedParam, RowDGV, ParamDGV));

            if (RowDGV.Rows.Count == 1 && RemoveEmptyParamOMS.Checked)
            {
                RemoveParamFMS_Click(sender, e);
                return;
            }

            foreach (DataGridViewRow dgvRow in RowDGV.SelectedRows)
            {
                RowWrapper currentRow = dgvRow.Cells[1].Value as RowWrapper;
                selectedParam.Param.Rows.Remove(currentRow.Row);
                success = true;
                RowDGV.Rows.Remove(dgvRow);
            }

            if (!modifiedParams.Contains(selectedParam) && success) modifiedParams.Add(selectedParam);
        }

        // TODO: Show About form message
        private void AboutHMS_Click(object sender, EventArgs e)
        {

        }

        // Show newly selected Param's Rows when Param DataGridView selection changes
        private void ParamDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (ParamDGV.CurrentRow == null) return;
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
        private void RowDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (RowDGV.CurrentRow == null) return;
            CellDGV.Rows.Clear();
            RowWrapper selectedRow = RowDGV.CurrentRow.Cells[1].Value as RowWrapper;
            rowStore = selectedRow;
            if (selectedRow.Row.Cells == null) return;
            foreach (var cell in selectedRow.Row.Cells)
            {
                object[] newCell = MakeObjectArray.MakeCellObject(cell);
                CellDGV.Rows.Add(newCell);
            }
        }

        // Backup cell value in case a user puts a value too large or too small
        private void CellDGV_SelectionChanged(object sender, EventArgs e)
        {
            cellValueStore = CellDGV.CurrentRow.Cells[2].Value;
        }

        // Saves a row's state
        private void RowDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (RowDGV.CurrentRow == null) return;
            RowWrapper previousRow = rowStore;
            RowWrapper newRowValue = RowDGV.CurrentRow.Cells[1].Value as RowWrapper;
            bool success = false;

            switch (e.ColumnIndex)
            {
                case 0:
                    int id = int.Parse((string)RowDGV.CurrentRow.Cells[0].Value);
                    newRowValue.Row.ID = id;
                    success = true;
                    break;
                case 1:
                    previousRow.Row.Name = RowDGV.CurrentRow.Cells[1].Value.ToString();
                    success = true;
                    RowDGV.Rows[e.RowIndex].Cells[1].Value = (previousRow);
                    break;
            }

            ParamWrapper selectedParam = ParamDGV.CurrentRow.Cells[0].Value as ParamWrapper;
            if (!modifiedParams.Contains(selectedParam) && success) modifiedParams.Add(selectedParam);
        }

        // Saves a cell's state
        private void CellDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (CellDGV.CurrentRow == null) return;
            ParamWrapper selectedParam = ParamDGV.CurrentRow.Cells[0].Value as ParamWrapper;
            try
            {
                object dgvValue = CellDGV.CurrentRow.Cells[2].Value;
                CellWrapper selectedCell = CellDGV.CurrentRow.Cells[1].Value as CellWrapper;
                if (selectedCell == null) return;
                selectedCell.Cell.Value = dgvValue;
                if (!modifiedParams.Contains(selectedParam)) modifiedParams.Add(selectedParam);
            }
            catch (OverflowException OFe) 
            {
                CellWrapper selectedCell = CellDGV.CurrentRow.Cells[1].Value as CellWrapper;
                selectedCell.Cell.Value = cellValueStore;
                CellDGV.CurrentRow.Cells[2].Value = cellValueStore;
                MainFormStatus.Text = "";
                string description = $"Value too high or too low for {selectedCell.Cell.Def.DisplayName}";
                MainFormStatus.Text = $"DEBUG: {description}, see parameditor.log";
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
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            ACFAParamEditor.Load.LoadParams(paths, defs, ParamDGV);
            if (ParamDGV.Rows.Count == 0)
            {
                RowDGV.Rows.Clear();
                CellDGV.Rows.Clear();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Control && e.KeyCode == Keys.Z) UndoEMS_Click(sender, e);
            //if (e.Control && e.KeyCode == Keys.Y) RedoEMS_Click(sender, e);
        }

        private void ParamDGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) RemoveParamFMS_Click(sender, e);
        }

        private void RowDGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) DeleteRowEMS_Click(sender, e);
            if (e.Control && e.KeyCode == Keys.C) CopyRowEMS_Click(sender, e);
            if (e.Control && e.KeyCode == Keys.V) PasteRowEMS_Click(sender, e);
        }

        private void UndoEMS_Click(object sender, EventArgs e)
        {
            //if (undoStack.Count != 0) { undoStack.Pop()(); }
        }

        private void RedoEMS_Click(object sender, EventArgs e)
        {
            //if (redoStack.Count != 0) { redoStack.Pop()(); }
        }

        private void CellDGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string value = Clipboard.GetText();
                string[] lines = value.Split('\n');
                int colIndex = CellDGV.CurrentCell.ColumnIndex;
                string[] cells = lines[0].Split('\t');
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i > CellDGV.SelectedCells.Count) return;
                    if (CellDGV[1, CellDGV.SelectedCells[i].RowIndex].Value is not CellWrapper selectedCell) return;
                    CellDGV[colIndex, CellDGV.SelectedCells[i].RowIndex].Value = lines[i];
                    selectedCell.Cell.Value = lines[i];
                }
            }
        }
    }
}
