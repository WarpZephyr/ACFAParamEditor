using System;
using System.Collections.Generic;
using System.IO;
using SoulsFormats;

namespace ACFAParamEditor
{
    internal static class MakeRow
    {
        
        /// <summary>
        /// Make an object array containing a param so it can be loaded into the Param DataGridView
        /// </summary>
        /// <param name="path">A string containing the full path to the param file</param>
        /// <param name="defList">The def list so that the params can be read</param>
        /// <returns>An object to be used as a DataGridView row.</returns>
        public static object[] MakeParamRow(string path, List<PARAMDEF> defList)
        {
            PARAM loadedParam = Reader.VerifyParam(path);
            if (loadedParam == null) return null;
            ParamWrapper param = new()
            {
                ParamName = Path.GetFileName(path),
                ParamPath = path,
                IsBND = false,
                Param = loadedParam
            };

            bool applyDef = param.Param.ApplyParamdefSomewhatCarefully(defList);
            object[] newParamRow = { param, param.Param.ParamType };
            if (applyDef == true) return newParamRow;
            return null;
        }

        /// <summary>
        /// Make an object array using data from a BND3 containing a param so it can be loaded into the Param DataGridView
        /// </summary>
        /// <param name="bindFile">A BindFile containing a param and its pathing information.</param>
        /// <param name="defs">A list of defs to read the param.</param>
        /// <returns>An object to be used as a DataGridView row.</returns>
        public static object[] MakeParamRow(Bind.BindFile bindFile, List<PARAMDEF> defs)
        {
            PARAM loadedParam = Reader.VerifyParam(bindFile.Bytes);
            if (loadedParam == null) return null;
            ParamWrapper param = new()
            {
                ParamName = bindFile.RelativePath,
                ParamPath = bindFile.FullPath,
                IsBND = true,
                Param = loadedParam
            };

            bool applyDef = param.Param.ApplyParamdefCarefully(defs);
            object[] newParamRow = { param, param.Param.ParamType };
            if (applyDef == true) return newParamRow;
            return null;
        }

        /// <summary>
        /// Make an object array containing a param row so it can be loaded into the Row DataGridView
        /// </summary>
        /// <param name="row"></param>
        /// <returns>An object to be used as a DataGridView row.</returns>
        public static object[] MakeRowRow(PARAM.Row row)
        {
            RowWrapper rowWrapper = new()
            {
                Row = row
            };

            object[] newRow = { rowWrapper.Row.ID, rowWrapper };
            return newRow;
        }

        /// <summary>
        /// Make an object array containing a param cell so it can be loaded into the Cell DataGridView
        /// </summary>
        /// <param name="cell"></param>
        /// <returns>An object to be used as a DataGridView row.</returns>
        public static object[] MakeCellRow(PARAM.Cell cell)
        {
            CellWrapper cellWrapper = new()
            {
                Cell = cell
            };

            object[] newCell = { cellWrapper.Cell.Def.DisplayType, cellWrapper, cellWrapper.Cell.Value };
            return newCell;
        }
    }
}
