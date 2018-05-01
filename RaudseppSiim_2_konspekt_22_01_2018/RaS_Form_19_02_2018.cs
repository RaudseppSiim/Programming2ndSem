using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaudseppSiim_2_konspekt_22_01_2018
{
    public partial class RaS_Form_19_02_2018 : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        Image image;
        Bitmap bm;
        
        public RaS_Form_19_02_2018()
        {
            InitializeComponent();
        }

        private void valiPiltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.Title = "Kaust piltidega";
            openFile.Filter = "Image (*.png;*.bmp;*.jpeg;*.jpg;*.gif)|*.png;*.bmp;*.jpeg;*.jpg;*.gif|All files(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                image = Image.FromFile(openFile.FileName);
                bm = new Bitmap(image);
                RaS_Pic1.BackgroundImage = bm;
                kolmnurkToolStripMenuItem.Enabled = true;
                rombToolStripMenuItem.Enabled = true;
                ellipsToolStripMenuItem.Enabled = true;
                

            }

        }

        private void kolmnurkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bm2 = new Bitmap(bm.Width,bm.Height);
            for (int y = 0; y < bm.Height; y++)
            {
                int width = (int)((float)y * bm.Width / bm.Height);
                int dx = (bm.Width - width) / 2 ;
                for (int x = 0; x < width; x++)
                {
                    int xx = (int)((float)x * bm.Width / width);
                    Color c = bm.GetPixel(xx, y);
                    bm2.SetPixel(dx + x, y, c);
                }
            }

            RaS_Pic2.BackgroundImage = bm2;
        }

        private void rombToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bm2 = new Bitmap(bm.Width, bm.Height);
            float aspect = bm.Width / bm.Height;
            float w = 0;

            for (int y = 0; y < bm.Height; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    int xx = x * bm.Width / (int)w;
                    int dx = (bm.Width - (int)w) / 2;
                    Color c = bm.GetPixel(xx, y);
                    bm2.SetPixel(dx + x, y, c);
                }
                w += aspect * y >= bm.Height / 2 ? -2 : 2 ;
            }

            RaS_Pic2.BackgroundImage = bm2;
        }

        private void ellipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bm2 = new Bitmap(bm.Width, bm.Height);
            float a = bm.Width / 2;
            float b = bm.Height / 2;
            for (int y = 0; y < bm.Height; y++)
            {
                int yy = (int)b - y;
                int xx = (int)bm.Width / (int)b * (int)Math.Sqrt((b * b) - (yy * yy));
                for (int x = 0; x < xx; x++)
                {

                    int xxx = x * bm.Width / (int)xx;
                    int dx = (bm.Width - (int)xx) / 2;
                    Color c = bm.GetPixel((int)xxx, y);
                    bm2.SetPixel(dx+x, y, c);
                }
            }

            RaS_Pic2.BackgroundImage = bm2;
        }
    }
}
