using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHours_UAMApp.Estructuras
{
    internal class Estudiante
    {
        public string nombreEstudiante { get; set; }

        public string apellidoEstudiante { get; set; }

        public string correoEstudiante { get; set; }
        public string cifEstudiante { get; set; }
        public string contraseñaEstudiante { get; set; }
        
       
        public List<string> eventosAsistidos { get; private set; } // IDs de eventos asistidos
        public Asistencia asistencia { get; set; }

        // Constructor
        public Estudiante()
        {
            eventosAsistidos = new List<string>();
            asistencia = new Asistencia();
        }

        // Método para registrar asistencia y contar las horas y partidos realizados
        public bool RegistrarAsistencia(Evento evento,bool asistio)
        {
            if (evento == null)
                throw new ArgumentNullException("El evento no puede ser nulo."); //Validar que el evento no sea nulo.

            if (eventosAsistidos.Contains(evento.idEvento)) //Validar que el evento no haya sido registrado previamente
            {
                Console.WriteLine($"El estudiante ya asistió al evento {evento.nombreEvento}.");
                MessageBox.Show("El estudiante ya asistió a este evento.","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false; // Ya asistió al evento
            }

            // Registrar el evento y actualizar datos
            eventosAsistidos.Add(evento.idEvento);
            asistencia.horasCompletadas += evento.cantidadConvalidar;
            asistencia.cantidadDePartidosAsistidos++;
            Console.WriteLine($"Asistencia registrada para el evento {evento.nombreEvento}.");
            MessageBox.Show("Asistencia registrada correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true; // Asistencia registrada correctamente
        }
    }

}



