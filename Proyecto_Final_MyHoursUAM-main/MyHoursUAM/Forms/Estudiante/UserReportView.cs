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
using MyHours_UAMApp.Estructuras;

namespace MyHours_UAMApp.Forms.Estudiante
{
    public partial class UserReportView : Form
    {
        public UserReportView()
        {
            InitializeComponent();
        }

        private void gpbDatosPersonales_Enter(object sender, EventArgs e)
        {

        }

        private void pnlPieArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlAreaAdministrador_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserReportView_Load(object sender, EventArgs e)
        {

            try
            {
                // Obtener los datos
                var eventosAsistidos = Metodos.ObtenerEventosAsistidos("ID_ESTUDIANTE");
                var partidosAsistidos = Metodos.ObtenerPartidosAsistidos("ID_ESTUDIANTE");

                // Configurar el ReportViewer con los datos
                Metodos.ConfigurarReportViewer(reportViewer1, eventosAsistidos, partidosAsistidos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblEstudiante_Click(object sender, EventArgs e)
        {
            UserMiPerfil form = new UserMiPerfil();
            form.Show();
            this.Close();
        }

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion form = new IniciarSesion();
            form.Show();
            this.Close();
        }

        private void btnVerEventos_Click(object sender, EventArgs e)
        {
            UserEvento form = new UserEvento();
            form.Show();
            this.Close();
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            UserPartidos form = new UserPartidos();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserMiPerfil form = new UserMiPerfil();
            form.Show();
            this.Close();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            UserCambiarContraseña form = new UserCambiarContraseña();
            form.Show();
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            UserReporte form = new UserReporte();
            form.Show();
            this.Close();
        }
    }
}
