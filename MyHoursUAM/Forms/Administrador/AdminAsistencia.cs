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
            CargarSolicitudesEventos();
            CargarSolicitudesPartidos();

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
            if (lvAsistencia.SelectedItems.Count > 0)
            {
                var solicitudId = lvAsistencia.SelectedItems[0].Text;
                var resultado = Metodos.ConfirmarSolicitudEvento(solicitudId);
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSolicitudesEventos();
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud para confirmar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDenegarAsistencia_Click(object sender, EventArgs e)
        {

            if (lvAsistencia.SelectedItems.Count > 0)
            {
                var solicitudId = lvAsistencia.SelectedItems[0].Text;
                var resultado = Metodos.RechazarSolicitudEvento(solicitudId);
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSolicitudesEventos();
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud para denegar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        }

        private void btnConfirmarPartido_Click(object sender, EventArgs e)
        {
            if (lvPartidos.SelectedItems.Count > 0)
            {
                var solicitudId = lvPartidos.SelectedItems[0].Text;
                var resultado = Metodos.ConfirmarSolicitudPartidos(solicitudId);
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSolicitudesPartidos();
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud para confirmar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        // Método para cargar solicitudes de eventos en el ListView
        private void CargarSolicitudesEventos()
        {
            lvAsistencia.Items.Clear();
            foreach (var solicitud in Metodos.solicitudesEventos)
            {
                var item = new ListViewItem(solicitud.Id);
                item.SubItems.Add(solicitud.EventoId);
                item.SubItems.Add(solicitud.EstudianteId);
                item.SubItems.Add(solicitud.Eventos.nombreEvento);
                item.SubItems.Add(solicitud.EstadoSolicitud.ToString());
                item.SubItems.Add(solicitud.FechaSolicitud.ToString("dd/MM/yyyy HH:mm"));
                lvAsistencia.Items.Add(item);
            }
        }

        // Método para cargar solicitudes de partidos en el ListView
        private void CargarSolicitudesPartidos()
        {
            lvPartidos.Items.Clear();
            foreach (var solicitud in Metodos.solicitudesPartidos)
            {
                var item = new ListViewItem(solicitud.Id);
                item.SubItems.Add(solicitud.EventoId);
                item.SubItems.Add(solicitud.EstudianteId);
                item.SubItems.Add(solicitud.Partidos.nombrePartido);
                item.SubItems.Add(solicitud.EstadoSolicitud.ToString());
                item.SubItems.Add(solicitud.FechaSolicitud.ToString("dd/MM/yyyy HH:mm"));
                lvPartidos.Items.Add(item);
            }
        }

        private void btnDenegarPartido_Click(object sender, EventArgs e)
        {
            if (lvPartidos.SelectedItems.Count > 0)
            {
                var solicitudId = lvPartidos.SelectedItems[0].Text;
                var resultado = Metodos.RechazarSolicitudPartido(solicitudId);
                MessageBox.Show(resultado, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSolicitudesPartidos();
            }
            else
            {
                MessageBox.Show("Seleccione una solicitud para denegar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
