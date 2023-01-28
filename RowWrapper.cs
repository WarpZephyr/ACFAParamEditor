using SoulsFormats;

namespace ACFAParamEditor
{
    internal class RowWrapper
    {
        internal string RowName { get; init; }
        internal PARAM.Row Row { get; init; }
        public override string ToString() => RowName;
    }
}
