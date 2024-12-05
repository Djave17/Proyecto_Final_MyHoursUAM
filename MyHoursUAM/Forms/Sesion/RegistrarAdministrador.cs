using MyHours_UAMApp.Estructuras.Metodos;
using MyHours_UAMApp.Estructuras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHours_UAMApp.Forms.Sesion
{
   public partial class RegistrarAdministrador : Form
   {
      public RegistrarAdministrador()
      {
         InitializeComponent();
      }

      private void btnIniciarSesion_Click(object sender, EventArgs e)
      {
         string usuario = txbCIF.Text.Trim();
         string contraseña = txbContraseña.Text.Trim();
         string nombre = txbNombre.Text.Trim();


         SesionActual.LimpiarSesion(); 
         var mensaje = Metodos.RegistrarAdministrador(usuario, contraseña, nombre);
         MessageBox.Show(mensaje, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);



      }

      private void lblSalir_Click(object sender, EventArgs e)
      {
         IniciarSesion iniciar = new IniciarSesion();
         iniciar.Show(); 
         this.Close();
      }
   }
}
