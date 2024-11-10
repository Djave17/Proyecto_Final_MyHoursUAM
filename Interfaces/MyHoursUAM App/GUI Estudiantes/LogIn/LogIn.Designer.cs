namespace MyHoursUAM_App.GUI.LogIn
{
    partial class imgIconApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imgIconApp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCIF = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtbCIF = new System.Windows.Forms.TextBox();
            this.txtbContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(99, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCIF
            // 
            this.lblCIF.AutoSize = true;
            this.lblCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIF.Location = new System.Drawing.Point(33, 190);
            this.lblCIF.Name = "lblCIF";
            this.lblCIF.Size = new System.Drawing.Size(34, 16);
            this.lblCIF.TabIndex = 1;
            this.lblCIF.Text = "CIF:";
            this.lblCIF.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(33, 248);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(90, 16);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbCIF
            // 
            this.txtbCIF.Location = new System.Drawing.Point(130, 184);
            this.txtbCIF.Name = "txtbCIF";
            this.txtbCIF.Size = new System.Drawing.Size(165, 22);
            this.txtbCIF.TabIndex = 3;
            // 
            // txtbContraseña
            // 
            this.txtbContraseña.Location = new System.Drawing.Point(130, 248);
            this.txtbContraseña.Name = "txtbContraseña";
            this.txtbContraseña.Size = new System.Drawing.Size(165, 22);
            this.txtbContraseña.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(130, 307);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(99, 34);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // imgIconApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 380);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtbContraseña);
            this.Controls.Add(this.txtbCIF);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCIF);
            this.Controls.Add(this.pictureBox1);
            this.Name = "imgIconApp";
            this.Text = "MyHoursUAM - Inicia Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCIF;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtbCIF;
        private System.Windows.Forms.TextBox txtbContraseña;
        private System.Windows.Forms.Button btnIngresar;
    }
}