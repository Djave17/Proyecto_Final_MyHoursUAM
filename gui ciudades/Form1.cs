using gui_ciudades.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_ciudades
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
      {
         CiudadFrm frm = new CiudadFrm();
         frm.Show();
      }

      private void salirToolStripMenuItem_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
