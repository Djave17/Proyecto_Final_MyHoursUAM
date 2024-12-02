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
            // Validar que haya una solicitud seleccionada
            if (lvAsistencia.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una solicitud para confirmar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Obtener el ID de la solicitud seleccionada
                string solicitudId = lvAsistencia.SelectedItems[0].Text;

                // Buscar la solicitud directamente en la lista global
                var solicitud = Metodos.solicitudes.FirstOrDefault(s => s.Id == solicitudId);

                if (solicitud == null)
                {
                    MessageBox.Show("No se encontró la solicitud seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string mensaje;

                // Determinar si es un partido o un evento
                if (solicitud.Partidos != null)
                {
                    // Confirmar partido
                    mensaje = Metodos.ConfirmarSolicitudPartidos(solicitudId);
                }
                else if (solicitud.Eventos != null)
                {
                    // Confirmar evento
                    mensaje = Metodos.ConfirmarSolicitud(solicitudId);
                }
                else
                {
                    // Caso inesperado: solicitud sin partido ni evento
                    MessageBox.Show("La solicitud seleccionada no corresponde a un evento ni a un partido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mostrar resultado
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar el ListView (opcional: filtrar según tipo, si es necesario)
                Metodos.CargarSolicitudesEnListViewPrueba(lvAsistencia, solicitud.Partidos != null);
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

        private void pnlPieArriba_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminAsistencia_Load(object sender, EventArgs e)
        {
            try
            {
                // Validar si la lista solicitudes está inicializada
                if (Metodos.solicitudes == null)
                {
                    MessageBox.Show("La lista de solicitudes no está inicializada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cargar solicitudes en el ListView
                Metodos.CargarSolicitudesEnListViewPrueba(lvAsistencia, false); // false: cargar eventos
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las solicitudes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
