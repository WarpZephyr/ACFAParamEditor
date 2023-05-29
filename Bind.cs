using SoulsFormats;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using static ACFAParamEditor.Bind;

namespace ACFAParamEditor
{
    /// <summary>
    /// A class for wrapping additional information inside of Binders being processed.
    /// </summary>
    public class Bind
    {
        /// <summary>
        /// The Binder this Bind is adding information to.
        /// </summary>
        public IBinder Binder { get; set; }

        /// <summary>
        /// The name of this Bind.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The full file path to this Bind.
        /// </summary>
        public string FullPath { get; set; }

        /// <summary>
        /// The full file path to this Bind's BHD if applicable.
        /// </summary>
        public string FullBHDPath { get; set; }

        /// <summary>
        /// The relative file path of this Bind.
        /// </summary>
        public string RelativePath { get; set; }

        /// <summary>
        /// BindFiles in this Bind.
        /// </summary>
        public List<BindFile> BindFiles { get; set; }

        /// <summary>
        /// Create a new Bind using a Binder, a name string, a full path to the Binder, and a relative path to the Binder.
        /// </summary>
        /// <param name="binder">An IBinder.</param>
        /// <param name="name">The name of the Bind.</param>
        /// <param name="fullPath">A string representing the full path to the Binder.</param>
        /// <param name="relativePath">A string representing the relative path of the Binder.</param>
        public Bind(IBinder binder, string name, string fullPath, string relativePath)
        {
            Binder = binder;
            Name = name;
            FullPath = fullPath;
            RelativePath = relativePath;
            BindFiles = new List<BindFile>();
            foreach (BinderFile bFile in Binder.Files)
            {
                BindFiles.Add(new BindFile(bFile, fullPath, $"{RelativePath}\\{bFile.Name}", Name));
            }
        }

        /// <summary>
        /// Create a new Bind using a Binder, a name string, a full path to the Binder, a relative path to the Binder, and a full path to the Binder's BHD.
        /// </summary>
        /// <param name="binder">An IBinder.</param>
        /// <param name="name">The name of the Bind.</param>
        /// <param name="fullPath">A string representing the full path to the Binder.</param>
        /// <param name="relativePath">A string representing the relative path of the Binder.</param>
        /// <param name="fullBHDPath">A string representing the full path to this Bind's Binder's BHD.</param>
        public Bind(IBinder binder, string name, string fullPath, string relativePath, string fullBHDPath)
        {
            Binder = binder;
            Name = name;
            FullPath = fullPath;
            RelativePath = relativePath;
            FullBHDPath = fullBHDPath;
            BindFiles = new List<BindFile>();
            foreach (BinderFile bFile in Binder.Files)
            {
                BindFiles.Add(new BindFile(bFile, fullPath, $"{RelativePath}\\{bFile.Name}", Name));
            }
        }

        /// <summary>
        /// Write this Bind to its specified full path and its specified full BHD path if applicable.
        /// </summary>
        /// <param name="bind"></param>
        public static void Write(Bind bind)
        {
            IBinder binder = bind.Binder;

            if (bind.FullPath == null) return;
            else if (binder is BND3 bnd3) bnd3.Write(bind.FullPath);
            else if (binder is BND4 bnd4) bnd4.Write(bind.FullPath);
            else if (bind.FullBHDPath == null) return;
            else if (binder is BXF3 bxf3) bxf3.Write(bind.FullBHDPath, bind.FullPath);
            else if (binder is BXF4 bxf4) bxf4.Write(bind.FullBHDPath, bind.FullPath);
        }

        /// <summary>
        /// Checks if a file is a Binder.
        /// </summary>
        /// <param name="bytes">An array of bytes representing a Binder.</param>
        /// <returns>Whether or not a file is a Binder.</returns>
        public static bool IsBinder(byte[] bytes)
        {
            if (BND3.Is(bytes)) return true;
            else if (BND4.Is(bytes)) return true;
            return false;
        }

        /// <summary>
        /// Checks if a file is a Binder.
        /// </summary>
        /// <param name="path">A string representing the path to a Binder.</param>
        /// <returns>Whether or not a file is a Binder.</returns>
        public static bool IsBinder(string path)
        {
            return IsBinder(File.ReadAllBytes(path));
        }

