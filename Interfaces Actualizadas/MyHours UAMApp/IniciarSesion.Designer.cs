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
            this.pcbIconApp.Location = new System.Drawing.Point(117, 24);
            this.pcbIconApp.Name = "pcbIconApp";
            this.pcbIconApp.Size = new System.Drawing.Size(72, 92);
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
            this.btnIniciarSesion.Location = new System.Drawing.Point(47, 383);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(216, 35);
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
            this.chbVerContraseña.Location = new System.Drawing.Point(133, 328);
            this.chbVerContraseña.Name = "chbVerContraseña";
            this.chbVerContraseña.Size = new System.Drawing.Size(144, 24);
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
            this.txbContraseña.Location = new System.Drawing.Point(61, 271);
            this.txbContraseña.Multiline = true;
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.Size = new System.Drawing.Size(216, 28);
            this.txbContraseña.TabIndex = 32;
            this.txbContraseña.TextChanged += new System.EventHandler(this.txbContraseña_TextChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.Teal;
            this.lblContraseña.Location = new System.Drawing.Point(8, 267);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(47, 32);
            this.lblContraseña.TabIndex = 31;
            this.lblContraseña.Text = "🔒";
            // 
            // txbCIF
            // 
            this.txbCIF.BackColor = System.Drawing.Color.MintCream;
            this.txbCIF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCIF.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCIF.Location = new System.Drawing.Point(61, 199);
            this.txbCIF.Multiline = true;
            this.txbCIF.Name = "txbCIF";
            this.txbCIF.Size = new System.Drawing.Size(216, 28);
            this.txbCIF.TabIndex = 30;
            // 
            // lblCIF
            // 
            this.lblCIF.AutoSize = true;
            this.lblCIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIF.ForeColor = System.Drawing.Color.Teal;
            this.lblCIF.Location = new System.Drawing.Point(8, 195);
            this.lblCIF.Name = "lblCIF";
            this.lblCIF.Size = new System.Drawing.Size(47, 32);
            this.lblCIF.TabIndex = 29;
            this.lblCIF.Text = "👤";
            // 
            // lblRotulo1
            // 
            this.lblRotulo1.AutoSize = true;
            this.lblRotulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotulo1.ForeColor = System.Drawing.Color.Teal;
            this.lblRotulo1.Location = new System.Drawing.Point(89, 134);
            this.lblRotulo1.Name = "lblRotulo1";
            this.lblRotulo1.Size = new System.Drawing.Size(136, 25);
            this.lblRotulo1.TabIndex = 35;
            this.lblRotulo1.Text = "Inicia Sesion";
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Teal;
            this.pnl1.Location = new System.Drawing.Point(15, 233);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(265, 5);
            this.pnl1.TabIndex = 36;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.Teal;
            this.pnl2.Location = new System.Drawing.Point(14, 305);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(265, 5);
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
            this.btnLimpiar.Location = new System.Drawing.Point(47, 440);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(216, 35);
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
            this.lblSalir.Location = new System.Drawing.Point(177, 496);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(48, 20);
            this.lblSalir.TabIndex = 39;
            this.lblSalir.Text = "Salir";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // lblAtras
            // 
            this.lblAtras.AutoSize = true;
            this.lblAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtras.ForeColor = System.Drawing.Color.Teal;
            this.lblAtras.Location = new System.Drawing.Point(66, 496);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(54, 20);
            this.lblAtras.TabIndex = 40;
            this.lblAtras.Text = "Atras";
            this.lblAtras.Click += new System.EventHandler(this.lblAtras_Click);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 539);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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

