using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace minel_selvi
{
    public partial class Form5 : Form
    {
        Bitmap kaynak, islem;
        public Form5()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Görüntüler|*.jpg;*.png";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dik = kaynak.Height;
            int en = kaynak.Width;
            islem = new Bitmap(en, dik);
            for (int y = 0; y < dik; y++)
            {
                for (int x = 0; x < en; x++)
                {
                    Color normal = kaynak.GetPixel(x, y);
                    int max = Math.Max(normal.R, normal.G);
                    int finishmax = Math.Max(max, normal.B);
                    int min = Math.Min(normal.R, normal.G);
                    int finishmin = Math.Min(min, normal.B);
                    int sonuc = (finishmax + finishmin) / 2;
                    Color finishRenk = Color.FromArgb(sonuc, sonuc, sonuc);
                    islem.SetPixel(x, y, finishRenk);
                }

            }
            islemBox.Image = islem;
                }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            ImageFormat format = ImageFormat.Png;
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);

            }
        }
    }
}
