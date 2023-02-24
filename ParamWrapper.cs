using SoulsFormats;
using System.IO;

namespace ACFAParamEditor
{
    internal class ParamWrapper
    {
        internal string ParamName { get; init; }
        internal string ParamPath { get; init; }
        internal string BNDPath { get; init; }
        internal bool IsBND { get; init; }
        internal PARAM Param { get; init; }
        public override string ToString() => ParamName;
    }
}
