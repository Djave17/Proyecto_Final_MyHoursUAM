namespace MyHours_UAMApp.Forms.Estudiante
{
    partial class UserReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserReportView));
            this.pnlPieArriba = new System.Windows.Forms.Panel();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.pcbLogOutIcon = new System.Windows.Forms.PictureBox();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.pcbStudentIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAreaAdministrador = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnVerEventos = new System.Windows.Forms.Button();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlPieArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStudentIcon)).BeginInit();
            this.pnlAreaAdministrador.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPieArriba
            // 
            this.pnlPieArriba.BackColor = System.Drawing.Color.White;
            this.pnlPieArriba.Controls.Add(this.lblCerrarSesion);
            this.pnlPieArriba.Controls.Add(this.pcbLogOutIcon);
            this.pnlPieArriba.Controls.Add(this.lblEstudiante);
            this.pnlPieArriba.Controls.Add(this.pcbStudentIcon);
            this.pnlPieArriba.Controls.Add(this.label1);
            this.pnlPieArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPieArriba.Location = new System.Drawing.Point(176, 0);
            this.pnlPieArriba.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPieArriba.Name = "pnlPieArriba";
            this.pnlPieArriba.Size = new System.Drawing.Size(707, 73);
            this.pnlPieArriba.TabIndex = 10;
            this.pnlPieArriba.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPieArriba_Paint);
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.Teal;
            this.lblCerrarSesion.Location = new System.Drawing.Point(620, 37);
            this.lblCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(83, 13);
            this.lblCerrarSesion.TabIndex = 8;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblCerrarSesion_Click);
            // 
            // pcbLogOutIcon
            // 
            this.pcbLogOutIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pcbLogOutIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogOutIcon.Image")));
            this.pcbLogOutIcon.Location = new System.Drawing.Point(576, 21);
            this.pcbLogOutIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pcbLogOutIcon.Name = "pcbLogOutIcon";
            this.pcbLogOutIcon.Size = new System.Drawing.Size(40, 41);
            this.pcbLogOutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogOutIcon.TabIndex = 7;
            this.pcbLogOutIcon.TabStop = false;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.ForeColor = System.Drawing.Color.Teal;
            this.lblEstudiante.Location = new System.Drawing.Point(511, 37);
            this.lblEstudiante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(67, 13);
            this.lblEstudiante.TabIndex = 5;
            this.lblEstudiante.Text = "Estudiante";
            this.lblEstudiante.Click += new System.EventHandler(this.lblEstudiante_Click);
            // 
            // pcbStudentIcon
            // 
            this.pcbStudentIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pcbStudentIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbStudentIcon.Image")));
            this.pcbStudentIcon.Location = new System.Drawing.Point(470, 24);
            this.pcbStudentIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pcbStudentIcon.Name = "pcbStudentIcon";
            this.pcbStudentIcon.Size = new System.Drawing.Size(36, 38);
            this.pcbStudentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbStudentIcon.TabIndex = 6;
            this.pcbStudentIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "DASHBOARD";
            // 
            // pnlAreaAdministrador
            // 
            this.pnlAreaAdministrador.BackColor = System.Drawing.Color.Teal;
            this.pnlAreaAdministrador.Controls.Add(this.panel1);
            this.pnlAreaAdministrador.Controls.Add(this.pnlIcon);
            this.pnlAreaAdministrador.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAreaAdministrador.ForeColor = System.Drawing.Color.White;
            this.pnlAreaAdministrador.Location = new System.Drawing.Point(0, 0);
            this.pnlAreaAdministrador.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAreaAdministrador.Name = "pnlAreaAdministrador";
            this.pnlAreaAdministrador.Size = new System.Drawing.Size(176, 591);
            this.pnlAreaAdministrador.TabIndex = 9;
            this.pnlAreaAdministrador.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAreaAdministrador_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPartidos);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAjustes);
            this.panel1.Controls.Add(this.btnAsistencia);
            this.panel1.Controls.Add(this.btnVerEventos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 624);
            this.panel1.TabIndex = 2;
            // 
            // btnPartidos
            // 
            this.btnPartidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPartidos.FlatAppearance.BorderSize = 0;
            this.btnPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos.ForeColor = System.Drawing.Color.White;
            this.btnPartidos.Location = new System.Drawing.Point(-2, 98);
            this.btnPartidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(165, 97);
            this.btnPartidos.TabIndex = 15;
            this.btnPartidos.Text = "⚽ Partidos";
            this.btnPartidos.UseVisualStyleBackColor = false;
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(-4, 414);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(165, 97);
            this.btnReporte.TabIndex = 14;
            this.btnReporte.Text = "📄 Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 99);
            this.button1.TabIndex = 13;
            this.button1.Text = "👤 Mi Perfil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 202);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 103);
            this.panel2.TabIndex = 3;
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.Location = new System.Drawing.Point(-2, 306);
            this.btnAjustes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(165, 99);
            this.btnAjustes.TabIndex = 12;
            this.btnAjustes.Text = "⚙️   Ajustes";
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.btnAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnAsistencia.Location = new System.Drawing.Point(0, 104);
            this.btnAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(0, 0);
            this.btnAsistencia.TabIndex = 11;
            this.btnAsistencia.Text = "🗒️  Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = false;
            // 
            // btnVerEventos
            // 
            this.btnVerEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnVerEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerEventos.FlatAppearance.BorderSize = 0;
            this.btnVerEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEventos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEventos.ForeColor = System.Drawing.Color.White;
            this.btnVerEventos.Location = new System.Drawing.Point(-2, 5);
            this.btnVerEventos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerEventos.Name = "btnVerEventos";
            this.btnVerEventos.Size = new System.Drawing.Size(165, 99);
            this.btnVerEventos.TabIndex = 10;
            this.btnVerEventos.Text = "👁  Ver Eventos";
            this.btnVerEventos.UseVisualStyleBackColor = false;
            this.btnVerEventos.Click += new System.EventHandler(this.btnVerEventos_Click);
            // 
            // pnlIcon
            // 
            this.pnlIcon.Controls.Add(this.pictureBox1);
            this.pnlIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIcon.Location = new System.Drawing.Point(0, 0);
            this.pnlIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(176, 73);
            this.pnlIcon.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // UserReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 591);
            this.Controls.Add(this.pnlPieArriba);
            this.Controls.Add(this.pnlAreaAdministrador);
            this.Name = "UserReportView";
            this.Text = "UserReportView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserReportView_Load);
            this.pnlPieArriba.ResumeLayout(false);
            this.pnlPieArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStudentIcon)).EndInit();
            this.pnlAreaAdministrador.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPieArriba;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.PictureBox pcbLogOutIcon;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.PictureBox pcbStudentIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAreaAdministrador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnVerEventos;
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}