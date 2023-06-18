using SoulsFormats;

namespace ACFAParamEditor
{
    internal class CellWrapper
    {
        internal PARAM.Cell Cell { get; init; }
        public override string ToString()
        {
            if (Cell.Def.InternalName != null)
                return Cell.Def.InternalName;
            else
                return Cell.Def.DisplayName;
        }
    }
}
