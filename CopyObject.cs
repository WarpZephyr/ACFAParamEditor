using System;

namespace ACFAParamEditor
{
    internal class CopyObject
    {
        public object[] CopyRow(RowWrapper rowPasteRowWrapper, ParamWrapper rowPasteParam)
        {
            object[] newRowObject = Util.CopyRow(rowPasteParam, rowPasteRowWrapper);
            return newRowObject;
        }
    }
}
