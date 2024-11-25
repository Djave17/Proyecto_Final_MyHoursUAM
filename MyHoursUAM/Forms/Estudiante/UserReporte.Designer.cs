namespace MyHours_UAMApp
{
    partial class UserReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserReporte));
            this.btnReporte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnVerEventos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.pnlAreaAdministrador = new System.Windows.Forms.Panel();
            this.pnlPieArriba = new System.Windows.Forms.Panel();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.pcbLogOutIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.pcbStudentIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlIcon.SuspendLayout();
            this.pnlAreaAdministrador.SuspendLayout();
            this.pnlPieArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStudentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(12, 527);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(202, 119);
            this.btnReporte.TabIndex = 15;
            this.btnReporte.Text = "📄 Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnPartidos);
            this.panel1.Controls.Add(this.btnAjustes);
            this.panel1.Controls.Add(this.btnVerEventos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 769);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 122);
            this.button1.TabIndex = 13;
            this.button1.Text = "👤 Mi Perfil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 519);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 127);
            this.panel2.TabIndex = 3;
            // 
            // btnPartidos
            // 
            this.btnPartidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPartidos.FlatAppearance.BorderSize = 0;
            this.btnPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartidos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartidos.ForeColor = System.Drawing.Color.White;
            this.btnPartidos.Location = new System.Drawing.Point(-3, 124);
            this.btnPartidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(220, 119);
            this.btnPartidos.TabIndex = 9;
            this.btnPartidos.Text = "⚽ Partidos";
            this.btnPartidos.UseVisualStyleBackColor = false;
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.Location = new System.Drawing.Point(-6, 378);
            this.btnAjustes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(220, 122);
            this.btnAjustes.TabIndex = 12;
            this.btnAjustes.Text = "⚙️   Ajustes";
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // btnVerEventos
            // 
            this.btnVerEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnVerEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerEventos.FlatAppearance.BorderSize = 0;
            this.btnVerEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEventos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEventos.ForeColor = System.Drawing.Color.White;
            this.btnVerEventos.Location = new System.Drawing.Point(-3, 6);
            this.btnVerEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerEventos.Name = "btnVerEventos";
            this.btnVerEventos.Size = new System.Drawing.Size(220, 122);
            this.btnVerEventos.TabIndex = 10;
            this.btnVerEventos.Text = "👁  Ver Eventos";
            this.btnVerEventos.UseVisualStyleBackColor = false;
            this.btnVerEventos.Click += new System.EventHandler(this.btnVerEventos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // pnlIcon
            // 
            this.pnlIcon.Controls.Add(this.pictureBox1);
            this.pnlIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIcon.Location = new System.Drawing.Point(0, 0);
            this.pnlIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(220, 90);
            this.pnlIcon.TabIndex = 1;
            // 
            // pnlAreaAdministrador
            // 
            this.pnlAreaAdministrador.BackColor = System.Drawing.Color.Teal;
            this.pnlAreaAdministrador.Controls.Add(this.panel1);
            this.pnlAreaAdministrador.Controls.Add(this.pnlIcon);
            this.pnlAreaAdministrador.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAreaAdministrador.ForeColor = System.Drawing.Color.White;
            this.pnlAreaAdministrador.Location = new System.Drawing.Point(0, 0);
            this.pnlAreaAdministrador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAreaAdministrador.Name = "pnlAreaAdministrador";
            this.pnlAreaAdministrador.Size = new System.Drawing.Size(220, 738);
            this.pnlAreaAdministrador.TabIndex = 12;
            // 
            // pnlPieArriba
            // 
            this.pnlPieArriba.BackColor = System.Drawing.Color.White;
            this.pnlPieArriba.Controls.Add(this.lblCerrarSesion);
            this.pnlPieArriba.Controls.Add(this.pcbLogOutIcon);
            this.pnlPieArriba.Controls.Add(this.label1);
            this.pnlPieArriba.Controls.Add(this.lblEstudiante);
            this.pnlPieArriba.Controls.Add(this.pcbStudentIcon);
            this.pnlPieArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPieArriba.Location = new System.Drawing.Point(220, 0);
            this.pnlPieArriba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPieArriba.Name = "pnlPieArriba";
            this.pnlPieArriba.Size = new System.Drawing.Size(887, 90);
            this.pnlPieArriba.TabIndex = 13;
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.Teal;
            this.lblCerrarSesion.Location = new System.Drawing.Point(779, 43);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(102, 16);
            this.lblCerrarSesion.TabIndex = 4;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblCerrarSesion_Click);
            // 
            // pcbLogOutIcon
            // 
            this.pcbLogOutIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogOutIcon.Image")));
            this.pcbLogOutIcon.Location = new System.Drawing.Point(720, 23);
            this.pcbLogOutIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbLogOutIcon.Name = "pcbLogOutIcon";
            this.pcbLogOutIcon.Size = new System.Drawing.Size(53, 50);
            this.pcbLogOutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogOutIcon.TabIndex = 3;
            this.pcbLogOutIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "DASHBOARD";
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.ForeColor = System.Drawing.Color.Teal;
            this.lblEstudiante.Location = new System.Drawing.Point(633, 43);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(80, 16);
            this.lblEstudiante.TabIndex = 0;
            this.lblEstudiante.Text = "Estudiante";
            // 
            // pcbStudentIcon
            // 
            this.pcbStudentIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbStudentIcon.Image")));
            this.pcbStudentIcon.Location = new System.Drawing.Point(579, 26);
            this.pcbStudentIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbStudentIcon.Name = "pcbStudentIcon";
            this.pcbStudentIcon.Size = new System.Drawing.Size(48, 47);
            this.pcbStudentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbStudentIcon.TabIndex = 0;
            this.pcbStudentIcon.TabStop = false;
            // 
            // UserReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1107, 738);
            this.Controls.Add(this.pnlPieArriba);
            this.Controls.Add(this.pnlAreaAdministrador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyHoursUAM - Reporte";
            this.Load += new System.EventHandler(this.UserReporte_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlIcon.ResumeLayout(false);
            this.pnlAreaAdministrador.ResumeLayout(false);
            this.pnlPieArriba.ResumeLayout(false);
            this.pnlPieArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStudentIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Button btnVerEventos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.Panel pnlAreaAdministrador;
        private System.Windows.Forms.Panel pnlPieArriba;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.PictureBox pcbLogOutIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.PictureBox pcbStudentIcon;
        private System.Windows.Forms.Button btnPartidos;
    }
}