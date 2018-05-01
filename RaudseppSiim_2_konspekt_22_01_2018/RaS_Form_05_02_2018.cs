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
    public partial class RaS_Form_05_02_2018 : Form
    {
        Image cardFull = Properties.Resources.cards;
        List<Image> cards = new List<Image>();
        PictureBox[] picMas = new PictureBox[65];
        int mast, vaartus;
        bool Selected = false;
        string[] masMast = { "Ärtu", "Ruutu", "Risti", "Poti", "Muu" };
        string[] masVaartus = { "Äss", "Kaks", "Kolm", "Neli", "Viis", "Kuus", "Seitse","Kaheksa","Üheksa",
        "Kümme", "Soldat", "Emand", "Kuningas"};
        
        public RaS_Form_05_02_2018()
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
                    Bitmap bitmap = new Bitmap(cardFull, cardFull.Width, cardFull.Height);

                    Bitmap crop = bitmap.Clone(new Rectangle(x * j, y * i, x, y), bitmap.PixelFormat);
                    cards.Add(crop);

                }
            }

        }
        private void CreatePictureBox()
        {
            int x = (RaS_CardHold.Width) / 13;
            int y = (RaS_CardHold.Height) / 4;
            int i = 0;
            int j = 0;
            int currentBox = 0;

            foreach (Image card in cards)
            {

                picMas[currentBox] = new PictureBox();
                RaS_CardHold.Controls.Add(picMas[currentBox]);
                picMas[currentBox].Width = x;
                picMas[currentBox].Height = y;
                picMas[currentBox].Top = y * j;
                picMas[currentBox].Left = x * i;
                picMas[currentBox].BackColor = Color.LightPink;
                picMas[currentBox].BackgroundImageLayout = ImageLayout.Stretch;
                picMas[currentBox].BorderStyle = BorderStyle.FixedSingle;
                picMas[currentBox].BackgroundImage = card;
                
                picMas[currentBox].Tag = masMast[j] + masVaartus[i];



                currentBox++;
                i++;
                if (i % 13 < 1)
                {
                    j++;
                    i = 0;
                }
            }
        }

        

        private void RaS_Form_05_02_2018_Load(object sender, EventArgs e)
        {
            CutOutPic();
            CreatePictureBox();
            RaS_Mast.Items.Clear();
            for (int i = 0; i < masMast.Length; i++) RaS_Mast.Items.Add(masMast[i]);
            RaS_Vaartus.Items.Clear();
            for (int i = 0; i < masVaartus.Length; i++) RaS_Vaartus.Items.Add(masVaartus[i]);
        }

        private void RaS_Mast_SelectedIndexChanged(object sender, EventArgs e)
        {
            mast = RaS_Mast.SelectedIndex;
            Selected = true;
            if (Selected == true)
            {
                RaS_Output.BackgroundImage = picMas[((mast * 13) + vaartus)].BackgroundImage;
            }
        }

        private void RaS_Vaartus_SelectedIndexChanged(object sender, EventArgs e)
        {

            vaartus = RaS_Vaartus.SelectedIndex;
            Selected = true;
            if (Selected == true)
            {
                RaS_Output.BackgroundImage = picMas[((mast * 13) + vaartus)].BackgroundImage;
            }
        }
    }
}
