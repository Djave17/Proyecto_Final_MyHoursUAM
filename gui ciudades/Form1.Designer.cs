namespace gui_ciudades
{
   partial class Form1
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
         this.components = new System.ComponentModel.Container();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.ciudadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.catálogosToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(800, 28);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // archivoToolStripMenuItem
         // 
         this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
         this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
         this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
         this.archivoToolStripMenuItem.Text = "Archivo";
         // 
         // salirToolStripMenuItem
         // 
         this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
         this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
         this.salirToolStripMenuItem.Text = "Salir";
         this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
         // 
         // catálogosToolStripMenuItem
         // 
         this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ciudadesToolStripMenuItem});
         this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
         this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
         this.catálogosToolStripMenuItem.Text = "Catálogos";
         // 
         // ciudadesToolStripMenuItem
         // 
         this.ciudadesToolStripMenuItem.Name = "ciudadesToolStripMenuItem";
         this.ciudadesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
         this.ciudadesToolStripMenuItem.Text = "Ciudades";
         this.ciudadesToolStripMenuItem.Click += new System.EventHandler(this.ciudadesToolStripMenuItem_Click);
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "Form1";
         this.Text = "Form1";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem ciudadesToolStripMenuItem;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
   }
}

