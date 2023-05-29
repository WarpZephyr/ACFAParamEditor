using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ACFAParamEditor
{
    internal class OverrideTabControl : TabControl
    {
        protected override void WndProc(ref Message message)
        {
            if (message.Msg == 0x1300 + 40)
            {
                RECT rectangle = (RECT)message.GetLParam(typeof(RECT));
                rectangle.Left -= 4;
                rectangle.Right += 4;
                rectangle.Top -= 2;
                rectangle.Bottom += 4;
                Marshal.StructureToPtr(rectangle, message.LParam, true);
            }
            base.WndProc(ref message);
        }
    }

    internal struct RECT { public int Left, Top, Right, Bottom; }
}
