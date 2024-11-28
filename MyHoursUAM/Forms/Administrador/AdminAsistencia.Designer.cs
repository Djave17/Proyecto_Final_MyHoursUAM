namespace MyHours_UAMApp
{
    partial class AdminAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAsistencia));
            this.pnlPieArriba = new System.Windows.Forms.Panel();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.pcbLogOutIcon = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAreaAdministrador = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.btnAddPartidos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAñadirEventos = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxEstudianteEventos = new System.Windows.Forms.GroupBox();
            this.lvAsistencia = new System.Windows.Forms.ListView();
            this.clhID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhEstudianteId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhEstadoSolicitud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFechaSolicitud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDenegarAsistencia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmarAsistencia = new System.Windows.Forms.Button();
            this.pnlPieArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlAreaAdministrador.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxEstudianteEventos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPieArriba
            // 
            this.pnlPieArriba.BackColor = System.Drawing.Color.White;
            this.pnlPieArriba.Controls.Add(this.lblCerrarSesion);
            this.pnlPieArriba.Controls.Add(this.pcbLogOutIcon);
            this.pnlPieArriba.Controls.Add(this.lblAdmin);
            this.pnlPieArriba.Controls.Add(this.pictureBox2);
            this.pnlPieArriba.Controls.Add(this.label1);
            this.pnlPieArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPieArriba.Location = new System.Drawing.Point(165, 0);
            this.pnlPieArriba.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPieArriba.Name = "pnlPieArriba";
            this.pnlPieArriba.Size = new System.Drawing.Size(678, 73);
            this.pnlPieArriba.TabIndex = 7;
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.Teal;
            this.lblCerrarSesion.Location = new System.Drawing.Point(578, 28);
            this.lblCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(83, 13);
            this.lblCerrarSesion.TabIndex = 21;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblCerrarSesion_Click);
            // 
            // pcbLogOutIcon
            // 
            this.pcbLogOutIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogOutIcon.Image")));
            this.pcbLogOutIcon.Location = new System.Drawing.Point(533, 11);
            this.pcbLogOutIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pcbLogOutIcon.Name = "pcbLogOutIcon";
            this.pcbLogOutIcon.Size = new System.Drawing.Size(40, 41);
            this.pcbLogOutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogOutIcon.TabIndex = 20;
            this.pcbLogOutIcon.TabStop = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Teal;
            this.lblAdmin.Location = new System.Drawing.Point(452, 28);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(83, 13);
            this.lblAdmin.TabIndex = 18;
            this.lblAdmin.Text = "Administrador";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(411, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "MYHOURSUAM";
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
            this.pnlAreaAdministrador.Size = new System.Drawing.Size(165, 690);
            this.pnlAreaAdministrador.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGraficos);
            this.panel1.Controls.Add(this.btnAddPartidos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAñadirEventos);
            this.panel1.Controls.Add(this.btnAsistencia);
            this.panel1.Controls.Add(this.btnAjustes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 540);
            this.panel1.TabIndex = 2;
            // 
            // btnGraficos
            // 
            this.btnGraficos.BackColor = System.Drawing.Color.Transparent;
            this.btnGraficos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGraficos.FlatAppearance.BorderSize = 0;
            this.btnGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficos.ForeColor = System.Drawing.Color.White;
            this.btnGraficos.Location = new System.Drawing.Point(2, 446);
            this.btnGraficos.Margin = new System.Windows.Forms.Padding(2);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(163, 120);
            this.btnGraficos.TabIndex = 23;
            this.btnGraficos.Text = "📈 Graficos";
            this.btnGraficos.UseVisualStyleBackColor = false;
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click);
            // 
            // btnAddPartidos
            // 
            this.btnAddPartidos.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPartidos.FlatAppearance.BorderSize = 0;
            this.btnAddPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPartidos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPartidos.ForeColor = System.Drawing.Color.White;
            this.btnAddPartidos.Location = new System.Drawing.Point(0, 105);
            this.btnAddPartidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPartidos.Name = "btnAddPartidos";
            this.btnAddPartidos.Size = new System.Drawing.Size(165, 120);
            this.btnAddPartidos.TabIndex = 21;
            this.btnAddPartidos.Text = "⚽ Añadir Partidos";
            this.btnAddPartidos.UseVisualStyleBackColor = false;
            this.btnAddPartidos.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 236);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 103);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-81, -9);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 120);
            this.button1.TabIndex = 21;
            this.button1.Text = "⚽ Añadir Partidos";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAñadirEventos
            // 
            this.btnAñadirEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirEventos.FlatAppearance.BorderSize = 0;
            this.btnAñadirEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirEventos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirEventos.ForeColor = System.Drawing.Color.White;
            this.btnAñadirEventos.Location = new System.Drawing.Point(-2, 5);
            this.btnAñadirEventos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirEventos.Name = "btnAñadirEventos";
            this.btnAñadirEventos.Size = new System.Drawing.Size(165, 97);
            this.btnAñadirEventos.TabIndex = 9;
            this.btnAñadirEventos.Text = "➕ Añadir Eventos";
            this.btnAñadirEventos.UseVisualStyleBackColor = false;
            this.btnAñadirEventos.Click += new System.EventHandler(this.btnAñadirEventos_Click);
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.btnAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnAsistencia.Location = new System.Drawing.Point(0, 236);
            this.btnAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(165, 99);
            this.btnAsistencia.TabIndex = 11;
            this.btnAsistencia.Text = "🗒️  Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = false;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.Location = new System.Drawing.Point(0, 343);
            this.btnAjustes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(165, 99);
            this.btnAjustes.TabIndex = 12;
            this.btnAjustes.Text = "⚙️   Ajustes";
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // pnlIcon
            // 
            this.pnlIcon.Controls.Add(this.pictureBox1);
            this.pnlIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIcon.Location = new System.Drawing.Point(0, 0);
            this.pnlIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(165, 73);
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
            // gbxEstudianteEventos
            // 
            this.gbxEstudianteEventos.Controls.Add(this.lvAsistencia);
            this.gbxEstudianteEventos.Controls.Add(this.btnDenegarAsistencia);
            this.gbxEstudianteEventos.Controls.Add(this.label3);
            this.gbxEstudianteEventos.Controls.Add(this.label2);
            this.gbxEstudianteEventos.Controls.Add(this.btnConfirmarAsistencia);
            this.gbxEstudianteEventos.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstudianteEventos.Location = new System.Drawing.Point(191, 78);
            this.gbxEstudianteEventos.Name = "gbxEstudianteEventos";
            this.gbxEstudianteEventos.Size = new System.Drawing.Size(635, 519);
            this.gbxEstudianteEventos.TabIndex = 94;
            this.gbxEstudianteEventos.TabStop = false;
            this.gbxEstudianteEventos.Text = "Asistencia";
            // 
            // lvAsistencia
            // 
            this.lvAsistencia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhID,
            this.clhEstudianteId,
            this.clhNombre,
            this.clhEstadoSolicitud,
            this.clhFechaSolicitud});
            this.lvAsistencia.FullRowSelect = true;
            this.lvAsistencia.HideSelection = false;
            this.lvAsistencia.LabelEdit = true;
            this.lvAsistencia.Location = new System.Drawing.Point(0, 169);
            this.lvAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.lvAsistencia.Name = "lvAsistencia";
            this.lvAsistencia.Size = new System.Drawing.Size(630, 350);
            this.lvAsistencia.TabIndex = 95;
            this.lvAsistencia.UseCompatibleStateImageBehavior = false;
            this.lvAsistencia.View = System.Windows.Forms.View.Details;
            // 
            // clhID
            // 
            this.clhID.Text = "ID";
            this.clhID.Width = 100;
            // 
            // clhEstudianteId
            // 
            this.clhEstudianteId.Text = "CIF";
            this.clhEstudianteId.Width = 120;
            // 
            // clhNombre
            // 
            this.clhNombre.Text = "Evento";
            this.clhNombre.Width = 90;
            // 
            // clhEstadoSolicitud
            // 
            this.clhEstadoSolicitud.Text = "Estado ";
            this.clhEstadoSolicitud.Width = 200;
            // 
            // clhFechaSolicitud
            // 
            this.clhFechaSolicitud.Text = "Fecha";
            this.clhFechaSolicitud.Width = 220;
            // 
            // btnDenegarAsistencia
            // 
            this.btnDenegarAsistencia.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDenegarAsistencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDenegarAsistencia.Location = new System.Drawing.Point(188, 120);
            this.btnDenegarAsistencia.Name = "btnDenegarAsistencia";
            this.btnDenegarAsistencia.Size = new System.Drawing.Size(176, 29);
            this.btnDenegarAsistencia.TabIndex = 94;
            this.btnDenegarAsistencia.Text = "Denegar Asistencia";
            this.btnDenegarAsistencia.UseVisualStyleBackColor = false;
            this.btnDenegarAsistencia.Click += new System.EventHandler(this.btnDenegarAsistencia_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(644, 43);
            this.label3.TabIndex = 92;
            this.label3.Text = "Es necesario enviar un comprobante de asistencia. ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 43);
            this.label2.TabIndex = 91;
            this.label2.Text = "Marcar asistencia seleccione el evento que esté disponible según la hora de envío" +
    " de la asistencia.";
            // 
            // btnConfirmarAsistencia
            // 
            this.btnConfirmarAsistencia.BackColor = System.Drawing.Color.CadetBlue;
            this.btnConfirmarAsistencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmarAsistencia.Location = new System.Drawing.Point(6, 120);
            this.btnConfirmarAsistencia.Name = "btnConfirmarAsistencia";
            this.btnConfirmarAsistencia.Size = new System.Drawing.Size(176, 29);
            this.btnConfirmarAsistencia.TabIndex = 90;
            this.btnConfirmarAsistencia.Text = "Confirmar Asistencia";
            this.btnConfirmarAsistencia.UseVisualStyleBackColor = false;
            this.btnConfirmarAsistencia.Click += new System.EventHandler(this.btnConfirmarAsistencia_Click);
            // 
            // AdminAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 690);
            this.Controls.Add(this.gbxEstudianteEventos);
            this.Controls.Add(this.pnlPieArriba);
            this.Controls.Add(this.pnlAreaAdministrador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyHoursUAM - Asistencia";
            this.Load += new System.EventHandler(this.AdminAsistencia_Load);
            this.pnlPieArriba.ResumeLayout(false);
            this.pnlPieArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlAreaAdministrador.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxEstudianteEventos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPieArriba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAreaAdministrador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAñadirEventos;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.PictureBox pcbLogOutIcon;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAddPartidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.GroupBox gbxEstudianteEventos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmarAsistencia;
        private System.Windows.Forms.Button btnDenegarAsistencia;
        private System.Windows.Forms.ListView lvAsistencia;
        private System.Windows.Forms.ColumnHeader clhID;
        private System.Windows.Forms.ColumnHeader clhEstudianteId;
        private System.Windows.Forms.ColumnHeader clhNombre;
        private System.Windows.Forms.ColumnHeader clhEstadoSolicitud;
        private System.Windows.Forms.ColumnHeader clhFechaSolicitud;
    }
}