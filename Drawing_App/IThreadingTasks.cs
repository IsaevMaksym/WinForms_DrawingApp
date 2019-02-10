using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace Drawing_App
{
    interface IthreadingTasks
    {
        
        Bitmap BitmapChanger(Bitmap bmp, Calback i);
    }
}
