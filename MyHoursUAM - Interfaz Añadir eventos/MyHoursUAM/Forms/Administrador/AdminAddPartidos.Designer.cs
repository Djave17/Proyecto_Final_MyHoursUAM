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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddPartidos = new System.Windows.Forms.Button();
            this.btnAñadirEventos = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbAddPartidos = new System.Windows.Forms.GroupBox();
            this.lvwEventosRecienAdd = new System.Windows.Forms.ListView();
            this.clhNombrePartido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLugarPartido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDeporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhHoraEnvio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCantidadConvalidar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCupos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.tbxHoraEnvio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTipodeEvento = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCupos = new System.Windows.Forms.TextBox();
            this.lblCupos = new System.Windows.Forms.Label();
            this.lblRotulo2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbAddPartidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAddPartidos);
            this.panel1.Controls.Add(this.btnAñadirEventos);
            this.panel1.Controls.Add(this.btnAsistencia);
            this.panel1.Controls.Add(this.btnAjustes);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 821);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // btnAddPartidos
            // 
            this.btnAddPartidos.BackColor = System.Drawing.Color.Teal;
            this.btnAddPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPartidos.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPartidos.ForeColor = System.Drawing.Color.Snow;
            this.btnAddPartidos.Location = new System.Drawing.Point(2, 210);
            this.btnAddPartidos.Name = "btnAddPartidos";
            this.btnAddPartidos.Size = new System.Drawing.Size(165, 130);
            this.btnAddPartidos.TabIndex = 17;
            this.btnAddPartidos.Text = "Añadir Partido";
            this.btnAddPartidos.UseVisualStyleBackColor = false;
            // 
            // btnAñadirEventos
            // 
            this.btnAñadirEventos.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadirEventos.FlatAppearance.BorderSize = 0;
            this.btnAñadirEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirEventos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirEventos.ForeColor = System.Drawing.Color.White;
            this.btnAñadirEventos.Location = new System.Drawing.Point(0, 81);
            this.btnAñadirEventos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirEventos.Name = "btnAñadirEventos";
            this.btnAñadirEventos.Size = new System.Drawing.Size(163, 124);
            this.btnAñadirEventos.TabIndex = 14;
            this.btnAñadirEventos.Text = "➕ Añadir Eventos";
            this.btnAñadirEventos.UseVisualStyleBackColor = false;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.btnAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnAsistencia.Location = new System.Drawing.Point(0, 332);
            this.btnAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(165, 123);
            this.btnAsistencia.TabIndex = 15;
            this.btnAsistencia.Text = "🗒️  Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = false;
            // 
            // btnAjustes
            // 
            this.btnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.Location = new System.Drawing.Point(0, 472);
            this.btnAjustes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(165, 120);
            this.btnAjustes.TabIndex = 16;
            this.btnAjustes.Text = "⚙️   Ajustes";
            this.btnAjustes.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(191, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gpbAddPartidos
            // 
            this.gpbAddPartidos.Controls.Add(this.lvwEventosRecienAdd);
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
            this.gpbAddPartidos.Controls.Add(this.tbxHoraEnvio);
            this.gpbAddPartidos.Controls.Add(this.label2);
            this.gpbAddPartidos.Controls.Add(this.lblTipodeEvento);
            this.gpbAddPartidos.Controls.Add(this.btnEditar);
            this.gpbAddPartidos.Controls.Add(this.btnGuardar);
            this.gpbAddPartidos.Controls.Add(this.txtCupos);
            this.gpbAddPartidos.Controls.Add(this.lblCupos);
            this.gpbAddPartidos.Controls.Add(this.lblRotulo2);
            this.gpbAddPartidos.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAddPartidos.Location = new System.Drawing.Point(197, 57);
            this.gpbAddPartidos.Name = "gpbAddPartidos";
            this.gpbAddPartidos.Size = new System.Drawing.Size(630, 763);
            this.gpbAddPartidos.TabIndex = 2;
            this.gpbAddPartidos.TabStop = false;
            this.gpbAddPartidos.Text = "Añadir Partidos";
            // 
            // lvwEventosRecienAdd
            // 
            this.lvwEventosRecienAdd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhNombrePartido,
            this.clhLugarPartido,
            this.clhDeporte,
            this.clhHora,
            this.clhFecha,
            this.clhHoraEnvio,
            this.clhCantidadConvalidar,
            this.clhCupos});
            this.lvwEventosRecienAdd.HideSelection = false;
            this.lvwEventosRecienAdd.Location = new System.Drawing.Point(0, 389);
            this.lvwEventosRecienAdd.Margin = new System.Windows.Forms.Padding(2);
            this.lvwEventosRecienAdd.Name = "lvwEventosRecienAdd";
            this.lvwEventosRecienAdd.Size = new System.Drawing.Size(616, 352);
            this.lvwEventosRecienAdd.TabIndex = 88;
            this.lvwEventosRecienAdd.UseCompatibleStateImageBehavior = false;
            this.lvwEventosRecienAdd.View = System.Windows.Forms.View.Details;
            this.lvwEventosRecienAdd.SelectedIndexChanged += new System.EventHandler(this.lvwEventosRecienAdd_SelectedIndexChanged);
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
            // clhHoraEnvio
            // 
            this.clhHoraEnvio.Text = "Hora de envio";
            this.clhHoraEnvio.Width = 200;
            // 
            // clhCantidadConvalidar
            // 
            this.clhCantidadConvalidar.Text = "Cantidad a convalidar";
            // 
            // clhCupos
            // 
            this.clhCupos.Text = "Cupos";
            this.clhCupos.Width = 75;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.Teal;
            this.dtpFecha.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dtpFecha.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpFecha.Location = new System.Drawing.Point(10, 213);
            this.dtpFecha.MinDate = new System.DateTime(2010, 3, 11, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(240, 26);
            this.dtpFecha.TabIndex = 87;
            // 
            // tbxLugar
            // 
            this.tbxLugar.BackColor = System.Drawing.Color.Teal;
            this.tbxLugar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLugar.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLugar.ForeColor = System.Drawing.Color.White;
            this.tbxLugar.Location = new System.Drawing.Point(8, 267);
            this.tbxLugar.Margin = new System.Windows.Forms.Padding(2);
            this.tbxLugar.Multiline = true;
            this.tbxLugar.Name = "tbxLugar";
            this.tbxLugar.Size = new System.Drawing.Size(242, 23);
            this.tbxLugar.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 85;
            this.label4.Text = "Lugar:";
            // 
            // txbHorario
            // 
            this.txbHorario.BackColor = System.Drawing.Color.Teal;
            this.txbHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbHorario.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHorario.ForeColor = System.Drawing.Color.White;
            this.txbHorario.Location = new System.Drawing.Point(8, 159);
            this.txbHorario.Margin = new System.Windows.Forms.Padding(2);
            this.txbHorario.Multiline = true;
            this.txbHorario.Name = "txbHorario";
            this.txbHorario.Size = new System.Drawing.Size(242, 23);
            this.txbHorario.TabIndex = 84;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(5, 141);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(53, 16);
            this.lblHorario.TabIndex = 83;
            this.lblHorario.Text = "Hora: ";
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.BackColor = System.Drawing.Color.Teal;
            this.txtNombreEvento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEvento.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEvento.ForeColor = System.Drawing.Color.White;
            this.txtNombreEvento.Location = new System.Drawing.Point(8, 112);
            this.txtNombreEvento.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEvento.Multiline = true;
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(242, 23);
            this.txtNombreEvento.TabIndex = 82;
            this.txtNombreEvento.TextChanged += new System.EventHandler(this.txtNombreEvento_TextChanged);
            // 
            // nombreEvento
            // 
            this.nombreEvento.AutoSize = true;
            this.nombreEvento.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEvento.Location = new System.Drawing.Point(5, 94);
            this.nombreEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreEvento.Name = "nombreEvento";
            this.nombreEvento.Size = new System.Drawing.Size(156, 16);
            this.nombreEvento.TabIndex = 81;
            this.nombreEvento.Text = "Nombre del Evento:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(5, 195);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(57, 16);
            this.lblFecha.TabIndex = 80;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNombreEvento
            // 
            this.lblNombreEvento.AutoSize = true;
            this.lblNombreEvento.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEvento.Location = new System.Drawing.Point(328, 93);
            this.lblNombreEvento.Name = "lblNombreEvento";
            this.lblNombreEvento.Size = new System.Drawing.Size(178, 16);
            this.lblNombreEvento.TabIndex = 79;
            this.lblNombreEvento.Text = "Cantidad a convalidar:";
            // 
            // txbHorasConvalidas
            // 
            this.txbHorasConvalidas.BackColor = System.Drawing.Color.Teal;
            this.txbHorasConvalidas.Location = new System.Drawing.Point(331, 112);
            this.txbHorasConvalidas.Name = "txbHorasConvalidas";
            this.txbHorasConvalidas.Size = new System.Drawing.Size(245, 26);
            this.txbHorasConvalidas.TabIndex = 78;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(292, 322);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 28);
            this.btnEliminar.TabIndex = 77;
            this.btnEliminar.Text = "Eliminar";
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
            this.cbxTipoDeporte.Location = new System.Drawing.Point(151, 48);
            this.cbxTipoDeporte.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTipoDeporte.Name = "cbxTipoDeporte";
            this.cbxTipoDeporte.Size = new System.Drawing.Size(161, 27);
            this.cbxTipoDeporte.TabIndex = 75;
            // 
            // tbxHoraEnvio
            // 
            this.tbxHoraEnvio.BackColor = System.Drawing.Color.Teal;
            this.tbxHoraEnvio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxHoraEnvio.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoraEnvio.ForeColor = System.Drawing.Color.White;
            this.tbxHoraEnvio.Location = new System.Drawing.Point(332, 210);
            this.tbxHoraEnvio.Margin = new System.Windows.Forms.Padding(2);
            this.tbxHoraEnvio.Multiline = true;
            this.tbxHoraEnvio.Name = "tbxHoraEnvio";
            this.tbxHoraEnvio.Size = new System.Drawing.Size(242, 23);
            this.tbxHoraEnvio.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Hora de Envio:";
            // 
            // lblTipodeEvento
            // 
            this.lblTipodeEvento.AutoSize = true;
            this.lblTipodeEvento.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeEvento.Location = new System.Drawing.Point(5, 53);
            this.lblTipodeEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipodeEvento.Name = "lblTipodeEvento";
            this.lblTipodeEvento.Size = new System.Drawing.Size(134, 16);
            this.lblTipodeEvento.TabIndex = 71;
            this.lblTipodeEvento.Text = "Tipo de Deporte:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Teal;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(395, 322);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 28);
            this.btnEditar.TabIndex = 66;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(194, 322);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 28);
            this.btnGuardar.TabIndex = 65;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCupos
            // 
            this.txtCupos.BackColor = System.Drawing.Color.Teal;
            this.txtCupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCupos.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCupos.ForeColor = System.Drawing.Color.White;
            this.txtCupos.Location = new System.Drawing.Point(331, 158);
            this.txtCupos.Margin = new System.Windows.Forms.Padding(2);
            this.txtCupos.Multiline = true;
            this.txtCupos.Name = "txtCupos";
            this.txtCupos.Size = new System.Drawing.Size(242, 23);
            this.txtCupos.TabIndex = 64;
            // 
            // lblCupos
            // 
            this.lblCupos.AutoSize = true;
            this.lblCupos.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupos.Location = new System.Drawing.Point(329, 138);
            this.lblCupos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCupos.Name = "lblCupos";
            this.lblCupos.Size = new System.Drawing.Size(58, 16);
            this.lblCupos.TabIndex = 63;
            this.lblCupos.Text = "Cupos:";
            // 
            // lblRotulo2
            // 
            this.lblRotulo2.AutoSize = true;
            this.lblRotulo2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotulo2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRotulo2.Location = new System.Drawing.Point(3, 24);
            this.lblRotulo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRotulo2.Name = "lblRotulo2";
            this.lblRotulo2.Size = new System.Drawing.Size(260, 16);
            this.lblRotulo2.TabIndex = 60;
            this.lblRotulo2.Text = "Todos los campos son requeridos";
            // 
            // AdminAddPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 832);
            this.Controls.Add(this.gpbAddPartidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddPartidos";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbAddPartidos.ResumeLayout(false);
            this.gpbAddPartidos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbAddPartidos;
        private System.Windows.Forms.Label lblNombreEvento;
        private System.Windows.Forms.TextBox txbHorasConvalidas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbxTipoDeporte;
        private System.Windows.Forms.TextBox tbxHoraEnvio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTipodeEvento;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCupos;
        private System.Windows.Forms.Label lblCupos;
        private System.Windows.Forms.Label lblRotulo2;
        private System.Windows.Forms.Button btnAddPartidos;
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
        private System.Windows.Forms.ListView lvwEventosRecienAdd;
        private System.Windows.Forms.ColumnHeader clhNombrePartido;
        private System.Windows.Forms.ColumnHeader clhLugarPartido;
        private System.Windows.Forms.ColumnHeader clhDeporte;
        private System.Windows.Forms.ColumnHeader clhHora;
        private System.Windows.Forms.ColumnHeader clhFecha;
        private System.Windows.Forms.ColumnHeader clhHoraEnvio;
        private System.Windows.Forms.ColumnHeader clhCantidadConvalidar;
        private System.Windows.Forms.ColumnHeader clhCupos;
    }
}