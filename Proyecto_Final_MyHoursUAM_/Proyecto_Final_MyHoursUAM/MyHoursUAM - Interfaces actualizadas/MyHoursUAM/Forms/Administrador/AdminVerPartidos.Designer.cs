namespace MyHours_UAMApp.Forms.Administrador
{
    partial class AdminVerPartidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminVerPartidos));
            this.panel3 = new System.Windows.Forms.Panel();
            this.gpbGestiones = new System.Windows.Forms.GroupBox();
            this.dgvPartidos = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlPieArriba = new System.Windows.Forms.Panel();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbLogOutIcon = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlAreaAdministrador = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAñadirEventos = new System.Windows.Forms.Button();
            this.btnAjustesPartidos = new System.Windows.Forms.Button();
            this.btnAsistenciaPartidos = new System.Windows.Forms.Button();
            this.btnVerPartidos = new System.Windows.Forms.Button();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminarPartido = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.gpbGestiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).BeginInit();
            this.pnlPieArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlAreaAdministrador.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.gpbGestiones);
            this.panel3.Location = new System.Drawing.Point(172, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 449);
            this.panel3.TabIndex = 60;
            // 
            // gpbGestiones
            // 
            this.gpbGestiones.BackColor = System.Drawing.Color.White;
            this.gpbGestiones.Controls.Add(this.btnEliminarPartido);
            this.gpbGestiones.Controls.Add(this.dgvPartidos);
            this.gpbGestiones.Controls.Add(this.btnEditar);
            this.gpbGestiones.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGestiones.Location = new System.Drawing.Point(2, 2);
            this.gpbGestiones.Margin = new System.Windows.Forms.Padding(2);
            this.gpbGestiones.Name = "gpbGestiones";
            this.gpbGestiones.Padding = new System.Windows.Forms.Padding(2);
            this.gpbGestiones.Size = new System.Drawing.Size(628, 510);
            this.gpbGestiones.TabIndex = 15;
            this.gpbGestiones.TabStop = false;
            this.gpbGestiones.Text = "Partidos Inscritos";
            // 
            // dgvPartidos
            // 
            this.dgvPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidos.Location = new System.Drawing.Point(17, 32);
            this.dgvPartidos.Name = "dgvPartidos";
            this.dgvPartidos.Size = new System.Drawing.Size(521, 412);
            this.dgvPartidos.TabIndex = 52;
            this.dgvPartidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Teal;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(568, 178);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(48, 28);
            this.btnEditar.TabIndex = 50;
            this.btnEditar.Text = "🖊️";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // pnlPieArriba
            // 
            this.pnlPieArriba.BackColor = System.Drawing.Color.White;
            this.pnlPieArriba.Controls.Add(this.lblCerrarSesion);
            this.pnlPieArriba.Controls.Add(this.label1);
            this.pnlPieArriba.Controls.Add(this.pcbLogOutIcon);
            this.pnlPieArriba.Controls.Add(this.lblAdmin);
            this.pnlPieArriba.Controls.Add(this.pictureBox2);
            this.pnlPieArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPieArriba.Location = new System.Drawing.Point(165, 0);
            this.pnlPieArriba.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPieArriba.Name = "pnlPieArriba";
            this.pnlPieArriba.Size = new System.Drawing.Size(635, 73);
            this.pnlPieArriba.TabIndex = 59;
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.Teal;
            this.lblCerrarSesion.Location = new System.Drawing.Point(572, 28);
            this.lblCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(83, 13);
            this.lblCerrarSesion.TabIndex = 17;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "PARTIDOS";
            // 
            // pcbLogOutIcon
            // 
            this.pcbLogOutIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogOutIcon.Image")));
            this.pcbLogOutIcon.Location = new System.Drawing.Point(528, 11);
            this.pcbLogOutIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pcbLogOutIcon.Name = "pcbLogOutIcon";
            this.pcbLogOutIcon.Size = new System.Drawing.Size(40, 41);
            this.pcbLogOutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogOutIcon.TabIndex = 16;
            this.pcbLogOutIcon.TabStop = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Teal;
            this.lblAdmin.Location = new System.Drawing.Point(446, 28);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(83, 13);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Administrador";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(406, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
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
            this.pnlAreaAdministrador.Size = new System.Drawing.Size(165, 538);
            this.pnlAreaAdministrador.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAñadirEventos);
            this.panel1.Controls.Add(this.btnAjustesPartidos);
            this.panel1.Controls.Add(this.btnAsistenciaPartidos);
            this.panel1.Controls.Add(this.btnVerPartidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 421);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(2, 114);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 126);
            this.panel2.TabIndex = 62;
            // 
            // btnAñadirEventos
            // 
            this.btnAñadirEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirEventos.FlatAppearance.BorderSize = 0;
            this.btnAñadirEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirEventos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirEventos.ForeColor = System.Drawing.Color.White;
            this.btnAñadirEventos.Location = new System.Drawing.Point(8, 4);
            this.btnAñadirEventos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirEventos.Name = "btnAñadirEventos";
            this.btnAñadirEventos.Size = new System.Drawing.Size(152, 124);
            this.btnAñadirEventos.TabIndex = 62;
            this.btnAñadirEventos.Text = "➕ Añadir Partido";
            this.btnAñadirEventos.UseVisualStyleBackColor = false;
            this.btnAñadirEventos.Click += new System.EventHandler(this.btnAñadirEventos_Click);
            // 
            // btnAjustesPartidos
            // 
            this.btnAjustesPartidos.BackColor = System.Drawing.Color.Transparent;
            this.btnAjustesPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustesPartidos.FlatAppearance.BorderSize = 0;
            this.btnAjustesPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustesPartidos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustesPartidos.ForeColor = System.Drawing.Color.White;
            this.btnAjustesPartidos.Location = new System.Drawing.Point(2, 351);
            this.btnAjustesPartidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjustesPartidos.Name = "btnAjustesPartidos";
            this.btnAjustesPartidos.Size = new System.Drawing.Size(165, 124);
            this.btnAjustesPartidos.TabIndex = 61;
            this.btnAjustesPartidos.Text = "⚙️   Ajustes";
            this.btnAjustesPartidos.UseVisualStyleBackColor = false;
            this.btnAjustesPartidos.Click += new System.EventHandler(this.btnAjustesPartidos_Click);
            // 
            // btnAsistenciaPartidos
            // 
            this.btnAsistenciaPartidos.BackColor = System.Drawing.Color.Transparent;
            this.btnAsistenciaPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistenciaPartidos.FlatAppearance.BorderSize = 0;
            this.btnAsistenciaPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistenciaPartidos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistenciaPartidos.ForeColor = System.Drawing.Color.White;
            this.btnAsistenciaPartidos.Location = new System.Drawing.Point(2, 229);
            this.btnAsistenciaPartidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsistenciaPartidos.Name = "btnAsistenciaPartidos";
            this.btnAsistenciaPartidos.Size = new System.Drawing.Size(165, 124);
            this.btnAsistenciaPartidos.TabIndex = 60;
            this.btnAsistenciaPartidos.Text = "🗒️  Asistencia";
            this.btnAsistenciaPartidos.UseVisualStyleBackColor = false;
            this.btnAsistenciaPartidos.Click += new System.EventHandler(this.btnAsistenciaPartidos_Click);
            // 
            // btnVerPartidos
            // 
            this.btnVerPartidos.BackColor = System.Drawing.Color.Transparent;
            this.btnVerPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPartidos.FlatAppearance.BorderSize = 0;
            this.btnVerPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPartidos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPartidos.ForeColor = System.Drawing.Color.White;
            this.btnVerPartidos.Location = new System.Drawing.Point(4, 114);
            this.btnVerPartidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerPartidos.Name = "btnVerPartidos";
            this.btnVerPartidos.Size = new System.Drawing.Size(163, 124);
            this.btnVerPartidos.TabIndex = 59;
            this.btnVerPartidos.Text = "👁  Ver Partidos";
            this.btnVerPartidos.UseVisualStyleBackColor = false;
            this.btnVerPartidos.Click += new System.EventHandler(this.btnVerPartidos_Click);
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
            // btnEliminarPartido
            // 
            this.btnEliminarPartido.BackColor = System.Drawing.Color.Teal;
            this.btnEliminarPartido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPartido.FlatAppearance.BorderSize = 0;
            this.btnEliminarPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPartido.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPartido.Location = new System.Drawing.Point(568, 237);
            this.btnEliminarPartido.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarPartido.Name = "btnEliminarPartido";
            this.btnEliminarPartido.Size = new System.Drawing.Size(48, 28);
            this.btnEliminarPartido.TabIndex = 53;
            this.btnEliminarPartido.Text = "🗑";
            this.btnEliminarPartido.UseVisualStyleBackColor = false;
            this.btnEliminarPartido.Click += new System.EventHandler(this.btnEliminarPartido_Click);
            // 
            // AdminVerPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlPieArriba);
            this.Controls.Add(this.pnlAreaAdministrador);
            this.Name = "AdminVerPartidos";
            this.Text = "AdminVerPartidos";
            this.Load += new System.EventHandler(this.AdminVerPartidos_Load);
            this.panel3.ResumeLayout(false);
            this.gpbGestiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidos)).EndInit();
            this.pnlPieArriba.ResumeLayout(false);
            this.pnlPieArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlAreaAdministrador.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gpbGestiones;
        private System.Windows.Forms.DataGridView dgvPartidos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pnlPieArriba;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbLogOutIcon;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlAreaAdministrador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAñadirEventos;
        private System.Windows.Forms.Button btnAjustesPartidos;
        private System.Windows.Forms.Button btnAsistenciaPartidos;
        private System.Windows.Forms.Button btnVerPartidos;
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminarPartido;
    }
}