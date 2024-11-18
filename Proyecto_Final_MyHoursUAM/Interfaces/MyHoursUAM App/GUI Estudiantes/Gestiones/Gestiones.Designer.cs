namespace MyHoursUAM_App.GUI_Estudiantes.Gestiones
{
    partial class Gestiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestiones));
            this.imgIconApp = new System.Windows.Forms.PictureBox();
            this.gbxVisualizarEventos = new System.Windows.Forms.GroupBox();
            this.btnEliminarAsistencia = new System.Windows.Forms.Button();
            this.lblConanca = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnGestiones = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).BeginInit();
            this.gbxVisualizarEventos.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgIconApp
            // 
            this.imgIconApp.Image = ((System.Drawing.Image)(resources.GetObject("imgIconApp.Image")));
            this.imgIconApp.Location = new System.Drawing.Point(358, 212);
            this.imgIconApp.Name = "imgIconApp";
            this.imgIconApp.Size = new System.Drawing.Size(132, 60);
            this.imgIconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIconApp.TabIndex = 12;
            this.imgIconApp.TabStop = false;
            // 
            // gbxVisualizarEventos
            // 
            this.gbxVisualizarEventos.Controls.Add(this.lblEstado);
            this.gbxVisualizarEventos.Controls.Add(this.btnEliminarAsistencia);
            this.gbxVisualizarEventos.Controls.Add(this.lblConanca);
            this.gbxVisualizarEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVisualizarEventos.Location = new System.Drawing.Point(13, 111);
            this.gbxVisualizarEventos.Name = "gbxVisualizarEventos";
            this.gbxVisualizarEventos.Size = new System.Drawing.Size(474, 95);
            this.gbxVisualizarEventos.TabIndex = 11;
            this.gbxVisualizarEventos.TabStop = false;
            this.gbxVisualizarEventos.Text = "Eventos Inscritos";
            // 
            // btnEliminarAsistencia
            // 
            this.btnEliminarAsistencia.Location = new System.Drawing.Point(403, 37);
            this.btnEliminarAsistencia.Name = "btnEliminarAsistencia";
            this.btnEliminarAsistencia.Size = new System.Drawing.Size(60, 36);
            this.btnEliminarAsistencia.TabIndex = 4;
            this.btnEliminarAsistencia.Text = "🗑";
            this.btnEliminarAsistencia.UseVisualStyleBackColor = true;
            // 
            // lblConanca
            // 
            this.lblConanca.AutoSize = true;
            this.lblConanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConanca.Location = new System.Drawing.Point(26, 47);
            this.lblConanca.Name = "lblConanca";
            this.lblConanca.Size = new System.Drawing.Size(80, 16);
            this.lblConanca.TabIndex = 3;
            this.lblConanca.Text = "CONANCA";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEventos);
            this.flowLayoutPanel1.Controls.Add(this.btnAsistencia);
            this.flowLayoutPanel1.Controls.Add(this.btnGestiones);
            this.flowLayoutPanel1.Controls.Add(this.btnPerfil);
            this.flowLayoutPanel1.Controls.Add(this.btnAjustes);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(477, 73);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // btnEventos
            // 
            this.btnEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventos.Location = new System.Drawing.Point(3, 3);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(85, 55);
            this.btnEventos.TabIndex = 0;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.Location = new System.Drawing.Point(94, 3);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(100, 55);
            this.btnAsistencia.TabIndex = 1;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            // 
            // btnGestiones
            // 
            this.btnGestiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestiones.Location = new System.Drawing.Point(200, 3);
            this.btnGestiones.Name = "btnGestiones";
            this.btnGestiones.Size = new System.Drawing.Size(96, 55);
            this.btnGestiones.TabIndex = 2;
            this.btnGestiones.Text = "Gestiones";
            this.btnGestiones.UseVisualStyleBackColor = true;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.Location = new System.Drawing.Point(302, 3);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(86, 55);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.Text = "Mi Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // btnAjustes
            // 
            this.btnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.Location = new System.Drawing.Point(394, 3);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(72, 54);
            this.btnAjustes.TabIndex = 4;
            this.btnAjustes.Text = "Ajustes";
            this.btnAjustes.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(194, 47);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(114, 16);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado: Inscrito";
            // 
            // Gestiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 283);
            this.Controls.Add(this.imgIconApp);
            this.Controls.Add(this.gbxVisualizarEventos);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Gestiones";
            this.Text = "MyHoursUAM - Gestiones";
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).EndInit();
            this.gbxVisualizarEventos.ResumeLayout(false);
            this.gbxVisualizarEventos.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgIconApp;
        private System.Windows.Forms.GroupBox gbxVisualizarEventos;
        private System.Windows.Forms.Button btnEliminarAsistencia;
        private System.Windows.Forms.Label lblConanca;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnGestiones;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Label lblEstado;
    }
}