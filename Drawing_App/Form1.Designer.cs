namespace Drawing_App
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pgsBar = new System.Windows.Forms.ProgressBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gBx_ProgressBar = new System.Windows.Forms.GroupBox();
            this.lbl_progressBar = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_FreeDraw = new System.Windows.Forms.Button();
            this.btn_Line = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.btn_LineColor = new System.Windows.Forms.Button();
            this.btn_BgColor = new System.Windows.Forms.Button();
            this.btn_RestoreDefaultColor = new System.Windows.Forms.Button();
            this.CD_LineColor = new System.Windows.Forms.ColorDialog();
            this.CD_FillColor = new System.Windows.Forms.ColorDialog();
            this.btn_Invert = new System.Windows.Forms.Button();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.gBx_ProgressBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Paint 1";
            this.saveFileDialog.Filter = "Image Files (*.BMP;*.JPG;*.GIF;*.PNG) | *.BMP;*.JPG;*.GIF;*.PNG";
            // 
            // pgsBar
            // 
            this.pgsBar.Location = new System.Drawing.Point(0, 27);
            this.pgsBar.Name = "pgsBar";
            this.pgsBar.Size = new System.Drawing.Size(204, 19);
            this.pgsBar.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // gBx_ProgressBar
            // 
            this.gBx_ProgressBar.Controls.Add(this.lbl_progressBar);
            this.gBx_ProgressBar.Controls.Add(this.pgsBar);
            this.gBx_ProgressBar.Font = new System.Drawing.Font("Jokerman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBx_ProgressBar.Location = new System.Drawing.Point(1020, 25);
            this.gBx_ProgressBar.Name = "gBx_ProgressBar";
            this.gBx_ProgressBar.Size = new System.Drawing.Size(246, 52);
            this.gBx_ProgressBar.TabIndex = 0;
            this.gBx_ProgressBar.TabStop = false;
            this.gBx_ProgressBar.Text = "Progress Bar";
            // 
            // lbl_progressBar
            // 
            this.lbl_progressBar.AutoSize = true;
            this.lbl_progressBar.Location = new System.Drawing.Point(210, 29);
            this.lbl_progressBar.Name = "lbl_progressBar";
            this.lbl_progressBar.Size = new System.Drawing.Size(0, 20);
            this.lbl_progressBar.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1278, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_OpenFile,
            this.Menu_SaveFile});
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.saveImageToolStripMenuItem.Text = "File";
            // 
            // Menu_OpenFile
            // 
            this.Menu_OpenFile.Name = "Menu_OpenFile";
            this.Menu_OpenFile.Size = new System.Drawing.Size(122, 22);
            this.Menu_OpenFile.Text = "Open file";
            this.Menu_OpenFile.Click += new System.EventHandler(this.Menu_OpenFile_Click);
            // 
            // Menu_SaveFile
            // 
            this.Menu_SaveFile.Name = "Menu_SaveFile";
            this.Menu_SaveFile.Size = new System.Drawing.Size(122, 22);
            this.Menu_SaveFile.Text = "Save file";
            this.Menu_SaveFile.Click += new System.EventHandler(this.Menu_SaveFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(7, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1263, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // btn_FreeDraw
            // 
            this.btn_FreeDraw.Font = new System.Drawing.Font("Jokerman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FreeDraw.Location = new System.Drawing.Point(7, 27);
            this.btn_FreeDraw.Name = "btn_FreeDraw";
            this.btn_FreeDraw.Size = new System.Drawing.Size(100, 50);
            this.btn_FreeDraw.TabIndex = 10;
            this.btn_FreeDraw.Text = "Free Line";
            this.btn_FreeDraw.UseMnemonic = false;
            this.btn_FreeDraw.UseVisualStyleBackColor = true;
            this.btn_FreeDraw.Click += new System.EventHandler(this.btn_FreeDraw_Click);
            // 
            // btn_Line
            // 
            this.btn_Line.Font = new System.Drawing.Font("Jokerman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Line.Location = new System.Drawing.Point(113, 27);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(100, 50);
            this.btn_Line.TabIndex = 11;
            this.btn_Line.Text = "Line";
            this.btn_Line.UseMnemonic = false;
            this.btn_Line.UseVisualStyleBackColor = true;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.Font = new System.Drawing.Font("Jokerman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Circle.Location = new System.Drawing.Point(219, 27);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(100, 50);
            this.btn_Circle.TabIndex = 12;
            this.btn_Circle.Text = "Ellipse";
            this.btn_Circle.UseMnemonic = false;
            this.btn_Circle.UseVisualStyleBackColor = true;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.Font = new System.Drawing.Font("Jokerman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rectangle.Location = new System.Drawing.Point(325, 27);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(100, 50);
            this.btn_Rectangle.TabIndex = 13;
            this.btn_Rectangle.Text = "Rectangle";
            this.btn_Rectangle.UseMnemonic = false;
            this.btn_Rectangle.UseVisualStyleBackColor = true;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // btn_LineColor
            // 
            this.btn_LineColor.Font = new System.Drawing.Font("Jokerman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LineColor.Location = new System.Drawing.Point(431, 27);
            this.btn_LineColor.Name = "btn_LineColor";
            this.btn_LineColor.Size = new System.Drawing.Size(100, 50);
            this.btn_LineColor.TabIndex = 15;
            this.btn_LineColor.Text = "Line Color";
            this.btn_LineColor.UseVisualStyleBackColor = true;
            this.btn_LineColor.Click += new System.EventHandler(this.btn_LineColor_Click);
            // 
            // btn_BgColor
            // 
            this.btn_BgColor.Font = new System.Drawing.Font("Jokerman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BgColor.Location = new System.Drawing.Point(537, 27);
            this.btn_BgColor.Name = "btn_BgColor";
            this.btn_BgColor.Size = new System.Drawing.Size(100, 50);
            this.btn_BgColor.TabIndex = 16;
            this.btn_BgColor.Text = "Fill Color";
            this.btn_BgColor.UseMnemonic = false;
            this.btn_BgColor.UseVisualStyleBackColor = true;
            this.btn_BgColor.Click += new System.EventHandler(this.btn_FillColor_Click);
            // 
            // btn_RestoreDefaultColor
            // 
            this.btn_RestoreDefaultColor.Font = new System.Drawing.Font("Jokerman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RestoreDefaultColor.Location = new System.Drawing.Point(643, 27);
            this.btn_RestoreDefaultColor.Name = "btn_RestoreDefaultColor";
            this.btn_RestoreDefaultColor.Size = new System.Drawing.Size(111, 50);
            this.btn_RestoreDefaultColor.TabIndex = 17;
            this.btn_RestoreDefaultColor.Text = "Restore Default Colors";
            this.btn_RestoreDefaultColor.UseVisualStyleBackColor = true;
            this.btn_RestoreDefaultColor.Click += new System.EventHandler(this.btn_RestoreDefaultColor_Click);
            // 
            // CD_FillColor
            // 
            this.CD_FillColor.FullOpen = true;
            // 
            // btn_Invert
            // 
            this.btn_Invert.Font = new System.Drawing.Font("Jokerman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Invert.Location = new System.Drawing.Point(905, 27);
            this.btn_Invert.Name = "btn_Invert";
            this.btn_Invert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Invert.Size = new System.Drawing.Size(100, 50);
            this.btn_Invert.TabIndex = 18;
            this.btn_Invert.Text = "Invert Colors";
            this.btn_Invert.UseVisualStyleBackColor = true;
            this.btn_Invert.Click += new System.EventHandler(this.btn_Invert_Click);
            // 
            // Main_Form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1278, 620);
            this.Controls.Add(this.btn_Rectangle);
            this.Controls.Add(this.btn_Circle);
            this.Controls.Add(this.btn_Line);
            this.Controls.Add(this.btn_FreeDraw);
            this.Controls.Add(this.gBx_ProgressBar);
            this.Controls.Add(this.btn_Invert);
            this.Controls.Add(this.btn_RestoreDefaultColor);
            this.Controls.Add(this.btn_BgColor);
            this.Controls.Add(this.btn_LineColor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Max\'s Paint";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.gBx_ProgressBar.ResumeLayout(false);
            this.gBx_ProgressBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ProgressBar pgsBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox gBx_ProgressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem Menu_SaveFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_FreeDraw;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Button btn_LineColor;
        private System.Windows.Forms.Button btn_BgColor;
        private System.Windows.Forms.Button btn_RestoreDefaultColor;
        private System.Windows.Forms.ColorDialog CD_LineColor;
        private System.Windows.Forms.ColorDialog CD_FillColor;
        private System.Windows.Forms.Button btn_Invert;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label lbl_progressBar;
    }
}

