namespace MyHours_UAMApp.Forms.Administrador
{
    partial class AdminAddPartidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddPartidos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddPartidos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAñadirEventos = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.gpbAddPartidos = new System.Windows.Forms.GroupBox();
            this.tbxEstado = new System.Windows.Forms.ComboBox();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.lvPartidos = new System.Windows.Forms.ListView();
            this.clhID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNombrePartido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLugarPartido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDeporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCupos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCantidadConvalidar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.tbxLugar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbHorario = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.nombreEvento = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombreEvento = new System.Windows.Forms.Label();
            this.txbHorasConvalidas = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbxTipoDeporte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTipodeEvento = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCupos = new System.Windows.Forms.TextBox();
            this.lblCupos = new System.Windows.Forms.Label();
            this.lblRotulo2 = new System.Windows.Forms.Label();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.pcbLogOutIcon = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbAddPartidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnGraficos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAddPartidos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAñadirEventos);
            this.panel1.Controls.Add(this.btnAsistencia);
            this.panel1.Controls.Add(this.btnAjustes);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 1020);
            this.panel1.TabIndex = 0;
            // 
            // btnGraficos
            // 
            this.btnGraficos.BackColor = System.Drawing.Color.Transparent;
            this.btnGraficos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGraficos.FlatAppearance.BorderSize = 0;
            this.btnGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficos.ForeColor = System.Drawing.Color.White;
            this.btnGraficos.Location = new System.Drawing.Point(-3, 734);
            this.btnGraficos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(220, 148);
            this.btnGraficos.TabIndex = 22;
            this.btnGraficos.Text = "📈 Graficos";
            this.btnGraficos.UseVisualStyleBackColor = false;
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 263);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 127);
            this.panel2.TabIndex = 4;
            // 
            // btnAddPartidos
            // 
            this.btnAddPartidos.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPartidos.FlatAppearance.BorderSize = 0;
            this.btnAddPartidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPartidos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPartidos.ForeColor = System.Drawing.Color.White;
            this.btnAddPartidos.Location = new System.Drawing.Point(0, 257);
            this.btnAddPartidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPartidos.Name = "btnAddPartidos";
            this.btnAddPartidos.Size = new System.Drawing.Size(220, 148);
            this.btnAddPartidos.TabIndex = 19;
            this.btnAddPartidos.Text = "⚽ Añadir Partidos";
            this.btnAddPartidos.UseVisualStyleBackColor = false;
            this.btnAddPartidos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // btnAñadirEventos
            // 
            this.btnAñadirEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirEventos.FlatAppearance.BorderSize = 0;
            this.btnAñadirEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirEventos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirEventos.ForeColor = System.Drawing.Color.White;
            this.btnAñadirEventos.Location = new System.Drawing.Point(0, 100);
            this.btnAñadirEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadirEventos.Name = "btnAñadirEventos";
            this.btnAñadirEventos.Size = new System.Drawing.Size(217, 153);
            this.btnAñadirEventos.TabIndex = 14;
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
            this.btnAsistencia.Location = new System.Drawing.Point(0, 409);
            this.btnAsistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(220, 151);
            this.btnAsistencia.TabIndex = 15;
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
            this.btnAjustes.Location = new System.Drawing.Point(0, 581);
            this.btnAjustes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(220, 148);
            this.btnAjustes.TabIndex = 16;
            this.btnAjustes.Text = "⚙️   Ajustes";
            this.btnAjustes.UseVisualStyleBackColor = false;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click);
            // 
            // gpbAddPartidos
            // 
            this.gpbAddPartidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbAddPartidos.BackColor = System.Drawing.Color.White;
            this.gpbAddPartidos.Controls.Add(this.tbxEstado);
            this.gpbAddPartidos.Controls.Add(this.btnCambiarEstado);
            this.gpbAddPartidos.Controls.Add(this.lvPartidos);
            this.gpbAddPartidos.Controls.Add(this.dtpFecha);
            this.gpbAddPartidos.Controls.Add(this.tbxLugar);
            this.gpbAddPartidos.Controls.Add(this.label4);
            this.gpbAddPartidos.Controls.Add(this.txbHorario);
            this.gpbAddPartidos.Controls.Add(this.lblHorario);
            this.gpbAddPartidos.Controls.Add(this.txtNombreEvento);
            this.gpbAddPartidos.Controls.Add(this.nombreEvento);
            this.gpbAddPartidos.Controls.Add(this.lblFecha);
            this.gpbAddPartidos.Controls.Add(this.lblNombreEvento);
            this.gpbAddPartidos.Controls.Add(this.txbHorasConvalidas);
            this.gpbAddPartidos.Controls.Add(this.btnEliminar);
            this.gpbAddPartidos.Controls.Add(this.cbxTipoDeporte);
            this.gpbAddPartidos.Controls.Add(this.label2);
            this.gpbAddPartidos.Controls.Add(this.lblTipodeEvento);
            this.gpbAddPartidos.Controls.Add(this.btnEditar);
            this.gpbAddPartidos.Controls.Add(this.btnGuardar);
            this.gpbAddPartidos.Controls.Add(this.txtCupos);
            this.gpbAddPartidos.Controls.Add(this.lblCupos);
            this.gpbAddPartidos.Controls.Add(this.lblRotulo2);
            this.gpbAddPartidos.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAddPartidos.Location = new System.Drawing.Point(229, 101);
            this.gpbAddPartidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbAddPartidos.Name = "gpbAddPartidos";
            this.gpbAddPartidos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbAddPartidos.Size = new System.Drawing.Size(834, 1020);
            this.gpbAddPartidos.TabIndex = 2;
            this.gpbAddPartidos.TabStop = false;
            this.gpbAddPartidos.Text = "Añadir Partidos";
            this.gpbAddPartidos.Enter += new System.EventHandler(this.gpbAddPartidos_Enter);
            // 
            // tbxEstado
            // 
            this.tbxEstado.FormattingEnabled = true;
            this.tbxEstado.Items.AddRange(new object[] {
            "Disponible",
            "No_Disponible"});
            this.tbxEstado.Location = new System.Drawing.Point(11, 521);
            this.tbxEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxEstado.Name = "tbxEstado";
            this.tbxEstado.Size = new System.Drawing.Size(648, 32);
            this.tbxEstado.TabIndex = 89;
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCambiarEstado.BackColor = System.Drawing.Color.Teal;
            this.btnCambiarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarEstado.FlatAppearance.BorderSize = 0;
            this.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstado.ForeColor = System.Drawing.Color.White;
            this.btnCambiarEstado.Location = new System.Drawing.Point(467, 594);
            this.btnCambiarEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(173, 34);
            this.btnCambiarEstado.TabIndex = 64;
            this.btnCambiarEstado.Text = "Cambiar Estado";
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // lvPartidos
            // 
            this.lvPartidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPartidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhID,
            this.clhNombrePartido,
            this.clhLugarPartido,
            this.clhDeporte,
            this.clhHora,
            this.clhFecha,
            this.clhCupos,
            this.clhCantidadConvalidar,
            this.clhEstado});
            this.lvPartidos.FullRowSelect = true;
            this.lvPartidos.HideSelection = false;
            this.lvPartidos.LabelEdit = true;
            this.lvPartidos.Location = new System.Drawing.Point(7, 645);
            this.lvPartidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvPartidos.Name = "lvPartidos";
            this.lvPartidos.Size = new System.Drawing.Size(819, 345);
            this.lvPartidos.TabIndex = 88;
            this.lvPartidos.UseCompatibleStateImageBehavior = false;
            this.lvPartidos.View = System.Windows.Forms.View.Details;
            this.lvPartidos.SelectedIndexChanged += new System.EventHandler(this.lvPartidos_SelectedIndexChanged);
            // 
            // clhID
            // 
            this.clhID.Text = "ID";
            this.clhID.Width = 100;
            // 
            // clhNombrePartido
            // 
            this.clhNombrePartido.Text = "Nombre";
            this.clhNombrePartido.Width = 120;
            // 
            // clhLugarPartido
            // 
            this.clhLugarPartido.Text = "Lugar";
            this.clhLugarPartido.Width = 120;
            // 
            // clhDeporte
            // 
            this.clhDeporte.Text = "Deporte";
            this.clhDeporte.Width = 90;
            // 
            // clhHora
            // 
            this.clhHora.Text = "Hora";
            // 
            // clhFecha
            // 
            this.clhFecha.Text = "Fecha";
            this.clhFecha.Width = 100;
            // 
            // clhCupos
            // 
            this.clhCupos.Text = "Cupos";
            this.clhCupos.Width = 75;
            // 
            // clhCantidadConvalidar
            // 
            this.clhCantidadConvalidar.Text = "Cantidad a convalidar";
            // 
            // clhEstado
            // 
            this.clhEstado.Text = "Estado";
            this.clhEstado.Width = 200;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFecha.CalendarTitleBackColor = System.Drawing.Color.Teal;
            this.dtpFecha.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpFecha.CalendarTrailingForeColor = System.Drawing.Color.Teal;
            this.dtpFecha.Location = new System.Drawing.Point(13, 262);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.MinDate = new System.DateTime(2010, 3, 11, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(645, 31);
            this.dtpFecha.TabIndex = 87;
            // 
            // tbxLugar
            // 
            this.tbxLugar.BackColor = System.Drawing.Color.Teal;
            this.tbxLugar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLugar.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLugar.ForeColor = System.Drawing.Color.White;
            this.tbxLugar.Location = new System.Drawing.Point(11, 329);
            this.tbxLugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxLugar.Multiline = true;
            this.tbxLugar.Name = "tbxLugar";
            this.tbxLugar.Size = new System.Drawing.Size(649, 28);
            this.tbxLugar.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Lugar:";
            // 
            // txbHorario
            // 
            this.txbHorario.BackColor = System.Drawing.Color.Teal;
            this.txbHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbHorario.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHorario.ForeColor = System.Drawing.Color.White;
            this.txbHorario.Location = new System.Drawing.Point(11, 196);
            this.txbHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbHorario.Multiline = true;
            this.txbHorario.Name = "txbHorario";
            this.txbHorario.Size = new System.Drawing.Size(649, 28);
            this.txbHorario.TabIndex = 84;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(7, 174);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(65, 20);
            this.lblHorario.TabIndex = 83;
            this.lblHorario.Text = "Hora: ";
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.BackColor = System.Drawing.Color.Teal;
            this.txtNombreEvento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEvento.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEvento.ForeColor = System.Drawing.Color.White;
            this.txtNombreEvento.Location = new System.Drawing.Point(11, 138);
            this.txtNombreEvento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEvento.Multiline = true;
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(649, 28);
            this.txtNombreEvento.TabIndex = 82;
            // 
            // nombreEvento
            // 
            this.nombreEvento.AutoSize = true;
            this.nombreEvento.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEvento.Location = new System.Drawing.Point(7, 116);
            this.nombreEvento.Name = "nombreEvento";
            this.nombreEvento.Size = new System.Drawing.Size(190, 20);
            this.nombreEvento.TabIndex = 81;
            this.nombreEvento.Text = "Nombre del Evento:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(7, 240);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(70, 20);
            this.lblFecha.TabIndex = 80;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNombreEvento
            // 
            this.lblNombreEvento.AutoSize = true;
            this.lblNombreEvento.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEvento.Location = new System.Drawing.Point(7, 374);
            this.lblNombreEvento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreEvento.Name = "lblNombreEvento";
            this.lblNombreEvento.Size = new System.Drawing.Size(216, 20);
            this.lblNombreEvento.TabIndex = 79;
            this.lblNombreEvento.Text = "Cantidad a convalidar:";
            // 
            // txbHorasConvalidas
            // 
            this.txbHorasConvalidas.BackColor = System.Drawing.Color.Teal;
            this.txbHorasConvalidas.ForeColor = System.Drawing.SystemColors.Window;
            this.txbHorasConvalidas.Location = new System.Drawing.Point(11, 398);
            this.txbHorasConvalidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbHorasConvalidas.Name = "txbHorasConvalidas";
            this.txbHorasConvalidas.Size = new System.Drawing.Size(648, 31);
            this.txbHorasConvalidas.TabIndex = 78;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(314, 594);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 34);
            this.btnEliminar.TabIndex = 77;
            this.btnEliminar.Text = "🗑";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbxTipoDeporte
            // 
            this.cbxTipoDeporte.FormattingEnabled = true;
            this.cbxTipoDeporte.Items.AddRange(new object[] {
            "Futbol",
            "Baloncesto",
            "Voleibol",
            "Tenis de Mesa",
            "Voleibol Playa",
            "Futbol Sala",
            "Karate",
            "Taekwondo",
            "Ajedrez",
            "Natacion",
            "Atletismo"});
            this.cbxTipoDeporte.Location = new System.Drawing.Point(191, 65);
            this.cbxTipoDeporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTipoDeporte.Name = "cbxTipoDeporte";
            this.cbxTipoDeporte.Size = new System.Drawing.Size(468, 32);
            this.cbxTipoDeporte.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Estado de envio: ";
            // 
            // lblTipodeEvento
            // 
            this.lblTipodeEvento.AutoSize = true;
            this.lblTipodeEvento.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeEvento.Location = new System.Drawing.Point(7, 65);
            this.lblTipodeEvento.Name = "lblTipodeEvento";
            this.lblTipodeEvento.Size = new System.Drawing.Size(164, 20);
            this.lblTipodeEvento.TabIndex = 71;
            this.lblTipodeEvento.Text = "Tipo de Deporte:";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditar.BackColor = System.Drawing.Color.Teal;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(390, 594);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 34);
            this.btnEditar.TabIndex = 66;
            this.btnEditar.Text = "🖊️";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(238, 594);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 34);
            this.btnGuardar.TabIndex = 65;
            this.btnGuardar.Text = "💾";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCupos
            // 
            this.txtCupos.BackColor = System.Drawing.Color.Teal;
            this.txtCupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCupos.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCupos.ForeColor = System.Drawing.Color.White;
            this.txtCupos.Location = new System.Drawing.Point(11, 454);
            this.txtCupos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCupos.Multiline = true;
            this.txtCupos.Name = "txtCupos";
            this.txtCupos.Size = new System.Drawing.Size(649, 28);
            this.txtCupos.TabIndex = 64;
            // 
            // lblCupos
            // 
            this.lblCupos.AutoSize = true;
            this.lblCupos.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupos.Location = new System.Drawing.Point(9, 430);
            this.lblCupos.Name = "lblCupos";
            this.lblCupos.Size = new System.Drawing.Size(71, 20);
            this.lblCupos.TabIndex = 63;
            this.lblCupos.Text = "Cupos:";
            // 
            // lblRotulo2
            // 
            this.lblRotulo2.AutoSize = true;
            this.lblRotulo2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotulo2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRotulo2.Location = new System.Drawing.Point(4, 30);
            this.lblRotulo2.Name = "lblRotulo2";
            this.lblRotulo2.Size = new System.Drawing.Size(318, 20);
            this.lblRotulo2.TabIndex = 60;
            this.lblRotulo2.Text = "Todos los campos son requeridos";
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.Teal;
            this.lblCerrarSesion.Location = new System.Drawing.Point(723, 43);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(102, 16);
            this.lblCerrarSesion.TabIndex = 21;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblCerrarSesion_Click);
            // 
            // pcbLogOutIcon
            // 
            this.pcbLogOutIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pcbLogOutIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogOutIcon.Image")));
            this.pcbLogOutIcon.Location = new System.Drawing.Point(651, 21);
            this.pcbLogOutIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbLogOutIcon.Name = "pcbLogOutIcon";
            this.pcbLogOutIcon.Size = new System.Drawing.Size(53, 50);
            this.pcbLogOutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogOutIcon.TabIndex = 20;
            this.pcbLogOutIcon.TabStop = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Teal;
            this.lblAdmin.Location = new System.Drawing.Point(520, 43);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(103, 16);
            this.lblAdmin.TabIndex = 18;
            this.lblAdmin.Text = "Administrador";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(458, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "DASHBOARD";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblCerrarSesion);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pcbLogOutIcon);
            this.panel3.Controls.Add(this.lblAdmin);
            this.panel3.Location = new System.Drawing.Point(219, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(844, 90);
            this.panel3.TabIndex = 3;
            // 
            // AdminAddPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1107, 922);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gpbAddPartidos);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminAddPartidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyHoursUAM - Añadir Partidos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbAddPartidos.ResumeLayout(false);
            this.gpbAddPartidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbAddPartidos;
        private System.Windows.Forms.Label lblNombreEvento;
        private System.Windows.Forms.TextBox txbHorasConvalidas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbxTipoDeporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTipodeEvento;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCupos;
        private System.Windows.Forms.Label lblCupos;
        private System.Windows.Forms.Label lblRotulo2;
        private System.Windows.Forms.Button btnAñadirEventos;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox tbxLugar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbHorario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.Label nombreEvento;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ListView lvPartidos;
        private System.Windows.Forms.ColumnHeader clhNombrePartido;
        private System.Windows.Forms.ColumnHeader clhLugarPartido;
        private System.Windows.Forms.ColumnHeader clhDeporte;
        private System.Windows.Forms.ColumnHeader clhHora;
        private System.Windows.Forms.ColumnHeader clhFecha;
        private System.Windows.Forms.ColumnHeader clhEstado;
        private System.Windows.Forms.ColumnHeader clhCantidadConvalidar;
        private System.Windows.Forms.ColumnHeader clhCupos;
        private System.Windows.Forms.Button btnAddPartidos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pcbLogOutIcon;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.ColumnHeader clhID;
        private System.Windows.Forms.ComboBox tbxEstado;
        private System.Windows.Forms.Button btnGraficos;
    }
}