        /// <summary>
        /// Checks if a file is a Binder.
        /// </summary>
        /// <param name="binder">A BinderFile representing a Binder.</param>
        /// <returns>Whether or not a file is a Binder.</returns>
        public static bool IsBinder(BinderFile binder)
        {
            return IsBinder(binder.Bytes);
        }

        /// <summary>
        /// Checks if a file is a Binder.
        /// </summary>
        /// <param name="binder">A BindFile representing a Binder.</param>
        /// <returns>Whether or not a file is a Binder.</returns>
        public static bool IsBinder(BindFile binder)
        {
            return IsBinder(binder.Bytes);
        }

        /// <summary>
        /// Checks if a file is a Binder BHD.
        /// </summary>
        /// <param name="bytes">An array of bytes representing a Binder BHD.</param>
        /// <returns>Whether or not a file is a Binder BHD.</returns>
        public static bool IsBinderBHD(byte[] bytes)
        {
            if (BXF3.IsBHD(bytes)) return true;
            else if (BXF4.IsBHD(bytes)) return true;
            else if (BHD5.IsBHD(bytes)) return true;
            return false;
        }

        /// <summary>
        /// Checks if a file is a Binder BHD.
        /// </summary>
        /// <param name="bhdPath">A string representing the path to a Binder BHD.</param>
        /// <returns>Whether or not a file is a Binder BHD.</returns>
        public static bool IsBinderBHD(string bhdPath)
        {
            return IsBinderBHD(File.ReadAllBytes(bhdPath));
        }

        /// <summary>
        /// Checks if a file is a Binder BHD.
        /// </summary>
        /// <param name="bhd">A BinderFile representing a Binder BHD.</param>
        /// <returns>Whether or not a file is a Binder BHD.</returns>
        public static bool IsBinderBHD(BinderFile bhd)
        {
            return IsBinderBHD(bhd.Bytes);
        }

        /// <summary>
        /// Checks if a file is a Binder BHD.
        /// </summary>
        /// <param name="bhd">A BindFile representing a Binder BHD.</param>
        /// <returns>Whether or not a file is a Binder BHD.</returns>
        public static bool IsBinderBHD(BindFile bhd)
        {
            return IsBinderBHD(bhd.Bytes);
        }

        /// <summary>
        /// Checks if a file is a Binder.
        /// </summary>
        /// <param name="bytes">An array of bytes representing a Binder BDT.</param>
        /// <returns>Whether or not a file is a Binder BDT.</returns>
        public static bool IsBinderBDT(byte[] bytes)
        {
            if (BXF3.IsBDT(bytes)) return true;
            else if (BXF4.IsBDT(bytes)) return true;
            else if (BHD5.IsBDT(bytes)) return true;
            return false;
        }

        /// <summary>
        /// Checks if a file is a Binder BDT.
        /// </summary>
        /// <param name="bdtPath">A string representing the path to a Binder BDT.</param>
        /// <returns>Whether or not a file is a Binder BDT.</returns>
        public static bool IsBinderBDT(string bdtPath)
        {
            return IsBinderBDT(File.ReadAllBytes(bdtPath));
        }

        /// <summary>
        /// Checks if a file is a Binder BDT.
        /// </summary>
        /// <param name="bdt">A BinderFile representing a Binder BDT.</param>
        /// <returns>Whether or not a file is a Binder BDT.</returns>
        public static bool IsBinderBDT(BinderFile bdt)
        {
            return IsBinderBDT(bdt.Bytes);
        }

        /// <summary>
        /// Checks if a file is a Binder BDT.
        /// </summary>
        /// <param name="bdt">A BindFile representing a Binder BDT.</param>
        /// <returns>Whether or not a file is a Binder BDT.</returns>
        public static bool IsBinderBDT(BindFile bdt)
        {
            return IsBinderBDT(bdt.Bytes);
        }

