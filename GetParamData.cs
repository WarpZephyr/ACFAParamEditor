using System.Collections.Generic;
using SoulsFormats;

namespace ACFAParamEditor
{
    internal class GetParamData
    {
        public List<string[]> GetRow(PARAM param) 
        {
            List<string[]> paramRows = new List<string[]>();
            foreach (var row in param.Rows) {
                string[] newRowRow = { $"{row.ID}", $"{row.Name}"};
                paramRows.Add(newRowRow);
            }
            return paramRows;
        }

        public List<string[]> GetCell(PARAM.Row row)
        {
            List<string[]> rowCells = new List<string[]>();
            foreach (var cell in row.Cells)
            {
                string[] newCellRow = { $"{row.ID}", $"{row.Name}" };
                rowCells.Add(newCellRow);
            }
            return rowCells;
        }
    }
}
