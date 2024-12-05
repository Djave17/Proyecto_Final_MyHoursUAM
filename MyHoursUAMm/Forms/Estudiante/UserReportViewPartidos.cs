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
using Microsoft.Reporting.WinForms;

namespace MyHours_UAMApp.Forms.Estudiante
{
    public partial class UserReportViewPartidos : Form
    {
        public UserReportViewPartidos()
        {
            InitializeComponent();
        }

        private void UserReportViewPartidos_Load(object sender, EventArgs e)
        {
            var estudiante = SesionActual.EstudianteActual;

            if (estudiante == null)
            {
                MessageBox.Show("No se ha iniciado sesión como estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Cierra el formulario si no hay sesión
                return;
            }

            // Obtener partidos asistidos por el estudiante
            var partidosAsistidos = Metodos.ObtenerPartidosAsistidos(estudiante.cifEstudiante);

            // Configurar el ReportViewer para partidos
            Metodos.ConfigurarReportViewerParaPartidos(reportViewer1, partidosAsistidos);

            this.reportViewer1.RefreshReport();

        }

        

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // Crear ComboBox con formatos
            ComboBox comboBox = new ComboBox
            {
                Location = new System.Drawing.Point(10, 10),
                Width = 150
            };
            comboBox.Items.Add("PDF");
            comboBox.Items.Add("Word");
            comboBox.Items.Add("Excel");
            comboBox.SelectedIndex = 0; // Seleccionar "PDF" por defecto

            // Crear Botón para Exportar
            Button buttonExportar = new Button
            {
                Text = "Exportar",
                Location = new System.Drawing.Point(170, 10),
                Width = 100
            };

            // Evento Click del Botón
            buttonExportar.Click += (s, x) =>
            {
                // Configurar ReportViewer
                ReportViewer reportViewer = Metodos.ConfigurarReportViewer();

                // Obtener formato seleccionado
                string formato = comboBox.SelectedItem.ToString();

                // Llamar al método de exportación
                Metodos.ExportarReporte(reportViewer, formato);
            };

            // Agregar controles al formulario
            Controls.Add(comboBox);
            Controls.Add(buttonExportar);


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

        private void btnReporte_Click(object sender, EventArgs e)
        {
            UserReporte form = new UserReporte();
            form.Show();
            this.Close();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener valores de los controles del formulario
            string fechaEvento = dtpInicio.Value.ToString("yyyy-MM-dd");
            string nombrePartido = txtNombre.Text.Trim();
            string lugarEvento = txtLugar.Text.Trim();

            // Crear una lista de parámetros dinámicamente
            List<ReportParameter> parameters = new List<ReportParameter>();

            if (!string.IsNullOrWhiteSpace(fechaEvento))
            {
                parameters.Add(new ReportParameter("Fecha", fechaEvento));
            }
            if (!string.IsNullOrWhiteSpace(nombrePartido))
            {
                parameters.Add(new ReportParameter("NombrePartido", nombrePartido));
            }
            if (!string.IsNullOrWhiteSpace(lugarEvento))
            {
                parameters.Add(new ReportParameter("LugarEvento", lugarEvento));
            }

            // Validar que al menos un parámetro tenga valor
            if (parameters.Count == 0)
            {
                MessageBox.Show("Por favor, ingrese al menos un valor para filtrar el informe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Configurar el ReportViewer
            reportViewer1.LocalReport.ReportPath = "RptPartido.rdlc"; // Ruta al informe
            reportViewer1.LocalReport.SetParameters(parameters);      // Pasar los parámetros
            reportViewer1.RefreshReport();

        }
            // Evento para validar si hay datos en el reporte
            private void reportViewer1_RenderingComplete(object sender, Microsoft.Reporting.WinForms.RenderingCompleteEventArgs e)
            {
            // Obtener el estado del informe
            var warnings = reportViewer1.LocalReport.GetParameters();

            // Verificar si hay datos en el reporte
            if (reportViewer1.LocalReport.GetTotalPages() == 0)
            {
                MessageBox.Show("No hay datos para mostrar en el informe con los filtros aplicados.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
    }
    
}
