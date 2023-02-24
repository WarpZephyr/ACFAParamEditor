using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SoulsFormats;

namespace ACFAParamEditor
{
    internal static class Load
    {
        /// <summary>
        /// Load all defs in the resource directory throwing and catching an InvalidDataException for files that cannot be read as defs
        /// </summary>
        /// <param name="defs">A list of the PARAMDEF type containing defs to read params</param>
        public static void LoadDefs(List<PARAMDEF> defs)
        {
            Logger.CreateLog();
            Directory.CreateDirectory($"{Util.resFolderPath}/def/");

            string[] defFiles = Directory.GetFiles($"{Util.resFolderPath}/def/", "*.def");
            foreach (string defPath in defFiles)
            {
                try
                {
                    defs.Add(PARAMDEF.Read(defPath));
                }
                catch (InvalidDataException IDEx)
                {
                    Logger.LogExceptionWithDate(IDEx, $"Failed to parse Paramdef at {defPath}");
                }
            }

            if (defs.Count == 0) Logger.Log("WARNING: No defs found in resource folder");
        }

        /// <summary>
        /// Makes a DataGridView row for params
        /// </summary>
        /// <param name="path">The path to a single param file</param>
        /// <param name="defs">A list of the PARAMDEF type containing defs to read params</param>
        /// <returns>An object array containing everything needed to load a single param as a DataGridView row</returns>
        public static object[] LoadParam(string path, List<PARAMDEF> defs)
        {
            if (path == null) return null;
            if (Path.GetExtension(path) == ".bak") return null;
            object[] newParam = MakeObjectArray.MakeParamObject(path, defs);
            if (newParam == null) return null;
            return newParam;
        }

        /// <summary>
        /// Loads all params found from user selected files into the selected DataGridView
        /// </summary>
        /// <param name="paths">A string array holding multiple folders or paths to params</param>
        /// <param name="defs">A list of the PARAMDEF type containing defs to read params</param>
        /// <param name="dgv">The DataGridView to add these params to</param>
        public static void LoadParams(string[] paths, List<PARAMDEF> defs, DataGridView dgv)
        {
            if (paths == null) return;
            foreach (string path in paths)
            {
                if (Directory.Exists(path)) { LoadParams(Directory.GetFiles(path), defs, dgv); continue; }
                if (Path.GetExtension(path) == ".bak") continue;
                if (BND3.Is(path)) { LoadBND(path, BND3.Read(path), defs, dgv); continue; }
                object[] newParam = LoadParam(path, defs);
                if (newParam == null) continue;
                dgv.Rows.Add(newParam);
            }
        }

        /// <summary>
        /// Recurse BND3 for param files
        /// </summary>
        /// <param name="bndPath">A string containing the path to a BND3 file needed to tell if a param is inside of a BND3 or not</param>>
        /// <param name="bnd">The loaded bnd file needed to pass an inner BinderFile as a BND3 to read</param>>
        /// <param name="defs">A list of the PARAMDEF type containing defs to read params</param>
        /// <param name="dgv">The DataGridView to add these params to</param>
        /// <param name="paramPath">A string to assist in pathing out BNDs, do not set this</param>
        public static void LoadBND(string bndPath, BND3 bnd, List<PARAMDEF> defs, DataGridView dgv, string paramPath = null)
        {
            paramPath ??= $"{Path.GetFileName(bndPath)}";
            foreach (BinderFile bFile in bnd.Files)
            {
                if (BND3.Is(bFile.Bytes))
                {
                    LoadBND(bndPath, BND3.Read(bFile.Bytes), defs, dgv, $"{paramPath}\\{bFile.Name}");
                }
                else
                {
                    object[] newParam = MakeObjectArray.MakeParamObject(bndPath, bFile, defs, $"{paramPath}\\{bFile.Name}");
                    if (newParam == null) continue;
                    dgv.Rows.Add(newParam);
                }
            }
        }

        /// <summary>
        /// PARAM.Read wrapper that catches exceptions when trying to read files that are not params
        /// </summary>
        /// <param name="path">A string containing the full path to the param file</param>
        /// <returns>A param if no exceptions occurred</returns>
        public static PARAM VerifyParam(string path)
        {
            try
            {
                return PARAM.Read(path);
            }
            catch (Exception e)
            {
                Logger.LogExceptionWithDate(e, $"Could not load {path} as a param");
                return null;
            }
        }

        /// <summary>
        /// PARAM.Read wrapper that catches exceptions when trying to read files that are not params
        /// </summary>
        /// <param name="bytes">A byte array from a BinderFile that is presumed to be a param</param>
        /// <returns>A param from a byte array if no exceptions occurred</returns>
        public static PARAM VerifyParam(byte[] bytes)
        {
            try
            {
                return PARAM.Read(bytes);
            }
            catch (Exception e)
            {
                Logger.LogExceptionWithDate(e, $"Could not load BinderFile in BND as a param");
                return null;
            }
        }
    }
}
