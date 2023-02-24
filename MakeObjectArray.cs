using System;
using System.Collections.Generic;
using System.IO;
using SoulsFormats;

namespace ACFAParamEditor
{
    internal static class MakeObjectArray
    {
        
        /// <summary>
        /// Make an object array containing a param so it can be loaded into the Param DataGridView
        /// </summary>
        /// <param name="path">A string containing the full path to the param file</param>
        /// <param name="defList">The def list so that the params can be read</param>
        /// <returns></returns>
        public static object[] MakeParamObject(string path, List<PARAMDEF> defList)
        {
            PARAM loadedParam = Load.VerifyParam(path);
            if (loadedParam == null) return null;
            ParamWrapper param = new()
            {
                ParamName = Path.GetFileName(path),
                ParamPath = path,
                IsBND = false,
                Param = loadedParam
            };

            bool applyDef = param.Param.ApplyParamdefCarefully(defList);
            object[] newParamRow = { param, param.Param.ParamType };
            if (applyDef == true) return newParamRow;
            return null;
        }

        /// <summary>
        /// Make an object array using data from a BND3 containing a param so it can be loaded into the Param DataGridView
        /// </summary>
        /// <param name="bndPath"></param>
        /// <param name="bFile"></param>
        /// <param name="defList"></param>
        /// <param name="paramPath"></param>
        /// <returns></returns>
        public static object[] MakeParamObject(string bndPath, BinderFile bFile, List<PARAMDEF> defList, string paramPath)
        {
            PARAM loadedParam = Load.VerifyParam(bFile.Bytes);
            if (loadedParam == null) return null;
            ParamWrapper param = new()
            {
                ParamName = paramPath,
                ParamPath = bFile.Name,
                BNDPath = bndPath,
                IsBND = true,
                Param = loadedParam
            };

            bool applyDef = param.Param.ApplyParamdefCarefully(defList);
            object[] newParamRow = { param, param.Param.ParamType };
            if (applyDef == true) return newParamRow;
            return null;
        }

        /// <summary>
        /// Make an object array containing a param row so it can be loaded into the Row DataGridView
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public static object[] MakeRowObject(PARAM.Row row)
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
        /// <returns></returns>
        public static object[] MakeCellObject(PARAM.Cell cell)
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
