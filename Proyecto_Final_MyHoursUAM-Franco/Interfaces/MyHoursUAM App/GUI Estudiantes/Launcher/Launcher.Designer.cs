namespace MyHoursUAM_App.GUI_Estudiantes.Launcher
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.imgIconApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).BeginInit();
            this.SuspendLayout();
            // 
            // imgIconApp
            // 
            this.imgIconApp.Image = ((System.Drawing.Image)(resources.GetObject("imgIconApp.Image")));
            this.imgIconApp.Location = new System.Drawing.Point(127, 159);
            this.imgIconApp.Name = "imgIconApp";
            this.imgIconApp.Size = new System.Drawing.Size(237, 108);
            this.imgIconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIconApp.TabIndex = 16;
            this.imgIconApp.TabStop = false;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.imgIconApp);
            this.Name = "Launcher";
            this.Text = "Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgIconApp;
    }
}