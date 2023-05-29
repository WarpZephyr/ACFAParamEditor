using System.Drawing;
using System.Windows.Forms;

namespace ACFAParamEditor
{
    internal class OverrideToolStripRenderer : ToolStripProfessionalRenderer
    {
        public OverrideToolStripRenderer() : base(new OverrideMenuStripSelectedColorTable()) {}
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            if (e.Item is ToolStripMenuItem tsMenuItem) e.ArrowColor = Color.White;
            base.OnRenderArrow(e);
        }
        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
        {
            
            base.OnRenderItemCheck(e);
        }
    }
}
