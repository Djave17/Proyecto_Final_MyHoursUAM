namespace MyHoursUAM_App.GUI_Estudiantes.LogIn
{
   partial class Form1
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
         this.btnIngresar = new System.Windows.Forms.Button();
         this.lblCif = new System.Windows.Forms.Label();
         this.lblContraseña = new System.Windows.Forms.Label();
         this.txtbCif = new System.Windows.Forms.TextBox();
         this.txtbContraseña = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // btnIngresar
         // 
         this.btnIngresar.Location = new System.Drawing.Point(128, 321);
         this.btnIngresar.Name = "btnIngresar";
         this.btnIngresar.Size = new System.Drawing.Size(157, 59);
         this.btnIngresar.TabIndex = 0;
         this.btnIngresar.Text = "Ingresar";
         this.btnIngresar.UseVisualStyleBackColor = true;
         this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
         // 
         // lblCif
         // 
         this.lblCif.AutoSize = true;
         this.lblCif.Location = new System.Drawing.Point(24, 109);
         this.lblCif.Name = "lblCif";
         this.lblCif.Size = new System.Drawing.Size(22, 16);
         this.lblCif.TabIndex = 1;
         this.lblCif.Text = "Cif";
         // 
         // lblContraseña
         // 
         this.lblContraseña.AutoSize = true;
         this.lblContraseña.Location = new System.Drawing.Point(24, 179);
         this.lblContraseña.Name = "lblContraseña";
         this.lblContraseña.Size = new System.Drawing.Size(76, 16);
         this.lblContraseña.TabIndex = 2;
         this.lblContraseña.Text = "Contraseña";
         // 
         // txtbCif
         // 
         this.txtbCif.Location = new System.Drawing.Point(113, 103);
         this.txtbCif.Name = "txtbCif";
         this.txtbCif.Size = new System.Drawing.Size(185, 22);
         this.txtbCif.TabIndex = 3;
         this.txtbCif.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // txtbContraseña
         // 
         this.txtbContraseña.Location = new System.Drawing.Point(110, 183);
         this.txtbContraseña.Name = "txtbContraseña";
         this.txtbContraseña.Size = new System.Drawing.Size(187, 22);
         this.txtbContraseña.TabIndex = 4;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(513, 450);
         this.Controls.Add(this.txtbContraseña);
         this.Controls.Add(this.txtbCif);
         this.Controls.Add(this.lblContraseña);
         this.Controls.Add(this.lblCif);
         this.Controls.Add(this.btnIngresar);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnIngresar;
      private System.Windows.Forms.Label lblCif;
      private System.Windows.Forms.Label lblContraseña;
      private System.Windows.Forms.TextBox txtbCif;
      private System.Windows.Forms.TextBox txtbContraseña;
   }
}