using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Drawing_App
{
    class MyRectangle : Figure, IFigure
    {
        #region IFigure

        public MyRectangle(Pen pen)
            : base(pen)
        { }

        public MyRectangle(Pen pen, SolidBrush brush)
          : base(pen, brush)
        { }

        void IFigure.BtnPressed(MouseEventArgs e)
        {
            _prevPoint = e.Location;

            _currentPoint = e.Location;

            _isPressed = true;

        }

        void IFigure.MouseMove(MouseEventArgs e)
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
                gr.DrawRectangle(_pen, GetRectangle());

                gr.FillRectangle(_solidBrush, GetRectangle());

                return bmp;
            }

        }
               
        void IFigure.BrushChanged(SolidBrush s)
        {
            base.SetSolidBrush(s);
        }

        void IFigure.PenChanged(Pen p)
        {
            base.SetPen(p);
        }

        #endregion

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
