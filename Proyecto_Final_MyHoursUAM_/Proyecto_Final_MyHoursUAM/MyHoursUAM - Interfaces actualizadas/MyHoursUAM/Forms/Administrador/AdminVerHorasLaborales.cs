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
    public partial class AdminVerHorasLaborales : Form
    {
        public AdminVerHorasLaborales()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminVerHorasLaborales_Load(object sender, EventArgs e)
        {
            dgvHorasLaborales.DataSource = null;
            dgvHorasLaborales.DataSource = Metodos.ObtenerHorasLaborales().ToList();

        }

        private void btnAñadirEventos_Click(object sender, EventArgs e)
        {
            AdminAddHorasLaborales form = new AdminAddHorasLaborales();
            form.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAsistenciaPartidos_Click(object sender, EventArgs e)
        {
            AdminAsistencia form = new AdminAsistencia();
            form.Show();
            this.Close();
        }

        private void btnAjustesPartidos_Click(object sender, EventArgs e)
        {
            AdminAjustes form = new AdminAjustes();
            form.Show();
            this.Hide();
        }

        private void pnlAreaAdministrador_Paint(object sender, PaintEventArgs e)
        {
            AdminAjustes form = new AdminAjustes();
            form.Show();
            this.Hide();
        }
    }
}
