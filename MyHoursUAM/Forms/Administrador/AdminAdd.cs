using MyHours_UAMApp.Forms.Administrador;
using System;
using System.Windows.Forms;
using MyHours_UAMApp.Estructuras.Metodos;
namespace MyHours_UAMApp

{
    public partial class AdminAdd : Form
    {
        public AdminAdd()
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

        private void AdminAdd_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            AdminAddPartidos form = new AdminAddPartidos();
            form.Show();
            this.Close();
        }

        private void lblLugar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvwEventos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un evento para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indice = lvwEventos.SelectedIndices[0];

            try
            {
                string mensaje = Metodos.EliminarPartido(indice);

                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEventosEnListView();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lvwEventos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un evento para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indice = lvwEventos.SelectedIndices[0];

            try
            {
                string mensaje = Metodos.EditarEvento(
                    indice,
                    cbxEvento.Text,
                    cbxBeneficio.Text,
                    txtNombreEvento.Text,
                    int.Parse(txbHorasConvalidas.Text),
                    int.Parse(txtCupos.Text),
                    txbHoraEnvio.Text,
                    txbHorario.Text,
                    dtpFecha.Text,
                    txbLugar.Text
                );

                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEventosEnListView();
                LimpiarCampos(); // Limpiar los campos después de editar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LimpiarCampos()
        {
            cbxEvento.SelectedIndex = -1;
            cbxBeneficio.SelectedIndex = -1;
            txtNombreEvento.Clear();
            txbHorasConvalidas.Clear();
            txtCupos.Clear();
            txbHoraEnvio.Clear();
            txbHorario.Clear();
            dtpFecha.Value = DateTime.Now;
            txbLugar.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = Metodos.RegistrarEvento(
                    cbxEvento.Text,
                    cbxBeneficio.Text,
                    txtNombreEvento.Text,
                    int.Parse(txbHorasConvalidas.Text),
                    int.Parse(txtCupos.Text),
                    txbHoraEnvio.Text,
                    txbHorario.Text,
                    dtpFecha.Text,
                    txbLugar.Text

                );

                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEventosEnListView();
                LimpiarCampos(); // Limpiar los campos después de guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminAddPartidos form = new AdminAddPartidos();
            form.Show();
            this.Close();
        }
    }
}
