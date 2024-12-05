using MyHours_UAMApp.Forms.Administrador;
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
    public partial class AdminAjustes : Form
    {
        public AdminAjustes()
        {
            InitializeComponent();
        }

        private void btnAñadirEventos_Click(object sender, EventArgs e)
        {
            AdminAdd form = new AdminAdd();
            form.Show();
            this.Close();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            AdminAsistencia form = new AdminAsistencia();
            form.Show();
            this.Close();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            AdminAjustes form = new AdminAjustes();
            form.Show();
            this.Close();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion form = new IniciarSesion();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminAddPartidos form = new AdminAddPartidos();
            form.Show();
            this.Close();
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            AdminGrafico adminGrafico = new AdminGrafico();
            adminGrafico.Show();
            this.Close();
        }
    }
}
