using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Drawing_App
{
    class Ellipse : Figure, IFigure
    {
        public Ellipse(Pen pen)
            : base(pen)
        { }

        public Ellipse(Pen pen, SolidBrush brush)
          : base(pen, brush)
        { }

        void IFigure.BtnPressed(System.Windows.Forms.MouseEventArgs e)
        {
            _prevPoint = e.Location;

            _currentPoint = e.Location;

            _isPressed = true;
        }

        public void MouseMove(MouseEventArgs e)
        {
            if (_isPressed)
            {
                _currentPoint = e.Location;
            }
        }

        void IFigure.BtnUnpressed(System.Windows.Forms.MouseEventArgs e)
        {
            _currentPoint = e.Location;
            _isPressed = false;           
        }

        Bitmap IFigure.Draw(Bitmap bmp)
        {
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.DrawEllipse(_pen, GetRectangle());

                gr.FillEllipse(_solidBrush, GetRectangle());

                return bmp;
            }

        }

        void IFigure.PenChanged(Pen p)
        {
            base.SetPen(p);
        }

        void IFigure.BrushChanged(SolidBrush s)
        {
            base.SetSolidBrush(s);
        }
               
        private Rectangle GetRectangle()
        {
            return new Rectangle(CordX, CordY, Width, Heigh);

        }

        private int CordX
        {
            get
            {
                return Math.Min(_prevPoint.X, _currentPoint.X);
            }
        }
        private int CordY
        {
            get
            {
                return Math.Min(_prevPoint.Y, _currentPoint.Y);
            }

        }
        private int Width
        {
            get
            {
                return Math.Abs(_prevPoint.X - _currentPoint.X);
            }

        }
        private int Heigh
        {
            get
            {
                return Math.Abs(_prevPoint.Y - _currentPoint.Y);
            }

        }
    }
}
