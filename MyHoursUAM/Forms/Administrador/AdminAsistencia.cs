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
            Metodos.CargarSolicitudesEnListView(lvAsistencia,true);

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
            IniciarSesion form = new IniciarSesion();
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



        private void btnConfirmarAsistencia_Click(object sender, EventArgs e)
        {
            if (lvAsistencia.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una solicitud para confirmar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtener el ID de la solicitud seleccionada desde la primera columna
                string solicitudId = lvAsistencia.SelectedItems[0].SubItems[6].Text;
                string solicitudA = lvAsistencia.SelectedItems[0].Text;

                if (string.IsNullOrEmpty(solicitudId))
                {
                    MessageBox.Show("El ID de la solicitud no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //// Buscar la solicitud en la lista
                //var solicitud = Metodos.solicitudesEventos.FirstOrDefault(s => s.Id == solicitudId);

                //if (solicitud == null)
                //{
                //    // Mostrar los IDs disponibles para depuración
                //    var idsDisponibles = string.Join(", ", Metodos.solicitudesEventos.Select(s => s.Id));
                //    MessageBox.Show($"No se encontró la solicitud. IDs disponibles: {idsDisponibles}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                string mensaje;

                // Validar si es un partido o un evento basado en la solicitud
                if (solicitudId == "Partido") // Es un partido
                {
                    mensaje = Metodos.ConfirmarSolicitudPartidos(solicitudA);
                    Metodos.CargarSolicitudesEnListView(lvAsistencia,true);
                }
                else if (solicitudId == "Evento") // Es un evento
                {
                    mensaje = Metodos.ConfirmarSolicitudEvento(solicitudA);
                    Metodos.CargarSolicitudesEnListView(lvAsistencia, true);
                }
                else
                {
                    MessageBox.Show("La solicitud seleccionada no corresponde a un evento ni a un partido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mostrar resultado
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar el ListView
                Metodos.CargarSolicitudesEnListView(lvAsistencia, true);
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
                string solicitudId = lvAsistencia.SelectedItems[0].Text;
                // Rechazar la solicitud
                string mensaje = Metodos.RechazarSolicitudEvento(solicitudId);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizar vista
                Metodos.CargarSolicitudesEnListView(lvAsistencia,true);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al rechazar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvAsistencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnlPieArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
