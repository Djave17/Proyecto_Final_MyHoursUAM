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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.pcbLogOutIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.pcbStudentIcon = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwEventos = new System.Windows.Forms.ListView();
            this.clhIDEvento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNombreEvento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTipoConvalidacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhConvalida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhHorario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLugar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTipoEvento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwPartidosAsistidos = new System.Windows.Forms.ListView();
            this.clhID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhConvalidacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhFechaPartido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLugarPartido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDeporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBeneficioPartidos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHorasLaborales = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlIcon.SuspendLayout();
            this.pnlAreaAdministrador.SuspendLayout();
            this.pnlPieArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStudentIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.btnReporte.Location = new System.Drawing.Point(9, 428);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(152, 97);
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
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 674);
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
            this.button1.Location = new System.Drawing.Point(4, 203);
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
            this.panel2.Location = new System.Drawing.Point(2, 422);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 103);
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
            this.btnPartidos.Location = new System.Drawing.Point(-2, 101);
            this.btnPartidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(165, 97);
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
            this.btnAjustes.Location = new System.Drawing.Point(-4, 307);
            this.btnAjustes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(165, 99);
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
            this.btnVerEventos.Location = new System.Drawing.Point(-2, 5);
            this.btnVerEventos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerEventos.Name = "btnVerEventos";
            this.btnVerEventos.Size = new System.Drawing.Size(165, 99);
            this.btnVerEventos.TabIndex = 10;
            this.btnVerEventos.Text = "👁  Ver Eventos";
            this.btnVerEventos.UseVisualStyleBackColor = false;
            this.btnVerEventos.Click += new System.EventHandler(this.btnVerEventos_Click);
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
            this.pnlAreaAdministrador.Size = new System.Drawing.Size(165, 856);
            this.pnlAreaAdministrador.TabIndex = 12;
            // 
            // pnlPieArriba
            // 
            this.pnlPieArriba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPieArriba.BackColor = System.Drawing.Color.White;
            this.pnlPieArriba.Controls.Add(this.label2);
            this.pnlPieArriba.Controls.Add(this.lblCerrarSesion);
            this.pnlPieArriba.Controls.Add(this.pcbLogOutIcon);
            this.pnlPieArriba.Controls.Add(this.label1);
            this.pnlPieArriba.Controls.Add(this.lblEstudiante);
            this.pnlPieArriba.Controls.Add(this.pcbStudentIcon);
            this.pnlPieArriba.Location = new System.Drawing.Point(165, 0);
            this.pnlPieArriba.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPieArriba.Name = "pnlPieArriba";
            this.pnlPieArriba.Size = new System.Drawing.Size(3538, 73);
            this.pnlPieArriba.TabIndex = 13;
            this.pnlPieArriba.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPieArriba_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(1683, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cerrar Sesion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.Teal;
            this.lblCerrarSesion.Location = new System.Drawing.Point(1222, 35);
            this.lblCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(83, 13);
            this.lblCerrarSesion.TabIndex = 4;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblCerrarSesion_Click);
            // 
            // pcbLogOutIcon
            // 
            this.pcbLogOutIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogOutIcon.Image")));
            this.pcbLogOutIcon.Location = new System.Drawing.Point(1048, 19);
            this.pcbLogOutIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pcbLogOutIcon.Name = "pcbLogOutIcon";
            this.pcbLogOutIcon.Size = new System.Drawing.Size(40, 41);
            this.pcbLogOutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogOutIcon.TabIndex = 3;
            this.pcbLogOutIcon.TabStop = false;
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
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.ForeColor = System.Drawing.Color.Teal;
            this.lblEstudiante.Location = new System.Drawing.Point(969, 35);
            this.lblEstudiante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(67, 13);
            this.lblEstudiante.TabIndex = 0;
            this.lblEstudiante.Text = "Estudiante";
            // 
            // pcbStudentIcon
            // 
            this.pcbStudentIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbStudentIcon.Image")));
            this.pcbStudentIcon.Location = new System.Drawing.Point(928, 19);
            this.pcbStudentIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pcbStudentIcon.Name = "pcbStudentIcon";
            this.pcbStudentIcon.Size = new System.Drawing.Size(36, 38);
            this.pcbStudentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbStudentIcon.TabIndex = 0;
            this.pcbStudentIcon.TabStop = false;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Teal;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(21, 34);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(881, 307);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lvwEventos);
            this.groupBox1.Controls.Add(this.lvwPartidosAsistidos);
            this.groupBox1.Controls.Add(this.lblBeneficioPartidos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblHorasLaborales);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(191, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1167, 716);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eventos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lvwEventos
            // 
            this.lvwEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwEventos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhIDEvento,
            this.clhNombreEvento,
            this.clhTipoConvalidacion,
            this.clhConvalida,
            this.clhHorario,
            this.clhFecha,
            this.clhLugar,
            this.clhTipoEvento});
            this.lvwEventos.FullRowSelect = true;
            this.lvwEventos.HideSelection = false;
            this.lvwEventos.Location = new System.Drawing.Point(20, 375);
            this.lvwEventos.Margin = new System.Windows.Forms.Padding(2);
            this.lvwEventos.Name = "lvwEventos";
            this.lvwEventos.Size = new System.Drawing.Size(882, 152);
            this.lvwEventos.TabIndex = 99;
            this.lvwEventos.UseCompatibleStateImageBehavior = false;
            this.lvwEventos.View = System.Windows.Forms.View.Details;
            // 
            // clhIDEvento
            // 
            this.clhIDEvento.Text = "ID";
            this.clhIDEvento.Width = 98;
            // 
            // clhNombreEvento
            // 
            this.clhNombreEvento.Text = "Nombre";
            this.clhNombreEvento.Width = 160;
            // 
            // clhTipoConvalidacion
            // 
            this.clhTipoConvalidacion.DisplayIndex = 3;
            this.clhTipoConvalidacion.Text = "Tipo de convalidacion";
            this.clhTipoConvalidacion.Width = 205;
            // 
            // clhConvalida
            // 
            this.clhConvalida.DisplayIndex = 4;
            this.clhConvalida.Text = "Convalidacion";
            this.clhConvalida.Width = 140;
            // 
            // clhHorario
            // 
            this.clhHorario.DisplayIndex = 5;
            this.clhHorario.Text = "Horario";
            this.clhHorario.Width = 80;
            // 
            // clhFecha
            // 
            this.clhFecha.DisplayIndex = 7;
            this.clhFecha.Text = "Fecha";
            this.clhFecha.Width = 80;
            // 
            // clhLugar
            // 
            this.clhLugar.Text = "Lugar";
            this.clhLugar.Width = 80;
            // 
            // clhTipoEvento
            // 
            this.clhTipoEvento.DisplayIndex = 2;
            this.clhTipoEvento.Text = "Tipo de Evento";
            this.clhTipoEvento.Width = 160;
            // 
            // lvwPartidosAsistidos
            // 
            this.lvwPartidosAsistidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPartidosAsistidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhID,
            this.clhNombre,
            this.clhConvalidacion,
            this.clhHora,
            this.clhFechaPartido,
            this.clhLugarPartido,
            this.clhDeporte});
            this.lvwPartidosAsistidos.FullRowSelect = true;
            this.lvwPartidosAsistidos.HideSelection = false;
            this.lvwPartidosAsistidos.Location = new System.Drawing.Point(19, 570);
            this.lvwPartidosAsistidos.Margin = new System.Windows.Forms.Padding(2);
            this.lvwPartidosAsistidos.Name = "lvwPartidosAsistidos";
            this.lvwPartidosAsistidos.Size = new System.Drawing.Size(882, 152);
            this.lvwPartidosAsistidos.TabIndex = 100;
            this.lvwPartidosAsistidos.UseCompatibleStateImageBehavior = false;
            this.lvwPartidosAsistidos.View = System.Windows.Forms.View.Details;
            this.lvwPartidosAsistidos.SelectedIndexChanged += new System.EventHandler(this.lvwPartidosAsistidos_SelectedIndexChanged);
            // 
            // clhID
            // 
            this.clhID.Text = "ID";
            this.clhID.Width = 98;
            // 
            // clhNombre
            // 
            this.clhNombre.Text = "Nombre";
            this.clhNombre.Width = 160;
            // 
            // clhConvalidacion
            // 
            this.clhConvalidacion.Text = "Convalidacion";
            this.clhConvalidacion.Width = 140;
            // 
            // clhHora
            // 
            this.clhHora.Text = "Horario";
            this.clhHora.Width = 130;
            // 
            // clhFechaPartido
            // 
            this.clhFechaPartido.Text = "Fecha";
            this.clhFechaPartido.Width = 178;
            // 
            // clhLugarPartido
            // 
            this.clhLugarPartido.Text = "Lugar";
            this.clhLugarPartido.Width = 150;
            // 
            // clhDeporte
            // 
            this.clhDeporte.Text = "Deporte";
            this.clhDeporte.Width = 160;
            // 
            // lblBeneficioPartidos
            // 
            this.lblBeneficioPartidos.AutoSize = true;
            this.lblBeneficioPartidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficioPartidos.Location = new System.Drawing.Point(942, 87);
            this.lblBeneficioPartidos.Name = "lblBeneficioPartidos";
            this.lblBeneficioPartidos.Size = new System.Drawing.Size(51, 20);
            this.lblBeneficioPartidos.TabIndex = 18;
            this.lblBeneficioPartidos.Text = "label3";
            this.lblBeneficioPartidos.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 550);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "Partidos Asistidos";
            // 
            // lblHorasLaborales
            // 
            this.lblHorasLaborales.AutoSize = true;
            this.lblHorasLaborales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasLaborales.Location = new System.Drawing.Point(942, 54);
            this.lblHorasLaborales.Name = "lblHorasLaborales";
            this.lblHorasLaborales.Size = new System.Drawing.Size(51, 20);
            this.lblHorasLaborales.TabIndex = 17;
            this.lblHorasLaborales.Text = "label2";
            this.lblHorasLaborales.Click += new System.EventHandler(this.lblHorasLaborales_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1472, 530);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Eventos Asistidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1466, 523);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 96;
            this.label4.Text = "Eventos Asistidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 353);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "Eventos Asistidos";
            // 
            // UserReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1370, 856);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlPieArriba);
            this.Controls.Add(this.pnlAreaAdministrador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHorasLaborales;
        private System.Windows.Forms.Label lblBeneficioPartidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvwEventos;
        private System.Windows.Forms.ColumnHeader clhIDEvento;
        private System.Windows.Forms.ColumnHeader clhNombreEvento;
        private System.Windows.Forms.ColumnHeader clhTipoConvalidacion;
        private System.Windows.Forms.ColumnHeader clhConvalida;
        private System.Windows.Forms.ColumnHeader clhHorario;
        private System.Windows.Forms.ColumnHeader clhFecha;
        private System.Windows.Forms.ColumnHeader clhLugar;
        private System.Windows.Forms.ColumnHeader clhTipoEvento;
        private System.Windows.Forms.ListView lvwPartidosAsistidos;
        private System.Windows.Forms.ColumnHeader clhID;
        private System.Windows.Forms.ColumnHeader clhNombre;
        private System.Windows.Forms.ColumnHeader clhConvalidacion;
        private System.Windows.Forms.ColumnHeader clhHora;
        private System.Windows.Forms.ColumnHeader clhFechaPartido;
        private System.Windows.Forms.ColumnHeader clhLugarPartido;
        private System.Windows.Forms.ColumnHeader clhDeporte;
    }
}