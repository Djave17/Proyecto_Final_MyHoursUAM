namespace MyHoursUAM_App.GUI_Estudiantes.Mi_Perfil
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.imgIconApp = new System.Windows.Forms.PictureBox();
            this.gbxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblCorreoDescripcion = new System.Windows.Forms.Label();
            this.lblCarreraDescripcion = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblCIFNumber = new System.Windows.Forms.Label();
            this.lblCIF = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.imgIconStudent = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnGestiones = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).BeginInit();
            this.gbxDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconStudent)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgIconApp
            // 
            this.imgIconApp.Image = ((System.Drawing.Image)(resources.GetObject("imgIconApp.Image")));
            this.imgIconApp.Location = new System.Drawing.Point(726, 299);
            this.imgIconApp.Name = "imgIconApp";
            this.imgIconApp.Size = new System.Drawing.Size(132, 60);
            this.imgIconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIconApp.TabIndex = 15;
            this.imgIconApp.TabStop = false;
            // 
            // gbxDatosPersonales
            // 
            this.gbxDatosPersonales.Controls.Add(this.lblCorreoDescripcion);
            this.gbxDatosPersonales.Controls.Add(this.lblCarreraDescripcion);
            this.gbxDatosPersonales.Controls.Add(this.lblCorreo);
            this.gbxDatosPersonales.Controls.Add(this.lblCarrera);
            this.gbxDatosPersonales.Controls.Add(this.lblCIFNumber);
            this.gbxDatosPersonales.Controls.Add(this.lblCIF);
            this.gbxDatosPersonales.Controls.Add(this.lblNombres);
            this.gbxDatosPersonales.Controls.Add(this.lblNombreCompleto);
            this.gbxDatosPersonales.Controls.Add(this.imgIconStudent);
            this.gbxDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosPersonales.Location = new System.Drawing.Point(12, 107);
            this.gbxDatosPersonales.Name = "gbxDatosPersonales";
            this.gbxDatosPersonales.Size = new System.Drawing.Size(837, 175);
            this.gbxDatosPersonales.TabIndex = 14;
            this.gbxDatosPersonales.TabStop = false;
            this.gbxDatosPersonales.Text = "Datos Personales";
            // 
            // lblCorreoDescripcion
            // 
            this.lblCorreoDescripcion.AutoSize = true;
            this.lblCorreoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoDescripcion.Location = new System.Drawing.Point(289, 134);
            this.lblCorreoDescripcion.Name = "lblCorreoDescripcion";
            this.lblCorreoDescripcion.Size = new System.Drawing.Size(127, 16);
            this.lblCorreoDescripcion.TabIndex = 8;
            this.lblCorreoDescripcion.Text = "mario@uamv.edu.ni";
            // 
            // lblCarreraDescripcion
            // 
            this.lblCarreraDescripcion.AutoSize = true;
            this.lblCarreraDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarreraDescripcion.Location = new System.Drawing.Point(289, 100);
            this.lblCarreraDescripcion.Name = "lblCarreraDescripcion";
            this.lblCarreraDescripcion.Size = new System.Drawing.Size(61, 16);
            this.lblCarreraDescripcion.TabIndex = 7;
            this.lblCarreraDescripcion.Text = "Finanzas";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(117, 134);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(144, 16);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo Institucional:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(117, 100);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(63, 16);
            this.lblCarrera.TabIndex = 5;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblCIFNumber
            // 
            this.lblCIFNumber.AutoSize = true;
            this.lblCIFNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIFNumber.Location = new System.Drawing.Point(289, 65);
            this.lblCIFNumber.Name = "lblCIFNumber";
            this.lblCIFNumber.Size = new System.Drawing.Size(70, 16);
            this.lblCIFNumber.TabIndex = 4;
            this.lblCIFNumber.Text = "123456789";
            // 
            // lblCIF
            // 
            this.lblCIF.AutoSize = true;
            this.lblCIF.Location = new System.Drawing.Point(117, 65);
            this.lblCIF.Name = "lblCIF";
            this.lblCIF.Size = new System.Drawing.Size(34, 16);
            this.lblCIF.TabIndex = 3;
            this.lblCIF.Text = "CIF:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(117, 31);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(136, 16);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Nombre Completo:";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(289, 31);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(181, 16);
            this.lblNombreCompleto.TabIndex = 1;
            this.lblNombreCompleto.Text = "Mario Andres Robleto Garcia";
            // 
            // imgIconStudent
            // 
            this.imgIconStudent.Image = ((System.Drawing.Image)(resources.GetObject("imgIconStudent.Image")));
            this.imgIconStudent.Location = new System.Drawing.Point(6, 31);
            this.imgIconStudent.Name = "imgIconStudent";
            this.imgIconStudent.Size = new System.Drawing.Size(105, 119);
            this.imgIconStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIconStudent.TabIndex = 0;
            this.imgIconStudent.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEventos);
            this.flowLayoutPanel1.Controls.Add(this.btnAsistencia);
            this.flowLayoutPanel1.Controls.Add(this.btnGestiones);
            this.flowLayoutPanel1.Controls.Add(this.btnPerfil);
            this.flowLayoutPanel1.Controls.Add(this.btnAjustes);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 11);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(840, 73);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btnEventos
            // 
            this.btnEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.Location = new System.Drawing.Point(3, 3);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(131, 55);
            this.btnEventos.TabIndex = 0;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.Location = new System.Drawing.Point(140, 3);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(170, 55);
            this.btnAsistencia.TabIndex = 1;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            // 
            // btnGestiones
            // 
            this.btnGestiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestiones.Location = new System.Drawing.Point(316, 3);
            this.btnGestiones.Name = "btnGestiones";
            this.btnGestiones.Size = new System.Drawing.Size(189, 55);
            this.btnGestiones.TabIndex = 2;
            this.btnGestiones.Text = "Gestiones";
            this.btnGestiones.UseVisualStyleBackColor = true;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.Location = new System.Drawing.Point(511, 3);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(152, 55);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.Text = "Mi Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // btnAjustes
            // 
            this.btnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.Location = new System.Drawing.Point(669, 3);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(165, 54);
            this.btnAjustes.TabIndex = 4;
            this.btnAjustes.Text = "Ajustes";
            this.btnAjustes.UseVisualStyleBackColor = true;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.Location = new System.Drawing.Point(3, 321);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(555, 16);
            this.lblAviso.TabIndex = 16;
            this.lblAviso.Text = "Estimado Usuario si desea actualizar sus datos dirigirse a Registro Academico";
            // 
            // btnReporte
            // 
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(564, 310);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(156, 38);
            this.btnReporte.TabIndex = 17;
            this.btnReporte.Text = "Descargar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 360);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.imgIconApp);
            this.Controls.Add(this.gbxDatosPersonales);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Perfil";
            this.Text = "MyHoursUAM - Mi Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).EndInit();
            this.gbxDatosPersonales.ResumeLayout(false);
            this.gbxDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconStudent)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgIconApp;
        private System.Windows.Forms.GroupBox gbxDatosPersonales;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnGestiones;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.PictureBox imgIconStudent;
        private System.Windows.Forms.Label lblCorreoDescripcion;
        private System.Windows.Forms.Label lblCarreraDescripcion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblCIFNumber;
        private System.Windows.Forms.Label lblCIF;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnReporte;
    }
}