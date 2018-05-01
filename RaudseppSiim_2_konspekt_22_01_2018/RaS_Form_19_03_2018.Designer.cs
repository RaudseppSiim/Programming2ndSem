namespace RaudseppSiim_2_konspekt_22_01_2018
{
    partial class RaS_Form_19_03_2018
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
            this.components = new System.ComponentModel.Container();
            this.RaS_Canvas = new System.Windows.Forms.PictureBox();
            this.RaS_Lines = new System.Windows.Forms.Button();
            this.RaS_Graph = new System.Windows.Forms.Button();
            this.RaS_atomTimer = new System.Windows.Forms.Timer(this.components);
            this.RaS_EsmaneRoos = new System.Windows.Forms.CheckBox();
            this.RaS_Kardioid = new System.Windows.Forms.CheckBox();
            this.RaS_ButterFly = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.RaS_Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // RaS_Canvas
            // 
            this.RaS_Canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RaS_Canvas.Location = new System.Drawing.Point(211, 12);
            this.RaS_Canvas.Name = "RaS_Canvas";
            this.RaS_Canvas.Size = new System.Drawing.Size(556, 556);
            this.RaS_Canvas.TabIndex = 0;
            this.RaS_Canvas.TabStop = false;
            // 
            // RaS_Lines
            // 
            this.RaS_Lines.Location = new System.Drawing.Point(12, 12);
            this.RaS_Lines.Name = "RaS_Lines";
            this.RaS_Lines.Size = new System.Drawing.Size(184, 58);
            this.RaS_Lines.TabIndex = 1;
            this.RaS_Lines.Text = "Joonista Põhi";
            this.RaS_Lines.UseVisualStyleBackColor = true;
            this.RaS_Lines.Click += new System.EventHandler(this.RaS_Lines_Click);
            // 
            // RaS_Graph
            // 
            this.RaS_Graph.Location = new System.Drawing.Point(12, 76);
            this.RaS_Graph.Name = "RaS_Graph";
            this.RaS_Graph.Size = new System.Drawing.Size(184, 58);
            this.RaS_Graph.TabIndex = 2;
            this.RaS_Graph.Text = "Joonista Graafik";
            this.RaS_Graph.UseVisualStyleBackColor = true;
            this.RaS_Graph.Click += new System.EventHandler(this.RaS_Graph_Click);
            // 
            // RaS_atomTimer
            // 
            this.RaS_atomTimer.Interval = 1;
            this.RaS_atomTimer.Tick += new System.EventHandler(this.RaS_atomTimer_Tick);
            // 
            // RaS_EsmaneRoos
            // 
            this.RaS_EsmaneRoos.AutoSize = true;
            this.RaS_EsmaneRoos.Checked = true;
            this.RaS_EsmaneRoos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RaS_EsmaneRoos.Location = new System.Drawing.Point(27, 157);
            this.RaS_EsmaneRoos.Name = "RaS_EsmaneRoos";
            this.RaS_EsmaneRoos.Size = new System.Drawing.Size(92, 17);
            this.RaS_EsmaneRoos.TabIndex = 3;
            this.RaS_EsmaneRoos.Text = "Emsane Roos";
            this.RaS_EsmaneRoos.UseVisualStyleBackColor = true;
            // 
            // RaS_Kardioid
            // 
            this.RaS_Kardioid.AutoSize = true;
            this.RaS_Kardioid.Location = new System.Drawing.Point(27, 180);
            this.RaS_Kardioid.Name = "RaS_Kardioid";
            this.RaS_Kardioid.Size = new System.Drawing.Size(64, 17);
            this.RaS_Kardioid.TabIndex = 4;
            this.RaS_Kardioid.Text = "Kardioid";
            this.RaS_Kardioid.UseVisualStyleBackColor = true;
            // 
            // RaS_ButterFly
            // 
            this.RaS_ButterFly.AutoSize = true;
            this.RaS_ButterFly.Location = new System.Drawing.Point(27, 203);
            this.RaS_ButterFly.Name = "RaS_ButterFly";
            this.RaS_ButterFly.Size = new System.Drawing.Size(61, 17);
            this.RaS_ButterFly.TabIndex = 5;
            this.RaS_ButterFly.Text = "Liblikas";
            this.RaS_ButterFly.UseVisualStyleBackColor = true;
            // 
            // RaS_Form_19_03_2018
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 634);
            this.Controls.Add(this.RaS_ButterFly);
            this.Controls.Add(this.RaS_Kardioid);
            this.Controls.Add(this.RaS_EsmaneRoos);
            this.Controls.Add(this.RaS_Graph);
            this.Controls.Add(this.RaS_Lines);
            this.Controls.Add(this.RaS_Canvas);
            this.Name = "RaS_Form_19_03_2018";
            this.Text = "RaS_Form_19_03_2018";
            ((System.ComponentModel.ISupportInitialize)(this.RaS_Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RaS_Canvas;
        private System.Windows.Forms.Button RaS_Lines;
        private System.Windows.Forms.Button RaS_Graph;
        private System.Windows.Forms.Timer RaS_atomTimer;
        private System.Windows.Forms.CheckBox RaS_EsmaneRoos;
        private System.Windows.Forms.CheckBox RaS_Kardioid;
        private System.Windows.Forms.CheckBox RaS_ButterFly;
    }
}