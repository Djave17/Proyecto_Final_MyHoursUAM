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
    public partial class AdminAddPartido : Form
    {
        public AdminAddPartido()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombrePartido = txtNombrePartido.Text;
            string fechaPartido = dtpFechaPartido.Value.ToString("dd/MM/yyyy");
            string horaPartido = txtHoraPartido.Text;
            string lugarPartido = txtLugarPartido.Text;
            int cupos = int.Parse(txtCuposPartido.Text);
            int horasConvalidas = int.Parse(txtHorasPartido.Text);
            string organizadorPartido = txtOrganizadorPartido.Text;
            string deportePartido = txtDeportePartido.Text;
            string rival = txtRivalPartido.Text;

            Metodos.RegistrarPartido(nombrePartido, fechaPartido, horaPartido, horasConvalidas, organizadorPartido, lugarPartido,rival, deportePartido, cupos);

            MessageBox.Show("Partido registrado exitosamente.");
        }

        private void btnVerPartidos_Click(object sender, EventArgs e)
        {
            AdminVerPartidos form = new AdminVerPartidos();
            form.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AdminAdd form = new AdminAdd();
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
    }
}