        /// <summary>
        /// Reads a Binder file from an array of bytes.
        /// </summary>
        /// <param name="bytes">An array of bytes representing a Binder.</param>
        /// <returns>An IBinder.</returns>
        public static IBinder ReadBinder(byte[] bytes)
        {
            if (BND3.Is(bytes)) return BND3.Read(bytes);
            else if (BND4.Is(bytes)) return BND4.Read(bytes);
            return null;
        }

        /// <summary>
        /// Reads a Binder file from a string representing its path.
        /// </summary>
        /// <param name="path">A string representing the path to a Binder.</param>
        /// <returns>An IBinder.</returns>
        public static IBinder ReadBinder(string path)
        {
            return ReadBinder(File.ReadAllBytes(path));
        }

        /// <summary>
        /// Reads a Binder file from a BinderFile.
        /// </summary>
        /// <param name="binder">A BinderFile representing a Binder.</param>
        /// <returns>An IBinder.</returns>
        public static IBinder ReadBinder(BinderFile binder)
        {
            return ReadBinder(binder.Bytes);
        }

        /// <summary>
        /// Reads a Binder file from a BindFile.
        /// </summary>
        /// <param name="binder">A BindFile representing a Binder.</param>
        /// <returns>An IBinder.</returns>
        public static IBinder ReadBinder(BindFile binder)
        {
            return ReadBinder(binder.Bytes);
        }

        /// <summary>
        /// Reads a Binder file using its BHD file from an array of bytes.
        /// </summary>
        /// <param name="bdtBytes">An array of bytes representing a Binder's BDT.</param>
        /// <param name="bhdBytes">An array of bytes representing the Binder's BHD.</param>
        /// <returns>An IBinder.</returns>
        public static IBinder ReadBinder(byte[] bdtBytes, byte[] bhdBytes)
        {
            if (BXF3.IsBDT(bdtBytes) && BXF3.IsBHD(bhdBytes)) return BXF3.Read(bhdBytes, bdtBytes);
            else if (BXF4.IsBDT(bdtBytes) && BXF4.IsBHD(bhdBytes)) return BXF4.Read(bhdBytes, bdtBytes);
            return null;
        }

        /// <summary>
        /// Reads a Binder BDT file using its BHD file from strings representing the paths of each.
        /// </summary>
        /// <param name="bdtPath">A string representing the path to a Binder's BDT file.</param>
        /// <param name="bhdPath">A string representing the path to the Binder's BHD file.</param>
        /// <returns>An IBinder.</returns>
        public static IBinder ReadBinder(string bdtPath, string bhdPath)
        {
            return ReadBinder(File.ReadAllBytes(bdtPath), File.ReadAllBytes(bhdPath));
        }

        /// <summary>
        /// Reads a Binder BDT file using its BHD from BinderFiles representing each.
        /// </summary>
        /// <param name="bdt">A BinderFile representing a Binder's BDT.</param>
        /// <param name="bhd">A BinderFile representing the Binder's BHD.</param>
        /// <returns>An IBinder.</returns>
        public static IBinder ReadBinder(BinderFile bdt, BinderFile bhd)
        {
            return ReadBinder(bdt.Bytes, bhd.Bytes);
        }

        /// <summary>
        /// Reads a Binder BDT file using its BHD from BindFiles representing each.
        /// </summary>
        /// <param name="bdt">A BindFile representing a Binder's BDT.</param>
        /// <param name="bhd">A BindFile representing the Binder's BHD.</param>
        /// <returns>An IBinder.</returns>
        public static IBinder ReadBinder(BindFile bdt, BindFile bhd)
        {
            return ReadBinder(bdt.Bytes, bhd.Bytes);
        }

        /// <summary>
        /// Uses recursion to read through Binder files and return each file inside of them.
        /// </summary>
        /// <param name="binder">A Binder file.</param>
        /// <returns>A list of BinderFiles.</returns>
        public static List<BinderFile> RetrieveBinderFiles(IBinder binder)
        {
            List<BinderFile> bFiles = new();

            foreach (BinderFile bFile in binder.Files)
            {
                if (IsBinder(bFile.Bytes))
                    bFiles.AddRange(RetrieveBinderFiles(ReadBinder(bFile.Bytes)));
                else
                    bFiles.Add(bFile);
            }

            return bFiles;
        }

