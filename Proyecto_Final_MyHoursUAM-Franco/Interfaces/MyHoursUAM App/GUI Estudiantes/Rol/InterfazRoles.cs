using MyHoursUAM_App.GUI.LogIn;
using MyHoursUAM_App.GUI_Estudiantes.LogIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHoursUAM_App.GUI.Rol
{
    public partial class InterfazRoles : Form
    {
        public InterfazRoles()
        {
            InitializeComponent();
        }

        private void InterfazRoles_Load(object sender, EventArgs e)
        {

        }

      private void btnStudent_Click(object sender, EventArgs e)
      {
         // Crear una instancia del formulario Login
         imgIconApp loginForm = new imgIconApp();

         // Mostrar el formulario de login
         loginForm.Show();

         // Ocultar el formulario actual (InterfazRoles)
         this.Hide();
      }

      private void btnAdmin_Click(object sender, EventArgs e)
      {
         
         Form1 loginTrabajadorForm = new Form1();

         // Mostrar el formulario de login de Trabajador
         loginTrabajadorForm.Show();

         // Ocultar el formulario actual (InterfazRoles)
         this.Hide();
      }
   }
}
