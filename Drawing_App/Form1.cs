using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Drawing_App
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            _bitMap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            _graphic = Graphics.FromImage(_bitMap);

            _pen = new Pen(Color.Black, 10);

            _solidBrush = new SolidBrush(Color.Transparent);

            figure = new FreeFigure(_pen);

        }

        #region Menu Click Events

        private void Menu_NewFile_Click(object sender, EventArgs e)
        {

        }

        private void Menu_OpenFile_Click(object sender, EventArgs e)
        {
            using (openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)| *.BMP;*.JPG;*.GIF;*.PNG|All files(*.*)|*.*";
                openFileDialog.FileName = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                        _bitMap = new Bitmap(openFileDialog.FileName);
                        ResizeForm();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Невозможно открыть файл", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        }
        private void ResizeForm()
        {
            if (_bitMap.Height + 20 < 1080)
            {
                this.Height = _bitMap.Height + 20;
            }
            if (_bitMap.Width + 20 < 1980)
            {
                this.Width = _bitMap.Width + 20;
            }
            else
            {
                this.Height = 1920;
                this.Width = 1080;
            }

            pictureBox1.Width = _bitMap.Width;
            pictureBox1.Height = _bitMap.Height;

        }
        private void Menu_SaveFile_Click(object sender, EventArgs e)                
        {
            using (saveFileDialog = new SaveFileDialog())
            {
                DialogResult DR_SavingPath = saveFileDialog.ShowDialog();

                saveFileDialog.DefaultExt = "bmp";

                saveFileDialog.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
               
                if (DR_SavingPath == System.Windows.Forms.DialogResult.OK)
                {
                    _bitMap.Save(saveFileDialog.FileName + ".bmp");
                }
            }
        }
        #endregion

        #region Actions Click Events


        private void btn_FreeDraw_Click(object sender, EventArgs e)
        {
            figure = new FreeFigure(_pen);
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            figure = new Line(_pen);
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            figure = new Ellipse(_pen, _solidBrush);
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            figure = new MyRectangle(_pen, _solidBrush);

        }

        private void btn_Invert_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(StartInversion);
            if (!thread.IsAlive)
            {
                thread.IsBackground = true;
                thread.Start();
            }


        }

        void StartInversion()
        {
            Bitmap oldBitmap = (Bitmap)_bitMap.Clone();

            for (int w = 0; w < oldBitmap.Width; w++)
            {
                for (int h = 0; h < oldBitmap.Height; h++)
                {
                    Color prevColor = oldBitmap.GetPixel(w, h);
                    Color newColor = Color.FromArgb(255 - prevColor.R, 255 - prevColor.G, 255 - prevColor.B);
                    oldBitmap.SetPixel(w, h, newColor);

                    
                   
                }
                int progress = (w *  100) / (oldBitmap.Width * oldBitmap.Height);
                ChangeProgresBar(progress);
            }
            pictureBox1.Image = oldBitmap;
            _bitMap = oldBitmap;
        }
        
        private void ChangeProgresBar(int i)
        {
           
            Invoke(new Action(() => pgsBar.Value = i));

        }

        #endregion
        
        #region Colors Click Events

        private void btn_LineColor_Click(object sender, EventArgs e)
        {

            DialogResult DR_LineColor = CD_FillColor.ShowDialog();

            if (DR_LineColor == System.Windows.Forms.DialogResult.OK)
            {
                _pen.Color = CD_FillColor.Color;
                figure.PenChanged(_pen);
            }


        }

        private void btn_FillColor_Click(object sender, EventArgs e)
        {
            DialogResult DR_BGColor = CD_FillColor.ShowDialog();

            if (DR_BGColor == System.Windows.Forms.DialogResult.OK)
            {
                _solidBrush.Color = CD_FillColor.Color;
                figure.BrushChanged(_solidBrush);

            }
        }

        private void btn_RestoreDefaultColor_Click(object sender, EventArgs e)
        {
            _pen.Color = Color.Black;
            _pen.Width = 10;
            _solidBrush.Color = Color.Transparent;
            figure.PenChanged(new Pen(Color.Black, 10));
            figure.BrushChanged(new SolidBrush(Color.Transparent));
        }
        #endregion

        #region PictureBox Handler


        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isPresed)
            {
                figure.BtnUnpressed(e);

                _isPresed = false;

                _bitMap = figure.Draw((Bitmap)_bitMap.Clone()); ;

                history.Add((Bitmap)_bitMap.Clone());

                
            }

        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _isPresed = true;

            if (figure != null)
            {
                figure.BtnPressed(e);
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isPresed)
            {
                pictureBox1.Image = figure.Draw((Bitmap)_bitMap.Clone());

                figure.MouseMove(e);
            }
            else
            {
                pictureBox1.Image = _bitMap;
            }

        }

        #endregion

        #region Variables

        Pen _pen;
        SolidBrush _solidBrush;
        IFigure figure;
        bool _isPresed;
        List<Bitmap> history = new List<Bitmap>();
        Graphics _graphic;
        Bitmap _bitMap;

        #endregion

    }

}


