namespace MyHours_UAMApp
{
    partial class Rol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rol));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRotulo1 = new System.Windows.Forms.Label();
            this.pctAdminIcon = new System.Windows.Forms.PictureBox();
            this.pctStudentIcon = new System.Windows.Forms.PictureBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdminIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctStudentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(147, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Selecciona tu Rol";
            // 
            // lblRotulo1
            // 
            this.lblRotulo1.AutoSize = true;
            this.lblRotulo1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotulo1.ForeColor = System.Drawing.Color.Teal;
            this.lblRotulo1.Location = new System.Drawing.Point(32, 183);
            this.lblRotulo1.Name = "lblRotulo1";
            this.lblRotulo1.Size = new System.Drawing.Size(418, 33);
            this.lblRotulo1.TabIndex = 32;
            this.lblRotulo1.Text = "Bienvenid@ a MyHoursUAM";
            // 
            // pctAdminIcon
            // 
            this.pctAdminIcon.Image = ((System.Drawing.Image)(resources.GetObject("pctAdminIcon.Image")));
            this.pctAdminIcon.Location = new System.Drawing.Point(298, 324);
            this.pctAdminIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctAdminIcon.Name = "pctAdminIcon";
            this.pctAdminIcon.Size = new System.Drawing.Size(116, 129);
            this.pctAdminIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAdminIcon.TabIndex = 29;
            this.pctAdminIcon.TabStop = false;
            // 
            // pctStudentIcon
            // 
            this.pctStudentIcon.Image = ((System.Drawing.Image)(resources.GetObject("pctStudentIcon.Image")));
            this.pctStudentIcon.Location = new System.Drawing.Point(69, 324);
            this.pctStudentIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctStudentIcon.Name = "pctStudentIcon";
            this.pctStudentIcon.Size = new System.Drawing.Size(141, 144);
            this.pctStudentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctStudentIcon.TabIndex = 28;
            this.pctStudentIcon.TabStop = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.Color.Teal;
            this.btnAdmin.Location = new System.Drawing.Point(258, 479);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(192, 34);
            this.btnAdmin.TabIndex = 35;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.White;
            this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnStudent.ForeColor = System.Drawing.Color.Teal;
            this.btnStudent.Location = new System.Drawing.Point(38, 479);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(172, 34);
            this.btnStudent.TabIndex = 36;
            this.btnStudent.Text = "Estudiante";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 533);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRotulo1);
            this.Controls.Add(this.pctAdminIcon);
            this.Controls.Add(this.pctStudentIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Rol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyHoursUAM - Rol ";
            this.Load += new System.EventHandler(this.Rol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdminIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctStudentIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRotulo1;
        private System.Windows.Forms.PictureBox pctAdminIcon;
        private System.Windows.Forms.PictureBox pctStudentIcon;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnStudent;
    }
}