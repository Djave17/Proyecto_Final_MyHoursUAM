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
    public partial class AdminAsistencia : Form
    {
        public AdminAsistencia()
        {
            InitializeComponent();
        }

        private void btnAñadirEventos_Click(object sender, EventArgs e)
        {
            AdminAdd form = new AdminAdd();
            form.Show();
            this.Hide();
        }

        private void btnVerEventos_Click(object sender, EventArgs e)
        {
            AdminVer form = new AdminVer();
            form.Show();
            this.Hide();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            AdminAsistencia form = new AdminAsistencia();
            form.Show();
            this.Hide();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            AdminAjustes form = new AdminAjustes();
            form.Show();
            this.Hide();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Rol form = new Rol();
            form.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
