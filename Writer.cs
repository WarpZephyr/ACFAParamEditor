using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SoulsFormats;

namespace ACFAParamEditor
{
    internal static class Writer
    {
        /// <summary>
        /// Writes the chosen Binder to the chosen path, overwriting any existing file on that path and backing up the original file if specified to do so.
        /// </summary>
        /// <param name="data">A Binder to write to the chosen path.</param>
        /// <param name="dataPath">A string representing the path to write the chosen Binder to.</param>
        /// <param name="bhdPath">A string representing the path to write the chosen Binder's BHD to if necessary.</param>
        /// <param name="backup">Whether or not to backup the binder.</param>
        public static void WriteBinder(IBinder data, string dataPath, string bhdPath = null, bool backup = false)
        {
            Util.Clone(dataPath, backup);
            if (bhdPath != null) Util.Clone(bhdPath, backup);

            if (data is BND3 bnd3) bnd3.Write(dataPath);
            else if (data is BND4 bnd4) bnd4.Write(dataPath);
            else if (bhdPath == null) return;
            else if (data is BXF3 bxf3) bxf3.Write(bhdPath, dataPath);
            else if (data is BXF4 bxf4) bxf4.Write(bhdPath, dataPath);
        }

        /// <summary>
        /// Writes the chosen Binder to the chosen path, overwriting any existing file on that path.
        /// </summary>
        /// <param name="data">A Binder to write to the chosen path.</param>
        /// <param name="dataPath">A string representing the path to write the chosen Binder to.</param>
        /// <param name="bhdPath">A string representing the path to write the chosen Binder's BHD to if necessary.</param>
        public static void WriteBinder(IBinder data, string dataPath, string bhdPath = null)
        {
            if (data is BND3 bnd3) bnd3.Write(dataPath);
            else if (data is BND4 bnd4) bnd4.Write(dataPath);
            else if (bhdPath == null) return;
            else if (data is BXF3 bxf3) bxf3.Write(bhdPath, dataPath);
            else if (data is BXF4 bxf4) bxf4.Write(bhdPath, dataPath);
        }

        /// <summary>
        /// Writes the chosen Binder.
        /// </summary>
        /// <param name="data">A Binder to write.</param>
        public static byte[] WriteBinder(IBinder data)
        {
            if (data is BND3 bnd3) return bnd3.Write();
            else if (data is BND4 bnd4) return bnd4.Write();
            return null;
        }

        /// <summary>
        /// Writes the chosen Binder to the chosen path, backing up the file at that path if it exists, writing new data to the file, and then overwriting any existing file on that path.
        /// </summary>
        /// <param name="data">A Binder to write to the chosen path.</param>
        /// <param name="newData">New data to write to BinderFiles in a Binder.</param>
        /// <param name="binderFileNames">The names of BinderFiles you want to write the provided new data to.</param>
        /// <param name="dataPath">A string representing the path to write the chosen Binder to.</param>
        /// <param name="bhdPath">A string representing the path to write the chosen Binder's BHD to if necessary.</param>
        /// <param name="recurse">Whether or not to write to nested Binders in this Binder.</param>
        /// <param name="backup">Whether or not to backup the binder.</param>
        public static void WriteBinder(IBinder data, byte[] newData, string[] binderFileNames, string dataPath, string bhdPath = null, bool recurse = false, bool backup = false)
        {
            Util.Clone(dataPath, backup);
            if (bhdPath != null) Util.Clone(bhdPath, backup);
            IBinder binder = WriteBinder(data, newData, binderFileNames, "", dataPath, bhdPath, recurse);
            WriteBinder(binder, dataPath, bhdPath);
        }

        /// <summary>
        /// Writes new data to the chosen BinderFile in a Binder.
        /// </summary>
        /// <param name="binder">A Binder to write new data to.</param>
        /// <param name="newData">New data to write to BinderFiles in a Binder.</param>
        /// <param name="binderFileNames">The names of BinderFiles you want to write the provided new data to.</param>
        /// <param name="recurse">Whether or not to write to nested Binders in this Binder.</param>
        public static IBinder WriteBinder(IBinder binder, byte[] newData, string[] binderFileNames, string dataPath, string binderName, string bhdPath = null, bool recurse = false)
        {
            foreach (var bFile in binder.Files)
            {
                bool found = false;
                if (recurse && Bind.IsBinder(bFile.Bytes))
                {
                    IBinder deepBinder = Bind.ReadBinder(bFile.Bytes);
                    WriteBinder(deepBinder, newData, binderFileNames, binderName, dataPath, bhdPath, recurse);

                    byte[] newBytes = WriteBinder(deepBinder);
                    if (newBytes != null)
                        bFile.Bytes = newBytes;
                    break;
                }

                foreach (var name in binderFileNames)
                {
                    if (bFile.Name == null)
                        continue;
                    if (name.EndsWith(bFile.Name) && name.Contains(binderName))
                        bFile.Bytes = newData;
                    break;
                }

                if (found)
                    break;
            }

            return binder;
        }

        /// <summary>
        /// Save params writing to a Binder if needed.
        /// </summary>
        /// <param name="param">A param wrapper containing the param's name, directory, path, and finally the param itself</param>
        /// <param name="recurse">Whether or not to write to nested Binders if a file is inside a Binder.</param>
        /// <param name="backup">Whether or not to make a backup file of the file at the path set in the param path</param>
        /// <param name="verify">Whether or not to ask the user if they wish to save.</param>
        public static void SaveParam(ParamWrapper param, bool recurse = false, bool backup = false, bool verify = false)
        {
            if (verify && !Util.Verify("Are you sure you wish to save this Param?", "Save Param")) return;

            if (param.IsBND)
            {
                IBinder binder = Bind.ReadBinder(param.ParamPath);
                byte[] newBytes = param.Param.Write();
                string[] binderFileNames = new string[] { param.ParamName };
                WriteBinder(binder, newBytes, binderFileNames, param.ParamPath, null, recurse, backup);
                return;
            }

            Util.Clone($"{param.ParamPath}", backup);
            param.Param.Write($"{param.ParamPath}");
        }

        /// <summary>
        /// Save a list of params writing to Binders if needed.
        /// </summary>
        /// <param name="paramWrappers">A list of param wrapper containing the param's name, directory, path, and finally the param itself</param>
        /// <param name="recurse">Whether or not to write to nested Binders if a file is inside a Binder.</param>
        /// <param name="backup">Whether or not to make a backup file of the file at the path set in the param path</param>
        /// <param name="verify">Whether or not to ask the user if they wish to save.</param>
        public static void SaveParams(List<ParamWrapper> paramWrappers, bool recurse = false, bool backup = false, bool verify = false)
        {
            if (verify && !Util.Verify("Are you sure you wish to save all modified Params?", "Save All Modified Params")) return;

            foreach (var paramWrapper in paramWrappers)
            {
                SaveParam(paramWrapper, recurse, backup, false);
            }
        }
    }
}
