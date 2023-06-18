using SoulsFormats;

namespace ACFAParamEditor
{
    internal class RowWrapper
    {
        internal PARAM.Row Row { get; init; }
        public override string ToString() => Row.Name ?? "";
    }
}
