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
    public partial class UserMiPerfil : Form
    {
        public UserMiPerfil()
        {
            InitializeComponent();
        }

        private void btnVerEventos_Click(object sender, EventArgs e)
        {
            UserEvento form = new UserEvento();
            form.Show();
            this.Hide();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            UserAsistencia form = new UserAsistencia();
            form.Show();
            this.Hide();
        }

        private void btnEditarAsitencia_Click(object sender, EventArgs e)
        {
            UserGestiones form = new UserGestiones();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserMiPerfil form = new UserMiPerfil();
            form.Show();
            this.Hide();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            UserCambiarContraseña form = new UserCambiarContraseña();
            form.Show();
            this.Hide();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
