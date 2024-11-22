using MyHours_UAMApp.Estructuras;
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

        private void txtNombreEvento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvwEventosRecienAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {           
            Partido nuevoPartido = new Partido
            {
                nombrePartido = txtNombreEvento.Text,
                lugarPartido = tbxLugar.Text,
                horaPartido = txbHorario.Text,
                fechaPartido = dtpFecha.Value.ToString("dd/MM/yyyy"),
                cuposDisponibles = txtCupos.Text,
                horaEnvio = tbxHoraEnvio.Text,
                cantConvalidar = txbHorasConvalidas.Text,
                tipoDeporte = cbxTipoDeporte.SelectedItem.ToString(),
            
            };

            ListViewItem partido = new ListViewItem(new string[]
            {
                nuevoPartido.nombrePartido,
                nuevoPartido.lugarPartido,
                nuevoPartido.tipoDeporte,
                nuevoPartido.horaPartido,
                nuevoPartido.fechaPartido,
                nuevoPartido.horaEnvio,
                nuevoPartido.cantConvalidar,
                nuevoPartido.cuposDisponibles
            });

            lvwEventosRecienAdd.Items.Add(partido);
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreEvento.Clear();
            tbxLugar.Clear();
            txbHorario.Clear();
            dtpFecha.Value = DateTime.Now;
            txtCupos.Clear();
            tbxHoraEnvio.Clear();
            txbHorasConvalidas.Clear();
            cbxTipoDeporte.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lvwEventosRecienAdd.SelectedItems.Count > 0)
            {
                foreach (ListViewItem partido in lvwEventosRecienAdd.SelectedItems)
                {
                    lvwEventosRecienAdd.Items.Remove(partido);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un evento para eliminar.", "Eliminar Evento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lvwEventosRecienAdd.SelectedItems.Count > 0)
            {
                ListViewItem partidoSeleccionado = lvwEventosRecienAdd.SelectedItems[0];

                txtNombreEvento.Text = partidoSeleccionado.SubItems[0].Text;
                tbxLugar.Text = partidoSeleccionado.SubItems[1].Text;
                cbxTipoDeporte.SelectedItem = partidoSeleccionado.SubItems[2].Text;
                txbHorario.Text = partidoSeleccionado.SubItems[3].Text;
                dtpFecha.Value = DateTime.ParseExact(partidoSeleccionado.SubItems[4].Text, "dd/MM/yyyy", null);
                tbxHoraEnvio.Text = partidoSeleccionado.SubItems[5].Text;
                txbHorasConvalidas.Text = partidoSeleccionado.SubItems[6].Text;
                txtCupos.Text = partidoSeleccionado.SubItems[7].Text;

                lvwEventosRecienAdd.Items.Remove(partidoSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un evento para editar.", "Editar Evento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
