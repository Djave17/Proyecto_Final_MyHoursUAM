﻿namespace MyHoursUAM_App.GUI_Administrador.Eventos
{
    partial class Eventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eventos));
            this.imgIconApp = new System.Windows.Forms.PictureBox();
            this.gbxEventos = new System.Windows.Forms.GroupBox();
            this.gbxConanca = new System.Windows.Forms.GroupBox();
            this.lblCupos = new System.Windows.Forms.Label();
            this.lblCuposNumber = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblDescripcionLugar = new System.Windows.Forms.Label();
            this.lblHorarioNumber = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.lblHL = new System.Windows.Forms.Label();
            this.lblBeneficio = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.lblDescripciones = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.cbxBeneficio = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblBeneficios = new System.Windows.Forms.Label();
            this.cbxTypeEvent = new System.Windows.Forms.ComboBox();
            this.cbxHorario = new System.Windows.Forms.ComboBox();
            this.lblTypeEvent = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAñadirEventos = new System.Windows.Forms.Button();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).BeginInit();
            this.gbxEventos.SuspendLayout();
            this.gbxConanca.SuspendLayout();
            this.gbxFiltros.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgIconApp
            // 
            this.imgIconApp.Image = ((System.Drawing.Image)(resources.GetObject("imgIconApp.Image")));
            this.imgIconApp.Location = new System.Drawing.Point(524, 510);
            this.imgIconApp.Name = "imgIconApp";
            this.imgIconApp.Size = new System.Drawing.Size(132, 60);
            this.imgIconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIconApp.TabIndex = 12;
            this.imgIconApp.TabStop = false;
            // 
            // gbxEventos
            // 
            this.gbxEventos.Controls.Add(this.gbxConanca);
            this.gbxEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEventos.Location = new System.Drawing.Point(12, 186);
            this.gbxEventos.Name = "gbxEventos";
            this.gbxEventos.Size = new System.Drawing.Size(644, 318);
            this.gbxEventos.TabIndex = 11;
            this.gbxEventos.TabStop = false;
            this.gbxEventos.Text = "Eventos";
            // 
            // gbxConanca
            // 
            this.gbxConanca.Controls.Add(this.btnEditar);
            this.gbxConanca.Controls.Add(this.lblCupos);
            this.gbxConanca.Controls.Add(this.lblCuposNumber);
            this.gbxConanca.Controls.Add(this.lblLugar);
            this.gbxConanca.Controls.Add(this.lblDescripcionLugar);
            this.gbxConanca.Controls.Add(this.lblHorarioNumber);
            this.gbxConanca.Controls.Add(this.l);
            this.gbxConanca.Controls.Add(this.lblHL);
            this.gbxConanca.Controls.Add(this.lblBeneficio);
            this.gbxConanca.Controls.Add(this.lblEvento);
            this.gbxConanca.Controls.Add(this.lblTipoEvento);
            this.gbxConanca.Controls.Add(this.lblDescripciones);
            this.gbxConanca.Controls.Add(this.lblDescripcion);
            this.gbxConanca.Controls.Add(this.btnRegistrar);
            this.gbxConanca.Location = new System.Drawing.Point(9, 30);
            this.gbxConanca.Name = "gbxConanca";
            this.gbxConanca.Size = new System.Drawing.Size(629, 267);
            this.gbxConanca.TabIndex = 0;
            this.gbxConanca.TabStop = false;
            this.gbxConanca.Text = "CONANCA";
            // 
            // lblCupos
            // 
            this.lblCupos.AutoSize = true;
            this.lblCupos.Location = new System.Drawing.Point(19, 236);
            this.lblCupos.Name = "lblCupos";
            this.lblCupos.Size = new System.Drawing.Size(55, 16);
            this.lblCupos.TabIndex = 12;
            this.lblCupos.Text = "Cupos:";
            // 
            // lblCuposNumber
            // 
            this.lblCuposNumber.AutoSize = true;
            this.lblCuposNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuposNumber.Location = new System.Drawing.Point(143, 236);
            this.lblCuposNumber.Name = "lblCuposNumber";
            this.lblCuposNumber.Size = new System.Drawing.Size(21, 16);
            this.lblCuposNumber.TabIndex = 11;
            this.lblCuposNumber.Text = "35";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(19, 197);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(50, 16);
            this.lblLugar.TabIndex = 10;
            this.lblLugar.Text = "Lugar:";
            // 
            // lblDescripcionLugar
            // 
            this.lblDescripcionLugar.AutoSize = true;
            this.lblDescripcionLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionLugar.Location = new System.Drawing.Point(143, 197);
            this.lblDescripcionLugar.Name = "lblDescripcionLugar";
            this.lblDescripcionLugar.Size = new System.Drawing.Size(105, 16);
            this.lblDescripcionLugar.TabIndex = 9;
            this.lblDescripcionLugar.Text = "Auditorio Central";
            // 
            // lblHorarioNumber
            // 
            this.lblHorarioNumber.AutoSize = true;
            this.lblHorarioNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioNumber.Location = new System.Drawing.Point(143, 157);
            this.lblHorarioNumber.Name = "lblHorarioNumber";
            this.lblHorarioNumber.Size = new System.Drawing.Size(81, 16);
            this.lblHorarioNumber.TabIndex = 8;
            this.lblHorarioNumber.Text = "7AM - 12 PM";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(19, 157);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(63, 16);
            this.l.TabIndex = 7;
            this.l.Tag = "lblHorario";
            this.l.Text = "Horario:";
            // 
            // lblHL
            // 
            this.lblHL.AutoSize = true;
            this.lblHL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHL.Location = new System.Drawing.Point(143, 111);
            this.lblHL.Name = "lblHL";
            this.lblHL.Size = new System.Drawing.Size(108, 16);
            this.lblHL.TabIndex = 6;
            this.lblHL.Text = "Horas Laborales";
            // 
            // lblBeneficio
            // 
            this.lblBeneficio.AutoSize = true;
            this.lblBeneficio.Location = new System.Drawing.Point(19, 111);
            this.lblBeneficio.Name = "lblBeneficio";
            this.lblBeneficio.Size = new System.Drawing.Size(76, 16);
            this.lblBeneficio.TabIndex = 5;
            this.lblBeneficio.Text = "Beneficio:";
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.Location = new System.Drawing.Point(143, 75);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(91, 16);
            this.lblEvento.TabIndex = 4;
            this.lblEvento.Text = "Extracurricular";
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Location = new System.Drawing.Point(16, 75);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(117, 16);
            this.lblTipoEvento.TabIndex = 3;
            this.lblTipoEvento.Text = "Tipo de Evento:";
            // 
            // lblDescripciones
            // 
            this.lblDescripciones.AutoSize = true;
            this.lblDescripciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripciones.Location = new System.Drawing.Point(143, 38);
            this.lblDescripciones.Name = "lblDescripciones";
            this.lblDescripciones.Size = new System.Drawing.Size(419, 16);
            this.lblDescripciones.TabIndex = 2;
            this.lblDescripciones.Text = "Se organizara una colecta de dinero para la Organizacion CONANCA";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 38);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 16);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(545, 170);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(54, 43);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "✔";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.cbxBeneficio);
            this.gbxFiltros.Controls.Add(this.lblHorario);
            this.gbxFiltros.Controls.Add(this.lblBeneficios);
            this.gbxFiltros.Controls.Add(this.cbxTypeEvent);
            this.gbxFiltros.Controls.Add(this.cbxHorario);
            this.gbxFiltros.Controls.Add(this.lblTypeEvent);
            this.gbxFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFiltros.Location = new System.Drawing.Point(12, 101);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(644, 78);
            this.gbxFiltros.TabIndex = 10;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros de Busqueda";
            // 
            // cbxBeneficio
            // 
            this.cbxBeneficio.FormattingEnabled = true;
            this.cbxBeneficio.Location = new System.Drawing.Point(520, 29);
            this.cbxBeneficio.Name = "cbxBeneficio";
            this.cbxBeneficio.Size = new System.Drawing.Size(99, 24);
            this.cbxBeneficio.TabIndex = 12;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(6, 32);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(59, 16);
            this.lblHorario.TabIndex = 8;
            this.lblHorario.Text = "Horario";
            // 
            // lblBeneficios
            // 
            this.lblBeneficios.AutoSize = true;
            this.lblBeneficios.Location = new System.Drawing.Point(442, 32);
            this.lblBeneficios.Name = "lblBeneficios";
            this.lblBeneficios.Size = new System.Drawing.Size(72, 16);
            this.lblBeneficios.TabIndex = 10;
            this.lblBeneficios.Text = "Beneficio";
            // 
            // cbxTypeEvent
            // 
            this.cbxTypeEvent.FormattingEnabled = true;
            this.cbxTypeEvent.Location = new System.Drawing.Point(319, 29);
            this.cbxTypeEvent.Name = "cbxTypeEvent";
            this.cbxTypeEvent.Size = new System.Drawing.Size(99, 24);
            this.cbxTypeEvent.TabIndex = 11;
            // 
            // cbxHorario
            // 
            this.cbxHorario.FormattingEnabled = true;
            this.cbxHorario.Location = new System.Drawing.Point(71, 29);
            this.cbxHorario.Name = "cbxHorario";
            this.cbxHorario.Size = new System.Drawing.Size(99, 24);
            this.cbxHorario.TabIndex = 7;
            // 
            // lblTypeEvent
            // 
            this.lblTypeEvent.AutoSize = true;
            this.lblTypeEvent.Location = new System.Drawing.Point(200, 32);
            this.lblTypeEvent.Name = "lblTypeEvent";
            this.lblTypeEvent.Size = new System.Drawing.Size(113, 16);
            this.lblTypeEvent.TabIndex = 9;
            this.lblTypeEvent.Text = "Tipo de Evento";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAñadirEventos);
            this.flowLayoutPanel1.Controls.Add(this.btnEventos);
            this.flowLayoutPanel1.Controls.Add(this.btnAsistencia);
            this.flowLayoutPanel1.Controls.Add(this.btnAjustes);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(666, 73);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnAñadirEventos
            // 
            this.btnAñadirEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirEventos.Location = new System.Drawing.Point(3, 3);
            this.btnAñadirEventos.Name = "btnAñadirEventos";
            this.btnAñadirEventos.Size = new System.Drawing.Size(142, 55);
            this.btnAñadirEventos.TabIndex = 0;
            this.btnAñadirEventos.Text = "Añadir Eventos";
            this.btnAñadirEventos.UseVisualStyleBackColor = true;
            // 
            // btnEventos
            // 
            this.btnEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.Location = new System.Drawing.Point(151, 3);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(154, 55);
            this.btnEventos.TabIndex = 1;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.Location = new System.Drawing.Point(311, 3);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(158, 55);
            this.btnAsistencia.TabIndex = 3;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            // 
            // btnAjustes
            // 
            this.btnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.Location = new System.Drawing.Point(475, 3);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(181, 54);
            this.btnAjustes.TabIndex = 4;
            this.btnAjustes.Text = "Ajustes";
            this.btnAjustes.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(545, 111);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(54, 43);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "✏";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 583);
            this.Controls.Add(this.imgIconApp);
            this.Controls.Add(this.gbxEventos);
            this.Controls.Add(this.gbxFiltros);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Eventos";
            this.Text = "MyHoursUAM - Eventos";
            this.Load += new System.EventHandler(this.Eventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).EndInit();
            this.gbxEventos.ResumeLayout(false);
            this.gbxConanca.ResumeLayout(false);
            this.gbxConanca.PerformLayout();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgIconApp;
        private System.Windows.Forms.GroupBox gbxEventos;
        private System.Windows.Forms.GroupBox gbxConanca;
        private System.Windows.Forms.Label lblCupos;
        private System.Windows.Forms.Label lblCuposNumber;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblDescripcionLugar;
        private System.Windows.Forms.Label lblHorarioNumber;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label lblHL;
        private System.Windows.Forms.Label lblBeneficio;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.Label lblDescripciones;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.ComboBox cbxBeneficio;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblBeneficios;
        private System.Windows.Forms.ComboBox cbxTypeEvent;
        private System.Windows.Forms.ComboBox cbxHorario;
        private System.Windows.Forms.Label lblTypeEvent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAñadirEventos;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Button btnEditar;
    }
}