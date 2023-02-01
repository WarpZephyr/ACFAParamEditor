using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using SoulsFormats;

namespace ACFAParamEditor
{
    internal static class MakeObjectArray
    {
        // Make and return a param
        public static object[] MakeParamObject(string paramFilePath, List<PARAMDEF> defList)
        {
            var param = new ParamWrapper()
            {
                ParamName = Path.GetFileName(paramFilePath),
                Param = PARAM.Read(paramFilePath)
            };

            var applyDef = param.Param.ApplyParamdefCarefully(defList);
            object[] newParamRow = { param, param.Param.ParamType };
            if (applyDef == true) { return newParamRow; }
            return null;
        }

        // Make and return a row
        public static object[] MakeRowObject(PARAM.Row row)
        {
            var rowWrapper = new RowWrapper()
            {
                Row = row
            };

            object[] newRow = { rowWrapper.Row.ID, rowWrapper };
            return newRow;
        }

        // Make and return a cell
        public static object[] MakeCellObject(PARAM.Cell cell)
        {
            var cellWrapper = new CellWrapper()
            {
                Cell = cell
            };

            object[] newCell = { cellWrapper.Cell.Def.DisplayType, cellWrapper, cellWrapper.Cell.Value };
            return newCell;
        }
    }
}
