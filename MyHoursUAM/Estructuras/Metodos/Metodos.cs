
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static MyHours_UAMApp.Estructuras.Evento;

namespace MyHours_UAMApp.Estructuras.Metodos
{
    internal static class Metodos
    {
        public static List<Evento> eventos = new List<Evento>();
        private static int contadorSolicitudes = 1; // Contador global para IDs únicos de las solicitud


        private static int eventoCounter = 1; // Contador para IDs de eventos
        private static int partidoCounter = 1; // Contador para IDs de partidos

        public static List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante { cifEstudiante = "23020386", nombreEstudiante = "David Sanchez", contraseñaEstudiante = "123" },
            new Estudiante { cifEstudiante = "2021002", nombreEstudiante = "Ana López", contraseñaEstudiante = "estudiante2" }
        };

        public static List<Administrador> administradores = new List<Administrador>
        {
            new Administrador { cifAdministrador = "admin", contraseñaAdministrador = "admin" }
        };
        /// <summary>
        /// Devuelve todos los eventos como una lista.
        /// </summary>
        public static List<string[]> GetEventosAsString()
        {
            return eventos.Select(p => new string[]
            {
                p.idEvento,
                p.nombreEvento,
                p.tipoBeneficio,
                p.horaEvento,
                p.fechaEvento,
                p.lugarEvento,
                p.cantidadConvalidar.ToString(),
                p.cupos.ToString(),
                p.tipoEvento.ToString(),
                p.estadoEvento.ToString(),
               
                
            }).ToList();
        }
        public static (List<string[]>, List<string[]>) EventosPartidos()
        {
            var eventos = GetEventosAsString();
            var partidos = GetPartidosAsStringArray();
            return (eventos, partidos);
        }
        public static List<Partido> partidos = new List<Partido>();

        public static List<SolicitudAsistencia> Solicitudes = new List<SolicitudAsistencia>();



