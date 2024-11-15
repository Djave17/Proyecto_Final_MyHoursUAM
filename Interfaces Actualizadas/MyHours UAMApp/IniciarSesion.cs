using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHours_UAMApp
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void lblRotulo3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txbCIF.Text == "admin" && txbContraseña.Text== "admin")
            {
                SplashScreenAdmin form = new SplashScreenAdmin();
                form.Show();
                this.Hide();
            }
            else if (txbCIF.Text == "user" && txbContraseña.Text == "user")
            {
                SplashScreenUser form = new SplashScreenUser();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El Usuario o Contraseña es incorrecto.");
                txbCIF.Clear();
                txbContraseña.Clear();
                txbCIF.Focus();
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
            this.Hide();
        }
    }
}
