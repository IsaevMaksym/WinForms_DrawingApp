using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_App
{
    class Line : Figure, IFigure
    {

        public Line(Pen pen) : base(pen)
        { }

        void IFigure.BtnPressed(MouseEventArgs e)
        {
            _isPressed = true;
            if (_currentPoint.IsEmpty && _prevPoint.IsEmpty)
            {
                _prevPoint = e.Location;
                _currentPoint = e.Location;
            }

            if (e.Button == MouseButtons.Right)
            {
                _prevPoint = _currentPoint;
                _currentPoint = e.Location;
            }
            if (e.Button == MouseButtons.Left)
            {
                _prevPoint = e.Location;
                _currentPoint = e.Location;
            }

        }

        public void MouseMove(MouseEventArgs e)
        {
            if (_isPressed)
            {
                _currentPoint = e.Location;
            }
        }

        public void BtnUnpressed(MouseEventArgs e)
        {
            _currentPoint = e.Location;
            _isPressed = false;
        }

        public Bitmap Draw(Bitmap bmp)
        {
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.DrawLine(_pen, _prevPoint, _currentPoint);
                return bmp;
            }
        }
       
        void IFigure.BrushChanged(SolidBrush s)
        {
            base.SetSolidBrush(s);
        }

        void IFigure.PenChanged(Pen pen)
        {
            base.SetPen(pen);
        }

    }
}
