namespace gui_ciudades.Formulario
{
   partial class CiudadFrm
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
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.txtCodigo = new System.Windows.Forms.TextBox();
         this.grpDatosgenerales = new System.Windows.Forms.GroupBox();
         this.btnAgregar = new System.Windows.Forms.Button();
         this.lblNombreCiudad = new System.Windows.Forms.Label();
         this.lblCódigo = new System.Windows.Forms.Label();
         this.grpRegistros = new System.Windows.Forms.GroupBox();
         this.btnEliminar = new System.Windows.Forms.Button();
         this.btnCargar = new System.Windows.Forms.Button();
         this.btnGuardar = new System.Windows.Forms.Button();
         this.dgvRegistros = new System.Windows.Forms.DataGridView();
         this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.grpDatosgenerales.SuspendLayout();
         this.grpRegistros.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
         this.SuspendLayout();
         // 
         // txtNombre
         // 
         this.txtNombre.Location = new System.Drawing.Point(119, 76);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(178, 22);
         this.txtNombre.TabIndex = 0;
         this.txtNombre.TextChanged += new System.EventHandler(this.txtNombreCiudad_TextChanged);
         // 
         // txtCodigo
         // 
         this.txtCodigo.Location = new System.Drawing.Point(119, 36);
         this.txtCodigo.Name = "txtCodigo";
         this.txtCodigo.Size = new System.Drawing.Size(178, 22);
         this.txtCodigo.TabIndex = 1;
         this.txtCodigo.TextChanged += new System.EventHandler(this.txtCódigo_TextChanged);
         // 
         // grpDatosgenerales
         // 
         this.grpDatosgenerales.Controls.Add(this.btnAgregar);
         this.grpDatosgenerales.Controls.Add(this.lblNombreCiudad);
         this.grpDatosgenerales.Controls.Add(this.lblCódigo);
         this.grpDatosgenerales.Controls.Add(this.txtCodigo);
         this.grpDatosgenerales.Controls.Add(this.txtNombre);
         this.grpDatosgenerales.Location = new System.Drawing.Point(12, 23);
         this.grpDatosgenerales.Name = "grpDatosgenerales";
         this.grpDatosgenerales.Size = new System.Drawing.Size(544, 186);
         this.grpDatosgenerales.TabIndex = 2;
         this.grpDatosgenerales.TabStop = false;
         this.grpDatosgenerales.Text = "Datos generales";
         this.grpDatosgenerales.Enter += new System.EventHandler(this.groupBox1_Enter);
         // 
         // btnAgregar
         // 
         this.btnAgregar.Location = new System.Drawing.Point(361, 131);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(146, 30);
         this.btnAgregar.TabIndex = 4;
         this.btnAgregar.Text = "Agregar";
         this.btnAgregar.UseVisualStyleBackColor = true;
         this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
         // 
         // lblNombreCiudad
         // 
         this.lblNombreCiudad.AutoSize = true;
         this.lblNombreCiudad.Location = new System.Drawing.Point(6, 82);
         this.lblNombreCiudad.Name = "lblNombreCiudad";
         this.lblNombreCiudad.Size = new System.Drawing.Size(59, 16);
         this.lblNombreCiudad.TabIndex = 3;
         this.lblNombreCiudad.Text = "Nombre:";
         // 
         // lblCódigo
         // 
         this.lblCódigo.AutoSize = true;
         this.lblCódigo.Location = new System.Drawing.Point(6, 42);
         this.lblCódigo.Name = "lblCódigo";
         this.lblCódigo.Size = new System.Drawing.Size(54, 16);
         this.lblCódigo.TabIndex = 2;
         this.lblCódigo.Text = "Código:";
         // 
         // grpRegistros
         // 
         this.grpRegistros.Controls.Add(this.btnEliminar);
         this.grpRegistros.Controls.Add(this.btnCargar);
         this.grpRegistros.Controls.Add(this.btnGuardar);
         this.grpRegistros.Controls.Add(this.dgvRegistros);
         this.grpRegistros.Location = new System.Drawing.Point(12, 229);
         this.grpRegistros.Name = "grpRegistros";
         this.grpRegistros.Size = new System.Drawing.Size(520, 168);
         this.grpRegistros.TabIndex = 3;
         this.grpRegistros.TabStop = false;
         this.grpRegistros.Text = "Registros agregados";
         // 
         // btnEliminar
         // 
         this.btnEliminar.Location = new System.Drawing.Point(403, 116);
         this.btnEliminar.Name = "btnEliminar";
         this.btnEliminar.Size = new System.Drawing.Size(88, 45);
         this.btnEliminar.TabIndex = 3;
         this.btnEliminar.Text = "Eliminar";
         this.btnEliminar.UseVisualStyleBackColor = true;
         this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
         // 
         // btnCargar
         // 
         this.btnCargar.Location = new System.Drawing.Point(403, 68);
         this.btnCargar.Name = "btnCargar";
         this.btnCargar.Size = new System.Drawing.Size(88, 42);
         this.btnCargar.TabIndex = 2;
         this.btnCargar.Text = "Cargar";
         this.btnCargar.UseVisualStyleBackColor = true;
         this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
         // 
         // btnGuardar
         // 
         this.btnGuardar.Location = new System.Drawing.Point(403, 21);
         this.btnGuardar.Name = "btnGuardar";
         this.btnGuardar.Size = new System.Drawing.Size(88, 41);
         this.btnGuardar.TabIndex = 1;
         this.btnGuardar.Text = "Guardar";
         this.btnGuardar.UseVisualStyleBackColor = true;
         this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
         // 
         // dgvRegistros
         // 
         this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvRegistros.Location = new System.Drawing.Point(17, 37);
         this.dgvRegistros.Name = "dgvRegistros";
         this.dgvRegistros.RowHeadersWidth = 51;
         this.dgvRegistros.Size = new System.Drawing.Size(344, 106);
         this.dgvRegistros.TabIndex = 0;
         this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.FileName = "openFileDialog1";
         // 
         // CiudadFrm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.grpRegistros);
         this.Controls.Add(this.grpDatosgenerales);
         this.Name = "CiudadFrm";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.CiudadFrm_Load);
         this.grpDatosgenerales.ResumeLayout(false);
         this.grpDatosgenerales.PerformLayout();
         this.grpRegistros.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TextBox txtNombre;
      private System.Windows.Forms.TextBox txtCodigo;
      private System.Windows.Forms.GroupBox grpDatosgenerales;
      private System.Windows.Forms.Label lblNombreCiudad;
      private System.Windows.Forms.Label lblCódigo;
      private System.Windows.Forms.Button btnAgregar;
      private System.Windows.Forms.GroupBox grpRegistros;
      private System.Windows.Forms.Button btnEliminar;
      private System.Windows.Forms.Button btnCargar;
      private System.Windows.Forms.Button btnGuardar;
      private System.Windows.Forms.DataGridView dgvRegistros;
      private System.Windows.Forms.SaveFileDialog saveFileDialog1;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
   }
}