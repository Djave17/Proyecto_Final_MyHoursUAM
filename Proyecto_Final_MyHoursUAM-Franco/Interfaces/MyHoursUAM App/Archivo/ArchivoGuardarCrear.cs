using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHoursUAM_App.Archivo
{
   
   
      internal class ArchivoGuardarCrear
      {
         // Guardar Estudiantes en un archivo binario
         public void GuardarEstudiantes(List<Estudiante> estudiantes, string rutaArchivoEstudiantes)
         {
            using (FileStream archivo = new FileStream(rutaArchivoEstudiantes, FileMode.Create, FileAccess.Write))
            {
               using (BinaryWriter escritor = new BinaryWriter(archivo))
               {
                  foreach (Estudiante estudiante in estudiantes)
                  {
                     escritor.Write(estudiante.cifEstudiante);
                     escritor.Write(estudiante.contraseñaEstudiante);
                     escritor.Write(estudiante.eventosAsistidos);
                     escritor.Write(estudiante.partidosAsistidos);
                     escritor.Write(estudiante.horasCompletadas);
                     escritor.Write(estudiante.cantidadPartidosAsistidos);
                     escritor.Write(estudiante.comprobanteAsistencia);
                     escritor.Write(estudiante.solicitudAsistencia);
                  }
               }
            }
         }

         // Cargar Estudiantes desde el archivo binario
         public List<Estudiante> CargarEstudiantes(string rutaArchivoEstudiantes)
         {
            List<Estudiante> estudiantes = new List<Estudiante>();

            if (!File.Exists(rutaArchivoEstudiantes))
            {
               return estudiantes;
            }

            using (FileStream archivo = new FileStream(rutaArchivoEstudiantes, FileMode.Open, FileAccess.Read))
            {
               using (BinaryReader lector = new BinaryReader(archivo))
               {
                  while (archivo.Position != archivo.Length)
                  {
                     string cifEstudiante = lector.ReadString();
                     string contraseñaEstudiante = lector.ReadString();
                     string eventosAsistidos = lector.ReadString();
                     string partidosAsistidos = lector.ReadString();
                     int horasCompletadas = lector.ReadInt32();
                     int cantidadPartidosAsistidos = lector.ReadInt32();
                     string comprobanteAsistencia = lector.ReadString();
                     string solicitudAsistencia = lector.ReadString();

                     Estudiante estudiante = new Estudiante
                     {
                        cifEstudiante = cifEstudiante,
                        contraseñaEstudiante = contraseñaEstudiante,
                        eventosAsistidos = eventosAsistidos,
                        partidosAsistidos = partidosAsistidos,
                        horasCompletadas = horasCompletadas,
                        cantidadPartidosAsistidos = cantidadPartidosAsistidos,
                        comprobanteAsistencia = comprobanteAsistencia,
                        solicitudAsistencia = solicitudAsistencia
                     };

                     estudiantes.Add(estudiante);
                  }
               }
            }

            return estudiantes;
         }

         // Guardar Trabajadores en un archivo binario
         public void GuardarTrabajadores(List<Trabajador> trabajadores, string rutaArchivoTrabajadores)
         {
            using (FileStream archivo = new FileStream(rutaArchivoTrabajadores, FileMode.Create, FileAccess.Write))
            {
               using (BinaryWriter escritor = new BinaryWriter(archivo))
               {
                  foreach (Trabajador trabajador in trabajadores)
                  {
                     escritor.Write(trabajador.cifTrabajador);
                     escritor.Write(trabajador.contraseñaTrabajador);
                  }
               }
            }
         }

         // Cargar Trabajadores desde el archivo binario
         public List<Trabajador> CargarTrabajadores(string rutaArchivoTrabajadores)
         {
            List<Trabajador> trabajadores = new List<Trabajador>();

            if (!File.Exists(rutaArchivoTrabajadores))
            {
               return trabajadores;
            }

            using (FileStream archivo = new FileStream(rutaArchivoTrabajadores, FileMode.Open, FileAccess.Read))
            {
               using (BinaryReader lector = new BinaryReader(archivo))
               {
                  while (archivo.Position != archivo.Length)
                  {
                     string cifTrabajador = lector.ReadString();
                     string contraseñaTrabajador = lector.ReadString();

                     Trabajador trabajador = new Trabajador
                     {
                        cifTrabajador = cifTrabajador,
                        contraseñaTrabajador = contraseñaTrabajador
                     };

                     trabajadores.Add(trabajador);
                  }
               }
            }

            return trabajadores;
         }
      }
}
