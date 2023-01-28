using System.Collections.Generic;
using SoulsFormats;

namespace ACFAParamEditor
{
    internal class GetParamData
    {
        public Dictionary<string, PARAM.Row> GetRow(PARAM param) 
        {
            Dictionary<string, PARAM.Row> rowDict = new Dictionary<string, PARAM.Row>();
            foreach (var row in param.Rows) {
                rowDict.Add(row.Name, row);
            }
            return rowDict;
        }

        public List<PARAM.Cell> GetCell(PARAM.Row row)
        {
            List<PARAM.Cell> cellList = new List<PARAM.Cell>();
            foreach (var cell in row.Cells)
            {
                cellList.Add(cell);
            }
            return cellList;
        }
    }
}
