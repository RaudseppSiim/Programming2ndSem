using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaudseppSiim_2_konspekt_22_01_2018
{
    public partial class RaS_Form_12_02_2018 : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        ColorDialog RaS_Background = new ColorDialog();
        SaveFileDialog saveFile = new SaveFileDialog();
        List<Image> picmas = new List<Image>();
        List<string> filename = new List<string>();
        string savePath = "";
        public RaS_Form_12_02_2018()
        {
            InitializeComponent();
        }
        

        private void RaS_SourceBut_Click(object sender, EventArgs e)
        {
            openFile.Title = "Kaust piltidega";
            openFile.Multiselect = true;
            openFile.Filter = "Image (*.png;*.bmp;*.jpeg;*.jpg)|*.png;*.bmp;*.jpeg;*.jpg|All files(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
                {
                    RaS_Source.Text = openFile.FileName;
                    foreach(string file in openFile.FileNames)
                    {
                        filename.Add(file);
                    }
                    foreach (string file in openFile.SafeFileNames)
                    {
                    RaS_List.Items.Add(file);
                    }


            }

        }

        private void RaS_OutputBut_Click(object sender, EventArgs e)
        {
           
            saveFile.Title = "Kuhu salvestada";
            saveFile.Filter = "Image (*.png;*.bmp;*.jpeg;*.jpg)|*.png;*.bmp;*.jpeg;*.jpg|All files(*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                savePath = saveFile.FileName;
                RaS_Output.Text = savePath;
                
            }

        }

        private void RaS_Go_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < RaS_List.SelectedItems.Count; i++)
            {
                picmas.Add(Image.FromFile(filename[RaS_List.SelectedIndices[i]]));
                
            }

            int num_images = picmas.Count();
            int max_wid = 0;
            int max_hgt = 0;
            for (int i = 0; i < num_images; i++)
            {
                if (max_wid < picmas[i].Width) max_wid = picmas[i].Width;
                if (max_hgt < picmas[i].Height) max_hgt = picmas[i].Height;
            }

            // Make the result bitmap.
            int margin = int.Parse(RaS_Margin.Text);
            int num_cols = int.Parse(RaS_Column.Text);
            int num_rows = (int)Math.Ceiling(num_images / (float)num_cols);
            int wid = max_wid * num_cols + margin * (num_cols - 1);
            int hgt = max_hgt * num_rows + margin * (num_rows - 1);
            Bitmap bm = new Bitmap(wid, hgt);

            // Place the images on it.
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.Clear(RaS_Color.BackColor);

                int x = 0;
                int y = 0;
                for (int i = 0; i < num_images; i++)
                {
                    gr.DrawImage(picmas[i], x, y);
                    x += max_wid + margin;
                    if (x >= wid)
                    {
                        y += max_hgt + margin;
                        x = 0;
                    }
                }
            }
            pictureBox1.BackgroundImage = null;
            pictureBox1.BackgroundImage = bm;

            if(savePath == "")
            {
                savePath = Application.StartupPath + @"\Combined.jpg";
            }

            SaveImage(bm, savePath);

        }
        public void SaveImage(Image image, string filename)
        {
            
            string extension = Path.GetExtension(filename);
            switch (extension.ToLower())
            {
                case ".bmp":
                    image.Save(filename, ImageFormat.Bmp);
                    break;
                case ".exif":
                    image.Save(filename, ImageFormat.Exif);
                    break;
                case ".gif":
                    image.Save(filename, ImageFormat.Gif);
                    break;
                case ".jpg":
                case ".jpeg":
                    image.Save(filename, ImageFormat.Jpeg);
                    break;
                case ".png":
                    image.Save(filename, ImageFormat.Png);
                    break;
                case ".tif":
                case ".tiff":
                    image.Save(filename, ImageFormat.Tiff);
                    break;
                default:
                    throw new NotSupportedException(
                        "Unknown file extension " + extension);
            }
        }

        private void RaS_Color_Click(object sender, EventArgs e)
        {
            
            RaS_Background.Color = RaS_Color.BackColor;
            if (RaS_Background.ShowDialog() == DialogResult.OK)
                RaS_Color.BackColor = RaS_Background.Color;
        }
    }
}
