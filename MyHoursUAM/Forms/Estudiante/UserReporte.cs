using MyHours_UAMApp.Estructuras;
using MyHours_UAMApp.Estructuras.Metodos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MyHours_UAMApp
{
    public partial class UserReporte : Form
    {
        public UserReporte()
        {
            InitializeComponent();
            if (!ValidarSesion())
            {
                return;
            }
            else
            {
                var (eventos, partidos) = ObtenerDatosAsistidos();
                CargarDatosEnListViews(eventos, partidos);
                ActualizarEstadisticas();
            }

        }

        private void UserReporte_Load(object sender, EventArgs e)
        {
            var partidosAsistidos = Metodos.ObtenerPartidosAsistidos(SesionActual.EstudianteActual.cifEstudiante);
            Metodos.CargarPartidosAsistidos(lvwPartidosAsistidos, partidosAsistidos);

        }
        private bool ValidarSesion()
        {
            var estudiante = SesionActual.EstudianteActual;
            if (estudiante == null)
            {
                MessageBox.Show("No se ha iniciado sesión como estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private (List<Evento> eventos, List<Partido> partidos) ObtenerDatosAsistidos()
        {
            var estudiante = SesionActual.EstudianteActual;

            var eventosAsistidos = Metodos.ObtenerEventosAsistidos(estudiante.cifEstudiante);
            var partidosAsistidos = Metodos.ObtenerPartidosAsistidos(estudiante.cifEstudiante);

            return (eventosAsistidos, partidosAsistidos);
        }

        private void CargarDatosEnListViews(List<Evento> eventos, List<Partido> partidos)
        {
            Metodos.CargarEventosAsistidos(lvwEventos, eventos);
            Metodos.CargarPartidosAsistidos(lvwPartidosAsistidos, partidos);
        }
        private void ActualizarEstadisticas()
        {
            var estudiante = SesionActual.EstudianteActual;

            int horasLaborales = Metodos.CalcularHorasLaborales(estudiante.cifEstudiante);
            lblHorasLaborales.Text = $"Horas laborales: {horasLaborales}";

            int beneficioPartidos = Metodos.CalcularBeneficioPartidos(estudiante.cifEstudiante); //Uso de metodo CalcularBeneficioPartidos para contar partidos completados de 7
            lblBeneficioPartidos.Text = $"Partidos completados: {beneficioPartidos}";

            CrearGrafico(horasLaborales, beneficioPartidos);
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
            IniciarSesion form = new IniciarSesion();
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

        private void label2_Click(object sender, EventArgs e)
        {
            IniciarSesion form = new IniciarSesion();
            form.Show();
            this.Close();
        }

        private void pnlPieArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gbxPartidosAsistidos_Enter(object sender, EventArgs e)
        {

        }

        private void lblHorasLaborales_Click(object sender, EventArgs e)
        {

        }

        private void CrearGrafico(int horasLaborales, int beneficioPartidos)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            var series = new Series
            {
                Name = "Horas y Partidos",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };

            series.Points.AddXY("Horas Laborales", horasLaborales);
            series.Points.AddXY("Partidos completados", beneficioPartidos);

            series.Label = "#VALX: #VAL (#PERCENT{P0})";
            chart1.Series.Add(series);
            chart1.Titles.Add("Horas Laborales y Partidos completados");
        }

        private void lvwPartidosAsistidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            IniciarSesion form = new IniciarSesion();
            form.Show();
            this.Close();
        }
    }
}
