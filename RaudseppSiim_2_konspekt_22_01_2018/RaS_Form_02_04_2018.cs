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
    public partial class RaS_Form_02_04_2018 : Form
    {
        int[,] joon = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };
        int w, h,times = 0;
        string user;
        int joonenumber;
        List<Button> buttons = new List<Button>();
        
        public RaS_Form_02_04_2018()
        {
            InitializeComponent();
            w = RaS_TicTacToe.Width;
            h = RaS_TicTacToe.Height;
        }

        private void RaS_Form_02_04_2018_Load(object sender, EventArgs e)
        {
            int dx = w / 3;
            int dy = h / 3;
            int counter = 1;
            Font font = new Font("Arial", 24, FontStyle.Bold);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = new Button();
                    RaS_TicTacToe.Controls.Add(button);
                    button.BackColor = Color.Gray;
                    button.Width = dx;
                    button.Height = dy;
                    button.Font = font;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Left = dx * j;
                    button.Top = dy * i;
                    button.Tag = counter.ToString();
                    button.Click += TTT_but_Click;
                    counter++;
                    buttons.Add(button);
                }
            }
            //012
            //345
            //678
            //^ button grid
        }
        private void TTT_but_Click(object sender, EventArgs e)
        {
            Button but = sender as Button;
            
            if (RaS_AI.Checked == false && times > 0)
            {
                if (user == "X" && but.Text == "")
                {
                    user = "O";
                    
                }
                else if (user == "O" && but.Text == "")
                {
                    user = "X";
                    
                }
            }

            if (but.Text == "")
            but.Text = user;
            times++;
            if(RaS_AI.Checked == true)
                AI();
           
            if (WinYaes(user) == true)
            {
                RaS_Win.Text = "Võitis " + user;
                foreach(Button butskur in buttons)
                {
                   
                    butskur.Enabled = false;
                }
                return;
            }
            if (TieYaes() == true)
            {
                RaS_Win.Text = "Viik";
                foreach (Button butskur in buttons)
                {
                    butskur.Enabled = false;
                }
                return;
            }

        }

        private void RaS_O_CheckedChanged(object sender, EventArgs e)
        {
            if (RaS_O.Checked == true)
                user = "O";
            
            
        }

        private void RaS_X_CheckedChanged(object sender, EventArgs e)
        {
            if (RaS_X.Checked == true)
                user = "X";
            
            
        }

        private void Ras_New_Game_Click(object sender, EventArgs e)
        {
            foreach(Button but in buttons)
            {
                but.Text = "";
                but.BackColor = Color.Gray;
                but.Enabled = true;
            }
            if (RaS_X.Checked == true)
                user = "X";
            if (RaS_O.Checked == true)
                user = "O";
            times = 0;
            RaS_Win.Text = "";
        }

        private bool WinYaes(string player)
        {
            if (buttons[0].Text == player && buttons[2].Text == player && buttons[1].Text == player)
            {
                buttons[0].BackColor = Color.Red;
                buttons[1].BackColor = Color.Red;
                buttons[2].BackColor = Color.Red;
                return true;
            }
            if (buttons[3].Text == player && buttons[4].Text ==player && buttons[5].Text==player)
            {
                buttons[3].BackColor = Color.Red;
                buttons[4].BackColor = Color.Red;
                buttons[5].BackColor = Color.Red;
                return true;
            }
            if (buttons[6].Text == player && buttons[7].Text == player && buttons[8].Text == player)
            {
                buttons[6].BackColor = Color.Red;
                buttons[7].BackColor = Color.Red;
                buttons[8].BackColor = Color.Red;
                return true;
            }
            if (buttons[0].Text == player && buttons[3].Text == player && buttons[6].Text == player)
            {
                buttons[0].BackColor = Color.Red;
                buttons[3].BackColor = Color.Red;
                buttons[6].BackColor = Color.Red;
                return true;
            }
            if (buttons[1].Text == player && buttons[4].Text == player && buttons[7].Text == player)
            {
                buttons[1].BackColor = Color.Red;
                buttons[4].BackColor = Color.Red;
                buttons[7].BackColor = Color.Red;
                return true;
            }
            if (buttons[2].Text == player && buttons[5].Text == player && buttons[8].Text == player)
            {
                buttons[2].BackColor = Color.Red;
                buttons[5].BackColor = Color.Red;
                buttons[8].BackColor = Color.Red;
                return true;
            }
            if (buttons[0].Text == player && buttons[4].Text ==player && buttons[8].Text == player)
            {
                buttons[0].BackColor = Color.Red;
                buttons[4].BackColor = Color.Red;
                buttons[8].BackColor = Color.Red;
                return true;
            }
            if (buttons[2].Text == player && buttons[4].Text == player && buttons[6].Text == player)
            {
                buttons[2].BackColor = Color.Red;
                buttons[4].BackColor = Color.Red;
                buttons[6].BackColor = Color.Red;
                return true;
            }

            else
            return false;
        }
        private int ControlForAI(string t)
        {
            int i, i0, i1, i2;
            for (joonenumber = 0; joonenumber < 8; joonenumber++)
            {
                i0 = joon[joonenumber, 0];
                i1 = joon[joonenumber, 1];
                i2 = joon[joonenumber, 2];
                if (t[i0] == 'X' && t[i1] == 'X' && t[i2] == 'X') return -1;
                if (t[i0] == 'O' && t[i1] == 'O' && t[i2] == 'O') return 1;
            }
            for (i = 0; i < 9; i++)
                if (buttons[i].Text == "") return 0;

            return 10;
        }
        private bool TieYaes()
        {
            sbyte everyBut = 0;
            
            foreach(Button but in buttons)
            {
                if(but.Text != "")
                {
                    everyBut++;
                }
            }
            if (everyBut == 9)
                return true;
            else
                return false;
        }

        private void RaS_AI_CheckedChanged(object sender, EventArgs e)
        {
            if(RaS_AI.Checked == true)
            {
                RaS_Tasemed.Visible = true;
            }
            else
            {
                RaS_Tasemed.Visible = false;
            }
        }

        private void AI()
        {
            string player="X";
            int bestPlace = 0;
            string AIsign = "O";
            if (RaS_X.Checked == true)
            {
                AIsign = "O";
                player = "X";
            }
            if (RaS_O.Checked == true)
            { 
                AIsign = "X";
                player = "O";
            }
            string t1 = "";
            for (int i = 0; i < 9; i++)
            {
                if (buttons[i].Text == "") t1 += " ";
                else
                    t1 += buttons[i].Text;
            }

            
            if (RaS_Tase1.Checked == true && WinYaes(AIsign) == false)
                bestPlace = TheBestMoveTase1(AIsign);

            if (RaS_Tase2.Checked == true && WinYaes(AIsign) == false)
                bestPlace = TheBestMoveTase2(AIsign,player);

            if (RaS_Tase3.Checked == true && WinYaes(AIsign) == false)
            {       
                    bestPlace = TheBestMoveTase3(AIsign, player,t1);
            }
            if (RaS_Tase4.Checked == true && WinYaes(AIsign) == false)
            {
                bestPlace = TheBestMoveTase4(AIsign, player, t1);
            }

            if (WinYaes(AIsign) == true || WinYaes(user) == true)
            {
                RaS_Win.Text = "Võitis Arvuti " + AIsign;
                foreach (Button butskur in buttons)
                {

                    butskur.Enabled = false;
                }
                return;
            }

            if (TieYaes() == true)
            {
                RaS_Win.Text = "Viik";
                foreach (Button butskur in buttons)
                {
                    butskur.Enabled = false;
                }
                return;
            }

            if (bestPlace != 10)
                buttons[bestPlace].Text = AIsign;
            else
                return;
        }
        
        private int TheBestMoveTase1(string AIsign)
        {
            int ok;
            Random rand = new Random();
            ok = rand.Next(0, 8);
            if (WinYaes(AIsign) == false && WinYaes(user) == false)
            {
                while (buttons[ok].Text != "")
                {
                    ok = rand.Next(0, 8);
                }
                return ok;
            }
            else
                return 10;
        }
        private int TheBestMoveTase2(string AiSign,string player)
        {
            Random rand = new Random();
            int m1 = 0;
            int[] mas1 = new int[9];
            for (int i = 0; i < 9; i++) if (buttons[i].Text == "") { mas1[m1] = i; m1++; };
            int koh = -1;
            for (int i1 = 0; i1 < m1; i1++)
            {
                int j = mas1[i1];
                string t1 = "";
                for (int i = 0; i < 9; i++)
                {
                    if (i == j) t1 += AiSign;
                    if (buttons[i].Text == "") t1 += " ";
                    else t1 += buttons[i].Text;
                }
                int kk = ControlForAI(t1);
                if (kk == 1) return j;
                if (m1 > 1)
                {
                    int m2 = 0;
                    int[] mas2 = new int[9];
                    for (int i = 0; i < 9; i++) if (buttons[i].Text == "") { mas2[m2] = i; m2++; };
                    for (int i2 = 0; i2 < m2; i2++)
                    {
                        j = mas2[i2];
                        string t2 = "";
                        for (int i = 0; i < 9; i++)
                        {
                            if (i == j) t2 += player;
                            if (buttons[i].Text == "") t2 += " ";
                            else t2 += buttons[i].Text;
                        }
                        kk = ControlForAI(t2);
                        if (kk == -1) mas1[i1] = -100;
                    }
                }
            }
            int mm = 0;
            for (int i1 = 0; i1 < m1; i1++) if (mas1[i1] >= 0) mas1[mm++] = mas1[i1];
            m1 = mm;
            if (m1 == 0)
                for (int i = 0; i < 9; i++) if (buttons[i].Text == "") mas1[m1++] = i;
            int k = rand.Next(m1);
            koh = mas1[k];
            return koh;
        }
        private int TheBestMoveTase3(string AiSign, string player,string tt)
        {
            char mark;
            
            int tase = 3;
            
            int i;
            string[] ttt = new string[tase + 1];
            int[] iii = new int[tase + 1];
            int[] kkk = new int[tase + 1];
            ttt[0] = tt;
            for (i = 0; i < 9; i++) if (tt[i] == ' ') break;
            iii[0] = i - 1;
            int vvv = i;
            int tasenumber = 0;

            do
            {
                string t = ttt[tasenumber];
                int n = iii[tasenumber]+1;
                for (i = n; i < 9; i++) if (t[i] == ' ') break;
                if(i<9)
                {
                    if (tasenumber % 2 == 0) mark = AiSign[0]; else mark = player[0];
                    string tttt = "";
                    for (int j = 0; j < 9; j++)
                        if (j == i) tttt += mark; else tttt += t[j];
                    int k = ControlForAI(tttt);
                    if (tasenumber % 2 == 0 && k >= kkk[tasenumber]) kkk[tasenumber] = k;
                    if (tasenumber % 2 == 1 && k <= kkk[tasenumber]) kkk[tasenumber] = k;
                    iii[tasenumber] = i;

                    if(tasenumber<tase)
                    {
                        tasenumber++;
                        ttt[tasenumber] = tttt;
                        iii[tasenumber] = -1;
                        if (tasenumber % 2 == 0) kkk[tasenumber] = -100; else kkk[tasenumber] = 100;

                    }

                }
                else
                {
                    if(tasenumber>0)
                    {
                        if (tasenumber % 2 == 0 && kkk[tasenumber] < kkk[tasenumber - 1]) kkk[tasenumber - 1] = kkk[tasenumber];
                        if(tasenumber % 2 == 1 && kkk[tasenumber] >= kkk[tasenumber-1])
                        {
                            kkk[tasenumber - 1] = kkk[tasenumber];
                            if (tasenumber == 1) vvv = iii[0];
                        }

                    }
                    tasenumber--;
                }
            } while (tasenumber >= 0);
            return vvv;
        }
        private int TheBestMoveTase4(string AiSign, string player, string tt)
        {
            char mark;

            int tase = 4;
            int i;
            string[] ttt = new string[tase + 1];
            int[] iii = new int[tase + 1];
            int[] kkk = new int[tase + 1];
            ttt[0] = tt;
            for (i = 0; i < 9; i++) if (tt[i] == ' ') break;
            int vvv = i;
            iii[0] = i - 1;
            int tasenumber = 0;

            do
            {
                string t = ttt[tasenumber];
                int n = iii[tasenumber] + 1;
                for (i = n; i < 9; i++) if (t[i] == ' ') break;
                if (i < 9)
                {
                    if (tasenumber % 2 == 0) mark = AiSign[0]; else mark = player[0];
                    string tttt = "";
                    for (int j = 0; j < 9; j++)
                        if (j == i) tttt += mark; else tttt += t[j];
                    int k = ControlForAI(tttt);
                    if (tasenumber % 2 == 0 && k >= kkk[tasenumber]) kkk[tasenumber] = k;
                    if (tasenumber % 2 == 1 && k <= kkk[tasenumber]) kkk[tasenumber] = k;
                    iii[tasenumber] = i;

                    if (tasenumber < tase)
                    {
                        tasenumber++;
                        ttt[tasenumber] = tttt;
                        iii[tasenumber] = -1;
                        if (tasenumber % 2 == 0) kkk[tasenumber] = -100; else kkk[tasenumber] = 100;

                    }

                }
                else
                {
                    if (tasenumber > 0)
                    {
                        if (tasenumber % 2 == 0 && kkk[tasenumber] < kkk[tasenumber - 1]) kkk[tasenumber - 1] = kkk[tasenumber];
                        if (tasenumber % 2 == 1 && kkk[tasenumber] >= kkk[tasenumber - 1])
                        {
                            kkk[tasenumber - 1] = kkk[tasenumber];
                            if (tasenumber == 1) vvv = iii[0];
                        }
                    }
                    tasenumber--;
                }
            } while (tasenumber >= 0);
            return vvv;
        }
    }
}
