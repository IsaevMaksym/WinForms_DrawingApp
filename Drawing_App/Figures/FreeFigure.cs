using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Drawing_App
{
    class FreeFigure : Figure, IFigure
    {
        public FreeFigure(Pen pen)
            : base(pen)
        { }

        #region IFigure

        void IFigure.BtnPressed(MouseEventArgs e)
        {
            _isPressed = true;
            _prevPoint = e.Location;
            _currentPoint = e.Location;
            _points.Add(_prevPoint);
        }

        public void MouseMove(MouseEventArgs e)
        {            
            if (_isPressed)
            {
                _prevPoint = _currentPoint;
                _currentPoint = e.Location;
                _points.Add(_currentPoint);
            }
        }

        void IFigure.BtnUnpressed(MouseEventArgs e)
        {
            _currentPoint = e.Location;
            _isPressed = false;           
        }

        public Bitmap Draw(Bitmap bmp)
        {
            using (Graphics gr = Graphics.FromImage(bmp))
            {
                if (_points.Count>=2)
                {
                    gr.DrawLines(_pen, _points.ToArray());
                }                
                return bmp;
            }
        }

        void IFigure.PenChanged(Pen pen)
        {
            base.SetPen(pen);
        }

        void IFigure.BrushChanged(SolidBrush brush)
        {
            base.SetSolidBrush(brush);
        }

        List<Point> _points = new List<Point>();
       
        #endregion
    }
}
