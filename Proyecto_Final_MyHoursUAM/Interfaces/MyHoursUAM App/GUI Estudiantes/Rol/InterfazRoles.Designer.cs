namespace MyHoursUAM_App.GUI.Rol
{
    partial class InterfazRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazRoles));
            this.imgIconApp = new System.Windows.Forms.PictureBox();
            this.imgAdminIcon = new System.Windows.Forms.PictureBox();
            this.imgStudentIcon = new System.Windows.Forms.PictureBox();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lbl_rt_Bienvenida = new System.Windows.Forms.Label();
            this.llb_rt_Rol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdminIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // imgIconApp
            // 
            this.imgIconApp.Image = ((System.Drawing.Image)(resources.GetObject("imgIconApp.Image")));
            this.imgIconApp.Location = new System.Drawing.Point(170, 40);
            this.imgIconApp.Name = "imgIconApp";
            this.imgIconApp.Size = new System.Drawing.Size(175, 76);
            this.imgIconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIconApp.TabIndex = 0;
            this.imgIconApp.TabStop = false;
            // 
            // imgAdminIcon
            // 
            this.imgAdminIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgAdminIcon.Image")));
            this.imgAdminIcon.Location = new System.Drawing.Point(307, 219);
            this.imgAdminIcon.Name = "imgAdminIcon";
            this.imgAdminIcon.Size = new System.Drawing.Size(116, 129);
            this.imgAdminIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAdminIcon.TabIndex = 1;
            this.imgAdminIcon.TabStop = false;
            // 
            // imgStudentIcon
            // 
            this.imgStudentIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgStudentIcon.Image")));
            this.imgStudentIcon.Location = new System.Drawing.Point(72, 219);
            this.imgStudentIcon.Name = "imgStudentIcon";
            this.imgStudentIcon.Size = new System.Drawing.Size(127, 129);
            this.imgStudentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStudentIcon.TabIndex = 2;
            this.imgStudentIcon.TabStop = false;
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(84, 369);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(99, 23);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "Estudiante";
            this.btnStudent.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(307, 369);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(127, 23);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Administrador";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // lbl_rt_Bienvenida
            // 
            this.lbl_rt_Bienvenida.AutoSize = true;
            this.lbl_rt_Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rt_Bienvenida.Location = new System.Drawing.Point(129, 134);
            this.lbl_rt_Bienvenida.Name = "lbl_rt_Bienvenida";
            this.lbl_rt_Bienvenida.Size = new System.Drawing.Size(270, 22);
            this.lbl_rt_Bienvenida.TabIndex = 5;
            this.lbl_rt_Bienvenida.Text = "Bienvenid@s a MyHoursUAM";
            // 
            // llb_rt_Rol
            // 
            this.llb_rt_Rol.AutoSize = true;
            this.llb_rt_Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_rt_Rol.Location = new System.Drawing.Point(181, 173);
            this.llb_rt_Rol.Name = "llb_rt_Rol";
            this.llb_rt_Rol.Size = new System.Drawing.Size(141, 18);
            this.llb_rt_Rol.TabIndex = 6;
            this.llb_rt_Rol.Text = "Selecciona tu Rol";
            // 
            // InterfazRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.llb_rt_Rol);
            this.Controls.Add(this.lbl_rt_Bienvenida);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.imgStudentIcon);
            this.Controls.Add(this.imgAdminIcon);
            this.Controls.Add(this.imgIconApp);
            this.Name = "InterfazRoles";
            this.Text = "MyHoursUAM - Selecciona tu Rol";
            this.Load += new System.EventHandler(this.InterfazRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAdminIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudentIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgIconApp;
        private System.Windows.Forms.PictureBox imgAdminIcon;
        private System.Windows.Forms.PictureBox imgStudentIcon;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lbl_rt_Bienvenida;
        private System.Windows.Forms.Label llb_rt_Rol;
    }
}