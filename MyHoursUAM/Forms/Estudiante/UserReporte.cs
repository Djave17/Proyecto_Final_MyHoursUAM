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
using System.Windows.Forms.DataVisualization.Charting;

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
                return;
            }

            // Obtener eventos asistidos
            var eventosAsistidos = Metodos.ObtenerEventosAsistidos(estudiante.cifEstudiante);

            // Usar el método centralizado para cargar los eventos en el ListView
            Metodos.CargarEventosAsistidos(lvwEventos, eventosAsistidos);

            // Actualizar etiquetas de horas y beneficios
            int horasLaborales = Metodos.CalcularHorasLaborales(estudiante.cifEstudiante);
            lblHorasLaborales.Text = $"Horas laborales: {horasLaborales}";

            int beneficioPartidos = Metodos.CalcularBeneficioPartidos(estudiante.cifEstudiante);
            lblBeneficioPartidos.Text = $"Partidos asistidos: {beneficioPartidos}";
            CargarGrafico(); //LLamar funcion del grafico
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

        private void CargarGrafico() //Grafico para el reporte
        {
            chart1.Series.Clear();

            // Crear una nueva serie
            var series = new Series("Convalidación")
            {
                ChartType = SeriesChartType.Column
            };
            foreach (ListViewItem item in lvwEventos.Items)
            {
                string nombreEvento = item.SubItems[1].Text;
                string convalidacionStr = item.SubItems[3].Text; 

                if (double.TryParse(convalidacionStr, out double convalidacion))
                {
                    series.Points.AddXY(nombreEvento, convalidacion);
                }
                else
                {
                    MessageBox.Show($"Error al convertir la convalidación para el evento: {nombreEvento}. Valor: {convalidacionStr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Eventos";
            chart1.ChartAreas[0].AxisY.Title = "Convalidación";

        }

    }
}
