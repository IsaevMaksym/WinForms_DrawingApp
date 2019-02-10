using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Drawing_App
{
    interface IFigure
    {
        void PenChanged(Pen p);

        void BrushChanged(SolidBrush s);

        void BtnPressed(MouseEventArgs e);

        Bitmap Draw(Bitmap bitmap);       
         
        void BtnUnpressed(MouseEventArgs e);

        void MouseMove(MouseEventArgs e);
    }
}
