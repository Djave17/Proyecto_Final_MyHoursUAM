namespace MyHours_UAMApp
{
    partial class IniciarSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            this.pcbIconApp = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.chbVerContraseña = new System.Windows.Forms.CheckBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txbCIF = new System.Windows.Forms.TextBox();
            this.lblCIF = new System.Windows.Forms.Label();
            this.lblRotulo1 = new System.Windows.Forms.Label();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblAtras = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconApp)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbIconApp
            // 
            this.pcbIconApp.Image = ((System.Drawing.Image)(resources.GetObject("pcbIconApp.Image")));
            this.pcbIconApp.Location = new System.Drawing.Point(88, 20);
            this.pcbIconApp.Margin = new System.Windows.Forms.Padding(2);
            this.pcbIconApp.Name = "pcbIconApp";
            this.pcbIconApp.Size = new System.Drawing.Size(54, 75);
            this.pcbIconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIconApp.TabIndex = 28;
            this.pcbIconApp.TabStop = false;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Teal;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(35, 311);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(162, 28);
            this.btnIniciarSesion.TabIndex = 34;
            this.btnIniciarSesion.Text = "Inicia Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // chbVerContraseña
            // 
            this.chbVerContraseña.AutoSize = true;
            this.chbVerContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbVerContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbVerContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbVerContraseña.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.chbVerContraseña.Location = new System.Drawing.Point(100, 266);
            this.chbVerContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.chbVerContraseña.Name = "chbVerContraseña";
            this.chbVerContraseña.Size = new System.Drawing.Size(123, 21);
            this.chbVerContraseña.TabIndex = 33;
            this.chbVerContraseña.Text = "Ver Contraseña";
            this.chbVerContraseña.UseVisualStyleBackColor = true;
            this.chbVerContraseña.CheckedChanged += new System.EventHandler(this.chbVerContraseña_CheckedChanged);
            // 
            // txbContraseña
            // 
            this.txbContraseña.BackColor = System.Drawing.Color.MintCream;
            this.txbContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbContraseña.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseña.Location = new System.Drawing.Point(46, 220);
            this.txbContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txbContraseña.Multiline = true;
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.Size = new System.Drawing.Size(162, 23);
            this.txbContraseña.TabIndex = 32;
            this.txbContraseña.TextChanged += new System.EventHandler(this.txbContraseña_TextChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.Teal;
            this.lblContraseña.Location = new System.Drawing.Point(6, 217);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(34, 26);
            this.lblContraseña.TabIndex = 31;
            this.lblContraseña.Text = "🔒";
            // 
            // txbCIF
            // 
            this.txbCIF.BackColor = System.Drawing.Color.MintCream;
            this.txbCIF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCIF.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCIF.Location = new System.Drawing.Point(46, 162);
            this.txbCIF.Margin = new System.Windows.Forms.Padding(2);
            this.txbCIF.Multiline = true;
            this.txbCIF.Name = "txbCIF";
            this.txbCIF.Size = new System.Drawing.Size(162, 23);
            this.txbCIF.TabIndex = 30;
            this.txbCIF.TextChanged += new System.EventHandler(this.txbCIF_TextChanged);
            // 
            // lblCIF
            // 
            this.lblCIF.AutoSize = true;
            this.lblCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIF.ForeColor = System.Drawing.Color.Teal;
            this.lblCIF.Location = new System.Drawing.Point(6, 158);
            this.lblCIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCIF.Name = "lblCIF";
            this.lblCIF.Size = new System.Drawing.Size(34, 26);
            this.lblCIF.TabIndex = 29;
            this.lblCIF.Text = "👤";
            // 
            // lblRotulo1
            // 
            this.lblRotulo1.AutoSize = true;
            this.lblRotulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotulo1.ForeColor = System.Drawing.Color.Teal;
            this.lblRotulo1.Location = new System.Drawing.Point(67, 109);
            this.lblRotulo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRotulo1.Name = "lblRotulo1";
            this.lblRotulo1.Size = new System.Drawing.Size(112, 20);
            this.lblRotulo1.TabIndex = 35;
            this.lblRotulo1.Text = "Inicia Sesion";
            this.lblRotulo1.Click += new System.EventHandler(this.lblRotulo1_Click);
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Teal;
            this.pnl1.Location = new System.Drawing.Point(11, 189);
            this.pnl1.Margin = new System.Windows.Forms.Padding(2);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(199, 4);
            this.pnl1.TabIndex = 36;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Teal;
            this.pnl2.Location = new System.Drawing.Point(10, 248);
            this.pnl2.Margin = new System.Windows.Forms.Padding(2);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(199, 4);
            this.pnl2.TabIndex = 37;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Teal;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(35, 358);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(162, 28);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "Limpiar ";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.Color.Teal;
            this.lblSalir.Location = new System.Drawing.Point(133, 403);
            this.lblSalir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(41, 17);
            this.lblSalir.TabIndex = 39;
            this.lblSalir.Text = "Salir";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtras.ForeColor = System.Drawing.Color.Teal;
            this.lblAtras.Location = new System.Drawing.Point(50, 403);
            this.lblAtras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(46, 17);
            this.lblAtras.TabIndex = 40;
            this.lblAtras.Text = "Atras";
            this.lblAtras.Click += new System.EventHandler(this.lblAtras_Click);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(224, 438);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.lblRotulo1);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.chbVerContraseña);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txbCIF);
            this.Controls.Add(this.lblCIF);
            this.Controls.Add(this.pcbIconApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyHoursUAM - Iniciar Sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIconApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbIconApp;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.CheckBox chbVerContraseña;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txbCIF;
        private System.Windows.Forms.Label lblCIF;
        private System.Windows.Forms.Label lblRotulo1;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lblAtras;
    }
}

