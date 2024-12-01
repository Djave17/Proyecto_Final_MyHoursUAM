using MyHours_UAMApp.Estructuras.Metodos;
using MyHours_UAMApp.Estructuras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace MyHours_UAMApp
{
    public partial class UserReporte : Form
    {
        public UserReporte()
        {
            InitializeComponent();
           
        }
        

        private void UserReporte_Load(object sender, EventArgs e)
        {
            var estudiante = SesionActual.EstudianteActual;

            if (estudiante == null)
            {
                MessageBox.Show("No se ha iniciado sesión como estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Cierra el formulario si no hay sesión
                return;
            }

            // Obtener eventos asistidos por el estudiante
            var eventosAsistidos = Metodos.ObtenerEventosAsistidos(estudiante.cifEstudiante);

            // Configurar el ReportViewer
            Metodos.ConfigurarReportViewer(reportViewer1, eventosAsistidos);

            // Calcular y mostrar las horas laborales
            int horasLaborales = Metodos.CalcularHorasLaborales(estudiante.cifEstudiante);
            lblHorasLaborales.Text = $"Horas laborales: {horasLaborales}";

            // Calcular y mostrar el beneficio por partidos asistidos
            int beneficioPartidos = Metodos.CalcularBeneficioPartidos(estudiante.cifEstudiante);
            lblBeneficioPartidos.Text = $"Partidos asistidos: {beneficioPartidos}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserReporte form = new UserReporte();
            form.Show();
            this.Close();
        }

        private void btnVerEventos_Click(object sender, EventArgs e)
        {
            UserEvento form = new UserEvento();
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

        private void lblCerrarSesion_Click(object sender, EventArgs e)
        {
            Rol form = new Rol();
            form.Show();
            this.Close();
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            UserPartidos form = new UserPartidos();
            form.Show();
            this.Close();
        }

        private void lvEventosAsistidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lvwEventos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
