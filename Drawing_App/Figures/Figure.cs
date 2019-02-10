using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_App
{
    abstract class Figure
    {
        public Figure()
        {

        }

        public Figure(Pen pen, SolidBrush brush) : this(pen)
        {
            _solidBrush = brush;
        }

        public Figure(Pen pen) 
        {
            _pen = pen;                              
                       
        }

        protected virtual void SetCurrentPoint(MouseEventArgs e)
        {
            _currentPoint = e.Location;
        }

        protected virtual void SetPen(Pen pen)
        {
            _pen = pen;
        }

        protected virtual void SetSolidBrush(SolidBrush brush)
        {
            _solidBrush = brush;
        }

                
        #region Veriables

        protected bool _isPressed = false;        
        protected Point _currentPoint;
        protected Point _prevPoint;
        protected Pen _pen;
        protected SolidBrush _solidBrush;

        #endregion

    }
}
