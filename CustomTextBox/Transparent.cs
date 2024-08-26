using System.Windows.Forms;
using System.Drawing;

namespace CustomTextBox
{
    internal class Transparent
    {
        public static void textBoxTransparent(Control control, Graphics myGr)
        {
            Control parent = control.Parent;
            if(parent != null)
            {
                Rectangle rectangle = control.Bounds;
                Control.ControlCollection controls = parent.Controls;
                int index = controls.IndexOf(control);
                Bitmap bitmap = null;
                for(int i = controls.Count - 1; i > index; i--)
                {
                    Control myControl = controls[i];
                    if (myControl.Bounds.IntersectsWith(rectangle))
                    {
                        if(bitmap == null)
                        {
                            bitmap = new Bitmap(control.Parent.ClientSize.Width, control.Parent.ClientSize.Height);
                        }
                        myControl.DrawToBitmap(bitmap, myControl.Bounds);
                    }
                }
                if(bitmap != null)
                {
                    myGr.DrawImage((Image)bitmap, control.ClientRectangle, rectangle, (GraphicsUnit)GraphicsUnit.Pixel);
                    bitmap.Dispose();
                }
            }
        }
    }
}
