using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GoruntuIsleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Bitmap varsayilan = new Bitmap(dosyaYolu);
            //pictureBox1.Image = varsayilan;
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }





        public Bitmap resimHis;
        string dosyaYolu = "C:\\Users\\kalbi\\OneDrive\\Masaüstü\\Lenna.png";
        Bitmap bmp = null;

        private void YukleButonu_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dosyaYolu = openFileDialog1.FileName;
                    bmp = new Bitmap(dosyaYolu);
                    pictureBox1.Image = bmp;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hatalı dosya seçimi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }


        public static Bitmap Grilestir(Bitmap resim)
        {
            Color renk, griRenk;
            Bitmap girisResmi = new Bitmap(resim);
            int resimGenisligi = girisResmi.Width;
            int resimYuksekligi = girisResmi.Height;
            Bitmap yeniResim = new Bitmap(resimGenisligi, resimYuksekligi);
            int griDeger = 0;
            for (int x = 0; x < resimGenisligi; x++)
            {
                for (int y = 0; y < resimYuksekligi; y++)
                {
                    renk = girisResmi.GetPixel(x, y);
                    double R = renk.R;
                    double G = renk.G;
                    double B = renk.B;

                    griDeger = Convert.ToInt16(R * 0.3 + G * 0.6 + B * 0.1);
                    griRenk = Color.FromArgb(griDeger, griDeger, griDeger);
                    yeniResim.SetPixel(x, y, griRenk);
                }
            }
            return yeniResim;
        }
        private void GriButon_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap girisResmi = new Bitmap(pictureBox1.Image);
                pictureBox2.Image = Grilestir(girisResmi);
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }
        public static Bitmap esikle(Bitmap resim)
        {
            int R = 0, G = 0, B = 0;
            Color renk, esikRenk;
            Bitmap girisResmi = new Bitmap(resim);
            Bitmap yeniResim;
            girisResmi = Grilestir(girisResmi);
            int resimGenisligi = girisResmi.Width;
            int resimYuksekligi = girisResmi.Height;
            yeniResim = new Bitmap(resimGenisligi, resimYuksekligi);
            int esiklemeDegeri = 116;
            for (int x = 0; x < resimGenisligi; x++)
            {
                for (int y = 0; y < resimYuksekligi; y++)
                {
                    renk = girisResmi.GetPixel(x, y);
                    if (renk.R >= esiklemeDegeri)
                        R = 255;
                    else
                        R = 0;
                    if (renk.G >= esiklemeDegeri)
                        G = 255;
                    else
                        G = 0;
                    if (renk.B >= esiklemeDegeri)
                        B = 255;
                    else
                        B = 0;
                    esikRenk = Color.FromArgb(R, G, B);
                    yeniResim.SetPixel(x, y, esikRenk);
                }
            }
            return yeniResim;
        }

        private void esiklemeButon_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap girisResmi = new Bitmap(pictureBox1.Image);
                pictureBox2.Image = esikle(girisResmi);
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void negatifButon_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color renk, negatifRenk;
                int R = 0, G = 0, B = 0;
                Bitmap girisResmi, yeniResim;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                yeniResim = new Bitmap(resimGenisligi, resimYuksekligi);

                for (int x = 0; x < resimGenisligi; x++)
                {
                    for (int y = 0; y < resimYuksekligi; y++)
                    {
                        renk = girisResmi.GetPixel(x, y);
                        R = 255 - renk.R;
                        G = 255 - renk.G;
                        B = 255 - renk.B;
                        negatifRenk = Color.FromArgb(R, G, B);
                        yeniResim.SetPixel(x, y, negatifRenk);
                    }
                }
                pictureBox2.Image = yeniResim;
            }
            else
            {
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void kontrastButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int R = 0, G = 0, B = 0;
                Color OkunanRenk, DonusenRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width;
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                double kontrastDegeri = -128;
                double duzeltılmısKontrast = (259 * (kontrastDegeri + 255)) / (255 * (259 - kontrastDegeri));
                for (int x = 0; x < ResimGenisligi; x++)
                {
                    for (int y = 0; y < ResimYuksekligi; y++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x, y);
                        R = OkunanRenk.R;
                        G = OkunanRenk.G;
                        B = OkunanRenk.B;
                        R = (int)((duzeltılmısKontrast * (R - 128)) + 128);
                        G = (int)((duzeltılmısKontrast * (G - 128)) + 128);
                        B = (int)((duzeltılmısKontrast * (B - 128)) + 128);

                        if (R > 255) R = 255;
                        if (G > 255) G = 255;
                        if (B > 255) B = 255;
                        if (R < 0) R = 0;
                        if (G < 0) G = 0;
                        if (B < 0) B = 0;
                        DonusenRenk = Color.FromArgb(R, G, B);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                    }
                }
                pictureBox2.Image = CikisResmi;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ParlatButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int R = 0, G = 0, B = 0;
                Color renk, parlakRenk;
                Bitmap girisResmi, yeniResim;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                yeniResim = new Bitmap(resimGenisligi, resimYuksekligi);
                int i = 0, j = 0;
                for (int x = 0; x < resimGenisligi; x++)
                {
                    j = 0;
                    for (int y = 0; y < resimYuksekligi; y++)
                    {
                        renk = girisResmi.GetPixel(x, y);
                        R = renk.R + 60;
                        G = renk.G + 60;
                        B = renk.B + 60;
                        if (R > 255)
                            R = 255;
                        if (G > 255)
                            G = 255;
                        if (B > 255)
                            B = 255;
                        parlakRenk = Color.FromArgb(R, G, B);
                        yeniResim.SetPixel(i, j, parlakRenk);
                        j++;
                    }
                    i++;
                }
                pictureBox2.Image = yeniResim;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void MeanFiltreButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color renk;
                Bitmap girisResmi, yeniResim;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                yeniResim = new Bitmap(resimGenisligi, resimYuksekligi);
                int matrisBoyutu = 7;
                int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;
                for (x = (matrisBoyutu - 1) / 2; x < resimGenisligi - (matrisBoyutu - 1) / 2; x++)
                {
                    for (y = (matrisBoyutu - 1) / 2; y < resimYuksekligi - (matrisBoyutu - 1) / 2; y++)
                    {
                        toplamR = 0;
                        toplamG = 0;
                        toplamB = 0;
                        for (i = -((matrisBoyutu - 1) / 2); i <= (matrisBoyutu - 1) / 2; i++)
                        {
                            for (j = -((matrisBoyutu - 1) / 2); j <= (matrisBoyutu - 1) / 2; j++)
                            {
                                renk = girisResmi.GetPixel(x + i, y + j);
                                toplamR += renk.R;
                                toplamG += renk.G;
                                toplamB += renk.B;
                            }
                        }
                        ortalamaR = toplamR / (matrisBoyutu * matrisBoyutu);
                        ortalamaG = toplamG / (matrisBoyutu * matrisBoyutu);
                        ortalamaB = toplamB / (matrisBoyutu * matrisBoyutu);
                        yeniResim.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                    }
                }
                pictureBox2.Image = yeniResim;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void MedianFiltreButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color renk;
                Bitmap girisResmi, yeniResim;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                yeniResim = new Bitmap(resimGenisligi, resimYuksekligi);
                int matrisBoyutu = 5;
                int elemanSayisi = matrisBoyutu * matrisBoyutu;
                int[] R = new int[elemanSayisi];
                int[] G = new int[elemanSayisi];
                int[] B = new int[elemanSayisi];
                int[] gri = new int[elemanSayisi];
                int x, y, i, j;
                for (x = (matrisBoyutu - 1) / 2; x < resimGenisligi - (matrisBoyutu - 1) / 2; x++)
                {
                    for (y = (matrisBoyutu - 1) / 2; y < resimYuksekligi - (matrisBoyutu - 1) / 2; y++)
                    {
                        int k = 0;
                        for (i = -((matrisBoyutu - 1) / 2); i <= (matrisBoyutu - 1) / 2; i++)
                        {
                            for (j = -((matrisBoyutu - 1) / 2); j <= (matrisBoyutu - 1) / 2; j++)
                            {
                                renk = girisResmi.GetPixel(x + i, y + j);
                                R[k] = renk.R;
                                G[k] = renk.G;
                                B[k] = renk.B;
                                gri[k] = Convert.ToInt16(R[k] * 0.3 + G[k] * 0.6 + B[k] * 0.1);
                                k++;
                            }
                        }
                        int geciciSayi = 0;
                        for (i = 0; i < elemanSayisi; i++)
                        {
                            for (j = i + 1; j < elemanSayisi; j++)
                            {
                                if (gri[j] < gri[i])
                                {
                                    geciciSayi = gri[i];
                                    gri[i] = gri[j];
                                    gri[j] = geciciSayi;
                                    geciciSayi = R[i];
                                    R[i] = R[j];
                                    R[j] = geciciSayi;
                                    geciciSayi = G[i];
                                    G[i] = G[j];
                                    G[j] = geciciSayi;
                                    geciciSayi = B[i];
                                    B[i] = B[j];
                                    B[j] = geciciSayi;
                                }
                            }
                        }
                        yeniResim.SetPixel(x, y, Color.FromArgb(R[(elemanSayisi - 1) / 2], G[(elemanSayisi - 1) / 2], B[(elemanSayisi - 1) / 2]));
                    }
                }
                pictureBox2.Image = yeniResim;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GaussFiltreButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color renk;
                Bitmap girisResmi, yeniResim;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                yeniResim = new Bitmap(resimGenisligi, resimYuksekligi);
                int matrisBoyutu = 5;
                int elemanSayisi = matrisBoyutu * matrisBoyutu;
                int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;
                int[] Matris = { 1, 2, 4, 2, 1, 2, 6, 9, 6, 2, 4, 9, 16, 9, 4, 2, 6, 9, 6, 2, 1, 2, 4, 2, 1 };
                int MatrisToplami = 1 + 2 + 4 + 2 + 1 + 2 + 6 + 9 + 6 + 2 + 4 + 9 + 16 + 9 + 4 + 2 + 6 + 9 + 6 + 2 + 1 + 2 + 4 + 2 + 1;
                for (x = (matrisBoyutu - 1) / 2; x < resimGenisligi - (matrisBoyutu - 1) / 2; x++)
                {
                    for (y = (matrisBoyutu - 1) / 2; y < resimYuksekligi - (matrisBoyutu - 1) / 2; y++)
                    {
                        toplamR = 0;
                        toplamG = 0;
                        toplamB = 0;

                        int k = 0;
                        for (i = -((matrisBoyutu - 1) / 2); i <= (matrisBoyutu - 1) / 2; i++)
                        {
                            for (j = -((matrisBoyutu - 1) / 2); j <= (matrisBoyutu - 1) / 2; j++)
                            {
                                renk = girisResmi.GetPixel(x + i, y + j);
                                toplamR += renk.R * Matris[k];
                                toplamG += renk.G * Matris[k];
                                toplamB += renk.B * Matris[k];
                                k++;
                            }
                            ortalamaR = toplamR / MatrisToplami;
                            ortalamaG = toplamG / MatrisToplami;
                            ortalamaB = toplamB / MatrisToplami;
                            yeniResim.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                        }
                    }
                }
                pictureBox2.Image = yeniResim;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void NetlestirmeButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color renk;
                Bitmap girisResmi, yeniResim;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                yeniResim = new Bitmap(resimGenisligi, resimYuksekligi);
                int matrisBoyutu = 3;
                int elemanSayisi = matrisBoyutu * matrisBoyutu;
                int x, y, i, j, toplamR, toplamG, toplamB;
                int R, G, B;
                int[] Matris = { 0, -2, 0, -2, 11, -2, 0, -2, 0 };
                int MatrisToplami = 0 + -2 + 0 + -2 + 11 + -2 + 0 + -2 + 0;

                for (x = (matrisBoyutu - 1) / 2; x < resimGenisligi - (matrisBoyutu - 1) / 2; x++)
                {
                    for (y = (matrisBoyutu - 1) / 2; y < resimYuksekligi - (matrisBoyutu - 1) / 2; y++)
                    {
                        toplamR = 0;
                        toplamG = 0;
                        toplamB = 0;
                        int k = 0;
                        for (i = -((matrisBoyutu - 1) / 2); i <= (matrisBoyutu - 1) / 2; i++)
                        {
                            for (j = -((matrisBoyutu - 1) / 2); j <= (matrisBoyutu - 1) / 2; j++)
                            {
                                renk = girisResmi.GetPixel(x + i, y + j);
                                toplamR += renk.R * Matris[k];
                                toplamG += renk.G * Matris[k];
                                toplamB += renk.B * Matris[k];
                                k++;
                            }
                        }
                        R = toplamR / MatrisToplami;
                        G = toplamG / MatrisToplami;
                        B = toplamB / MatrisToplami;

                        if (R > 255)
                            R = 255;
                        if (G > 255)
                            G = 255;
                        if (B > 255)
                            B = 255;
                        if (R < 0)
                            R = 0;
                        if (G < 0)
                            G = 0;
                        if (B < 0)
                            B = 0;
                        yeniResim.SetPixel(x, y, Color.FromArgb(R, G, B));
                    }
                }
                pictureBox2.Image = yeniResim;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OtolemeButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color renk;
                Bitmap girisResmi, yeniResim;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                yeniResim = new Bitmap(resimGenisligi, resimYuksekligi);
                double x2 = 0, y2 = 0;
                int tasımaX = 100;
                int tasımaY = 50;
                for (int x1 = 0; x1 < (resimGenisligi); x1++)
                {
                    for (int y1 = 0; y1 < (resimYuksekligi); y1++)
                    {
                        renk = girisResmi.GetPixel(x1, y1);
                        x2 = x1 + tasımaX;
                        y2 = y1 + tasımaY;
                        if (x2 > 0 && x2 < resimGenisligi && y2 > 0 && y2 < resimYuksekligi)
                            yeniResim.SetPixel((int)x2, (int)y2, renk);

                    }
                }
                pictureBox2.Image = yeniResim;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void AynalamaButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color renk;
                Bitmap girisResmi, yeniResim;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                yeniResim = new Bitmap(resimGenisligi, resimYuksekligi);
                double aci = 60;
                double radyanAci = aci * 2 * Math.PI / 360;
                double x2 = 0, y2 = 0;
                int x0 = resimGenisligi / 2;
                int y0 = resimYuksekligi / 2;
                for (int x1 = 0; x1 < resimGenisligi; x1++)
                {
                    for (int y1 = 0; y1 < resimYuksekligi; y1++)
                    {
                        renk = girisResmi.GetPixel(x1, y1);

                        //----A-Orta dikey eksen etrafında aynalama 
                        //x2 = Convert.ToInt16(-x1 + 2 * x0);
                        //y2 = Convert.ToInt16(y1);
                        //----B-Orta yatay eksen etrafında aynalama 
                        x2 = Convert.ToInt16(x1);
                        y2 = Convert.ToInt16(-y1 + 2 * y0);

                        //----C-Ortadan geçen açı ile çizgi etrafında aynalama
                        double Delta = (x1 - x0) * Math.Sin(radyanAci) - (y1 - y0) * Math.Cos(radyanAci);
                        //x2 = Convert.ToInt16(x1 + 2 * Delta * (-Math.Sin(radyanAci)));
                        //y2 = Convert.ToInt16(y1 + 2 * Delta * (Math.Cos(radyanAci)));
                        if (x2 > 0 && x2 < resimGenisligi && y2 > 0 && y2 < resimYuksekligi)
                            yeniResim.SetPixel((int)x2, (int)y2, renk);
                    }
                }
                pictureBox2.Image = yeniResim;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }



        private void KucultmeButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color renk, renk2, renk3;
                Bitmap girisResmi, yeniResim;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                yeniResim = new Bitmap(resimGenisligi, resimYuksekligi);
                int x2 = 0, y2 = 0;
                int kucultmeKatsayisi = 2;
                for (int x1 = 0; x1 < resimGenisligi; x1 += kucultmeKatsayisi)
                {
                    y2 = 0;
                    for (int y1 = 0; y1 < resimYuksekligi; y1 += kucultmeKatsayisi)
                    {
                        renk = girisResmi.GetPixel(x1, y1);
                        yeniResim.SetPixel(x2, y2, renk);
                        y2++;
                    }
                    x2++;
                }
                pictureBox2.Image = yeniResim;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void ResimKaydetButonu_Click(object sender, EventArgs e)
        {

            SaveFileDialog kaydetResim = new SaveFileDialog();
            kaydetResim.Filter = "Jpeg Resmi|*.jpg|PNG Resmi|*.png|Gif Resmi|*.gif";
            kaydetResim.Title = "Resmi Kaydet";
            if (pictureBox2.Image != null)
            {
                kaydetResim.ShowDialog();
                if (kaydetResim.FileName != "")
                {
                    FileStream resimDosya = (FileStream)kaydetResim.OpenFile();
                    switch (kaydetResim.FilterIndex)
                    {
                        case 1:
                            pictureBox2.Image.Save(resimDosya, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case 2:
                            pictureBox2.Image.Save(resimDosya, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        case 3:
                            pictureBox2.Image.Save(resimDosya, System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                    }
                    resimDosya.Close();
                }
            }
            else
                MessageBox.Show("Kaydedilecek resim bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void SobelFiltreButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color renk;
                Bitmap girisResmi, yeniResimX, yeniResimY, yeniResimXY;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                yeniResimX = new Bitmap(resimGenisligi, resimYuksekligi);
                yeniResimY = new Bitmap(resimGenisligi, resimYuksekligi);
                yeniResimXY = new Bitmap(resimGenisligi, resimYuksekligi);
                int matrisBoyutu = 3;
                int elemanSayisi = matrisBoyutu * matrisBoyutu;
                int x, y, i, j;
                double gri = 0;
                int[] MatrisX = { -1, 0, 1, -2, 0, 2, -1, 0, 1 };
                int[] MatrisY = { 1, 2, 1, 0, 0, 0, -1, -2, -1 };
                int renkX, renkY, renkXY;
                for (x = (matrisBoyutu - 1) / 2; x < resimGenisligi - (matrisBoyutu - 1) / 2; x++)
                {
                    for (y = (matrisBoyutu - 1) / 2; y < resimYuksekligi - (matrisBoyutu - 1) / 2; y++)
                    {
                        int toplamGriX = 0, toplamGriY = 0;

                        int k = 0;
                        for (i = -((matrisBoyutu - 1) / 2); i <= (matrisBoyutu - 1) / 2; i++)
                        {
                            for (j = -((matrisBoyutu - 1) / 2); j <= (matrisBoyutu - 1) / 2; j++)
                            {
                                renk = girisResmi.GetPixel(x + i, y + j);
                                gri = (renk.R * 0.3 + renk.G * 0.6 + renk.B * 0.1);
                                toplamGriX += (int)gri * MatrisX[k];
                                toplamGriY += (int)gri * MatrisY[k];
                                k++;
                            }
                        }
                        renkX = Math.Abs(toplamGriX);
                        renkY = Math.Abs(toplamGriY);
                        renkXY = Math.Abs(toplamGriX) + Math.Abs(toplamGriY);

                        if (renkX > 255)
                            renkX = 255;
                        if (renkY > 255)
                            renkY = 255;
                        if (renkXY > 255)
                            renkXY = 255;
                        if (renkX < 0)
                            renkX = 0;
                        if (renkY < 0)
                            renkY = 0;
                        if (renkXY < 0)
                            renkXY = 0;

                        yeniResimX.SetPixel(x, y, Color.FromArgb(renkX, renkX, renkX));
                        yeniResimY.SetPixel(x, y, Color.FromArgb(renkY, renkY, renkY));
                        yeniResimXY.SetPixel(x, y, Color.FromArgb(renkXY, renkXY, renkXY));
                    }
                }
                //pictureBox2.Image = yeniResimY;
                //pictureBox2.Image = yeniResimX;
                pictureBox2.Image = yeniResimXY;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void PrewittFiltreButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color renk;
                Bitmap girisResmi, yeniResimX, yeniResimY, yeniResimXY;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                yeniResimX = new Bitmap(resimGenisligi, resimYuksekligi);
                yeniResimY = new Bitmap(resimGenisligi, resimYuksekligi);
                yeniResimXY = new Bitmap(resimGenisligi, resimYuksekligi);
                int matrisBoyutu = 3;
                int elemanSayisi = matrisBoyutu * matrisBoyutu;
                int x, y, i, j;
                double gri = 0;
                int[] MatrisX = { -1, 0, 1, -1, 0, 1, -1, 0, 1 };
                int[] MatrisY = { 1, 1, 1, 0, 0, 0, -1, -1, -1 };
                int renkX, renkY, renkXY;
                for (x = (matrisBoyutu - 1) / 2; x < resimGenisligi - (matrisBoyutu - 1) / 2; x++)
                {
                    for (y = (matrisBoyutu - 1) / 2; y < resimYuksekligi - (matrisBoyutu - 1) / 2; y++)
                    {
                        int toplamGriX = 0, toplamGriY = 0;
                        int k = 0;
                        for (i = -((matrisBoyutu - 1) / 2); i <= (matrisBoyutu - 1) / 2; i++)
                        {
                            for (j = -((matrisBoyutu - 1) / 2); j <= (matrisBoyutu - 1) / 2; j++)
                            {
                                renk = girisResmi.GetPixel(x + i, y + j);
                                gri = (renk.R * 0.3 + renk.G * 0.6 + renk.B * 0.1);
                                toplamGriX += (int)gri * MatrisX[k];
                                toplamGriY += (int)gri * MatrisY[k];
                                k++;
                            }
                        }
                        renkX = Math.Abs(toplamGriX);
                        renkY = Math.Abs(toplamGriY);
                        renkXY = Math.Abs(toplamGriX) + Math.Abs(toplamGriY);

                        if (renkX > 255)
                            renkX = 255;
                        if (renkY > 255)
                            renkY = 255;
                        if (renkXY > 255)
                            renkXY = 255;
                        if (renkX < 0)
                            renkX = 0;
                        if (renkY < 0)
                            renkY = 0;
                        if (renkXY < 0)
                            renkXY = 0;

                        yeniResimX.SetPixel(x, y, Color.FromArgb(renkX, renkX, renkX));
                        yeniResimY.SetPixel(x, y, Color.FromArgb(renkY, renkY, renkY));
                        yeniResimXY.SetPixel(x, y, Color.FromArgb(renkXY, renkXY, renkXY));
                    }
                }
                //pictureBox2.Image = yeniResimY;
                //pictureBox2.Image = yeniResimX;
                pictureBox2.Image = yeniResimXY;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void LaplicanFiltreButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color renk;
                Bitmap girisResmi, yeniResimX, yeniResimY, yeniResimXY;
                girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                yeniResimX = new Bitmap(resimGenisligi, resimYuksekligi);
                yeniResimY = new Bitmap(resimGenisligi, resimYuksekligi);
                yeniResimXY = new Bitmap(resimGenisligi, resimYuksekligi);
                int matrisBoyutu = 3;
                int elemanSayisi = matrisBoyutu * matrisBoyutu;
                int x, y, i, j;
                double gri = 0;
                int[] MatrisX = { 0, 1, 0, 1, -4, 1, 0, 1, 0 };
                int[] MatrisY = { 0, 1, 0, 1, -4, 1, 0, 1, 0 };
                int renkX, renkY, renkXY;
                for (x = (matrisBoyutu - 1) / 2; x < resimGenisligi - (matrisBoyutu - 1) / 2; x++)
                {
                    for (y = (matrisBoyutu - 1) / 2; y < resimYuksekligi - (matrisBoyutu - 1) / 2; y++)
                    {
                        int toplamGriX = 0, toplamGriY = 0;

                        int k = 0;
                        for (i = -((matrisBoyutu - 1) / 2); i <= (matrisBoyutu - 1) / 2; i++)
                        {
                            for (j = -((matrisBoyutu - 1) / 2); j <= (matrisBoyutu - 1) / 2; j++)
                            {
                                renk = girisResmi.GetPixel(x + (-i), y + (-j));
                                gri = (renk.R * 0.3 + renk.G * 0.6 + renk.B * 0.1);
                                toplamGriX += (int)gri * MatrisX[k];
                                toplamGriY += (int)gri * MatrisY[k];
                                k++;
                            }
                        }
                        renkX = Math.Abs(toplamGriX);
                        renkY = Math.Abs(toplamGriY);
                        renkXY = Math.Abs(toplamGriX) + Math.Abs(toplamGriY);

                        if (renkX > 255)
                            renkX = 255;
                        if (renkY > 255)
                            renkY = 255;
                        if (renkXY > 255)
                            renkXY = 255;
                        if (renkX < 0)
                            renkX = 0;
                        if (renkY < 0)
                            renkY = 0;
                        if (renkXY < 0)
                            renkXY = 0;

                        yeniResimX.SetPixel(x, y, Color.FromArgb(renkX, renkX, renkX));
                        yeniResimY.SetPixel(x, y, Color.FromArgb(renkY, renkY, renkY));
                        yeniResimXY.SetPixel(x, y, Color.FromArgb(renkXY, renkXY, renkXY));
                    }
                }
                // pictureBox2.Image = yeniResimY;
                // pictureBox2.Image = yeniResimX;
                pictureBox2.Image = yeniResimXY;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
          
        public double[,] MatrisTersiniAl(double[,] GirisMatrisi)
        {
            int MatrisBoyutu = Convert.ToInt16(Math.Sqrt(GirisMatrisi.Length));
            double[,] CikisMatrisi = new double[MatrisBoyutu, MatrisBoyutu];

            for (int i = 0; i < MatrisBoyutu; i++)
            {
                for (int j = 0; j < MatrisBoyutu; j++)
                {
                    if (i == j)
                        CikisMatrisi[i, j] = 1;
                    else
                        CikisMatrisi[i, j] = 0;
                }
            }

            double d, k;
            for (int i = 0; i < MatrisBoyutu; i++)
            {
                d = GirisMatrisi[i, i];
                for (int j = 0; j < MatrisBoyutu; j++)
                {
                    if (d == 0)
                    {
                        d = 0.0001;
                    }
                    GirisMatrisi[i, j] = GirisMatrisi[i, j] / d;
                    CikisMatrisi[i, j] = CikisMatrisi[i, j] / d;
                }
                for (int x = 0; x < MatrisBoyutu; x++)
                {
                    if (x != i)
                    {
                        k = GirisMatrisi[x, i];
                        for (int j = 0; j < MatrisBoyutu; j++)
                        {
                            GirisMatrisi[x, j] = GirisMatrisi[x, j] - GirisMatrisi[i, j] * k;
                            CikisMatrisi[x, j] = CikisMatrisi[x, j] - CikisMatrisi[i, j] * k;
                        }
                    }
                }
            }
            return CikisMatrisi;
        }


        private void PerspektifButonu_Click(object sender, EventArgs e)
        {

            double x1 = 47;
            double y1 = 155;
            double x2 = 806;
            double y2 = 101;
            double x3 = 46;
            double y3 = 291;
            double x4 = 726;
            double y4 = 417;
            double X1 = 0;
            double Y1 = 0;
            double X2 = 800;
            double Y2 = 0;
            double X3 = 0;
            double Y3 = 600;
            double X4 = 800;
            double Y4 = 600;
            double[,] GirisMatrisi = new double[8, 8];

            GirisMatrisi[0, 0] = x1;
            GirisMatrisi[0, 1] = y1;
            GirisMatrisi[0, 2] = 1;
            GirisMatrisi[0, 3] = 0;
            GirisMatrisi[0, 4] = 0;
            GirisMatrisi[0, 5] = 0;
            GirisMatrisi[0, 6] = -x1 * X1;
            GirisMatrisi[0, 7] = -y1 * X1;

            GirisMatrisi[1, 0] = 0;
            GirisMatrisi[1, 1] = 0;
            GirisMatrisi[1, 2] = 0;
            GirisMatrisi[1, 3] = x1;
            GirisMatrisi[1, 4] = y1;
            GirisMatrisi[1, 5] = 1;
            GirisMatrisi[1, 6] = -x1 * Y1;
            GirisMatrisi[1, 7] = -y1 * Y1;

            GirisMatrisi[2, 0] = x2;
            GirisMatrisi[2, 1] = y2;
            GirisMatrisi[2, 2] = 1;
            GirisMatrisi[2, 3] = 0;
            GirisMatrisi[2, 4] = 0;
            GirisMatrisi[2, 5] = 0;
            GirisMatrisi[2, 6] = -x2 * X2;
            GirisMatrisi[2, 7] = -y2 * X2;

            GirisMatrisi[3, 0] = 0;
            GirisMatrisi[3, 1] = 0;
            GirisMatrisi[3, 2] = 0;
            GirisMatrisi[3, 3] = x2;
            GirisMatrisi[3, 4] = y2;
            GirisMatrisi[3, 5] = 1;
            GirisMatrisi[3, 6] = -x2 * Y2;
            GirisMatrisi[3, 7] = -y2 * Y2;

            GirisMatrisi[4, 0] = x3;
            GirisMatrisi[4, 1] = y3;
            GirisMatrisi[4, 2] = 1;
            GirisMatrisi[4, 3] = 0;
            GirisMatrisi[4, 4] = 0;
            GirisMatrisi[4, 5] = 0;
            GirisMatrisi[4, 6] = -x3 * X3;
            GirisMatrisi[4, 7] = -y3 * X3;

            GirisMatrisi[5, 0] = 0;
            GirisMatrisi[5, 1] = 0;
            GirisMatrisi[5, 2] = 0;
            GirisMatrisi[5, 3] = x3;
            GirisMatrisi[5, 4] = y3;
            GirisMatrisi[5, 5] = 1;
            GirisMatrisi[5, 6] = -x3 * Y3;
            GirisMatrisi[5, 7] = -y3 * Y3;

            GirisMatrisi[6, 0] = x4;
            GirisMatrisi[6, 1] = y4;
            GirisMatrisi[6, 2] = 1;
            GirisMatrisi[6, 3] = 0;
            GirisMatrisi[6, 4] = 0;
            GirisMatrisi[6, 5] = 0;
            GirisMatrisi[6, 6] = -x4 * X4;
            GirisMatrisi[6, 7] = -y4 * X4;

            GirisMatrisi[7, 0] = 0;
            GirisMatrisi[7, 1] = 0;
            GirisMatrisi[7, 2] = 0;
            GirisMatrisi[7, 3] = x4;
            GirisMatrisi[7, 4] = y4;
            GirisMatrisi[7, 5] = 1;
            GirisMatrisi[7, 6] = -x4 * Y4;
            GirisMatrisi[7, 7] = -y4 * Y4;
            double[,] matrisBTersi = MatrisTersiniAl(GirisMatrisi);
            double a00 = 0, a01 = 0, a02 = 0, a10 = 0, a11 = 0, a12 = 0, a20 = 0, a21 = 0, a22 = 0;
            a00 = matrisBTersi[0, 0] * X1 + matrisBTersi[0, 1] * Y1 + matrisBTersi[0, 2] * X2 + matrisBTersi[0, 3] * Y2 + matrisBTersi[0, 4] * X3 + matrisBTersi[0, 5] * Y3 + matrisBTersi[0, 6] * X4 + matrisBTersi[0, 7] * Y4;
            a01 = matrisBTersi[1, 0] * X1 + matrisBTersi[1, 1] * Y1 + matrisBTersi[1, 2] * X2 + matrisBTersi[1, 3] * Y2 + matrisBTersi[1, 4] * X3 + matrisBTersi[1, 5] * Y3 + matrisBTersi[1, 6] * X4 + matrisBTersi[1, 7] * Y4;
            a02 = matrisBTersi[2, 0] * X1 + matrisBTersi[2, 1] * Y1 + matrisBTersi[2, 2] * X2 + matrisBTersi[2, 3] * Y2 + matrisBTersi[2, 4] * X3 + matrisBTersi[2, 5] * Y3 + matrisBTersi[2, 6] * X4 + matrisBTersi[2, 7] * Y4;
            a10 = matrisBTersi[3, 0] * X1 + matrisBTersi[3, 1] * Y1 + matrisBTersi[3, 2] * X2 + matrisBTersi[3, 3] * Y2 + matrisBTersi[3, 4] * X3 + matrisBTersi[3, 5] * Y3 + matrisBTersi[3, 6] * X4 + matrisBTersi[3, 7] * Y4;
            a11 = matrisBTersi[4, 0] * X1 + matrisBTersi[4, 1] * Y1 + matrisBTersi[4, 2] * X2 + matrisBTersi[4, 3] * Y2 + matrisBTersi[4, 4] * X3 + matrisBTersi[4, 5] * Y3 + matrisBTersi[4, 6] * X4 + matrisBTersi[4, 7] * Y4;
            a12 = matrisBTersi[5, 0] * X1 + matrisBTersi[5, 1] * Y1 + matrisBTersi[5, 2] * X2 + matrisBTersi[5, 3] * Y2 + matrisBTersi[5, 4] * X3 + matrisBTersi[5, 5] * Y3 + matrisBTersi[5, 6] * X4 + matrisBTersi[5, 7] * Y4;
            a20 = matrisBTersi[6, 0] * X1 + matrisBTersi[6, 1] * Y1 + matrisBTersi[6, 2] * X2 + matrisBTersi[6, 3] * Y2 + matrisBTersi[6, 4] * X3 + matrisBTersi[6, 5] * Y3 + matrisBTersi[6, 6] * X4 + matrisBTersi[6, 7] * Y4;
            a21 = matrisBTersi[7, 0] * X1 + matrisBTersi[7, 1] * Y1 + matrisBTersi[7, 2] * X2 + matrisBTersi[7, 3] * Y2 + matrisBTersi[7, 4] * X3 + matrisBTersi[7, 5] * Y3 + matrisBTersi[7, 6] * X4 + matrisBTersi[7, 7] * Y4; a22 = 1;


            PerspektifDuzelt(a00, a01, a02, a10, a11, a12, a20, a21, a22);




        }
        public void PerspektifDuzelt(double a00, double a01, double a02, double a10, double a11, double a12, double a20, double a21, double a22)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap GirisResmi, CikisResmi;
                Color OkunanRenk;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width;
                int ResimYuksekligi = GirisResmi.Height;

                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                double X, Y, z;
                for (int x = 0; x < (ResimGenisligi); x++)
                {
                    for (int y = 0; y < (ResimYuksekligi); y++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x, y);
                        z = a20 * x + a21 * y + 1;
                        X = (a00 * x + a01 * y + a02) / z;
                        Y = (a10 * x + a11 * y + a12) / z;
                        if (X > 0 && X < ResimGenisligi && Y > 0 && Y < ResimYuksekligi)
                            CikisResmi.SetPixel((int)X, (int)Y, OkunanRenk);
                    }
                }
                pictureBox2.Image = CikisResmi;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void HistogramButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox2.Refresh();
                pictureBox2.Image = null;
                ArrayList DiziPiksel = new ArrayList();
                int OrtalamaRenk = 0;
                Color OkunanRenk;
                int R = 0, G = 0, B = 0;
                Bitmap GirisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                GirisResmi = Grilestir(GirisResmi);
                int ResimGenisligi = GirisResmi.Width;
                int ResimYuksekligi = GirisResmi.Height;
                int i = 0;
                for (int x = 0; x < GirisResmi.Width; x++)
                {
                    for (int y = 0; y < GirisResmi.Height; y++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x, y);
                        OrtalamaRenk = (int)(OkunanRenk.R + OkunanRenk.G + OkunanRenk.B) / 3;
                        DiziPiksel.Add(OrtalamaRenk);
                    }
                }
                int[] DiziPikselSayilari = new int[256];
                for (int r = 0; r <= 255; r++)
                {
                    int PikselSayisi = 0;
                    for (int s = 0; s < DiziPiksel.Count; s++)
                    {
                        if (r == Convert.ToInt16(DiziPiksel[s]))
                            PikselSayisi++;
                    }
                    DiziPikselSayilari[r] = PikselSayisi;
                }

                int RenkMaksPikselSayisi = 0;
                int ort = 0;
                int sayac = 0;
                for (int k = 0; k <= 255; k++)
                {
                    listBox1.Items.Add("Renk:" + k + "=" + DiziPikselSayilari[k]);


                    if (DiziPikselSayilari[k] > RenkMaksPikselSayisi)
                    {
                        RenkMaksPikselSayisi = DiziPikselSayilari[k];
                    }
                    if (DiziPikselSayilari[k] != 0)
                    {
                        sayac++;
                    }
                }

                Graphics CizimAlani;
                Pen Kalem1 = new Pen(System.Drawing.Color.Yellow, 1);
                Pen Kalem2 = new Pen(System.Drawing.Color.Red, 1);
                CizimAlani = pictureBox2.CreateGraphics();
                pictureBox2.Refresh();
                int GrafikYuksekligi = 300;
                double OlcekY = RenkMaksPikselSayisi / GrafikYuksekligi;
                double OlcekX = 1.5;
                int X_kaydirma = 10;
                for (int x = 0; x <= 255; x++)
                {
                    if (x % 50 == 0)
                        CizimAlani.DrawLine(Kalem2, (int)(X_kaydirma + x * OlcekX), GrafikYuksekligi, (int)(X_kaydirma + x * OlcekX), 0);
                    CizimAlani.DrawLine(Kalem1, (int)(X_kaydirma + x * OlcekX), GrafikYuksekligi, (int)(X_kaydirma + x * OlcekX), (GrafikYuksekligi - (int)(DiziPikselSayilari[x] / OlcekY)));


                }
                textBox1.Text = "Maks.Piks=" + RenkMaksPikselSayisi.ToString();
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void rgbdebYUVaButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color renk, yuvRenk;
                Bitmap girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                Bitmap yeniResim = new Bitmap(resimGenisligi, resimYuksekligi);
                int griDeger = 0;
                for (int x = 0; x < resimGenisligi; x++)
                {
                    for (int y = 0; y < resimYuksekligi; y++)
                    {
                        renk = girisResmi.GetPixel(x, y);
                        double R = renk.R;
                        double G = renk.G;
                        double B = renk.B;
                        double Y = R * 0.3 + G * 0.6 + B * 0.1;
                        double U = (0.4 * (B - Y)) / (1 - 0.4);
                        double V = 0.6 * (R - Y) / (1 - 0.3);

                        if (Y > 255)
                            Y = 255;
                        if (U > 255)
                            U = 255;
                        if (V > 255)
                            V = 255;
                        if (Y < 0)
                            Y = 0;
                        if (U < 0)
                            U = 0;
                        if (V < 0)
                            V = 0;
                        griDeger = Convert.ToInt32(R + G * (0.4 * (B - y)));
                        yuvRenk = Color.FromArgb((int)Y, (int)U, (int)V);
                        yeniResim.SetPixel(x, y, yuvRenk);
                    }
                }
                pictureBox2.Image = yeniResim;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void rgbdenCMYyeButonu_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Color renk, yuvRenk;
                Bitmap girisResmi = new Bitmap(pictureBox1.Image);
                int resimGenisligi = girisResmi.Width;
                int resimYuksekligi = girisResmi.Height;
                Bitmap yeniResim = new Bitmap(resimGenisligi, resimYuksekligi);
                int griDeger = 0;
                for (int x = 0; x < resimGenisligi; x++)
                {
                    for (int y = 0; y < resimYuksekligi; y++)
                    {
                        renk = girisResmi.GetPixel(x, y);
                        double R = (double)renk.R / 255;
                        double G = (double)renk.G / 255;
                        double B = (double)renk.B / 255;
                        double tut = (double)R;
                        if (tut < G)
                            tut = G;
                        if (tut < B)
                            tut = B;

                        double K = 1 - (double)tut;

                        double C = (1 - (double)R - (double)K) / (1 - (double)K);
                        double M = (1 - (double)G - (double)K) / (1 - (double)K);
                        double Y = (1 - (double)B - (double)K) / (1 - (double)K);

                        if (C >= 0.7)
                            C = 255;
                        if (M >= 0.7)
                            M = 255;
                        if (M >= 0.7)
                            M = 255;
                        if (C <= 0.7)
                            C = 0;
                        if (M <= 0.7)
                            M = 0;
                        if (M <= 0.7)
                            M = 0;

                        yuvRenk = Color.FromArgb((int)C, (int)M, (int)Y);
                        yeniResim.SetPixel(x, y, yuvRenk);
                    }
                }
                pictureBox2.Image = yeniResim;
            }
            else
                MessageBox.Show("Picturebox içerisinde resim bulunmamakta!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}