        /// <summary>
        /// Registra un nuevo evento con validaciones de campos obligatorios.
        /// </summary>
        /// <param name="tipoEvento">Tipo de evento (deportivo, cultural, etc.).</param>
        /// <param name="tipoBeneficio">Tipo de beneficio asociado al evento.</param>
        /// <param name="nombreEvento">Nombre del evento.</param>
        /// <param name="cantidadConvalidar">Cantidad de horas a convalidar.</param>
        /// <param name="cupos">Número de cupos disponibles.</param>
        /// <param name="horaEnvio">Hora de envío del evento.</param>
        /// <param name="hora">Hora del evento.</param>
        /// <param name="fecha">Fecha del evento.</param>
        /// <param name="lugar">Lugar donde se llevará a cabo el evento.</param>
        /// <returns>Mensaje indicando el resultado del registro.</returns>
        public static string RegistrarEvento(
            string idEvento,
            string nombreEvento,
            string tipoBeneficio,
            string hora,
            string fecha,
            string lugar,
            int cantidadAConvalidar,
            int cupo,
            string tipoEvento,
            string estadoEvento)
           
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(tipoEvento) ||
                string.IsNullOrWhiteSpace(tipoBeneficio) ||
                string.IsNullOrWhiteSpace(nombreEvento) ||
                string.IsNullOrWhiteSpace(estadoEvento) ||
                string.IsNullOrWhiteSpace(hora) ||
                string.IsNullOrWhiteSpace(fecha) ||
                string.IsNullOrWhiteSpace(lugar) ||
                cantidadAConvalidar <= 0 ||
                cupo <= 0)
            {
                return "Todos los campos obligatorios deben estar completos y válidos.";
            }

            // Crear un nuevo evento
            Evento nuevoEvento = new Evento
            {
                idEvento = "E" + eventoCounter++,
                nombreEvento = nombreEvento,
                tipoBeneficio = tipoBeneficio,
                horaEvento = hora,
                fechaEvento = fecha,
                lugarEvento = lugar,
                cantidadConvalidar = cantidadAConvalidar,
                cupos = cupo,
                tipoEvento = Enum.TryParse(tipoEvento, true, out Evento.TipoEvento tipoEventoEnum)
                    ? tipoEventoEnum
                    : Evento.TipoEvento.deportivo, // Valor predeterminado
                estadoEvento = Enum.TryParse(estadoEvento, true, out Evento.EstadoEvento estadoEventoEnum)
                    ? estadoEventoEnum
                    : Evento.EstadoEvento.No_Disponible, // Valor predeterminado

            };

            eventos.Add(nuevoEvento);

            return $"Evento '{nombreEvento}' registrado exitosamente con ID {nuevoEvento.idEvento}.";
        }

        /// <summary>
        /// Edita un evento existente basado en su índice y nuevos datos.
        /// </summary>
        public static string EditarEvento(
            int indice,
            string idEvento,
            string nombreEvento,
            string tipoBeneficio,
            string hora,
            string fecha,
            string lugar,
            int cantidadAConvalidar,
            int cupo,
            string tipoEvento,
            string estadoEvento)
        {
            // Validar índice
            if (indice < 0 || indice >= eventos.Count)
            {
                return "Índice inválido.";
            }

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(tipoEvento) ||
                string.IsNullOrWhiteSpace(tipoBeneficio) ||
                string.IsNullOrWhiteSpace(nombreEvento) ||
                string.IsNullOrWhiteSpace(estadoEvento) ||
                string.IsNullOrWhiteSpace(hora) ||
                string.IsNullOrWhiteSpace(fecha) ||
                string.IsNullOrWhiteSpace(lugar) ||
                cantidadAConvalidar <= 0 ||
                cupo <= 0)
            {
                return "Todos los campos obligatorios deben estar completos y válidos.";
            }

            // Editar el evento existente
            eventos[indice] = new Evento
            {
                idEvento = eventos[indice].idEvento, // Mantener el ID existente
                nombreEvento = nombreEvento,
                tipoBeneficio = tipoBeneficio,
                horaEvento = hora,
                fechaEvento = fecha,
                lugarEvento = lugar,
                cantidadConvalidar = cantidadAConvalidar,
                cupos = cupo,
                tipoEvento = Enum.TryParse(tipoEvento, true, out Evento.TipoEvento tipoEventoEnum)
                    ? tipoEventoEnum
                    : Evento.TipoEvento.deportivo, // Valor predeterminado
                estadoEvento = Enum.TryParse(estadoEvento, true, out Evento.EstadoEvento estadoEventoEnum)
                    ? estadoEventoEnum
                    : Evento.EstadoEvento.No_Disponible, // Valor predeterminado
            };

            return $"Evento '{nombreEvento}' editado exitosamente.";
        }

        /// <summary>
        /// Elimina un evento basado en su índice.
        /// </summary>
        public static string EliminarEvento(int indice)
        {
            // Validar índice
            if (indice < 0 || indice >= eventos.Count)
            {
                return "Índice inválido.";
            }

            string nombreEvento = eventos[indice].nombreEvento;
            eventos.RemoveAt(indice);

            return $"Evento '{nombreEvento}' eliminado exitosamente.";
        }
        public static string RegistrarPartido(
            string idEvento,
            string tipoDeporte,
            string nombrePartido,
            int cantidadAConvalidar,
            int cupo,
            string horaEnvio,
            string hora,
            string fecha,
            string lugar,
            string estadoEvento)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(tipoDeporte) ||
                string.IsNullOrWhiteSpace(nombrePartido) ||
                string.IsNullOrWhiteSpace(horaEnvio) ||
                string.IsNullOrWhiteSpace(hora) ||
                string.IsNullOrWhiteSpace(fecha) ||
                string.IsNullOrWhiteSpace(lugar) ||
                cantidadAConvalidar <= 0 ||
                cupo <= 0)
            {
                return "Todos los campos obligatorios deben estar completos y válidos.";
            }

            // Crear un nuevo partido
            Partido nuevoPartido = new Partido
            {
                idEvento = "P" + partidoCounter++,
                nombrePartido = nombrePartido,
                lugarPartido = lugar,
                deporte = Enum.TryParse(tipoDeporte, true, out Partido.TipoDeporte deporteEnum)
                    ? deporteEnum
                    : Partido.TipoDeporte.futbol, // Valor predeterminado
                fechaEvento = fecha,
                horaEvento = hora,
                cantidadConvalidar = cantidadAConvalidar,
                cupos = cupo,
                estadoEvento = Enum.TryParse(estadoEvento, true, out Evento.EstadoEvento estadoEventoEnum)
                    ? estadoEventoEnum
                    : Evento.EstadoEvento.No_Disponible, // Valor predeterminado
            };

            partidos.Add(nuevoPartido);

            return $"Partido '{nombrePartido}' registrado exitosamente.";
        }

        /// <summary>
        /// Edita un partido existente basado en su índice.
        /// </summary>
        public static string EditarPartido(
            int indice,
            string idEvento,
            string tipoDeporte,
            string nombrePartido,
            int cantidadAConvalidar,
            int cupo,
            string horaEnvio,
            string hora,
            string fecha,
            string lugar,
            string estadoEvento)
        {
            // Validar índice
            if (indice < 0 || indice >= partidos.Count)
            {
                return "Índice inválido.";
            }

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(tipoDeporte) ||
                string.IsNullOrWhiteSpace(nombrePartido) ||
                string.IsNullOrWhiteSpace(horaEnvio) ||
                string.IsNullOrWhiteSpace(hora) ||
                string.IsNullOrWhiteSpace(fecha) ||
                string.IsNullOrWhiteSpace(lugar) ||
                string.IsNullOrWhiteSpace(estadoEvento) ||
                cantidadAConvalidar <= 0 ||
                cupo <= 0)
            {
                return "Todos los campos obligatorios deben estar completos y válidos.";
            }

            // Editar el partido existente
            partidos[indice] = new Partido
            {
                idEvento = partidos[indice].idEvento, // Mantener el ID existente
                nombrePartido = nombrePartido,
                lugarPartido = lugar,
                
                deporte = Enum.TryParse(tipoDeporte, true, out Partido.TipoDeporte deporteEnum)
                    ? deporteEnum
                    : Partido.TipoDeporte.futbol, // Valor predeterminado
                fechaEvento = fecha,
                horaEvento = hora,
                cantidadConvalidar = cantidadAConvalidar,
                cupos = cupo,
                estadoEvento = Enum.TryParse(estadoEvento, true, out Evento.EstadoEvento estadoEventoEnum)
                    ? estadoEventoEnum
                    : Evento.EstadoEvento.No_Disponible, // Valor predeterminado

            };

            return $"Partido '{nombrePartido}' editado exitosamente.";
        }

        /// <summary>
        /// Elimina un partido basado en su índice.
        /// </summary>
        public static string EliminarPartido(int indice)
        {
            // Validar índice
            if (indice < 0 || indice >= partidos.Count)
            {
                return "Índice inválido.";
            }

            string nombrePartido = partidos[indice].nombrePartido;
            partidos.RemoveAt(indice);

            return $"Partido '{nombrePartido}' eliminado exitosamente.";
        }

        /// <summary>
        /// Devuelve todos los partidos como una lista de arreglos de string para su uso en un ListView.
        /// </summary>
        public static List<string[]> GetPartidosAsStringArray()
        {
            return partidos.Select(p => new string[]
            {
                p.idEvento,
                p.nombrePartido,
                p.lugarPartido,
                p.deporte.ToString(),
                p.horaEvento,
                p.fechaEvento,
                p.cantidadConvalidar.ToString(),
                p.cupos.ToString(),
                p.estadoEvento.ToString(),

            }).ToList();
        }
        //Cambiar estado del evento
        public static string CambiarEstadoEvento(int indice)
        {
            // Validar índice
            if (indice < 0 || indice >= eventos.Count)
            {
                throw new ArgumentOutOfRangeException("Índice fuera de rango.");
            }

            // Obtener el evento seleccionado
            var evento = eventos[indice];

            // Alternar el estado

            if (evento.estadoEvento == Evento.EstadoEvento.Disponible)
            {
                evento.estadoEvento = Evento.EstadoEvento.No_Disponible;
            }
            else if (evento.estadoEvento == Evento.EstadoEvento.No_Disponible)
            {
                evento.estadoEvento = Evento.EstadoEvento.Disponible;
            }
            

            // Retornar mensaje de éxito
            return $"El estado del evento '{evento.nombreEvento}' se cambió a {evento.estadoEvento}.";
        }
        public static string CambiarEstadoPartido(int indice)
        {
            // Validar índice
            if (indice < 0 || indice >= partidos.Count)
            {
                throw new ArgumentOutOfRangeException("Índice fuera de rango.");
            }
            // Obtener el partido seleccionado
            var partido = partidos[indice];
            // Alternar el estado
            if (partido.estadoEvento == Partido.EstadoEvento.Disponible)
            {
                partido.estadoEvento = Partido.EstadoEvento.No_Disponible;
            }
            else if (partido.estadoEvento == Partido.EstadoEvento.No_Disponible)
            {
                partido.estadoEvento = Partido.EstadoEvento.Disponible;
            }
            // Retornar mensaje de éxito
            return $"El estado del partido '{partido.nombrePartido}' se cambió a {partido.estadoEvento}.";
        }


        // Método para registrar asistencia
        public static string RegistrarAsistencia(int indiceEvento, string cifEstudiante)
        {
            // Validar índice
            if (indiceEvento < 0 || indiceEvento >= eventos.Count)
            {
                throw new ArgumentOutOfRangeException("Índice fuera de rango.");
            }

            // Obtener el evento y validar su disponibilidad
            var evento = eventos[indiceEvento];
            if (evento.estadoEvento != Evento.EstadoEvento.Disponible)
            {
                return $"El evento '{evento.nombreEvento}' no está disponible para asistencia.";
            }

            // Buscar estudiante activo
            var estudiante = estudiantes.FirstOrDefault(e => e.cifEstudiante == cifEstudiante);
            if (estudiante == null)
            {
                return "El estudiante no existe.";
            }

            // Verificar si el estudiante ya asistió al evento
            if (estudiante.eventosAsistidos.Contains(evento.idEvento))
            {
                return $"El estudiante ya asistió al evento '{evento.nombreEvento}'.";
            }

            // Registrar asistencia
            estudiante.eventosAsistidos.Add(evento.idEvento);
            estudiante.HorasCompletadas += evento.cantidadConvalidar;

            // Actualizar cupos del evento
            evento.cupos--;
            if (evento.cupos <= 0)
            {
                evento.estadoEvento = Evento.EstadoEvento.No_Disponible;
            }

            return $"Asistencia registrada exitosamente para el evento '{evento.nombreEvento}'.";
        }
        // Método para validar inicio de sesión y determinar el rol
        public static (bool, string) ValidarCredenciales(string usuario, string contraseña)
        {
            // Validar si es administrador
            var admin = administradores.FirstOrDefault(a => a.cifAdministrador == usuario && a.contraseñaAdministrador == contraseña);
            if (admin != null)
            {
                return (true, "Administrador");
            }

            // Validar si es estudiante
            var estudiante = estudiantes.FirstOrDefault(e => e.cifEstudiante == usuario && e.contraseñaEstudiante == contraseña);
            if (estudiante != null)
            {
                return (true, "Estudiante");
            }

            // Credenciales inválidas
            return (false, null);
        }
        public static int CalcularHorasLaborales(string cifEstudiante)
        {
            var estudiante = SesionActual.EstudianteActual;
            if (estudiante == null) return 0;

            var eventosAsistidos = ObtenerEventosAsistidos(cifEstudiante);
            return eventosAsistidos.Sum(e => e.cantidadConvalidar); // Suponiendo que cantidadConvalidar representa las horas
        }

        // Calcular el beneficio acumulado de partidos
        public static int CalcularBeneficioPartidos(string cifEstudiante)
        {
            var estudiante = SesionActual.EstudianteActual;
            if (estudiante == null) return 0;

            var partidosAsistidos = eventos.OfType<Partido>()
                .Where(p => estudiante.eventosAsistidos.Contains(p.idEvento))
                .ToList();

            return partidosAsistidos.Count; // Calculando cantidad de partidos asistidos como beneficio
        }
        

        // Enviar solicitud de asistencia
        public static void EnviarSolicitud(string estudianteId, Evento evento)
        {
            // Validar si ya existe una solicitud para este evento
            if (Solicitudes.Any(s => s.EstudianteId == estudianteId && s.Evento.idEvento == evento.idEvento))
            {
                throw new InvalidOperationException("Ya existe una solicitud para este evento.");
            }

            // Crear y agregar la nueva solicitud
            Solicitudes.Add(new SolicitudAsistencia
            {
                Id = contadorSolicitudes++, // Generar un ID único
                EstudianteId = estudianteId,
                Evento = evento,
                EstadoSolicitud = SolicitudAsistencia.Estado.Pendiente,
                FechaSolicitud = DateTime.Now
            });
        }

        // Procesar solicitud (aprobar o rechazar)
        public static void ProcesarSolicitud(int solicitudId, SolicitudAsistencia.Estado nuevoEstado)
        {
            var solicitud = Solicitudes.FirstOrDefault(s => s.Id == solicitudId);
            if (solicitud != null)
            {
                solicitud.EstadoSolicitud = nuevoEstado;
            }
            else
            {
                throw new KeyNotFoundException("No se encontró la solicitud con el ID proporcionado.");
            }
        }

        // Obtener eventos asistidos por un estudiante
        public static List<Evento> ObtenerEventosAsistidos(string estudianteId)
        {
            return Solicitudes
                .Where(s => s.EstudianteId == estudianteId && s.EstadoSolicitud == SolicitudAsistencia.Estado.Aprobado)
                .Select(s => s.Evento)
                .ToList();
        }
        public static void CargarSolicitudesEnListView(ListView listView)
        {
            // Limpiar los elementos existentes en el ListView
            listView.Items.Clear();

            // Recorrer las solicitudes y agregarlas al ListView
            foreach (var solicitud in Solicitudes)
            {
                // Crear un nuevo elemento de ListView
                var item = new ListViewItem(solicitud.Id.ToString());
                item.SubItems.Add(solicitud.EstudianteId);
                item.SubItems.Add(solicitud.Evento.nombreEvento); // Asumiendo que Evento tiene una propiedad Nombre
                item.SubItems.Add(solicitud.EstadoSolicitud.ToString());
                item.SubItems.Add(solicitud.FechaSolicitud.ToString("dd/MM/yyyy HH:mm"));

                // Agregar el elemento al ListView
                listView.Items.Add(item);
            }
        }

        public static void ConfirmarSolicitud(int solicitudId)
        {
            var solicitud = Solicitudes.FirstOrDefault(s => s.Id == solicitudId);
            if (solicitud != null)
            {
                solicitud.EstadoSolicitud = SolicitudAsistencia.Estado.Aprobado;
                MessageBox.Show("La solicitud ha sido confirmada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine($"Solicitud con Id {solicitudId} ha sido confirmada.");
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró la solicitud con Id {solicitudId}.");
            }
        }

        public static void RechazarSolicitud(int solicitudId)
        {
            var solicitud = Solicitudes.FirstOrDefault(s => s.Id == solicitudId);
            if (solicitud != null)
            {
                solicitud.EstadoSolicitud = SolicitudAsistencia.Estado.Rechazado;
                Console.WriteLine($"Solicitud con Id {solicitudId} ha sido rechazada.");
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró la solicitud con Id {solicitudId}.");
            }
        }





    }

}
