using MyHours_UAMApp.Estructuras.Metodos;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            Rol form = new Rol();
            form.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void AdminAsistencia_Load(object sender, EventArgs e)
        {
            

            // Cargar datos en el ListView
            Metodos.CargarSolicitudesEnListView(lvAsistencia);
        }

        private void btnConfirmarAsistencia_Click(object sender, EventArgs e)
        {
            if (lvAsistencia.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una solicitud para confirmar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int solicitudId = int.Parse(lvAsistencia.SelectedItems[0].Text);

                // Confirmar la solicitud
                string mensaje = Metodos.ConfirmarSolicitud(solicitudId);

                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar vista
                Metodos.CargarSolicitudesEnListView(lvAsistencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al confirmar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDenegarAsistencia_Click(object sender, EventArgs e)
        {
            if (lvAsistencia.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una solicitud para rechazar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int solicitudId = int.Parse(lvAsistencia.SelectedItems[0].Text);
                // Rechazar la solicitud
                string mensaje = Metodos.RechazarSolicitud(solicitudId);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizar vista
                Metodos.CargarSolicitudesEnListView(lvAsistencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al rechazar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvAsistencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
