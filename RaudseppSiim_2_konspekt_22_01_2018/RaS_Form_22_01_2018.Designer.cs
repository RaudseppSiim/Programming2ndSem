namespace RaudseppSiim_2_konspekt_22_01_2018
{
    partial class RaS_Form_22_01_2018
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
            this.RaS_Cards = new System.Windows.Forms.GroupBox();
            this.RaS_Rotate = new System.Windows.Forms.Button();
            this.RaS_Input = new System.Windows.Forms.PictureBox();
            this.RaS_Output = new System.Windows.Forms.PictureBox();
            this.RaS_Timer = new System.Windows.Forms.Timer(this.components);
            this.RaS_TimerCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.RaS_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaS_Output)).BeginInit();
            this.SuspendLayout();
            // 
            // RaS_Cards
            // 
            this.RaS_Cards.Location = new System.Drawing.Point(304, 12);
            this.RaS_Cards.Name = "RaS_Cards";
            this.RaS_Cards.Size = new System.Drawing.Size(991, 598);
            this.RaS_Cards.TabIndex = 0;
            this.RaS_Cards.TabStop = false;
            // 
            // RaS_Rotate
            // 
            this.RaS_Rotate.Location = new System.Drawing.Point(1, 8);
            this.RaS_Rotate.Name = "RaS_Rotate";
            this.RaS_Rotate.Size = new System.Drawing.Size(297, 53);
            this.RaS_Rotate.TabIndex = 1;
            this.RaS_Rotate.Text = "Pööra";
            this.RaS_Rotate.UseVisualStyleBackColor = true;
            this.RaS_Rotate.Click += new System.EventHandler(this.RaS_Rotate_Click);
            // 
            // RaS_Input
            // 
            this.RaS_Input.BackColor = System.Drawing.Color.LimeGreen;
            this.RaS_Input.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RaS_Input.Location = new System.Drawing.Point(1, 75);
            this.RaS_Input.Name = "RaS_Input";
            this.RaS_Input.Size = new System.Drawing.Size(147, 182);
            this.RaS_Input.TabIndex = 2;
            this.RaS_Input.TabStop = false;
            // 
            // RaS_Output
            // 
            this.RaS_Output.BackColor = System.Drawing.Color.LimeGreen;
            this.RaS_Output.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RaS_Output.Location = new System.Drawing.Point(154, 75);
            this.RaS_Output.Name = "RaS_Output";
            this.RaS_Output.Size = new System.Drawing.Size(144, 182);
            this.RaS_Output.TabIndex = 3;
            this.RaS_Output.TabStop = false;
            // 
            // RaS_Timer
            // 
            this.RaS_Timer.Tick += new System.EventHandler(this.RaS_Timer_Tick);
            // 
            // RaS_TimerCheck
            // 
            this.RaS_TimerCheck.AutoSize = true;
            this.RaS_TimerCheck.Location = new System.Drawing.Point(19, 278);
            this.RaS_TimerCheck.Name = "RaS_TimerCheck";
            this.RaS_TimerCheck.Size = new System.Drawing.Size(82, 30);
            this.RaS_TimerCheck.TabIndex = 4;
            this.RaS_TimerCheck.Text = "Timer";
            this.RaS_TimerCheck.UseVisualStyleBackColor = true;
            this.RaS_TimerCheck.CheckedChanged += new System.EventHandler(this.RaS_TimerCheck_CheckedChanged);
            // 
            // RaS_Form_22_01_2018
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1312, 619);
            this.Controls.Add(this.RaS_TimerCheck);
            this.Controls.Add(this.RaS_Output);
            this.Controls.Add(this.RaS_Input);
            this.Controls.Add(this.RaS_Rotate);
            this.Controls.Add(this.RaS_Cards);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RaS_Form_22_01_2018";
            this.Text = "RaS_Form_22_01_2018";
            this.Load += new System.EventHandler(this.RaS_Form_22_01_2018_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RaS_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaS_Output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RaS_Cards;
        private System.Windows.Forms.Button RaS_Rotate;
        private System.Windows.Forms.PictureBox RaS_Input;
        private System.Windows.Forms.PictureBox RaS_Output;
        private System.Windows.Forms.Timer RaS_Timer;
        private System.Windows.Forms.CheckBox RaS_TimerCheck;
    }
}