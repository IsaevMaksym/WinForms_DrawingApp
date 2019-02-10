using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Drawing_App
{
    public delegate void Calback(int i);

    class Inversion : IthreadingTasks
    {
       
        public Bitmap BitmapChanger(Bitmap bmp, Calback calback)
        {
            int width;
            int height;

            for (width = 0; width < bmp.Width; width++)
            {
                for ( height = 0; height < bmp.Height; height++)
                {
                    Color prevColor = bmp.GetPixel(width, height);
                    Color newColor = Color.FromArgb(255 - prevColor.R, 255 - prevColor.G, 255 - prevColor.B);
                    bmp.SetPixel(width, height, newColor);

                    int progress = (width * height * 100) / (bmp.Width * bmp.Height);
                    calback(progress);
                }
            }

            return bmp;
        }
    }
}
