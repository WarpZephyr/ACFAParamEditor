using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SoulsFormats;

namespace ACFAParamEditor
{
    internal class CopyObject
    {
        public List<object[]> CopyRows(ParamWrapper selectedParam, DataGridView RowDGV)
        {
            List<object[]> copiedRows = new();
            foreach (DataGridViewRow dgvRow in RowDGV.SelectedRows)
            {
                RowWrapper currentRow = dgvRow.Cells[1].Value as RowWrapper;
                PARAM.Row newRow = new PARAM.Row(currentRow.Row.ID, currentRow.Row.Name, selectedParam.Param.AppliedParamdef);
                CopyCells(newRow, currentRow.Row);
                object[] newRowObject = MakeRow.MakeRowRow(newRow);
                copiedRows.Add(newRowObject);
            }
            return copiedRows;
        }

        public object[] CopyRow(ParamWrapper selectedParam, RowWrapper selectedRow)
        {
            PARAM.Row newRow = new PARAM.Row(selectedRow.Row.ID, selectedRow.Row.Name, selectedParam.Param.AppliedParamdef);
            CopyCells(newRow, selectedRow.Row);
            object[] newRowObject = MakeRow.MakeRowRow(newRow);
            return newRowObject;
        }

        public static List<object> GetCells(PARAM.Row row)
        {
            List<object> cellValues = new List<object>();
            foreach (PARAM.Cell cell in row.Cells)
            {
                cellValues.Add(cell.Value);
            }
            return cellValues;
        }

        public static PARAM.Row CopyCells(PARAM.Row newRow, PARAM.Row oldRow)
        {
            List<object> oldCellValues = GetCells(oldRow);
            int iterator = 0;
            foreach (PARAM.Cell newCell in newRow.Cells)
            {
                newCell.Value = oldCellValues[iterator];
                iterator++;
            }
            return newRow;
        }
    }
}
