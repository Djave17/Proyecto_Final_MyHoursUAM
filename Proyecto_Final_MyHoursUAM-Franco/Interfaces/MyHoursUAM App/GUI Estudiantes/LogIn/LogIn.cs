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


namespace MyHoursUAM_App.GUI.LogIn
{

   public partial class imgIconApp : Form
    {
      private List<Estudiante> estudiantes = new List<Estudiante>();
      
    
      /*private List<Usuario> usuarios;
      private Ciudad ciudadsel = new Ciudad();*/
      public imgIconApp()
        {
            InitializeComponent();
         estudiantes = new List<Estudiante>();
      }
    

      private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      private void txtbCIF_TextChanged(object sender, EventArgs e)
      {

      }

      private void btnIngresar_Click(object sender, EventArgs e)
      {
         Estudiante nuevoEstudiante = new Estudiante();

         nuevoEstudiante.cifEstudiante = txtbCIF.Text;
         nuevoEstudiante.contraseñaEstudiante = txtbContraseña.Text;

         estudiantes.Add(nuevoEstudiante);

         MessageBox.Show(" BIENVENIDO!");
         
      }
   }
}
