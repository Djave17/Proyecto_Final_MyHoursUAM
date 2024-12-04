using MyHours_UAMApp.Forms.Administrador;
using System;
using System.Windows.Forms;

using MyHours_UAMApp.Estructuras.Metodos;
using MyHours_UAMApp.Estructuras;
namespace MyHours_UAMApp

{
    public partial class AdminAdd : Form
    {
        // Instancia del servicio CRUD para manejar eventos
        private CrudService<Evento> eventoService;
        public AdminAdd()
        {
            InitializeComponent();
            eventoService = new CrudService<Evento>("eventos.dat");
            CargarEventosEnListView();
        }
        // Método para cargar eventos en el ListView
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
            IniciarSesion form = new IniciarSesion();
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
                string mensaje = Metodos.EliminarEvento(indice);

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
             //verificar si el ID existe
            var ID = Guid.NewGuid().ToString();
            ///Cargar los datos del evento seleccionado en los campos de texto///
            //cbxEvento.SelectedIndex = indice;
            //txtNombreEvento.Text = lvwEventos.SelectedItems[0].SubItems[1].Text;
            //cbxBeneficio.SelectedIndex = cbxBeneficio.FindStringExact(lvwEventos.SelectedItems[0].SubItems[2].Text);
            //txbHorario.Text = lvwEventos.SelectedItems[0].SubItems[3].Text;
            //dtpFecha.Text = lvwEventos.SelectedItems[0].SubItems[4].Text;
            //txbLugar.Text = lvwEventos.SelectedItems[0].SubItems[5].Text;
            //txbHorasConvalidas.Text = lvwEventos.SelectedItems[0].SubItems[6].Text;
            //txtCupos.Text = lvwEventos.SelectedItems[0].SubItems[7].Text;
            //tbxEstado.SelectedIndex = tbxEstado.FindStringExact(lvwEventos.SelectedItems[0].SubItems[8].Text);
            //cbxBeneficio.SelectedIndex = cbxBeneficio.FindStringExact(lvwEventos.SelectedItems[0].SubItems[9].Text);
        
            try
            {
                string mensaje = Metodos.EditarEvento(
                    indice,
                    ID,
                    txtNombreEvento.Text,
                    cbxBeneficio.Text,
                    txbHorario.Text,
                    dtpFecha.Text,
                    txbLugar.Text,
                    int.Parse(txbHorasConvalidas.Text),
                    int.Parse(txtCupos.Text),
                    tbxEstado.Text,
                    cbxBeneficio.Text
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
            tbxEstado.SelectedIndex = -1; 
            txbHorario.Clear();
            dtpFecha.Value = DateTime.Now;
            txbLugar.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //verificar si el ID existe
            var ID = Guid.NewGuid().ToString();

            try
            {
                string mensaje = Metodos.RegistrarEvento(
                    ID,
                    txtNombreEvento.Text,
                    cbxBeneficio.Text,
                    txbHorario.Text,
                    dtpFecha.Text,
                    txbLugar.Text,
                    int.Parse(txbHorasConvalidas.Text),
                    int.Parse(txtCupos.Text),
                    tbxEstado.Text,
                    cbxBeneficio.Text

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

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            // Verificar si hay un evento seleccionado
            if (lvwEventos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un evento para cambiar su estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int indice = lvwEventos.SelectedIndices[0]; // Obtener el índice del evento seleccionado

            try
            {
                // Alternar el estado del evento
                string mensaje = Metodos.CambiarEstadoEvento(indice);

                // Mostrar el mensaje de éxito
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el ListView con los nuevos datos
                CargarEventosEnListView();
            }
            catch (Exception ex)
            {
                // Manejar errores
                MessageBox.Show($"Error al cambiar el estado del evento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            AdminGrafico adminGrafico = new AdminGrafico();
            adminGrafico.Show();
            this.Close();
        }

        private void txbHorasConvalidas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