        /// <summary>
        /// Uses recursion to read through Binder files and return each file inside of them.
        /// </summary>
        /// <param name="binderPath">A string representing a path to a Binder file.</param>
        /// <returns>A list of BinderFiles.</returns>
        public static List<BinderFile> RetrieveBinderFiles(string binderPath)
        {
            return RetrieveBinderFiles(ReadBinder(File.ReadAllBytes(binderPath)));
        }

        /// <summary>
        /// Uses recursion to read through Binder files and return each file inside of them.
        /// </summary>
        /// <param name="binder">A byte array representing a Binder file.</param>
        /// <returns>A list of BinderFiles.</returns>
        public static List<BinderFile> RetrieveBinderFiles(byte[] binder)
        {
            return RetrieveBinderFiles(ReadBinder(binder));
        }

        /// <summary>
        /// Uses recursion to read through Binder files and return each file inside of them.
        /// </summary>
        /// <param name="binder">A BinderFile representing a Binder file.</param>
        /// <returns>A list of BinderFiles.</returns>
        public static List<BinderFile> RetrieveBinderFiles(BinderFile binder)
        {
            return RetrieveBinderFiles(ReadBinder(binder.Bytes));
        }

        /// <summary>
        /// Uses recursion to read through Binder files and return each file inside of them.
        /// </summary>
        /// <param name="binder">A BindFile representing a Binder file.</param>
        /// <returns>A list of BinderFiles.</returns>
        public static List<BinderFile> RetrieveBinderFiles(BindFile binder)
        {
            return RetrieveBinderFiles(ReadBinder(binder.Bytes));
        }

        /// <summary>
        /// Uses recursion to read through Bind files and return each BindFile inside of them.
        /// </summary>
        /// <param name="bind">A Bind file.</param>
        /// <returns>A list of BindFiles.</returns>
        public static List<BindFile> RetrieveBindFiles(Bind bind)
        {
            List<BindFile> bindFiles = new();

            foreach (BindFile bindFile in bind.BindFiles)
            {
                if (IsBinder(bindFile.Bytes))
                    bindFiles.AddRange(RetrieveBindFiles(new Bind(ReadBinder(bindFile), bindFile.Name, bindFile.FullPath, bindFile.RelativePath)));
                else
                    bindFiles.Add(bindFile);
            }

            return bindFiles;
        }

        /// <summary>
        /// Uses recursion to read through Binder files and return each file inside of them as a BindFile.
        /// </summary>
        /// <param name="binderPath">A string representing the path to a Binder file.</param>
        /// <returns>A list of BindFiles.</returns>
        public static List<BindFile> RetrieveBindFiles(string binderPath)
        {
            return RetrieveBindFiles(new Bind(ReadBinder(binderPath), Path.GetFileName(binderPath), binderPath, Path.GetFileName(binderPath)));
        }

        /// <summary>
        /// Uses recursion to read through Binder files and return each file inside of them as a BindFile.
        /// </summary>
        /// <param name="binder">A byte array representing a Binder file.</param>
        /// <param name="name">The name of the Binder file.</param>
        /// <param name="fullPath">A string representing a full path to the Binder file.</param>
        /// <param name="relativePath">A string representing the relative path to the Binder file.</param>
        /// <returns>A list of BindFiles.</returns>
        public static List<BindFile> RetrieveBindFiles(byte[] binder, string name, string fullPath, string relativePath)
        {
            return RetrieveBindFiles(new Bind(ReadBinder(binder), name, fullPath, relativePath));
        }

        /// <summary>
        /// Uses recursion to read through Binder files and return each file inside of them as a BindFile.
        /// </summary>
        /// <param name="binderFile">A BinderFile representing a Binder file.</param>
        /// <param name="name">The name of the Binder file.</param>
        /// <param name="fullPath">A string representing a full path to the Binder file.</param>
        /// <param name="relativePath">A string representing the relative path to the Binder file.</param>
        /// <returns>A list of BindFiles.</returns>
        public static List<BindFile> RetrieveBindFiles(BinderFile binderFile, string name, string fullPath, string relativePath)
        {
            return RetrieveBindFiles(new Bind(ReadBinder(binderFile), name, fullPath, relativePath));
        }

