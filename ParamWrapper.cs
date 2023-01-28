using SoulsFormats;

namespace ACFAParamEditor
{
    internal class ParamWrapper
    {
        internal string ParamName { get; init; }
        internal PARAM Param { get; init; }
        public override string ToString() => ParamName;
    }
}
