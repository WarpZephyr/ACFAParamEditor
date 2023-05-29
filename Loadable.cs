using SoulsFormats;

namespace ACFAParamEditor
{
    public class Loadable<T> where T : SoulsFile<T>, new()
    {
        public string Name { get; set; }
        public string FullPath { get; set; }
        public string RelativePath { get; set; }
        public T Object { get; set; }
    }
}
