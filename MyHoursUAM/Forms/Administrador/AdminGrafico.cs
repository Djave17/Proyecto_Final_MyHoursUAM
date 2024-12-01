using MyHours_UAMApp.Estructuras.Metodos;
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

namespace MyHours_UAMApp.Forms.Administrador
{
    public partial class AdminGrafico : Form
    {
        public AdminGrafico()
        {
            InitializeComponent();
            CrearGrafico();
        }

        private void CrearGrafico()
        {
            var (eventos, partidos) = Metodos.EventosPartidos();

            // Crear gráfico para eventos
            graficoCupos.Series.Clear();
            var serieEventos = new Series("Eventos");
            serieEventos.ChartType = SeriesChartType.Column;

            foreach (var evento in eventos)
            {
                if (int.TryParse(evento[7], out int cupos))
                {
                    serieEventos.Points.AddXY(evento[1], cupos);
                }
                else
                {
                    MessageBox.Show($"Error al convertir el valor '{evento[7]}' a entero para el evento '{evento[1]}'", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            graficoCupos.Series.Add(serieEventos);
            graficoCupos.ChartAreas[0].AxisX.Title = "Eventos";
            graficoCupos.ChartAreas[0].AxisY.Title = "Cupos";

            // Crear gráfico para partidos
            graficoHoras.Series.Clear();
            var partidosPorCategoria = partidos.GroupBy(p => p[3]);

            var seriePartidos = new Series("Partidos por Categoría");
            seriePartidos.ChartType = SeriesChartType.Column;

            foreach (var categoria in partidosPorCategoria)
            {
                seriePartidos.Points.AddXY(categoria.Key, categoria.Count());
            }

            graficoHoras.Series.Add(seriePartidos);
            graficoHoras.ChartAreas[0].AxisX.Title = "Categorías";
            graficoHoras.ChartAreas[0].AxisY.Title = "Cantidad de Partidos";
        }
        private void AdminGrafico_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnAñadirEventos_Click(object sender, EventArgs e)
        {
            AdminAdd adminAdd = new AdminAdd();
            adminAdd.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminAddPartidos adminAddPartidos = new AdminAddPartidos();
            adminAddPartidos.Show();
            this.Close();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            AdminAsistencia adminAsistencia = new AdminAsistencia();
            adminAsistencia.Show();
            this.Close();

        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            AdminAjustes adminAjustes = new AdminAjustes();
            adminAjustes.Show();
            this.Close();
        }
    }
}
