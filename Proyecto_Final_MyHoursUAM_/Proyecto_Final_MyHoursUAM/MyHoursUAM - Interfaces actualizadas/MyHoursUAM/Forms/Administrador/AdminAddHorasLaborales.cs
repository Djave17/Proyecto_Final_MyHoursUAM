using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyHours_UAMApp.Estructuras.Metodos;

namespace MyHours_UAMApp.Forms.Administrador
{
    public partial class AdminAddHorasLaborales : Form
    {
        public AdminAddHorasLaborales()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string areaHoras = txtAreaHoras.Text;
            string fechaHoras = dtpFechaHoras.Value.ToString("dd/MM/yyyy");
            string hora = txtHoraHoras.Text;
            string lugarHoras = txtLugarHoras.Text;
            string actividadDispo = txtActividadHoras.Text;
            int cuposHoras = int.Parse(txtCuposHoras.Text);
            int horasConv = int.Parse(txtHorasConv.Text);
            string descripcionHoras = txtDescripcionHoras.Text;
          
            Metodos.RegistrarHoras(areaHoras, fechaHoras, hora, lugarHoras, actividadDispo, cuposHoras, horasConv, descripcionHoras);
            MessageBox.Show("Partido registrado exitosamente.");
        }

        private void btnVerActividades_Click(object sender, EventArgs e)
        {
            AdminVerHorasLaborales form = new AdminVerHorasLaborales();
            form.Show();
            this.Close();
        }

        private void btnAjustesActividad_Click(object sender, EventArgs e)
        {
            AdminAjustes form = new AdminAjustes();
            form.Show();
            this.Hide();
        }

        private void btnAsistenciaActividad_Click(object sender, EventArgs e)
        {
            AdminAsistencia form = new AdminAsistencia();
            form.Show();
            this.Hide();
        }
    }
}
