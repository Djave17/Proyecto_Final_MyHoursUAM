namespace MyHours_UAMApp
{
    partial class SplashScreenUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenUser));
            this.ptbLogoApp = new System.Windows.Forms.PictureBox();
            this.lblRotulo1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogoApp)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLogoApp
            // 
            this.ptbLogoApp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbLogoApp.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogoApp.Image")));
            this.ptbLogoApp.Location = new System.Drawing.Point(325, 39);
            this.ptbLogoApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptbLogoApp.Name = "ptbLogoApp";
            this.ptbLogoApp.Size = new System.Drawing.Size(163, 258);
            this.ptbLogoApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogoApp.TabIndex = 0;
            this.ptbLogoApp.TabStop = false;
            // 
            // lblRotulo1
            // 
            this.lblRotulo1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRotulo1.AutoSize = true;
            this.lblRotulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotulo1.ForeColor = System.Drawing.Color.Teal;
            this.lblRotulo1.Location = new System.Drawing.Point(236, 340);
            this.lblRotulo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRotulo1.Name = "lblRotulo1";
            this.lblRotulo1.Size = new System.Drawing.Size(418, 44);
            this.lblRotulo1.TabIndex = 36;
            this.lblRotulo1.Text = "Bienvenido Estudiante";
            this.lblRotulo1.Click += new System.EventHandler(this.lblRotulo1_Click);
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
            this.progressBar.Location = new System.Drawing.Point(309, 405);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(191, 10);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 37;
            // 
            // SplashScreenUser
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
            this.Name = "SplashScreenUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreenUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogoApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLogoApp;
        private System.Windows.Forms.Label lblRotulo1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}