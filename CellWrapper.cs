using SoulsFormats;

namespace ACFAParamEditor
{
    internal class CellWrapper
    {
        internal PARAM.Cell Cell { get; init; }
        public override string ToString() => Cell.Def.DisplayName;
    }
}
