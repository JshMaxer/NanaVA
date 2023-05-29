
namespace NanaVA
{
    partial class Submitted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Submitted));
            this.subsmooth = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.rgbline = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rgbtrans = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.rgbtranslight = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.timerclose = new System.Windows.Forms.Timer(this.components);
            this.txtsecret = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subsmooth
            // 
            this.subsmooth.TargetControl = this;
            // 
            // rgbline
            // 
            this.rgbline.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rgbline.Location = new System.Drawing.Point(39, 122);
            this.rgbline.Name = "rgbline";
            this.rgbline.Size = new System.Drawing.Size(366, 10);
            this.rgbline.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your information is\r\nsuccesfully changed!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rgbtrans
            // 
            this.rgbtrans.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.Gray,
        System.Drawing.Color.Silver,
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))))};
            this.rgbtrans.EndColor = System.Drawing.Color.Black;
            this.rgbtrans.StartColor = System.Drawing.Color.DimGray;
            // 
            // rgbtranslight
            // 
            this.rgbtranslight.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))))};
            this.rgbtranslight.EndColor = System.Drawing.SystemColors.ControlLightLight;
            this.rgbtranslight.StartColor = System.Drawing.Color.White;
            // 
            // timerclose
            // 
            this.timerclose.Enabled = true;
            this.timerclose.Interval = 3000;
            this.timerclose.Tick += new System.EventHandler(this.timerclose_Tick);
            // 
            // txtsecret
            // 
            this.txtsecret.AutoSize = true;
            this.txtsecret.Location = new System.Drawing.Point(22, 241);
            this.txtsecret.Name = "txtsecret";
            this.txtsecret.Size = new System.Drawing.Size(0, 17);
            this.txtsecret.TabIndex = 4;
            // 
            // Submitted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(442, 198);
            this.Controls.Add(this.txtsecret);
            this.Controls.Add(this.rgbline);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Submitted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submitted";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse subsmooth;
        private Guna.UI2.WinForms.Guna2GradientPanel rgbline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ColorTransition rgbtrans;
        private Guna.UI2.WinForms.Guna2ColorTransition rgbtranslight;
        private System.Windows.Forms.Timer timerclose;
        public System.Windows.Forms.Label txtsecret;
    }
}