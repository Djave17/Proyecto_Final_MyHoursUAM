namespace MyHoursUAM_App.GUI_Administrador.Añadir_Eventos
{
    partial class Añadir_Eventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Añadir_Eventos));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.imgIconApp = new System.Windows.Forms.PictureBox();
            this.gbxNuevoEvento = new System.Windows.Forms.GroupBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAñadirEventos = new System.Windows.Forms.Button();
            this.btnEvento = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.lblTipodeEvento = new System.Windows.Forms.Label();
            this.rbtExtracurricular = new System.Windows.Forms.RadioButton();
            this.rbtAcademico = new System.Windows.Forms.RadioButton();
            this.rdbClub = new System.Windows.Forms.RadioButton();
            this.lblTipoBeneficio = new System.Windows.Forms.Label();
            this.rbtHorasLaborales = new System.Windows.Forms.RadioButton();
            this.rbtPartidos = new System.Windows.Forms.RadioButton();
            this.lblNombreEvento = new System.Windows.Forms.Label();
            this.txtbNombreEvento = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtbHorario = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtbLugar = new System.Windows.Forms.TextBox();
            this.lblCupos = new System.Windows.Forms.Label();
            this.txtbCupos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).BeginInit();
            this.gbxNuevoEvento.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(259, 395);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(52, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "❌";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(172, 395);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(53, 23);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "✔";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // imgIconApp
            // 
            this.imgIconApp.Image = ((System.Drawing.Image)(resources.GetObject("imgIconApp.Image")));
            this.imgIconApp.Location = new System.Drawing.Point(361, 378);
            this.imgIconApp.Name = "imgIconApp";
            this.imgIconApp.Size = new System.Drawing.Size(132, 60);
            this.imgIconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIconApp.TabIndex = 25;
            this.imgIconApp.TabStop = false;
            // 
            // gbxNuevoEvento
            // 
            this.gbxNuevoEvento.Controls.Add(this.txtbCupos);
            this.gbxNuevoEvento.Controls.Add(this.lblCupos);
            this.gbxNuevoEvento.Controls.Add(this.txtbLugar);
            this.gbxNuevoEvento.Controls.Add(this.lblLugar);
            this.gbxNuevoEvento.Controls.Add(this.txtbHorario);
            this.gbxNuevoEvento.Controls.Add(this.lblHorario);
            this.gbxNuevoEvento.Controls.Add(this.txtbNombreEvento);
            this.gbxNuevoEvento.Controls.Add(this.lblNombreEvento);
            this.gbxNuevoEvento.Controls.Add(this.rbtPartidos);
            this.gbxNuevoEvento.Controls.Add(this.rbtHorasLaborales);
            this.gbxNuevoEvento.Controls.Add(this.lblTipoBeneficio);
            this.gbxNuevoEvento.Controls.Add(this.rdbClub);
            this.gbxNuevoEvento.Controls.Add(this.rbtAcademico);
            this.gbxNuevoEvento.Controls.Add(this.rbtExtracurricular);
            this.gbxNuevoEvento.Controls.Add(this.lblTipodeEvento);
            this.gbxNuevoEvento.Controls.Add(this.lblAviso);
            this.gbxNuevoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNuevoEvento.Location = new System.Drawing.Point(14, 106);
            this.gbxNuevoEvento.Name = "gbxNuevoEvento";
            this.gbxNuevoEvento.Size = new System.Drawing.Size(479, 266);
            this.gbxNuevoEvento.TabIndex = 24;
            this.gbxNuevoEvento.TabStop = false;
            this.gbxNuevoEvento.Text = "Nuevo Evento";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(6, 23);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(244, 16);
            this.lblAviso.TabIndex = 19;
            this.lblAviso.Text = "Todos los campos son requeridos";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAñadirEventos);
            this.flowLayoutPanel1.Controls.Add(this.btnEvento);
            this.flowLayoutPanel1.Controls.Add(this.btnAsistencia);
            this.flowLayoutPanel1.Controls.Add(this.btnAjustes);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(477, 73);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // btnAñadirEventos
            // 
            this.btnAñadirEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirEventos.Location = new System.Drawing.Point(3, 3);
            this.btnAñadirEventos.Name = "btnAñadirEventos";
            this.btnAñadirEventos.Size = new System.Drawing.Size(133, 55);
            this.btnAñadirEventos.TabIndex = 0;
            this.btnAñadirEventos.Text = "Añadir Eventos";
            this.btnAñadirEventos.UseVisualStyleBackColor = true;
            // 
            // btnEvento
            // 
            this.btnEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvento.Location = new System.Drawing.Point(142, 3);
            this.btnEvento.Name = "btnEvento";
            this.btnEvento.Size = new System.Drawing.Size(100, 55);
            this.btnEvento.TabIndex = 1;
            this.btnEvento.Text = "Eventos";
            this.btnEvento.UseVisualStyleBackColor = true;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.Location = new System.Drawing.Point(248, 3);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(96, 55);
            this.btnAsistencia.TabIndex = 2;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            // 
            // btnAjustes
            // 
            this.btnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.Location = new System.Drawing.Point(350, 3);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(121, 54);
            this.btnAjustes.TabIndex = 4;
            this.btnAjustes.Text = "Ajustes";
            this.btnAjustes.UseVisualStyleBackColor = true;
            // 
            // lblTipodeEvento
            // 
            this.lblTipodeEvento.AutoSize = true;
            this.lblTipodeEvento.Location = new System.Drawing.Point(9, 55);
            this.lblTipodeEvento.Name = "lblTipodeEvento";
            this.lblTipodeEvento.Size = new System.Drawing.Size(117, 16);
            this.lblTipodeEvento.TabIndex = 20;
            this.lblTipodeEvento.Text = "Tipo de Evento:";
            // 
            // rbtExtracurricular
            // 
            this.rbtExtracurricular.AutoSize = true;
            this.rbtExtracurricular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtExtracurricular.Location = new System.Drawing.Point(226, 53);
            this.rbtExtracurricular.Name = "rbtExtracurricular";
            this.rbtExtracurricular.Size = new System.Drawing.Size(112, 20);
            this.rbtExtracurricular.TabIndex = 21;
            this.rbtExtracurricular.TabStop = true;
            this.rbtExtracurricular.Text = "Extracurricular";
            this.rbtExtracurricular.UseVisualStyleBackColor = true;
            // 
            // rbtAcademico
            // 
            this.rbtAcademico.AutoSize = true;
            this.rbtAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAcademico.Location = new System.Drawing.Point(358, 53);
            this.rbtAcademico.Name = "rbtAcademico";
            this.rbtAcademico.Size = new System.Drawing.Size(97, 20);
            this.rbtAcademico.TabIndex = 22;
            this.rbtAcademico.TabStop = true;
            this.rbtAcademico.Text = "Academico";
            this.rbtAcademico.UseVisualStyleBackColor = true;
            // 
            // rdbClub
            // 
            this.rdbClub.AutoSize = true;
            this.rdbClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbClub.Location = new System.Drawing.Point(152, 53);
            this.rdbClub.Name = "rdbClub";
            this.rdbClub.Size = new System.Drawing.Size(55, 20);
            this.rdbClub.TabIndex = 23;
            this.rdbClub.TabStop = true;
            this.rdbClub.Text = "Club";
            this.rdbClub.UseVisualStyleBackColor = true;
            // 
            // lblTipoBeneficio
            // 
            this.lblTipoBeneficio.AutoSize = true;
            this.lblTipoBeneficio.Location = new System.Drawing.Point(9, 95);
            this.lblTipoBeneficio.Name = "lblTipoBeneficio";
            this.lblTipoBeneficio.Size = new System.Drawing.Size(134, 16);
            this.lblTipoBeneficio.TabIndex = 24;
            this.lblTipoBeneficio.Text = "Tipo de Beneficio:";
            // 
            // rbtHorasLaborales
            // 
            this.rbtHorasLaborales.AutoSize = true;
            this.rbtHorasLaborales.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtHorasLaborales.Location = new System.Drawing.Point(152, 91);
            this.rbtHorasLaborales.Name = "rbtHorasLaborales";
            this.rbtHorasLaborales.Size = new System.Drawing.Size(129, 20);
            this.rbtHorasLaborales.TabIndex = 25;
            this.rbtHorasLaborales.TabStop = true;
            this.rbtHorasLaborales.Text = "Horas Laborales";
            this.rbtHorasLaborales.UseVisualStyleBackColor = true;
            // 
            // rbtPartidos
            // 
            this.rbtPartidos.AutoSize = true;
            this.rbtPartidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPartidos.Location = new System.Drawing.Point(303, 91);
            this.rbtPartidos.Name = "rbtPartidos";
            this.rbtPartidos.Size = new System.Drawing.Size(78, 20);
            this.rbtPartidos.TabIndex = 26;
            this.rbtPartidos.TabStop = true;
            this.rbtPartidos.Text = "Partidos";
            this.rbtPartidos.UseVisualStyleBackColor = true;
            // 
            // lblNombreEvento
            // 
            this.lblNombreEvento.AutoSize = true;
            this.lblNombreEvento.Location = new System.Drawing.Point(12, 127);
            this.lblNombreEvento.Name = "lblNombreEvento";
            this.lblNombreEvento.Size = new System.Drawing.Size(144, 16);
            this.lblNombreEvento.TabIndex = 27;
            this.lblNombreEvento.Text = "Nombre del Evento:";
            // 
            // txtbNombreEvento
            // 
            this.txtbNombreEvento.Location = new System.Drawing.Point(162, 124);
            this.txtbNombreEvento.Name = "txtbNombreEvento";
            this.txtbNombreEvento.Size = new System.Drawing.Size(230, 22);
            this.txtbNombreEvento.TabIndex = 28;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(15, 158);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(63, 16);
            this.lblHorario.TabIndex = 29;
            this.lblHorario.Text = "Horario:";
            // 
            // txtbHorario
            // 
            this.txtbHorario.Location = new System.Drawing.Point(162, 158);
            this.txtbHorario.Name = "txtbHorario";
            this.txtbHorario.Size = new System.Drawing.Size(230, 22);
            this.txtbHorario.TabIndex = 30;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(15, 188);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(50, 16);
            this.lblLugar.TabIndex = 31;
            this.lblLugar.Text = "Lugar:";
            // 
            // txtbLugar
            // 
            this.txtbLugar.Location = new System.Drawing.Point(162, 188);
            this.txtbLugar.Name = "txtbLugar";
            this.txtbLugar.Size = new System.Drawing.Size(230, 22);
            this.txtbLugar.TabIndex = 32;
            // 
            // lblCupos
            // 
            this.lblCupos.AutoSize = true;
            this.lblCupos.Location = new System.Drawing.Point(18, 224);
            this.lblCupos.Name = "lblCupos";
            this.lblCupos.Size = new System.Drawing.Size(55, 16);
            this.lblCupos.TabIndex = 33;
            this.lblCupos.Text = "Cupos:";
            // 
            // txtbCupos
            // 
            this.txtbCupos.Location = new System.Drawing.Point(162, 224);
            this.txtbCupos.Name = "txtbCupos";
            this.txtbCupos.Size = new System.Drawing.Size(230, 22);
            this.txtbCupos.TabIndex = 34;
            // 
            // Añadir_Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.imgIconApp);
            this.Controls.Add(this.gbxNuevoEvento);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Añadir_Eventos";
            this.Text = "MyHoursUAM - Añadir Eventos";
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).EndInit();
            this.gbxNuevoEvento.ResumeLayout(false);
            this.gbxNuevoEvento.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox imgIconApp;
        private System.Windows.Forms.GroupBox gbxNuevoEvento;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAñadirEventos;
        private System.Windows.Forms.Button btnEvento;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.RadioButton rbtHorasLaborales;
        private System.Windows.Forms.Label lblTipoBeneficio;
        private System.Windows.Forms.RadioButton rdbClub;
        private System.Windows.Forms.RadioButton rbtAcademico;
        private System.Windows.Forms.RadioButton rbtExtracurricular;
        private System.Windows.Forms.Label lblTipodeEvento;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtbNombreEvento;
        private System.Windows.Forms.Label lblNombreEvento;
        private System.Windows.Forms.RadioButton rbtPartidos;
        private System.Windows.Forms.TextBox txtbCupos;
        private System.Windows.Forms.Label lblCupos;
        private System.Windows.Forms.TextBox txtbLugar;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtbHorario;
    }
}