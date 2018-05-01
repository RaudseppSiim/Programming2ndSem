using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaudseppSiim_2_konspekt_22_01_2018
{
    public partial class RaS_Form_22_01_2018 : Form
    {
        Image cardFull = Properties.Resources.cards;
        List<Image> cards = new List<Image>();
        PictureBox[] picMas = new PictureBox[65];
        List<int> angleMas = new List<int>();
        List<Image> rotatepic = new List<Image>();
        List<PictureBox> whatRotate = new List<PictureBox>();
        string[] masMast = { "Ärtu", "Ruutu", "Risti", "Poti", "Muu" };
        string[] masVaartus = { "Äss", "Üks", "Kaks", "Kolm", "Neli", "Viis", "Kuus", "Seitse","Kaheksa","Üheksa",
        "Kümme", "Soldat", "Emand", "Kuningas"};
        int angleEdit = 0;
        public RaS_Form_22_01_2018()
        {
            InitializeComponent();
           
        }
        
        private void CutOutPic()
        {
            int x = cardFull.Width / 13;
            int y = cardFull.Height / 5;
            

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Bitmap bitmap = new Bitmap(cardFull,cardFull.Width, cardFull.Height);
                    
                    Bitmap crop = bitmap.Clone(new Rectangle(x * j, y * i, x, y), bitmap.PixelFormat);
                    cards.Add(crop);
                    
                }
            }
            
        }
        private void CreatePictureBox()
        {
            
            int x = (RaS_Cards.Width+20) / 13;
            int y = (RaS_Cards.Height) / 4;
            int i = 0;
            int j = 0;
            int currentBox = 0;

            foreach (Image card in cards)
            {
                int diagonaal = (int)Math.Sqrt(Math.Pow(card.Width, 2) + Math.Pow(card.Height, 2));
                Bitmap pilt = new Bitmap(diagonaal, diagonaal);
                int xpilt = (diagonaal - card.Width) / 2;
                int ypilt = (diagonaal - card.Height) / 2;
                using (Graphics gfx = Graphics.FromImage(pilt))
                {
                    gfx.DrawImage(card, xpilt, ypilt);
                }

                picMas[currentBox] = new PictureBox();
                RaS_Cards.Controls.Add(picMas[currentBox]);
                picMas[currentBox].Width = x;
                picMas[currentBox].Height = y;
                picMas[currentBox].Top = y * j;
                picMas[currentBox].Left = x * i;
                picMas[currentBox].BackColor = Color.LightPink;
                picMas[currentBox].BackgroundImageLayout = ImageLayout.Stretch;
                picMas[currentBox].BorderStyle = BorderStyle.FixedSingle;
                picMas[currentBox].BackgroundImage = pilt;
                picMas[currentBox].MouseClick += Picture_Click;
                picMas[currentBox].Tag = masMast[j] + masVaartus[i];

                
                
                currentBox++;
                i++;
                if(i%13 < 1)
                {
                    j++;
                    i = 0;
                }
            }
            

        }

        private void RaS_Form_22_01_2018_Load(object sender, EventArgs e)
        {
            CutOutPic();
            CreatePictureBox();
        }
       
        public void Picture_Click(object sender, EventArgs e)
        {
                
            //RaS_Input.Image = ((PictureBox)sender).BackgroundImage;
            //RaS_Output.Image = ((PictureBox)sender).BackgroundImage;


            int diagonaal = (int)Math.Sqrt(Math.Pow((sender as PictureBox).BackgroundImage.Width, 2) + Math.Pow((sender as PictureBox).BackgroundImage.Height, 2));
            Bitmap pilt = new Bitmap(diagonaal, diagonaal);
            int x = (diagonaal - (sender as PictureBox).BackgroundImage.Width) / 2;
            int y = (diagonaal - (sender as PictureBox).BackgroundImage.Height) / 2;
            using (Graphics gfx = Graphics.FromImage(pilt))
            {
                gfx.DrawImage((sender as PictureBox).BackgroundImage, x, y);
            }
            angleEdit = 0;
            RaS_Input.BackgroundImage = pilt;
            RaS_Output.BackgroundImage = pilt;
            if (whatRotate.Contains(sender as PictureBox)==false)
            {
                rotatepic.Add(pilt);
                angleMas.Add(0);
                whatRotate.Add((sender as PictureBox));
            }
            else if(whatRotate.Contains(sender as PictureBox)==true)
            {
                int k = whatRotate.IndexOf(sender as PictureBox);
                
                angleMas.RemoveAt(k);
                (sender as PictureBox).BackgroundImage = rotatepic[k];
                rotatepic.RemoveAt(k);
                whatRotate.RemoveAt(k);

            }
        }

        private void RaS_Rotate_Click(object sender, EventArgs e)
        {
            
            RaS_Output.BackgroundImage = RotateImage(RaS_Input.BackgroundImage, 0+angleEdit);
            angleEdit += 20;
        }
        public Image RotateImage(Image img, float rotationAngle)
        {
            
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
            gfx.RotateTransform(rotationAngle);
            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.DrawImage(img, new Point(0, 0));
            gfx.Dispose();
            return bmp;
        }

        private void RaS_Timer_Tick(object sender, EventArgs e)
        {
            angleEdit += 20;
            RaS_Output.BackgroundImage = RotateImage(RaS_Input.BackgroundImage, 0+angleEdit);
            if (whatRotate.Count > 0)
            {
                for (int i = 0; i < whatRotate.Count; i++)
                {

                    whatRotate[i].BackgroundImage = RotateImage(rotatepic[i], angleMas[i]);
                    angleMas[i] += 15;

                }
            }
        }

        private void RaS_TimerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(RaS_TimerCheck.Checked == true)
            {
                RaS_Timer.Start();
            }
            if(RaS_TimerCheck.Checked == false)
            {
                RaS_Timer.Stop();
            }
        }
    }

}

