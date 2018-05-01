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
    public partial class Form1 : Form
    {
        Form F1 = new RaS_Form_22_01_2018();
        Form F2 = new RaS_Form_05_02_2018();
        Form F3 = new RaS_Form_12_02_2018();
        Form F4 = new RaS_Form_19_02_2018();
        Form F5 = new RaS_Form_05_03_2018();
        Form F6 = new RaS_Form_19_03_2018();
        Form F7 = new RaS_Form_02_04_2018();
        public Form1()
        {
            InitializeComponent();
        }

        private void RaS_22_01_2018_Click(object sender, EventArgs e)
        {
            if (F1.Visible == false) F1 = new RaS_Form_22_01_2018();
            F1.Visible = true;
            F1.Activate();
        }

        private void RaS_05_02_2018_Click(object sender, EventArgs e)
        {
            if (F2.Visible == false) F2 = new RaS_Form_05_02_2018();
            F2.Visible = true;
            F2.Activate();
        }

        private void RaS_12_02_2018_Click(object sender, EventArgs e)
        {
            if (F3.Visible == false) F3 = new RaS_Form_12_02_2018();
            F3.Visible = true;
            F3.Activate();
        }

        private void RaS_19_02_2018_Click(object sender, EventArgs e)
        {
            if (F4.Visible == false) F4 = new RaS_Form_19_02_2018();
            F4.Visible = true;
            F4.Activate();

        }

        private void RaS_05_03_2018_Click(object sender, EventArgs e)
        {
            if (F5.Visible == false) F5 = new RaS_Form_05_03_2018();
            F5.Visible = true;
            F5.Activate();
        }

        private void RaS_19_03_2018_Click(object sender, EventArgs e)
        {
            if (F6.Visible == false) F6 = new RaS_Form_19_03_2018();
            F6.Visible = true;
            F6.Activate();
        }

        private void RaS_02_04_2018_Click(object sender, EventArgs e)
        {
            if (F7.Visible == false) F7 = new RaS_Form_02_04_2018();
            F7.Visible = true;
            F7.Activate();

        }
    }
}
