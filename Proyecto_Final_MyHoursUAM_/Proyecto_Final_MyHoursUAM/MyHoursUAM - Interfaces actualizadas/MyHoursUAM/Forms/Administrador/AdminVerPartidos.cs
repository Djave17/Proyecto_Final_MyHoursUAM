    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using MyHours_UAMApp.Estructuras.Metodos;

namespace MyHours_UAMApp.Forms.Administrador
    {
        public partial class AdminVerPartidos : Form
        {
            public AdminVerPartidos()
            {
                InitializeComponent();
            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void AdminVerPartidos_Load(object sender, EventArgs e)
            {
                dgvPartidos.DataSource = null;
                dgvPartidos.DataSource = Metodos.ObtenerPartidosProyectados().ToList();

            }

        private void btnAñadirEventos_Click(object sender, EventArgs e)
        {
            AdminAddPartido form = new AdminAddPartido();
            form.Show();
            this.Hide();

        }

        private void btnAjustesPartidos_Click(object sender, EventArgs e)
        {
            AdminAjustes form = new AdminAjustes();
            form.Show();
            this.Hide();
        }

        private void btnAsistenciaPartidos_Click(object sender, EventArgs e)
        {
            AdminAsistencia form = new AdminAsistencia();
            form.Show();
            this.Hide();
        }

        private void btnVerPartidos_Click(object sender, EventArgs e)
        {
            AdminVerPartidos form = new AdminVerPartidos();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarPartido_Click(object sender, EventArgs e)
        {
           
        }


    }
}
