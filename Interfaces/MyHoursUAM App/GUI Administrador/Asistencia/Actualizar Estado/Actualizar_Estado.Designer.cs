namespace MyHoursUAM_App.GUI_Administrador.Asistencia.Actualizar_Estado
{
    partial class Actualizar_Estado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Estado));
            this.gbxAsistencias = new System.Windows.Forms.GroupBox();
            this.lblCIFNumber = new System.Windows.Forms.Label();
            this.lblCIF = new System.Windows.Forms.Label();
            this.imgIconApp = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAñadirEventos = new System.Windows.Forms.Button();
            this.btnEvento = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblCONANCA = new System.Windows.Forms.Label();
            this.lblBeneficio = new System.Windows.Forms.Label();
            this.lblBeneficioDescripcion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.rbtPendiente = new System.Windows.Forms.RadioButton();
            this.rbtAprobado = new System.Windows.Forms.RadioButton();
            this.rbtRechazado = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxAsistencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAsistencias
            // 
            this.gbxAsistencias.Controls.Add(this.rbtRechazado);
            this.gbxAsistencias.Controls.Add(this.rbtAprobado);
            this.gbxAsistencias.Controls.Add(this.rbtPendiente);
            this.gbxAsistencias.Controls.Add(this.lblEstado);
            this.gbxAsistencias.Controls.Add(this.lblBeneficioDescripcion);
            this.gbxAsistencias.Controls.Add(this.lblBeneficio);
            this.gbxAsistencias.Controls.Add(this.lblCONANCA);
            this.gbxAsistencias.Controls.Add(this.lblEvento);
            this.gbxAsistencias.Controls.Add(this.lblCIFNumber);
            this.gbxAsistencias.Controls.Add(this.lblCIF);
            this.gbxAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAsistencias.Location = new System.Drawing.Point(5, 96);
            this.gbxAsistencias.Name = "gbxAsistencias";
            this.gbxAsistencias.Size = new System.Drawing.Size(477, 187);
            this.gbxAsistencias.TabIndex = 30;
            this.gbxAsistencias.TabStop = false;
            this.gbxAsistencias.Text = "Asistencias por Confirmar";
            // 
            // lblCIFNumber
            // 
            this.lblCIFNumber.AutoSize = true;
            this.lblCIFNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIFNumber.Location = new System.Drawing.Point(87, 35);
            this.lblCIFNumber.Name = "lblCIFNumber";
            this.lblCIFNumber.Size = new System.Drawing.Size(70, 16);
            this.lblCIFNumber.TabIndex = 1;
            this.lblCIFNumber.Text = "123455678";
            // 
            // lblCIF
            // 
            this.lblCIF.AutoSize = true;
            this.lblCIF.Location = new System.Drawing.Point(7, 35);
            this.lblCIF.Name = "lblCIF";
            this.lblCIF.Size = new System.Drawing.Size(38, 16);
            this.lblCIF.TabIndex = 0;
            this.lblCIF.Text = "CIF: ";
            // 
            // imgIconApp
            // 
            this.imgIconApp.Image = ((System.Drawing.Image)(resources.GetObject("imgIconApp.Image")));
            this.imgIconApp.Location = new System.Drawing.Point(350, 299);
            this.imgIconApp.Name = "imgIconApp";
            this.imgIconApp.Size = new System.Drawing.Size(132, 60);
            this.imgIconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIconApp.TabIndex = 29;
            this.imgIconApp.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAñadirEventos);
            this.flowLayoutPanel1.Controls.Add(this.btnEvento);
            this.flowLayoutPanel1.Controls.Add(this.btnAsistencia);
            this.flowLayoutPanel1.Controls.Add(this.btnAjustes);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(477, 73);
            this.flowLayoutPanel1.TabIndex = 28;
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
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(10, 77);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(59, 16);
            this.lblEvento.TabIndex = 2;
            this.lblEvento.Text = "Evento:";
            // 
            // lblCONANCA
            // 
            this.lblCONANCA.AutoSize = true;
            this.lblCONANCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONANCA.Location = new System.Drawing.Point(87, 77);
            this.lblCONANCA.Name = "lblCONANCA";
            this.lblCONANCA.Size = new System.Drawing.Size(73, 16);
            this.lblCONANCA.TabIndex = 3;
            this.lblCONANCA.Text = "CONANCA";
            // 
            // lblBeneficio
            // 
            this.lblBeneficio.AutoSize = true;
            this.lblBeneficio.Location = new System.Drawing.Point(10, 116);
            this.lblBeneficio.Name = "lblBeneficio";
            this.lblBeneficio.Size = new System.Drawing.Size(76, 16);
            this.lblBeneficio.TabIndex = 4;
            this.lblBeneficio.Text = "Beneficio:";
            // 
            // lblBeneficioDescripcion
            // 
            this.lblBeneficioDescripcion.AutoSize = true;
            this.lblBeneficioDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficioDescripcion.Location = new System.Drawing.Point(96, 116);
            this.lblBeneficioDescripcion.Name = "lblBeneficioDescripcion";
            this.lblBeneficioDescripcion.Size = new System.Drawing.Size(108, 16);
            this.lblBeneficioDescripcion.TabIndex = 5;
            this.lblBeneficioDescripcion.Text = "Horas Laborales";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(10, 157);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 16);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // rbtPendiente
            // 
            this.rbtPendiente.AutoSize = true;
            this.rbtPendiente.Location = new System.Drawing.Point(90, 157);
            this.rbtPendiente.Name = "rbtPendiente";
            this.rbtPendiente.Size = new System.Drawing.Size(98, 20);
            this.rbtPendiente.TabIndex = 7;
            this.rbtPendiente.TabStop = true;
            this.rbtPendiente.Text = "Pendiente";
            this.rbtPendiente.UseVisualStyleBackColor = true;
            // 
            // rbtAprobado
            // 
            this.rbtAprobado.AutoSize = true;
            this.rbtAprobado.Location = new System.Drawing.Point(212, 157);
            this.rbtAprobado.Name = "rbtAprobado";
            this.rbtAprobado.Size = new System.Drawing.Size(97, 20);
            this.rbtAprobado.TabIndex = 8;
            this.rbtAprobado.TabStop = true;
            this.rbtAprobado.Text = "Aprobado";
            this.rbtAprobado.UseVisualStyleBackColor = true;
            // 
            // rbtRechazado
            // 
            this.rbtRechazado.AutoSize = true;
            this.rbtRechazado.Location = new System.Drawing.Point(325, 157);
            this.rbtRechazado.Name = "rbtRechazado";
            this.rbtRechazado.Size = new System.Drawing.Size(107, 20);
            this.rbtRechazado.TabIndex = 9;
            this.rbtRechazado.TabStop = true;
            this.rbtRechazado.Text = "Rechazado";
            this.rbtRechazado.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(150, 312);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(43, 23);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "✔";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(253, 312);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(41, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "❌";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Actualizar_Estado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 373);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbxAsistencias);
            this.Controls.Add(this.imgIconApp);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Actualizar_Estado";
            this.Text = "MyHoursUAM - Actualizar Estado";
            this.gbxAsistencias.ResumeLayout(false);
            this.gbxAsistencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAsistencias;
        private System.Windows.Forms.Label lblCIFNumber;
        private System.Windows.Forms.Label lblCIF;
        private System.Windows.Forms.PictureBox imgIconApp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAñadirEventos;
        private System.Windows.Forms.Button btnEvento;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Label lblCONANCA;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.RadioButton rbtAprobado;
        private System.Windows.Forms.RadioButton rbtPendiente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblBeneficioDescripcion;
        private System.Windows.Forms.Label lblBeneficio;
        private System.Windows.Forms.RadioButton rbtRechazado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}