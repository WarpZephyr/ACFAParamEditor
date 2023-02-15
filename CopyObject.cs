using System;
using System.Collections.Generic;
using SoulsFormats;

namespace ACFAParamEditor
{
    internal static class CopyObject
    {
        public static object[] CopyRow(ParamWrapper selectedParam, RowWrapper selectedRow)
        {
            PARAM.Row newRow = new PARAM.Row(selectedRow.Row.ID, selectedRow.Row.Name, selectedParam.Param.AppliedParamdef);
            CopyCells(newRow, selectedRow.Row);
            object[] newRowObject = MakeObjectArray.MakeRowObject(newRow);
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
