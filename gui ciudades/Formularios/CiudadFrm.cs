using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gui_ciudades.Estructura;
using gui_ciudades.Servicios;

namespace gui_ciudades.Formulario
{
   public partial class CiudadFrm : Form
   {

      private List<Ciudad> ciudades;
      private Ciudad ciudadsel = new Ciudad();
      public CiudadFrm()
      {
         InitializeComponent();
         ciudades = new List<Ciudad>();
      }

      private void groupBox1_Enter(object sender, EventArgs e)
      {

      }

      private void btnAgregar_Click(object sender, EventArgs e)
      {
         Ciudad ciudad = new Ciudad();
         ciudad.Id = int.Parse(txtCodigo.Text); // deben de ser el mismo nombre que se puso en le diseño
         ciudad.Nombre = txtNombre.Text;

         int index = ciudades.FindIndex(item => item.Id == ciudad.Id);

            if (index != -1)
            
             ciudades[index] = ciudad;

            
         else
         
            ciudades.Add(ciudad);
         MostrarDatos();
      }

      private void MostrarDatos()
      {
         dgvRegistros.DataSource = null;
         dgvRegistros.DataSource = ciudades;
      }

      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }

      private void btnCargar_Click(object sender, EventArgs e)
      {
         /* dgvRegistros.DataSource = ciudades;
          LimpiarCampos();*/
         try
         {
            openFileDialog1.Filter = "Archivos DAT (*.dat)|*.dat"; //abrir archivo
            openFileDialog1.Title = "Seleccionar archivo para cargar";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               string rutaArchivo = openFileDialog1.FileName; //nombre del archivo a cargar o mostrar

               // Creamos la instancia del servicio para cargar los datos
               CiudadArchivoServicio archivoServicio = new CiudadArchivoServicio();
               ciudades = archivoServicio.CargarCiudades(rutaArchivo);  // Cargamos los datos del archivo

              
               MostrarDatos(); 

               MessageBox.Show("Archivo cargado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }



      }

      private void btnEliminar_Click(object sender, EventArgs e)
      {
         try
         {
            //abrir archivo
            openFileDialog1.Filter = "Archivos DAT (*.dat)|*.dat";
            openFileDialog1.Title = "Seleccionar archivo para eliminar ciudad";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               string rutaArchivo = openFileDialog1.FileName;

               //  cargar las ciudades o los elementod q sp estna en la lista  una instancia de la lista
               CiudadArchivoServicio archivoServicio = new CiudadArchivoServicio();
               List<Ciudad> ciudades = archivoServicio.CargarCiudades(rutaArchivo);

               
               int idCiudadAEliminar = int.Parse(txtCodigo.Text);  // Suponiendo que usas txtCodigo para el Id

              
               int index = ciudades.FindIndex(c => c.Id == idCiudadAEliminar); // se puede hacer con if pero asi lo hizo el profe y ps xd
               if (index != -1) // se pone diferenfe a -1 pq si es menor a uno no esta en la losita
               {
                  ciudades.RemoveAt(index);  // se elimina la ciudad de la lista en el índice especificado.


                  archivoServicio.GuardarArchivo(ciudades, rutaArchivo); // se guardan los cambios osea eliminar 

                  MessageBox.Show("La ciudad ha sido eliminada y el archivo actualizado.", "Eliminar Ciudad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  MostrarDatos();  // Refresca el DataGridView si es necesario
               }
               else
               {
                  MessageBox.Show("La ciudad no fue encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void txtCódigo_TextChanged(object sender, EventArgs e)
      {

      }

      private void txtNombreCiudad_TextChanged(object sender, EventArgs e)
      {

      }

      private void btnGuardar_Click(object sender, EventArgs e)
      {
         try
         {
            saveFileDialog1.Filter = "Archivos DAT (*.dat)|*.dat";
            saveFileDialog1.Title = "Guardar archivo";


                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                     CiudadArchivoServicio archivo = new CiudadArchivoServicio();
                   archivo.GuardarArchivo(ciudades, saveFileDialog1.FileName);
                 MessageBox.Show(" Se ha guardado el archivo", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
                }


         }
         catch(Exception ex)
         {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      private void CiudadFrm_Load(object sender, EventArgs e)
      {

      }

     /* private void LimpiarCampos()
      {

         txtCodigo.Clear();
         txtNombre.Clear();

      }*/

   }
}
