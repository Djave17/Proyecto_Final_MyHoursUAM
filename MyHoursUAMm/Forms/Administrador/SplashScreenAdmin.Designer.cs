﻿namespace MyHours_UAMApp
{
    partial class SplashScreenAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenAdmin));
            this.lblRotulo1 = new System.Windows.Forms.Label();
            this.ptbLogoApp = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogoApp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRotulo1
            // 
            this.lblRotulo1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRotulo1.AutoSize = true;
            this.lblRotulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotulo1.ForeColor = System.Drawing.Color.Teal;
            this.lblRotulo1.Location = new System.Drawing.Point(190, 375);
            this.lblRotulo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRotulo1.Name = "lblRotulo1";
            this.lblRotulo1.Size = new System.Drawing.Size(478, 44);
            this.lblRotulo1.TabIndex = 38;
            this.lblRotulo1.Text = "Bienvenido Administrador";
            // 
            // ptbLogoApp
            // 
            this.ptbLogoApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbLogoApp.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogoApp.Image")));
            this.ptbLogoApp.Location = new System.Drawing.Point(336, 75);
            this.ptbLogoApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptbLogoApp.Name = "ptbLogoApp";
            this.ptbLogoApp.Size = new System.Drawing.Size(163, 258);
            this.ptbLogoApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogoApp.TabIndex = 37;
            this.ptbLogoApp.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.ForeColor = System.Drawing.Color.Teal;
            this.progressBar.Location = new System.Drawing.Point(325, 433);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(191, 10);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 39;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // SplashScreenAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 494);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblRotulo1);
            this.Controls.Add(this.ptbLogoApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SplashScreenAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreenAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SplashScreenAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogoApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRotulo1;
        private System.Windows.Forms.PictureBox ptbLogoApp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}