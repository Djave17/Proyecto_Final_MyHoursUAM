using MyHours_UAMApp.Estructuras;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace MyHours_UAMApp
{
    public partial class AdminAdd : Form
    {
        private List<Evento> eventos;
        public AdminAdd()
        {
            InitializeComponent();
            eventos = new List<Evento>();
        }

        private void AdminAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadirEventos_Click(object sender, EventArgs e)
        {
            AdminAdd form = new AdminAdd();
            form.Show();
            this.Close();
        }

        private void btnVerEventos_Click(object sender, EventArgs e)
        {
            AdminVer form = new AdminVer();
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
            Rol form = new Rol();
            form.Show();
            this.Close();
        }

        private void gpbNuevoEvento_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lvwEventosRecienAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Evento nuevoEvento = new Evento
            {
                nombreEvento = txtNombreEvento.Text,
                fechaEvento = txbHorario.Text,
                lugarEvento = txtLugar.Text,
                cuposEvento = txtCupos.Text,
                horaEnvio = textBox1.Text,
                horasConvalidar = txbHorasConvalidas.Text,
                tipoBeneficio = cbxBeneficio.SelectedItem.ToString(),
                TipoEvento = cbxEvento.SelectedItem.ToString(),
                idEvento = Guid.NewGuid().ToString()
            };

            eventos.Add(nuevoEvento);
            ActualizarDataGrid();
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombreEvento.Clear();
            txbHorario.Clear();
            txtLugar.Clear();
            txtCupos.Clear();
            textBox1.Clear();
            txbHorasConvalidas.Clear();
            cbxBeneficio.SelectedIndex = -1;
            cbxEvento.SelectedIndex = -1;
        }

        private void ActualizarDataGrid()
        {
            dgvEventos.DataSource = null;
            dgvEventos.DataSource = eventos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int temp1 = dgvEventos.CurrentCell.RowIndex;
            eventos.RemoveAt(temp1);
            ActualizarDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int temp2 = dgvEventos.CurrentCell.RowIndex;
            Evento evento = eventos[temp2];

            txtNombreEvento.Text = evento.nombreEvento;
            txbHorario.Text = evento.fechaEvento;
            txtLugar.Text = evento.lugarEvento;
            txtCupos.Text = evento.cuposEvento;
            textBox1.Text = evento.horaEnvio;
            txbHorasConvalidas.Text = evento.horasConvalidar;
            cbxBeneficio.SelectedItem = evento.tipoBeneficio;
            cbxEvento.SelectedItem = evento.TipoEvento;

            eventos.RemoveAt(temp2);
            ActualizarDataGrid();
        }
    }
}
