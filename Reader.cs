using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SoulsFormats;

namespace ACFAParamEditor
{
    internal static class Reader
    {
        /// <summary>
        /// Loader all defs in the resource directory throwing and catching an InvalidDataException for files that cannot be read as defs
        /// </summary>
        /// <param name="defs">A list of the PARAMDEF type containing defs to read params</param>
        public static void LoadDefs(List<PARAMDEF> defs)
        {
            Logger.CreateLog();
            Directory.CreateDirectory($"{Util.resFolderPath}/def/");

            string[] defFiles = Directory.GetFiles($"{Util.resFolderPath}/def/", "*");
            foreach (string defPath in defFiles)
            {
                try
                {
                    if (defPath.EndsWith(".xml"))
                        defs.Add(PARAMDEF.XmlDeserialize(defPath));
                    else if (defPath.EndsWith(".def"))
                        defs.Add(PARAMDEF.Read(defPath));
                }
                catch (InvalidDataException IDEx)
                {
                    Logger.LogExceptionWithDate(IDEx, $"Failed to parse Paramdef at {defPath}");
                }
            }

            if (defs.Count == 0)
                Logger.Log("WARNING: No defs found in resource folder");
        }

        /// <summary>
        /// Makes a DataGridView row for params
        /// </summary>
        /// <param name="path">A string representing the path to a Param file</param>
        /// <param name="defs">A list of the PARAMDEF type containing defs to read params</param>
        /// <param name="skipBackup">Whether or not to skip backup files while reading.</param>
        /// <returns>An object array containing everything needed to load a single param as a DataGridView row</returns>
        public static object[] ReadParam(string path, List<PARAMDEF> defs, bool skipBackup = false)
        {
            if (path == null) return null;
            if (skipBackup && Path.GetExtension(path) == ".bak") return null; 
            object[] newParam = MakeRow.MakeParamRow(path, defs);
            if (newParam == null) return null;
            return newParam;
        }

        /// <summary>
        /// Load params from Binders.
        /// </summary>
        /// <param name="path">A string containing the path to a root Binder.</param>>
        /// <param name="defs">A list of the PARAMDEF type containing defs to read params</param>
        /// <param name="dgv">The DataGridView to add these params to</param>
        /// <param name="recurse">Whether or not to use recursion on nested Binders to search for more Params.</param>
        /// <param name="skipBackup">Whether or not to skip backup files while reading.</param>
        public static void ReadParam(string path, List<PARAMDEF> defs, DataGridView dgv, bool recurse = false, bool skipBackup = false)
        {
            if (skipBackup && Path.GetExtension(path) == ".bak") return;

            List<Bind.BindFile> bindFiles = Bind.RetrieveBindFiles(path);

            foreach (Bind.BindFile bindFile in bindFiles)
            {
                object[] newParam = MakeRow.MakeParamRow(bindFile, defs);

                if (newParam == null) continue;
                dgv.Rows.Add(newParam);
            }
        }

        /// <summary>
        /// Loads all params found from user selected files into the selected DataGridView
        /// </summary>
        /// <param name="paths">A string array holding multiple folders or paths to params</param>
        /// <param name="defs">A list of the PARAMDEF type containing defs to read params</param>
        /// <param name="dgv">The DataGridView to add these params to</param>
        /// <param name="recurse">Whether or not to use recursion on nested Binders to search for more Params.</param>
        /// <param name="skipBackup">Whether or not to skip backup files while reading.</param>
        public static void ReadParams(string[] paths, List<PARAMDEF> defs, DataGridView dgv, bool recurse = false, bool skipBackup = false)
        {
            if (paths == null) return;
            foreach (string path in paths)
            {
                if (Directory.Exists(path))
                {
                    ReadParams(Directory.GetFiles(path), defs, dgv, recurse, false);
                    continue;
                }

                if (Bind.IsBinder(path))
                {
                    ReadParam(path, defs, dgv, recurse, skipBackup);
                    continue;
                }

                object[] newParam = ReadParam(path, defs, skipBackup);
                if (newParam == null)
                {
                    Console.WriteLine(Path.GetFileName(path));
                    continue;
                }
                dgv.Rows.Add(newParam);
            }
        }

        /// <summary>
        /// Retrieves a list of param wrappers from a DataGridView.
        /// </summary>
        /// <param name="dataGridView">A DataGridView containing param wrappers.</param>
        /// <returns>A list of param wrappers.</returns>
        public static List<ParamWrapper> RetrieveParams(DataGridView dataGridView)
        {
            List<ParamWrapper> paramWrappers = new();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                ParamWrapper paramWrapper = row.Cells[0].Value as ParamWrapper;
                paramWrappers.Add(paramWrapper);
            }

            return paramWrappers;
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

        /// <summary>
        /// Converts a list of Params to a list of byte arrays.
        /// </summary>
        /// <param name="paramWrappers">A list of Params.</param>
        /// <returns>A list of byte arrays.</returns>
        public static List<byte[]> ParamsListToBytesList(List<ParamWrapper> paramWrappers)
        {
            List<byte[]> byteList = new();
            foreach (ParamWrapper paramWrapper in paramWrappers)
            {
                byteList.Add(paramWrapper.Param.Write());
            }

            return byteList;
        }

        /// <summary>
        /// Converts a list of Param names to a list of strings.
        /// </summary>
        /// <param name="paramWrappers">A list of Params.</param>
        /// <returns>A list of param names.</returns>
        public static List<string> ParamsListToNameList(List<ParamWrapper> paramWrappers)
        {
            List<string> nameList = new();
            foreach (ParamWrapper paramWrapper in paramWrappers)
            {
                nameList.Add(paramWrapper.ParamName);
            }

            return nameList;
        }
    }
}
