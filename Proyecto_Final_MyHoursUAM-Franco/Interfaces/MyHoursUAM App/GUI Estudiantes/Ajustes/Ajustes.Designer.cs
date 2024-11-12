namespace MyHoursUAM_App.GUI_Estudiantes.Ajustes
{
    partial class Ajustes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajustes));
            this.imgIconApp = new System.Windows.Forms.PictureBox();
            this.gbxCambiarContraseña = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnGestiones = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.lblContraseñaActual = new System.Windows.Forms.Label();
            this.lblNuevaContraseña = new System.Windows.Forms.Label();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtbContraseñaActual = new System.Windows.Forms.TextBox();
            this.txtbConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).BeginInit();
            this.gbxCambiarContraseña.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgIconApp
            // 
            this.imgIconApp.Image = ((System.Drawing.Image)(resources.GetObject("imgIconApp.Image")));
            this.imgIconApp.Location = new System.Drawing.Point(358, 278);
            this.imgIconApp.Name = "imgIconApp";
            this.imgIconApp.Size = new System.Drawing.Size(132, 60);
            this.imgIconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIconApp.TabIndex = 15;
            this.imgIconApp.TabStop = false;
            // 
            // gbxCambiarContraseña
            // 
            this.gbxCambiarContraseña.Controls.Add(this.lblAviso);
            this.gbxCambiarContraseña.Controls.Add(this.txtbConfirmarContraseña);
            this.gbxCambiarContraseña.Controls.Add(this.lblConfirmarContraseña);
            this.gbxCambiarContraseña.Controls.Add(this.textBox1);
            this.gbxCambiarContraseña.Controls.Add(this.txtbContraseñaActual);
            this.gbxCambiarContraseña.Controls.Add(this.lblNuevaContraseña);
            this.gbxCambiarContraseña.Controls.Add(this.lblContraseñaActual);
            this.gbxCambiarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCambiarContraseña.Location = new System.Drawing.Point(11, 108);
            this.gbxCambiarContraseña.Name = "gbxCambiarContraseña";
            this.gbxCambiarContraseña.Size = new System.Drawing.Size(474, 164);
            this.gbxCambiarContraseña.TabIndex = 14;
            this.gbxCambiarContraseña.TabStop = false;
            this.gbxCambiarContraseña.Text = "Cambiar Contraseña";
            this.gbxCambiarContraseña.Enter += new System.EventHandler(this.gbxCambiarContraseña_Enter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnEventos);
            this.flowLayoutPanel1.Controls.Add(this.btnAsistencia);
            this.flowLayoutPanel1.Controls.Add(this.btnGestiones);
            this.flowLayoutPanel1.Controls.Add(this.btnPerfil);
            this.flowLayoutPanel1.Controls.Add(this.btnAjustes);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(477, 73);
            this.flowLayoutPanel1.TabIndex = 13;
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
            // lblContraseñaActual
            // 
            this.lblContraseñaActual.AutoSize = true;
            this.lblContraseñaActual.Location = new System.Drawing.Point(6, 63);
            this.lblContraseñaActual.Name = "lblContraseñaActual";
            this.lblContraseñaActual.Size = new System.Drawing.Size(137, 16);
            this.lblContraseñaActual.TabIndex = 0;
            this.lblContraseñaActual.Text = "Contraseña Actual:";
            // 
            // lblNuevaContraseña
            // 
            this.lblNuevaContraseña.AutoSize = true;
            this.lblNuevaContraseña.Location = new System.Drawing.Point(6, 94);
            this.lblNuevaContraseña.Name = "lblNuevaContraseña";
            this.lblNuevaContraseña.Size = new System.Drawing.Size(139, 16);
            this.lblNuevaContraseña.TabIndex = 1;
            this.lblNuevaContraseña.Text = "Nueva Contraseña:";
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(6, 126);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(160, 16);
            this.lblConfirmarContraseña.TabIndex = 2;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 16;
            // 
            // txtbContraseñaActual
            // 
            this.txtbContraseñaActual.Location = new System.Drawing.Point(172, 60);
            this.txtbContraseñaActual.Name = "txtbContraseñaActual";
            this.txtbContraseñaActual.Size = new System.Drawing.Size(158, 22);
            this.txtbContraseñaActual.TabIndex = 17;
            // 
            // txtbConfirmarContraseña
            // 
            this.txtbConfirmarContraseña.Location = new System.Drawing.Point(172, 123);
            this.txtbConfirmarContraseña.Name = "txtbConfirmarContraseña";
            this.txtbConfirmarContraseña.Size = new System.Drawing.Size(158, 22);
            this.txtbConfirmarContraseña.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(163, 291);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(53, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "✔";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(252, 291);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(52, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "❌";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(6, 28);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(244, 16);
            this.lblAviso.TabIndex = 20;
            this.lblAviso.Text = "Todos los campos son requeridos";
            // 
            // Ajustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 350);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.imgIconApp);
            this.Controls.Add(this.gbxCambiarContraseña);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Ajustes";
            this.Text = "MyHoursUAM - Ajustes";
            ((System.ComponentModel.ISupportInitialize)(this.imgIconApp)).EndInit();
            this.gbxCambiarContraseña.ResumeLayout(false);
            this.gbxCambiarContraseña.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgIconApp;
        private System.Windows.Forms.GroupBox gbxCambiarContraseña;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnGestiones;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.TextBox txtbConfirmarContraseña;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtbContraseñaActual;
        private System.Windows.Forms.Label lblNuevaContraseña;
        private System.Windows.Forms.Label lblContraseñaActual;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAviso;
    }
}