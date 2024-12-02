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
using MyHours_UAMApp.Estructuras;

namespace MyHours_UAMApp
{
    public partial class UserEvento : Form
    {
        public UserEvento()
        {
            InitializeComponent();
            CargarEventosEnListView();
        }
        private void CargarEventosEnListView()
        {
            lvwEventos.Items.Clear();
            var eventos = Metodos.GetEventosAsString();

            foreach (var evento in eventos)
            {
                var listItem = new ListViewItem(evento);
                lvwEventos.Items.Add(listItem);
            }
        }

        private void btnVerEventos_Click(object sender, EventArgs e)
        {
            UserEvento form = new UserEvento();
            form.Show();
            this.Close();
        }

        private void btnEditarAsitencia_Click(object sender, EventArgs e)
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

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            UserPartidos form = new UserPartidos();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //Enviar asistencia
        {
            // Verificar que se haya seleccionado un evento
            if (lvwEventos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un evento para enviar la solicitud de asistencia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indiceEvento = lvwEventos.SelectedIndices[0];

            try
            {
                // Obtener el evento seleccionado
                var eventoSeleccionado = Metodos.eventos[indiceEvento];

                // Enviar solicitud usando el método actualizado
                Metodos.EnviarSolicitudEvento(SesionActual.EstudianteActual.cifEstudiante, eventoSeleccionado);

                MessageBox.Show("Solicitud de asistencia enviada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar vista (opcional: si necesitas reflejar solicitudesEventos pendientes en la interfaz del estudiante)
                CargarEventosEnListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserEvento_Load(object sender, EventArgs e)
        {
           
        }

        private void pnlPieArriba_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
