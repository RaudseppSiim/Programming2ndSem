namespace RaudseppSiim_2_konspekt_22_01_2018
{
    partial class RaS_Form_05_03_2018
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
            this.RaS_World = new System.Windows.Forms.PictureBox();
            this.RaS_Map = new System.Windows.Forms.PictureBox();
            this.RaS_Speed = new System.Windows.Forms.VScrollBar();
            this.RaS_Tilt = new System.Windows.Forms.HScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RaS_ValiPilt = new System.Windows.Forms.ToolStripMenuItem();
            this.RaS_LoePlaneet = new System.Windows.Forms.ToolStripMenuItem();
            this.keerutaPlaneetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RaS_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RaS_World)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaS_Map)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RaS_World
            // 
            this.RaS_World.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RaS_World.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RaS_World.Location = new System.Drawing.Point(367, 313);
            this.RaS_World.Name = "RaS_World";
            this.RaS_World.Size = new System.Drawing.Size(324, 269);
            this.RaS_World.TabIndex = 0;
            this.RaS_World.TabStop = false;
            // 
            // RaS_Map
            // 
            this.RaS_Map.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RaS_Map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RaS_Map.Location = new System.Drawing.Point(24, 16);
            this.RaS_Map.Name = "RaS_Map";
            this.RaS_Map.Size = new System.Drawing.Size(666, 269);
            this.RaS_Map.TabIndex = 1;
            this.RaS_Map.TabStop = false;
            // 
            // RaS_Speed
            // 
            this.RaS_Speed.Location = new System.Drawing.Point(332, 313);
            this.RaS_Speed.Maximum = 1000;
            this.RaS_Speed.Minimum = 1;
            this.RaS_Speed.Name = "RaS_Speed";
            this.RaS_Speed.Size = new System.Drawing.Size(25, 253);
            this.RaS_Speed.TabIndex = 2;
            this.RaS_Speed.Value = 1;
            this.RaS_Speed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RaS_Speed_Scroll);
            // 
            // RaS_Tilt
            // 
            this.RaS_Tilt.Location = new System.Drawing.Point(369, 288);
            this.RaS_Tilt.Name = "RaS_Tilt";
            this.RaS_Tilt.Size = new System.Drawing.Size(320, 25);
            this.RaS_Tilt.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RaS_ValiPilt,
            this.RaS_LoePlaneet,
            this.keerutaPlaneetiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RaS_ValiPilt
            // 
            this.RaS_ValiPilt.Name = "RaS_ValiPilt";
            this.RaS_ValiPilt.Size = new System.Drawing.Size(79, 20);
            this.RaS_ValiPilt.Text = "Vali Planeet";
            this.RaS_ValiPilt.Click += new System.EventHandler(this.RaS_Vali_Planeet_Click);
            // 
            // RaS_LoePlaneet
            // 
            this.RaS_LoePlaneet.Enabled = false;
            this.RaS_LoePlaneet.Name = "RaS_LoePlaneet";
            this.RaS_LoePlaneet.Size = new System.Drawing.Size(80, 20);
            this.RaS_LoePlaneet.Text = "Loe Planeet";
            this.RaS_LoePlaneet.Click += new System.EventHandler(this.RaS_LoePlaneet_Click);
            // 
            // keerutaPlaneetiToolStripMenuItem
            // 
            this.keerutaPlaneetiToolStripMenuItem.Enabled = false;
            this.keerutaPlaneetiToolStripMenuItem.Name = "keerutaPlaneetiToolStripMenuItem";
            this.keerutaPlaneetiToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.keerutaPlaneetiToolStripMenuItem.Text = "Keeruta Planeeti";
            this.keerutaPlaneetiToolStripMenuItem.Click += new System.EventHandler(this.keerutaPlaneetiToolStripMenuItem_Click);
            // 
            // RaS_Timer
            // 
            this.RaS_Timer.Interval = 10;
            this.RaS_Timer.Tick += new System.EventHandler(this.RaS_Timer_Tick);
            // 
            // RaS_Form_05_03_2018
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 585);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.RaS_Tilt);
            this.Controls.Add(this.RaS_Speed);
            this.Controls.Add(this.RaS_Map);
            this.Controls.Add(this.RaS_World);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RaS_Form_05_03_2018";
            this.Text = "RaS_Form_05_03_2018";
            ((System.ComponentModel.ISupportInitialize)(this.RaS_World)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaS_Map)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RaS_World;
        private System.Windows.Forms.PictureBox RaS_Map;
        private System.Windows.Forms.VScrollBar RaS_Speed;
        private System.Windows.Forms.HScrollBar RaS_Tilt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RaS_ValiPilt;
        private System.Windows.Forms.ToolStripMenuItem RaS_LoePlaneet;
        private System.Windows.Forms.ToolStripMenuItem keerutaPlaneetiToolStripMenuItem;
        private System.Windows.Forms.Timer RaS_Timer;
    }
}