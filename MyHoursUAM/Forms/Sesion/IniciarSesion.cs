using MyHours_UAMApp.Estructuras;
using MyHours_UAMApp.Estructuras.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyHours_UAMApp.Forms;

namespace MyHours_UAMApp
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
            txbCIF.KeyDown += BloquearTeclasEspeciales;
            txbContraseña.KeyDown += BloquearTeclasEspeciales;
        }

        private void lblRotulo3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txbCIF.Text.Trim();
            string contraseña = txbContraseña.Text.Trim();

            // Validaciones básicas
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar credenciales usando Metodos.cs
            var (exito, rol) = Metodos.ValidarCredenciales(usuario, contraseña);
            if (exito)
            {
                // Limpiar sesión previa
                SesionActual.LimpiarSesion();

                if (rol == "Administrador")
                {
                    // Configurar sesión para administrador
                    SesionActual.AdministradorActual = Metodos.administradores.FirstOrDefault(admin => admin.cifAdministrador == usuario);
                    MessageBox.Show("Bienvenido, Administrador.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AbrirFormularioAdministrador();
                }
                else if (rol == "Estudiante")
                {
                    // Configurar sesión para estudiante
                    SesionActual.EstudianteActual = Metodos.estudiantes.FirstOrDefault(est => est.cifEstudiante == usuario);
                    MessageBox.Show("Bienvenido, Estudiante.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AbrirFormularioEstudiante();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbContraseña.Clear();
            }
        }


        

        private void chbVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVerContraseña.Checked)
            {
                txbContraseña.PasswordChar = '\0'; 
            }
            else
            {
                txbContraseña.PasswordChar = '*'; 
            }
        }

        // Evento para bloquear Espacio y Enter en txbCIF y txbContraseña
        private void BloquearTeclasEspeciales(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                //Esto bloquea la accion de laa teclas configuradas
                e.SuppressKeyPress = true; 
            }
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbCIF.Clear();
            txbContraseña.Clear();
            txbCIF.Focus();
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAtras_Click(object sender, EventArgs e)
        {
            Rol form = new Rol();
            form.Show();
            this.Close();
        }

        private void lblRotulo1_Click(object sender, EventArgs e)
        {

        }

        private void txbCIF_TextChanged(object sender, EventArgs e)
        {

        }

        private void pcbIconApp_Click(object sender, EventArgs e)
        {

        }
        private void AbrirFormularioAdministrador()
        {
            SplashScreenAdmin form = new SplashScreenAdmin();
            form.Show();
            this.Close();
        }

        private void AbrirFormularioEstudiante()
        {
            SplashScreenUser form = new SplashScreenUser();
            form.Show();
            this.Close();
        }
    }
}
