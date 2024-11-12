using gui_ciudades.Estructura;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gui_ciudades.Servicios
{
   internal class CiudadArchivoServicio
   {
      public void GuardarArchivo(List<Ciudad> ciudades , string rutaArchivo)
      {

         using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write))
         {
            using(BinaryWriter escritor = new BinaryWriter(archivo))
            {
                    foreach (Ciudad c in ciudades)
                    {
                        escritor.Write(c.Id);
                        escritor.Write(c.Nombre.Length); 
                        escritor.Write(c.Nombre.ToCharArray());
                    }
            }
         }


      }

      public List<Ciudad> CargarCiudades(string rutaArchivo)
      {
         List<Ciudad> ciudades = new List<Ciudad>();

            if (!File.Exists(rutaArchivo))
            {
              return ciudades;
            }

         using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read))
         {
            using(BinaryReader lector = new BinaryReader(archivo))
            {
               while(archivo.Position != archivo.Length)
               {
                  int id = lector.ReadInt32();
                  int tamaño = lector.ReadInt32();
                  char[] nombreArray = lector.ReadChars(tamaño);
                  string nombre = new string(nombreArray);
                  Ciudad ciudad = new Ciudad(); 
                  ciudad.Id = id;
                  ciudad.Nombre = nombre;
                  ciudades.Add(ciudad);
               }
            }
         }

         return ciudades;


        }

   }
}
