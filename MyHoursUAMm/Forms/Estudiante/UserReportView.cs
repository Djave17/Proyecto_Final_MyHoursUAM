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
using System.IO;
using System;

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

            this.reportViewer1.RefreshReport();
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

        // Métodos para exportar el reporte
        private void ExportarReporte(string formato, string nombreArchivo)
        {
            Warning[] warnings;
            string[] streamIds;
            string mimeType;
            string encoding;
            string extension;

            // Renderizar el reporte en el formato deseado
            byte[] bytes = reportViewer1.LocalReport.Render(
                formato, null, out mimeType, out encoding, out extension, out streamIds, out warnings);

            // Guardar el archivo exportado
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombreArchivo + "." + extension);
            File.WriteAllBytes(rutaArchivo, bytes);

            // Mostrar mensaje de éxito
            MessageBox.Show($"Reporte exportado como {formato.ToUpper()} en:\n{rutaArchivo}", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            ExportarReporte("PDF", "Reporte");
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarReporte("EXCEL", "Reporte");
        }

        private void btnExportarWord_Click(object sender, EventArgs e)
        {
            ExportarReporte("WORD", "Reporte");
        }
    }
}

