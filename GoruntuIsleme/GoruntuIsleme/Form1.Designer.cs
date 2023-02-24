
namespace GoruntuIsleme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.YukleButonu = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GriButon = new System.Windows.Forms.Button();
            this.esiklemeButon = new System.Windows.Forms.Button();
            this.negatifButon = new System.Windows.Forms.Button();
            this.kontrastButonu = new System.Windows.Forms.Button();
            this.ParlatButonu = new System.Windows.Forms.Button();
            this.MeanFiltreButonu = new System.Windows.Forms.Button();
            this.MedianFiltreButonu = new System.Windows.Forms.Button();
            this.GaussFiltreButonu = new System.Windows.Forms.Button();
            this.NetlestirmeButonu = new System.Windows.Forms.Button();
            this.OtolemeButonu = new System.Windows.Forms.Button();
            this.AynalamaButonu = new System.Windows.Forms.Button();
            this.KucultmeButonu = new System.Windows.Forms.Button();
            this.ResimKaydetButonu = new System.Windows.Forms.Button();
            this.SobelFiltreButonu = new System.Windows.Forms.Button();
            this.PrewittFiltreButonu = new System.Windows.Forms.Button();
            this.LaplicanFiltreButonu = new System.Windows.Forms.Button();
            this.PerspektifButonu = new System.Windows.Forms.Button();
            this.HistogramButonu = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rgbdebYUVaButonu = new System.Windows.Forms.Button();
            this.rgbdenCMYyeButonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(438, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(387, 365);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // YukleButonu
            // 
            this.YukleButonu.BackColor = System.Drawing.Color.Lime;
            this.YukleButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YukleButonu.ForeColor = System.Drawing.Color.Red;
            this.YukleButonu.Location = new System.Drawing.Point(12, 545);
            this.YukleButonu.Name = "YukleButonu";
            this.YukleButonu.Size = new System.Drawing.Size(118, 48);
            this.YukleButonu.TabIndex = 2;
            this.YukleButonu.Text = "RESİM YÜKLE";
            this.YukleButonu.UseVisualStyleBackColor = false;
            this.YukleButonu.Click += new System.EventHandler(this.YukleButonu_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GriButon
            // 
            this.GriButon.BackColor = System.Drawing.Color.Turquoise;
            this.GriButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GriButon.Location = new System.Drawing.Point(13, 36);
            this.GriButon.Name = "GriButon";
            this.GriButon.Size = new System.Drawing.Size(125, 54);
            this.GriButon.TabIndex = 3;
            this.GriButon.Text = "Grileştirme";
            this.GriButon.UseVisualStyleBackColor = false;
            this.GriButon.Click += new System.EventHandler(this.GriButon_Click);
            // 
            // esiklemeButon
            // 
            this.esiklemeButon.BackColor = System.Drawing.Color.Turquoise;
            this.esiklemeButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esiklemeButon.Location = new System.Drawing.Point(156, 36);
            this.esiklemeButon.Name = "esiklemeButon";
            this.esiklemeButon.Size = new System.Drawing.Size(125, 54);
            this.esiklemeButon.TabIndex = 4;
            this.esiklemeButon.Text = "Eşikleme";
            this.esiklemeButon.UseVisualStyleBackColor = false;
            this.esiklemeButon.Click += new System.EventHandler(this.esiklemeButon_Click);
            // 
            // negatifButon
            // 
            this.negatifButon.BackColor = System.Drawing.Color.Turquoise;
            this.negatifButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.negatifButon.Location = new System.Drawing.Point(295, 36);
            this.negatifButon.Name = "negatifButon";
            this.negatifButon.Size = new System.Drawing.Size(125, 54);
            this.negatifButon.TabIndex = 5;
            this.negatifButon.Text = "Negatif";
            this.negatifButon.UseVisualStyleBackColor = false;
            this.negatifButon.Click += new System.EventHandler(this.negatifButon_Click);
            // 
            // kontrastButonu
            // 
            this.kontrastButonu.BackColor = System.Drawing.Color.Turquoise;
            this.kontrastButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kontrastButonu.Location = new System.Drawing.Point(435, 36);
            this.kontrastButonu.Name = "kontrastButonu";
            this.kontrastButonu.Size = new System.Drawing.Size(125, 54);
            this.kontrastButonu.TabIndex = 6;
            this.kontrastButonu.Text = "Kontrast";
            this.kontrastButonu.UseVisualStyleBackColor = false;
            this.kontrastButonu.Click += new System.EventHandler(this.kontrastButonu_Click);
            // 
            // ParlatButonu
            // 
            this.ParlatButonu.BackColor = System.Drawing.Color.Turquoise;
            this.ParlatButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ParlatButonu.Location = new System.Drawing.Point(572, 36);
            this.ParlatButonu.Name = "ParlatButonu";
            this.ParlatButonu.Size = new System.Drawing.Size(128, 54);
            this.ParlatButonu.TabIndex = 7;
            this.ParlatButonu.Text = "Parlaklaştır";
            this.ParlatButonu.UseVisualStyleBackColor = false;
            this.ParlatButonu.Click += new System.EventHandler(this.ParlatButonu_Click);
            // 
            // MeanFiltreButonu
            // 
            this.MeanFiltreButonu.BackColor = System.Drawing.Color.Turquoise;
            this.MeanFiltreButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MeanFiltreButonu.Location = new System.Drawing.Point(1149, 112);
            this.MeanFiltreButonu.Name = "MeanFiltreButonu";
            this.MeanFiltreButonu.Size = new System.Drawing.Size(153, 60);
            this.MeanFiltreButonu.TabIndex = 8;
            this.MeanFiltreButonu.Text = "Mean filtreleme";
            this.MeanFiltreButonu.UseVisualStyleBackColor = false;
            this.MeanFiltreButonu.Click += new System.EventHandler(this.MeanFiltreButonu_Click);
            // 
            // MedianFiltreButonu
            // 
            this.MedianFiltreButonu.BackColor = System.Drawing.Color.Turquoise;
            this.MedianFiltreButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MedianFiltreButonu.Location = new System.Drawing.Point(1149, 188);
            this.MedianFiltreButonu.Name = "MedianFiltreButonu";
            this.MedianFiltreButonu.Size = new System.Drawing.Size(153, 60);
            this.MedianFiltreButonu.TabIndex = 9;
            this.MedianFiltreButonu.Text = "Median filtreleme";
            this.MedianFiltreButonu.UseVisualStyleBackColor = false;
            this.MedianFiltreButonu.Click += new System.EventHandler(this.MedianFiltreButonu_Click);
            // 
            // GaussFiltreButonu
            // 
            this.GaussFiltreButonu.BackColor = System.Drawing.Color.Turquoise;
            this.GaussFiltreButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GaussFiltreButonu.Location = new System.Drawing.Point(1149, 262);
            this.GaussFiltreButonu.Name = "GaussFiltreButonu";
            this.GaussFiltreButonu.Size = new System.Drawing.Size(153, 60);
            this.GaussFiltreButonu.TabIndex = 10;
            this.GaussFiltreButonu.Text = "Gauss filtreleme";
            this.GaussFiltreButonu.UseVisualStyleBackColor = false;
            this.GaussFiltreButonu.Click += new System.EventHandler(this.GaussFiltreButonu_Click);
            // 
            // NetlestirmeButonu
            // 
            this.NetlestirmeButonu.BackColor = System.Drawing.Color.Turquoise;
            this.NetlestirmeButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NetlestirmeButonu.Location = new System.Drawing.Point(713, 36);
            this.NetlestirmeButonu.Name = "NetlestirmeButonu";
            this.NetlestirmeButonu.Size = new System.Drawing.Size(128, 54);
            this.NetlestirmeButonu.TabIndex = 11;
            this.NetlestirmeButonu.Text = "Netleştirme";
            this.NetlestirmeButonu.UseVisualStyleBackColor = false;
            this.NetlestirmeButonu.Click += new System.EventHandler(this.NetlestirmeButonu_Click);
            // 
            // OtolemeButonu
            // 
            this.OtolemeButonu.BackColor = System.Drawing.Color.Turquoise;
            this.OtolemeButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OtolemeButonu.Location = new System.Drawing.Point(857, 36);
            this.OtolemeButonu.Name = "OtolemeButonu";
            this.OtolemeButonu.Size = new System.Drawing.Size(128, 54);
            this.OtolemeButonu.TabIndex = 12;
            this.OtolemeButonu.Text = "Öteleme";
            this.OtolemeButonu.UseVisualStyleBackColor = false;
            this.OtolemeButonu.Click += new System.EventHandler(this.OtolemeButonu_Click);
            // 
            // AynalamaButonu
            // 
            this.AynalamaButonu.BackColor = System.Drawing.Color.Turquoise;
            this.AynalamaButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AynalamaButonu.Location = new System.Drawing.Point(1149, 34);
            this.AynalamaButonu.Name = "AynalamaButonu";
            this.AynalamaButonu.Size = new System.Drawing.Size(322, 59);
            this.AynalamaButonu.TabIndex = 13;
            this.AynalamaButonu.Text = "Aynalama ve Çevirme";
            this.AynalamaButonu.UseVisualStyleBackColor = false;
            this.AynalamaButonu.Click += new System.EventHandler(this.AynalamaButonu_Click);
            // 
            // KucultmeButonu
            // 
            this.KucultmeButonu.BackColor = System.Drawing.Color.Turquoise;
            this.KucultmeButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KucultmeButonu.Location = new System.Drawing.Point(1004, 36);
            this.KucultmeButonu.Name = "KucultmeButonu";
            this.KucultmeButonu.Size = new System.Drawing.Size(128, 54);
            this.KucultmeButonu.TabIndex = 15;
            this.KucultmeButonu.Text = "Küçültme";
            this.KucultmeButonu.UseVisualStyleBackColor = false;
            this.KucultmeButonu.Click += new System.EventHandler(this.KucultmeButonu_Click);
            // 
            // ResimKaydetButonu
            // 
            this.ResimKaydetButonu.BackColor = System.Drawing.Color.Lime;
            this.ResimKaydetButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ResimKaydetButonu.ForeColor = System.Drawing.Color.Red;
            this.ResimKaydetButonu.Location = new System.Drawing.Point(160, 545);
            this.ResimKaydetButonu.Name = "ResimKaydetButonu";
            this.ResimKaydetButonu.Size = new System.Drawing.Size(130, 48);
            this.ResimKaydetButonu.TabIndex = 16;
            this.ResimKaydetButonu.Text = "RESMİ KAYDET";
            this.ResimKaydetButonu.UseVisualStyleBackColor = false;
            this.ResimKaydetButonu.Click += new System.EventHandler(this.ResimKaydetButonu_Click);
            // 
            // SobelFiltreButonu
            // 
            this.SobelFiltreButonu.BackColor = System.Drawing.Color.Turquoise;
            this.SobelFiltreButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SobelFiltreButonu.Location = new System.Drawing.Point(1320, 111);
            this.SobelFiltreButonu.Name = "SobelFiltreButonu";
            this.SobelFiltreButonu.Size = new System.Drawing.Size(151, 60);
            this.SobelFiltreButonu.TabIndex = 17;
            this.SobelFiltreButonu.Text = "Sobel filtreleme";
            this.SobelFiltreButonu.UseVisualStyleBackColor = false;
            this.SobelFiltreButonu.Click += new System.EventHandler(this.SobelFiltreButonu_Click);
            // 
            // PrewittFiltreButonu
            // 
            this.PrewittFiltreButonu.BackColor = System.Drawing.Color.Turquoise;
            this.PrewittFiltreButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PrewittFiltreButonu.Location = new System.Drawing.Point(1317, 186);
            this.PrewittFiltreButonu.Name = "PrewittFiltreButonu";
            this.PrewittFiltreButonu.Size = new System.Drawing.Size(154, 60);
            this.PrewittFiltreButonu.TabIndex = 18;
            this.PrewittFiltreButonu.Text = "Prewitt filtreleme";
            this.PrewittFiltreButonu.UseVisualStyleBackColor = false;
            this.PrewittFiltreButonu.Click += new System.EventHandler(this.PrewittFiltreButonu_Click);
            // 
            // LaplicanFiltreButonu
            // 
            this.LaplicanFiltreButonu.BackColor = System.Drawing.Color.Turquoise;
            this.LaplicanFiltreButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LaplicanFiltreButonu.Location = new System.Drawing.Point(1317, 262);
            this.LaplicanFiltreButonu.Name = "LaplicanFiltreButonu";
            this.LaplicanFiltreButonu.Size = new System.Drawing.Size(154, 60);
            this.LaplicanFiltreButonu.TabIndex = 19;
            this.LaplicanFiltreButonu.Text = "Laplican filtreleme";
            this.LaplicanFiltreButonu.UseVisualStyleBackColor = false;
            this.LaplicanFiltreButonu.Click += new System.EventHandler(this.LaplicanFiltreButonu_Click);
            // 
            // PerspektifButonu
            // 
            this.PerspektifButonu.BackColor = System.Drawing.Color.Turquoise;
            this.PerspektifButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PerspektifButonu.Location = new System.Drawing.Point(1238, 410);
            this.PerspektifButonu.Name = "PerspektifButonu";
            this.PerspektifButonu.Size = new System.Drawing.Size(153, 60);
            this.PerspektifButonu.TabIndex = 22;
            this.PerspektifButonu.Text = "Perspektif";
            this.PerspektifButonu.UseVisualStyleBackColor = false;
            this.PerspektifButonu.Click += new System.EventHandler(this.PerspektifButonu_Click);
            // 
            // HistogramButonu
            // 
            this.HistogramButonu.BackColor = System.Drawing.Color.Turquoise;
            this.HistogramButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HistogramButonu.Location = new System.Drawing.Point(12, 96);
            this.HistogramButonu.Name = "HistogramButonu";
            this.HistogramButonu.Size = new System.Drawing.Size(125, 54);
            this.HistogramButonu.TabIndex = 23;
            this.HistogramButonu.Text = "Histogram";
            this.HistogramButonu.UseVisualStyleBackColor = false;
            this.HistogramButonu.Click += new System.EventHandler(this.HistogramButonu_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(846, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(134, 356);
            this.listBox1.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(986, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 22);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "0";
            // 
            // rgbdebYUVaButonu
            // 
            this.rgbdebYUVaButonu.BackColor = System.Drawing.Color.Turquoise;
            this.rgbdebYUVaButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rgbdebYUVaButonu.Location = new System.Drawing.Point(1149, 335);
            this.rgbdebYUVaButonu.Name = "rgbdebYUVaButonu";
            this.rgbdebYUVaButonu.Size = new System.Drawing.Size(153, 60);
            this.rgbdebYUVaButonu.TabIndex = 33;
            this.rgbdebYUVaButonu.Text = "RGB --> YUV";
            this.rgbdebYUVaButonu.UseVisualStyleBackColor = false;
            this.rgbdebYUVaButonu.Click += new System.EventHandler(this.rgbdebYUVaButonu_Click);
            // 
            // rgbdenCMYyeButonu
            // 
            this.rgbdenCMYyeButonu.BackColor = System.Drawing.Color.Turquoise;
            this.rgbdenCMYyeButonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rgbdenCMYyeButonu.Location = new System.Drawing.Point(1320, 336);
            this.rgbdenCMYyeButonu.Name = "rgbdenCMYyeButonu";
            this.rgbdenCMYyeButonu.Size = new System.Drawing.Size(154, 60);
            this.rgbdenCMYyeButonu.TabIndex = 35;
            this.rgbdenCMYyeButonu.Text = "RGB --> CMY";
            this.rgbdenCMYyeButonu.UseVisualStyleBackColor = false;
            this.rgbdenCMYyeButonu.Click += new System.EventHandler(this.rgbdenCMYyeButonu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1514, 621);
            this.Controls.Add(this.rgbdenCMYyeButonu);
            this.Controls.Add(this.rgbdebYUVaButonu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.HistogramButonu);
            this.Controls.Add(this.PerspektifButonu);
            this.Controls.Add(this.LaplicanFiltreButonu);
            this.Controls.Add(this.PrewittFiltreButonu);
            this.Controls.Add(this.SobelFiltreButonu);
            this.Controls.Add(this.ResimKaydetButonu);
            this.Controls.Add(this.KucultmeButonu);
            this.Controls.Add(this.AynalamaButonu);
            this.Controls.Add(this.OtolemeButonu);
            this.Controls.Add(this.NetlestirmeButonu);
            this.Controls.Add(this.GaussFiltreButonu);
            this.Controls.Add(this.MedianFiltreButonu);
            this.Controls.Add(this.MeanFiltreButonu);
            this.Controls.Add(this.ParlatButonu);
            this.Controls.Add(this.kontrastButonu);
            this.Controls.Add(this.negatifButon);
            this.Controls.Add(this.esiklemeButon);
            this.Controls.Add(this.GriButon);
            this.Controls.Add(this.YukleButonu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button YukleButonu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button GriButon;
        private System.Windows.Forms.Button esiklemeButon;
        private System.Windows.Forms.Button negatifButon;
        private System.Windows.Forms.Button kontrastButonu;
        private System.Windows.Forms.Button ParlatButonu;
        private System.Windows.Forms.Button MeanFiltreButonu;
        private System.Windows.Forms.Button MedianFiltreButonu;
        private System.Windows.Forms.Button GaussFiltreButonu;
        private System.Windows.Forms.Button NetlestirmeButonu;
        private System.Windows.Forms.Button OtolemeButonu;
        private System.Windows.Forms.Button AynalamaButonu;
        private System.Windows.Forms.Button KucultmeButonu;
        private System.Windows.Forms.Button ResimKaydetButonu;
        private System.Windows.Forms.Button SobelFiltreButonu;
        private System.Windows.Forms.Button PrewittFiltreButonu;
        private System.Windows.Forms.Button LaplicanFiltreButonu;
        private System.Windows.Forms.Button PerspektifButonu;
        private System.Windows.Forms.Button HistogramButonu;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button rgbdebYUVaButonu;
        private System.Windows.Forms.Button rgbdenCMYyeButonu;
    }
}

