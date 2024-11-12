using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyHoursUAM_App;
using MyHoursUAM_App.Archivo;

namespace MyHoursUAM_App.GUI_Estudiantes.LogIn
{
   public partial class Form1 : Form
   {
      private List<Trabajador> trabajadores = new List<Trabajador>();
      public Form1()
      {
         InitializeComponent();
         trabajadores = new List<Trabajador>();
      }

      private void btnIngresar_Click(object sender, EventArgs e)
      {

         Trabajador nuevoTrabajador = new Trabajador();

         nuevoTrabajador.cifTrabajador = txtbCif.Text;
         nuevoTrabajador.contraseñaTrabajador = txtbContraseña.Text;

         trabajadores.Add(nuevoTrabajador);

         MessageBox.Show(" BIENVENIDO!");

      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }
   }
}
