namespace MyHours_UAMApp.Forms.Administrador
{
    partial class AdminGrafico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGrafico));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlPieArriba = new System.Windows.Forms.Panel();
            this.lblCerrarSesion = new System.Windows.Forms.Label();
            this.pcbLogOutIcon = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAreaAdministrador = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAñadirEventos = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.graficoCupos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graficoHoras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlPieArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlAreaAdministrador.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoCupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPieArriba
            // 
            this.pnlPieArriba.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPieArriba.BackColor = System.Drawing.Color.White;
            this.pnlPieArriba.Controls.Add(this.lblCerrarSesion);
            this.pnlPieArriba.Controls.Add(this.pcbLogOutIcon);
            this.pnlPieArriba.Controls.Add(this.lblAdmin);
            this.pnlPieArriba.Controls.Add(this.pictureBox2);
            this.pnlPieArriba.Controls.Add(this.label1);
            this.pnlPieArriba.Location = new System.Drawing.Point(165, 0);
            this.pnlPieArriba.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPieArriba.Name = "pnlPieArriba";
            this.pnlPieArriba.Size = new System.Drawing.Size(674, 73);
            this.pnlPieArriba.TabIndex = 14;
            // 
            // lblCerrarSesion
            // 
            this.lblCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCerrarSesion.AutoSize = true;
            this.lblCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarSesion.ForeColor = System.Drawing.Color.Teal;
            this.lblCerrarSesion.Location = new System.Drawing.Point(575, 28);
            this.lblCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCerrarSesion.Name = "lblCerrarSesion";
            this.lblCerrarSesion.Size = new System.Drawing.Size(83, 13);
            this.lblCerrarSesion.TabIndex = 21;
            this.lblCerrarSesion.Text = "Cerrar Sesion";
            this.lblCerrarSesion.Click += new System.EventHandler(this.lblCerrarSesion_Click);
            // 
            // pcbLogOutIcon
            // 
            this.pcbLogOutIcon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pcbLogOutIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogOutIcon.Image")));
            this.pcbLogOutIcon.Location = new System.Drawing.Point(531, 11);
            this.pcbLogOutIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbLogOutIcon.Name = "pcbLogOutIcon";
            this.pcbLogOutIcon.Size = new System.Drawing.Size(40, 41);
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
            this.lblAdmin.Location = new System.Drawing.Point(449, 28);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(83, 13);
            this.lblAdmin.TabIndex = 18;
            this.lblAdmin.Text = "Administrador";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(409, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "DASHBOARD";
            // 
            // pnlAreaAdministrador
            // 
            this.pnlAreaAdministrador.BackColor = System.Drawing.Color.Teal;
            this.pnlAreaAdministrador.Controls.Add(this.panel2);
            this.pnlAreaAdministrador.Controls.Add(this.panel1);
            this.pnlAreaAdministrador.Controls.Add(this.pnlIcon);
            this.pnlAreaAdministrador.Controls.Add(this.btnGraficos);
            this.pnlAreaAdministrador.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAreaAdministrador.ForeColor = System.Drawing.Color.White;
            this.pnlAreaAdministrador.Location = new System.Drawing.Point(0, 0);
            this.pnlAreaAdministrador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAreaAdministrador.Name = "pnlAreaAdministrador";
            this.pnlAreaAdministrador.Size = new System.Drawing.Size(165, 609);
            this.pnlAreaAdministrador.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(2, 530);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 103);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnAñadirEventos);
            this.panel1.Controls.Add(this.btnAsistencia);
            this.panel1.Controls.Add(this.btnAjustes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 453);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 110);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 120);
            this.button2.TabIndex = 22;
            this.button2.Text = "⚽ Añadir Partidos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.btnAñadirEventos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnAsistencia.Location = new System.Drawing.Point(0, 233);
            this.btnAsistencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnAjustes.Location = new System.Drawing.Point(4, 351);
            this.btnAjustes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(160, 99);
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
            this.pnlIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(165, 73);
            this.pnlIcon.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // btnGraficos
            // 
            this.btnGraficos.BackColor = System.Drawing.Color.Transparent;
            this.btnGraficos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGraficos.FlatAppearance.BorderSize = 0;
            this.btnGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficos.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficos.ForeColor = System.Drawing.Color.White;
            this.btnGraficos.Location = new System.Drawing.Point(2, 527);
            this.btnGraficos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(163, 103);
            this.btnGraficos.TabIndex = 23;
            this.btnGraficos.Text = "📈 Graficos";
            this.btnGraficos.UseVisualStyleBackColor = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // graficoCupos
            // 
            this.graficoCupos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.graficoCupos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoCupos.Legends.Add(legend1);
            this.graficoCupos.Location = new System.Drawing.Point(191, 88);
            this.graficoCupos.Name = "graficoCupos";
            this.graficoCupos.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficoCupos.Series.Add(series1);
            this.graficoCupos.Size = new System.Drawing.Size(632, 284);
            this.graficoCupos.TabIndex = 15;
            this.graficoCupos.Text = "chart1";
            // 
            // graficoHoras
            // 
            this.graficoHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.graficoHoras.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graficoHoras.Legends.Add(legend2);
            this.graficoHoras.Location = new System.Drawing.Point(191, 382);
            this.graficoHoras.Name = "graficoHoras";
            this.graficoHoras.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graficoHoras.Series.Add(series2);
            this.graficoHoras.Size = new System.Drawing.Size(632, 317);
            this.graficoHoras.TabIndex = 16;
            this.graficoHoras.Text = "chart2";
            // 
            // AdminGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 609);
            this.Controls.Add(this.graficoHoras);
            this.Controls.Add(this.graficoCupos);
            this.Controls.Add(this.pnlPieArriba);
            this.Controls.Add(this.pnlAreaAdministrador);
            this.Name = "AdminGrafico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminGrafico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminGrafico_Load);
            this.pnlPieArriba.ResumeLayout(false);
            this.pnlPieArriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlAreaAdministrador.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoCupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPieArriba;
        private System.Windows.Forms.Label lblCerrarSesion;
        private System.Windows.Forms.PictureBox pcbLogOutIcon;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAreaAdministrador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAñadirEventos;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGraficos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoCupos;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHoras;
    }
}