namespace RaudseppSiim_2_konspekt_22_01_2018
{
    partial class RaS_Form_02_04_2018
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
            this.RaS_TicTacToe = new System.Windows.Forms.Panel();
            this.RaS_Win = new System.Windows.Forms.Label();
            this.RaS_X = new System.Windows.Forms.RadioButton();
            this.RaS_O = new System.Windows.Forms.RadioButton();
            this.Ras_New_Game = new System.Windows.Forms.Button();
            this.RaS_AI = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RaS_Tasemed = new System.Windows.Forms.Panel();
            this.RaS_Tase4 = new System.Windows.Forms.RadioButton();
            this.RaS_Tase3 = new System.Windows.Forms.RadioButton();
            this.RaS_Tase2 = new System.Windows.Forms.RadioButton();
            this.RaS_Tase1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.RaS_Tasemed.SuspendLayout();
            this.SuspendLayout();
            // 
            // RaS_TicTacToe
            // 
            this.RaS_TicTacToe.Location = new System.Drawing.Point(146, 92);
            this.RaS_TicTacToe.Name = "RaS_TicTacToe";
            this.RaS_TicTacToe.Size = new System.Drawing.Size(289, 273);
            this.RaS_TicTacToe.TabIndex = 0;
            // 
            // RaS_Win
            // 
            this.RaS_Win.AutoSize = true;
            this.RaS_Win.Location = new System.Drawing.Point(102, 29);
            this.RaS_Win.Name = "RaS_Win";
            this.RaS_Win.Size = new System.Drawing.Size(0, 13);
            this.RaS_Win.TabIndex = 1;
            // 
            // RaS_X
            // 
            this.RaS_X.AutoSize = true;
            this.RaS_X.Location = new System.Drawing.Point(6, 3);
            this.RaS_X.Name = "RaS_X";
            this.RaS_X.Size = new System.Drawing.Size(32, 17);
            this.RaS_X.TabIndex = 2;
            this.RaS_X.Text = "X";
            this.RaS_X.UseVisualStyleBackColor = true;
            this.RaS_X.CheckedChanged += new System.EventHandler(this.RaS_X_CheckedChanged);
            // 
            // RaS_O
            // 
            this.RaS_O.AutoSize = true;
            this.RaS_O.Location = new System.Drawing.Point(67, 4);
            this.RaS_O.Name = "RaS_O";
            this.RaS_O.Size = new System.Drawing.Size(33, 17);
            this.RaS_O.TabIndex = 3;
            this.RaS_O.Text = "O";
            this.RaS_O.UseVisualStyleBackColor = true;
            this.RaS_O.CheckedChanged += new System.EventHandler(this.RaS_O_CheckedChanged);
            // 
            // Ras_New_Game
            // 
            this.Ras_New_Game.Location = new System.Drawing.Point(243, 54);
            this.Ras_New_Game.Name = "Ras_New_Game";
            this.Ras_New_Game.Size = new System.Drawing.Size(100, 20);
            this.Ras_New_Game.TabIndex = 4;
            this.Ras_New_Game.Text = "Uus Mäng";
            this.Ras_New_Game.UseVisualStyleBackColor = true;
            this.Ras_New_Game.Click += new System.EventHandler(this.Ras_New_Game_Click);
            // 
            // RaS_AI
            // 
            this.RaS_AI.AutoSize = true;
            this.RaS_AI.Location = new System.Drawing.Point(12, 107);
            this.RaS_AI.Name = "RaS_AI";
            this.RaS_AI.Size = new System.Drawing.Size(36, 17);
            this.RaS_AI.TabIndex = 5;
            this.RaS_AI.Text = "AI";
            this.RaS_AI.UseVisualStyleBackColor = true;
            this.RaS_AI.CheckedChanged += new System.EventHandler(this.RaS_AI_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RaS_X);
            this.panel1.Controls.Add(this.RaS_O);
            this.panel1.Location = new System.Drawing.Point(79, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 24);
            this.panel1.TabIndex = 6;
            // 
            // RaS_Tasemed
            // 
            this.RaS_Tasemed.Controls.Add(this.RaS_Tase4);
            this.RaS_Tasemed.Controls.Add(this.RaS_Tase3);
            this.RaS_Tasemed.Controls.Add(this.RaS_Tase2);
            this.RaS_Tasemed.Controls.Add(this.RaS_Tase1);
            this.RaS_Tasemed.Location = new System.Drawing.Point(12, 135);
            this.RaS_Tasemed.Name = "RaS_Tasemed";
            this.RaS_Tasemed.Size = new System.Drawing.Size(105, 136);
            this.RaS_Tasemed.TabIndex = 7;
            this.RaS_Tasemed.Visible = false;
            // 
            // RaS_Tase4
            // 
            this.RaS_Tase4.AutoSize = true;
            this.RaS_Tase4.Location = new System.Drawing.Point(13, 116);
            this.RaS_Tase4.Name = "RaS_Tase4";
            this.RaS_Tase4.Size = new System.Drawing.Size(58, 17);
            this.RaS_Tase4.TabIndex = 3;
            this.RaS_Tase4.TabStop = true;
            this.RaS_Tase4.Text = "Tase 4";
            this.RaS_Tase4.UseVisualStyleBackColor = true;
            // 
            // RaS_Tase3
            // 
            this.RaS_Tase3.AutoSize = true;
            this.RaS_Tase3.Location = new System.Drawing.Point(13, 80);
            this.RaS_Tase3.Name = "RaS_Tase3";
            this.RaS_Tase3.Size = new System.Drawing.Size(58, 17);
            this.RaS_Tase3.TabIndex = 2;
            this.RaS_Tase3.TabStop = true;
            this.RaS_Tase3.Text = "Tase 3";
            this.RaS_Tase3.UseVisualStyleBackColor = true;
            // 
            // RaS_Tase2
            // 
            this.RaS_Tase2.AutoSize = true;
            this.RaS_Tase2.Location = new System.Drawing.Point(13, 42);
            this.RaS_Tase2.Name = "RaS_Tase2";
            this.RaS_Tase2.Size = new System.Drawing.Size(58, 17);
            this.RaS_Tase2.TabIndex = 1;
            this.RaS_Tase2.TabStop = true;
            this.RaS_Tase2.Text = "Tase 2";
            this.RaS_Tase2.UseVisualStyleBackColor = true;
            // 
            // RaS_Tase1
            // 
            this.RaS_Tase1.AutoSize = true;
            this.RaS_Tase1.Location = new System.Drawing.Point(13, 3);
            this.RaS_Tase1.Name = "RaS_Tase1";
            this.RaS_Tase1.Size = new System.Drawing.Size(58, 17);
            this.RaS_Tase1.TabIndex = 0;
            this.RaS_Tase1.TabStop = true;
            this.RaS_Tase1.Text = "Tase 1";
            this.RaS_Tase1.UseVisualStyleBackColor = true;
            // 
            // RaS_Form_02_04_2018
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(471, 414);
            this.Controls.Add(this.RaS_Tasemed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RaS_AI);
            this.Controls.Add(this.Ras_New_Game);
            this.Controls.Add(this.RaS_Win);
            this.Controls.Add(this.RaS_TicTacToe);
            this.Name = "RaS_Form_02_04_2018";
            this.Text = "RaS_Form_02_04_2018";
            this.Load += new System.EventHandler(this.RaS_Form_02_04_2018_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.RaS_Tasemed.ResumeLayout(false);
            this.RaS_Tasemed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RaS_TicTacToe;
        private System.Windows.Forms.Label RaS_Win;
        private System.Windows.Forms.RadioButton RaS_X;
        private System.Windows.Forms.RadioButton RaS_O;
        private System.Windows.Forms.Button Ras_New_Game;
        private System.Windows.Forms.CheckBox RaS_AI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel RaS_Tasemed;
        private System.Windows.Forms.RadioButton RaS_Tase4;
        private System.Windows.Forms.RadioButton RaS_Tase3;
        private System.Windows.Forms.RadioButton RaS_Tase2;
        private System.Windows.Forms.RadioButton RaS_Tase1;
    }
}