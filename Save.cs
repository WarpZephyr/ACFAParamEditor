using System.IO;
using System.Windows.Forms;
using SoulsFormats;

namespace ACFAParamEditor
{
    internal static class Save
    {
        /// <summary>
        /// Save params writing to BND3 if needed.
        /// </summary>
        /// <param name="param">The param wrapper containing the param's name, directory, path, and finally the param itself</param>
        /// <param name="verify">Whether or not to prompt the user if they really want to save the param</param>
        /// <param name="backup">Whether or not to make a backup file of the file at the path set in the param path</param>
        public static void SaveParam(ParamWrapper param, bool backup = false, bool verify = false)
        {
            if (verify) 
            {
                DialogResult saveDialog = MessageBox.Show("Are you sure you want to save this param?", "Save Param", MessageBoxButtons.YesNo);
                if (saveDialog != DialogResult.Yes) { return; }
            }
            
            if (!param.IsBND && backup && !File.Exists($"{param.ParamPath}.bak")) param.Param.Write($"{param.ParamPath}.bak");
         
            if (param.IsBND)
            {
                SaveParamBND(param, BND3.Read(param.BNDPath), param.BNDPath, false, backup);
                return;
            }

            param.Param.Write($"{Path.GetDirectoryName(param.ParamPath)}/{param.ParamName}");
        }

        /// <summary>
        /// Save param file inside of a BND3.
        /// </summary>
        /// <param name="param">The param wrapper containing the param's name, directory, path, and finally the param itself</param>
        /// <param name="bnd">The current BND being saved to</param>
        /// <param name="BNDPath">The path to the root BND</param>
        /// <param name="isDeepBND">Is this a BND inside of a BND, used for recursion, set this to false</param>
        /// <param name="backup">Whether or not to backup the root BND</param>
        public static void SaveParamBND(ParamWrapper param, BND3 bnd, string BNDPath, bool isDeepBND, bool backup)
        {
            if (backup && !File.Exists($"{param.BNDPath}.bak")) bnd.Write($"{param.BNDPath}.bak");
            foreach (BinderFile bFile in bnd.Files)
            {
                if (BND3.Is(bFile.Bytes))
                {
                    var deepBnd = BND3.Read(bFile.Bytes);
                    SaveParamBND(param, deepBnd, BNDPath, true, backup);
                    bFile.Bytes = deepBnd.Write();
                }
                else if (bFile.Name == param.ParamPath)
                {
                    bFile.Bytes = param.Param.Write();
                }
            }

            if(!isDeepBND) bnd.Write(BNDPath);
        }

        /// <summary>
        /// Save multiple param files
        /// </summary>
        /// <param name="dgv">The DataGridView you wish to access params from</param>
        /// <param name="verify">Whether or not to ask the user if they want to save all these params</param>
        public static void SaveParams(DataGridView dgv, bool backup, bool verify = false)
        {
            if (verify)
            {
                DialogResult saveDialog = MessageBox.Show("Are you sure you want to save all params?", "Save all Params", MessageBoxButtons.YesNo);
                if (saveDialog != DialogResult.Yes) { return; }
            }

            foreach (ParamWrapper param in MainForm.modifiedParams)
            {
                SaveParam(param, backup);
            }
        }
    }
}