        /// <summary>
        /// Uses recursion to read through Binder files and return each file inside of them as a BindFile.
        /// </summary>
        /// <param name="bindFile">A BindFile representing a Binder file.</param>
        /// <returns>A list of BindFiles.</returns>
        public static List<BindFile> RetrieveBindFiles(BindFile bindFile)
        {
            return RetrieveBindFiles(new Bind(ReadBinder(bindFile), bindFile.Name, bindFile.FullPath, bindFile.RelativePath));
        }

        /// <summary>
        /// Returns this Bind's IBinder.
        /// </summary>
        /// <returns>An IBinder.</returns>
        public IBinder ToBinder()
        {
            return Binder;
        }

        /// <summary>
        /// Overrides ToString and returns the relative path to this Bind's Binder.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return RelativePath;
        }

        /// <summary>
        /// Wraps a BinderFile with additional information.
        /// </summary>
        public class BindFile : BinderFile
        {
            /// <summary>
            /// The full file path to this BindFile's root parent Bind or Binder.
            /// </summary>
            public string FullPath { get; set; }

            /// <summary>
            /// The relative file path of this BindFile inside of its Bind including parent Binds of its Bind.
            /// </summary>
            public string RelativePath { get; set; }

            /// <summary>
            /// The name of the parent Bind or IBinder of this BindFile.
            /// </summary>
            public string ParentName { get; set; }

            /// <summary>
            /// Create a new BindFile using a full path to the root Binder containing the BindFile and any nested Binders it is inside, and a path relative to the BinderFile's parent Binder and that Binder's parent Binders.
            /// </summary>
            /// <param name="fullPath"></param>
            /// <param name="relativePath"></param>
            public BindFile(string fullPath, string relativePath, string parentName) : base()
            {
                FullPath = fullPath;
                RelativePath = relativePath;
                ParentName = parentName;
            }

            /// <summary>
            /// Create a new BindFile using a BinderFile, full path to the root Binder containing the BinderFile and any nested Binders it is inside, and a path relative to the BinderFile's parent Binder and that Binder's parent Binders.
            /// </summary>
            /// <param name="bFile">A BinderFile.</param>
            /// <param name="fullPath"></param>
            /// <param name="relativePath"></param>
            public BindFile(BinderFile bFile, string fullPath, string relativePath, string parentName)
            {
                Flags = bFile.Flags;
                ID = bFile.ID;
                Name = bFile.Name;
                Bytes = bFile.Bytes;
                CompressionType = DCX.Type.Zlib;
                FullPath = fullPath;
                RelativePath = relativePath;
                ParentName = parentName;
            }

            /// <summary>
            /// Create a new BindFile only using a BinderFile and set the paths later.
            /// </summary>
            /// <param name="bFile">A BinderFile.</param>
            public BindFile(BinderFile bFile)
            {
                Flags = bFile.Flags;
                ID = bFile.ID;
                Name = bFile.Name;
                Bytes = bFile.Bytes;
                CompressionType = DCX.Type.Zlib;
            }

            /// <summary>
            /// Strips this BindFile of its additional path information and returns a BinderFile.
            /// </summary>
            /// <returns>A BinderFile.</returns>
            public BinderFile ToBinderFile()
            {
                return new BinderFile(Flags, ID, Name, Bytes);
            }

            /// <summary>
            /// Reads this BindFile as an IBinder.
            /// </summary>
            /// <returns>An IBinder.</returns>
            public IBinder ToBinder()
            {
                return ReadBinder(this);
            }

            /// <summary>
            /// Reads this BindFile as a Bind.
            /// </summary>
            /// <returns>A Bind.</returns>
            public Bind ToBind()
            {
                return new Bind(ReadBinder(this), Name, FullPath, RelativePath);
            }

            /// <summary>
            /// Overrides ToString and returns the relative path to this BindFile's BinderFile.
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return RelativePath;
            }
        }
    }
}
