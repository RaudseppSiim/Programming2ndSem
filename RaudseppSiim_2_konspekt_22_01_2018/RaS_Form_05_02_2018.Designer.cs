namespace RaudseppSiim_2_konspekt_22_01_2018
{
    partial class RaS_Form_05_02_2018
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
            this.RaS_CardHold = new System.Windows.Forms.GroupBox();
            this.RaS_Vaartus = new System.Windows.Forms.ListBox();
            this.RaS_Mast = new System.Windows.Forms.ListBox();
            this.RaS_Output = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RaS_Output)).BeginInit();
            this.SuspendLayout();
            // 
            // RaS_CardHold
            // 
            this.RaS_CardHold.BackColor = System.Drawing.Color.Green;
            this.RaS_CardHold.Location = new System.Drawing.Point(179, 124);
            this.RaS_CardHold.Name = "RaS_CardHold";
            this.RaS_CardHold.Size = new System.Drawing.Size(775, 425);
            this.RaS_CardHold.TabIndex = 0;
            this.RaS_CardHold.TabStop = false;
            // 
            // RaS_Vaartus
            // 
            this.RaS_Vaartus.FormattingEnabled = true;
            this.RaS_Vaartus.Location = new System.Drawing.Point(9, 278);
            this.RaS_Vaartus.Name = "RaS_Vaartus";
            this.RaS_Vaartus.Size = new System.Drawing.Size(156, 251);
            this.RaS_Vaartus.TabIndex = 1;
            this.RaS_Vaartus.SelectedIndexChanged += new System.EventHandler(this.RaS_Vaartus_SelectedIndexChanged);
            // 
            // RaS_Mast
            // 
            this.RaS_Mast.FormattingEnabled = true;
            this.RaS_Mast.Location = new System.Drawing.Point(9, 21);
            this.RaS_Mast.Name = "RaS_Mast";
            this.RaS_Mast.Size = new System.Drawing.Size(156, 251);
            this.RaS_Mast.TabIndex = 2;
            this.RaS_Mast.SelectedIndexChanged += new System.EventHandler(this.RaS_Mast_SelectedIndexChanged);
            // 
            // RaS_Output
            // 
            this.RaS_Output.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RaS_Output.Location = new System.Drawing.Point(447, 13);
            this.RaS_Output.Name = "RaS_Output";
            this.RaS_Output.Size = new System.Drawing.Size(91, 111);
            this.RaS_Output.TabIndex = 3;
            this.RaS_Output.TabStop = false;
            // 
            // RaS_Form_05_02_2018
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(966, 561);
            this.Controls.Add(this.RaS_Output);
            this.Controls.Add(this.RaS_Mast);
            this.Controls.Add(this.RaS_Vaartus);
            this.Controls.Add(this.RaS_CardHold);
            this.Name = "RaS_Form_05_02_2018";
            this.Text = "RaS_Form_05_02_2018";
            this.Load += new System.EventHandler(this.RaS_Form_05_02_2018_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RaS_Output)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RaS_CardHold;
        private System.Windows.Forms.ListBox RaS_Vaartus;
        private System.Windows.Forms.ListBox RaS_Mast;
        private System.Windows.Forms.PictureBox RaS_Output;
    }
}