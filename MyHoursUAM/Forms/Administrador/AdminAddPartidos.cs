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

namespace MyHours_UAMApp.Forms.Administrador
{
    public partial class AdminAddPartidos : Form
    {
        public AdminAddPartidos()
        {
            InitializeComponent();
            CargarPartidosEnListView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminAdd adminAdd = new AdminAdd();
            adminAdd.Show();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var ID = Guid.NewGuid().ToString();
            try
            {
                string mensaje = Metodos.RegistrarPartido(
                    ID,
                    cbxTipoDeporte.Text,
                    txtNombreEvento.Text,
                    int.Parse(txbHorasConvalidas.Text),
                    int.Parse(txtCupos.Text),
                    tbxEstado.Text,
                    txbHorario.Text,
                    dtpFecha.Text,
                    tbxLugar.Text,
                    "Rival no definido" // No se si dejarlo gente ayuda__---asda-sdasd
                );

                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPartidosEnListView();
                LimpiarCampos(); // Limpiar los campos después de guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el partido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // Método para cargar los partidos en el ListView
        private void CargarPartidosEnListView()
        {
            lvPartidos.Items.Clear();
            var partidos = Metodos.GetPartidosAsStringArray();

            foreach (var partido in partidos)
            {
                var listItem = new ListViewItem(partido);
                lvPartidos.Items.Add(listItem);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvPartidos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un partido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indice = lvPartidos.SelectedIndices[0];

            try
            {
                string mensaje = Metodos.EliminarPartido(indice);

                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPartidosEnListView();
                LimpiarCampos(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el partido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lvPartidos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un partido para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indice = lvPartidos.SelectedIndices[0];
            var ID = Guid.NewGuid().ToString();

            try
            {
                string mensaje = Metodos.EditarPartido(
                    indice,
                    ID,
                    cbxTipoDeporte.Text,
                    txtNombreEvento.Text,
                    int.Parse(txbHorasConvalidas.Text),
                    int.Parse(txtCupos.Text),
                    tbxEstado.Text,
                    txbHorario.Text,
                    dtpFecha.Text,
                    tbxLugar.Text,
                    "Rival no definido" // Ajustar según la lógica
                );

                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPartidosEnListView();
                LimpiarCampos(); // Limpiar los campos después de editar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el partido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAñadirEventos_Click(object sender, EventArgs e)
        {
            AdminAdd form = new AdminAdd();
            form.Show();
            this.Close();

        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            AdminAjustes form = new AdminAjustes();
            form.Show();
            this.Close();
        }

        private void btnAddPartidos_Click(object sender, EventArgs e)
        {

        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            AdminAsistencia form = new AdminAsistencia();
            form.Show();
            this.Close();
        }

        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            cbxTipoDeporte.SelectedIndex = -1;
            txtNombreEvento.Clear();
            txbHorasConvalidas.Clear();
            txtCupos.Clear();
            tbxEstado.SelectedIndex = -1;
            txbHorario.Clear();
            dtpFecha.Value = DateTime.Now;
            tbxLugar.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminAddPartidos form = new AdminAddPartidos();
            form.Show();
            this.Close();
        }

        private void gpbAddPartidos_Enter(object sender, EventArgs e)
        {

        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (lvPartidos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un evento para cambiar su estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indice = lvPartidos.SelectedIndices[0]; // Obtener el índice del evento seleccionado

            try
            {
                // Alternar el estado del evento
                string mensaje = Metodos.CambiarEstadoPartido(indice);

                // Mostrar el mensaje de éxito
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el ListView con los nuevos datos
                CargarPartidosEnListView();
            }
            catch (Exception ex)
            {
                // Manejar errores
                MessageBox.Show($"Error al cambiar el estado del evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            AdminGrafico form = new AdminGrafico();
            form.Show();
            this.Close();
        }
    }
}
