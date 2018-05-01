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
    public partial class RaS_Form_05_03_2018 : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        List<Bitmap> slice = new List<Bitmap>(); 
        Image image;
        Pen pen = new Pen(Color.Black);
        Bitmap bm;
      
        int current = 0;
        public RaS_Form_05_03_2018()
        {
            InitializeComponent();
        }

        private void RaS_Vali_Planeet_Click(object sender, EventArgs e)
        {
            openFile.Title = "Kaust piltidega";
            openFile.Filter = "Image (*.png;*.bmp;*.jpeg;*.jpg;*.gif)|*.png;*.bmp;*.jpeg;*.jpg;*.gif|All files(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                image = Image.FromFile(openFile.FileName);
                bm = new Bitmap(image.Width*2,image.Height);
                
                using(Graphics gfx = Graphics.FromImage(bm))
                {
                    gfx.DrawImage(image, 0, 0,image.Width,image.Height);
                    gfx.DrawImage(image, image.Width,0,image.Width, image.Height);
                    
                }
                RaS_Map.BackgroundImage = bm;
                RaS_LoePlaneet.Enabled = true;
                keerutaPlaneetiToolStripMenuItem.Enabled = true;

            }
        }

        private void RaS_LoePlaneet_Click(object sender, EventArgs e)
        {
            int lineHeight = bm.Height;
            for (int i = 0; i < bm.Width/2; i+=40)
            {
                Bitmap bm2 = new Bitmap(RaS_Map.Width,RaS_Map.Height);
                Rectangle rect = new Rectangle(i,0,lineHeight,lineHeight);
                bm2 = bm.Clone(rect, bm.PixelFormat);
                using (Graphics gfx = Graphics.FromHwnd(RaS_Map.Handle))
                {
                    gfx.DrawRectangle(pen, rect);
                }
                    slice.Add(bm2);
            

            }
        }

        private void keerutaPlaneetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaS_Timer.Start();
        }

        private void RaS_Timer_Tick(object sender, EventArgs e)
        {
            if(current >= slice.Count)
            {
                current = 0;
            }
            RaS_World.BackgroundImage = null;
            RaS_World.BackgroundImage = drawEllips(slice[current]);
            current++;
        }
        private Bitmap drawEllips(Bitmap bm2)
        {
            Bitmap bm3 = new Bitmap(bm2.Width, bm2.Height);
            float a = bm2.Width / 2;
            float b = bm2.Height / 2;
            for (int y = 0; y < bm2.Height; y++)
            {
                int yy = (int)b - y;
                int xx = (int)bm2.Width / (int)b * (int)Math.Sqrt((b * b) - (yy * yy));
                for (int x = 0; x < xx; x++)
                {

                    int xxx = x * bm2.Width / (int)xx;
                    int dx = (bm2.Width - (int)xx) / 2;
                    Color c = bm2.GetPixel((int)xxx, y);
                    bm3.SetPixel(dx + x, y, c);
                }
            }

            return bm3;
        }

        private void RaS_Speed_Scroll(object sender, ScrollEventArgs e)
        {
            RaS_Timer.Interval = RaS_Speed.Value;
        }
    }
}
