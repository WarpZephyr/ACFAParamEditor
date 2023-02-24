using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoulsFormats;

namespace ACFAParamEditor
{
    internal static class Undo
    {
        public static Action UndoRowPaste(ParamWrapper selectedParam, DataGridView RowDGV, DataGridView ParamDGV)
        {
            
            Action action = () =>
            {
                
            };

            return action;
        }

        public static Action UndoRowDelete(ParamWrapper selectedParam, DataGridView RowDGV, DataGridView ParamDGV)
        {
            CopyObject newCopyObject = new();
            List<object[]> copiedRows = newCopyObject.CopyRows(selectedParam, RowDGV);
            int selectedDGVParamRow = ParamDGV.CurrentRow.Index;

            Action action = () =>
            {
                foreach (object[] row in copiedRows)
                {
                    RowWrapper newRowWrapper = row[1] as RowWrapper;
                    selectedParam.Param.Rows.Add(newRowWrapper.Row);
                    if (ParamDGV.CurrentRow.Index == selectedDGVParamRow) { RowDGV.Rows.Add(row); }
                }
            };

            return action;
        }
    }
}
