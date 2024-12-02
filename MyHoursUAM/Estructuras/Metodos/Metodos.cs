
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

        // Instancias de CRUD para archivos globales
        private static CrudService<Evento> eventoService = new CrudService<Evento>("eventos.dat");
        private static CrudService<Partido> partidoService = new CrudService<Partido>("partidos.dat");
        private static CrudService<SolicitudAsistencia> solicitudesService = new CrudService<SolicitudAsistencia>("solicitudes.dat");
        private static CrudService<Estudiante> estudiantesService = new CrudService<Estudiante>("estudiantes.dat");

        // Listas públicas cargadas desde los archivos
        public static List<SolicitudAsistencia> solicitudes = solicitudesService.GetAll();
        //public static List<Estudiante> estudiantes = estudiantesService.GetAll();
        public static List<Evento> eventos = eventoService.GetAll();
        public static List<Partido> partidos = partidoService.GetAll();

        //public static List<Partido> partidos = new List<Partido>();
        //public static List<Evento> eventos = new List<Evento>();

        private static int contadorSolicitudes = 1; // Contador global para IDs únicos de las solicitud

        //Contadores para IDs de eventos y partidos
        private static int eventoCounter = 1; // Contador para IDs de eventos
        private static int partidoCounter = 1; // Contador para IDs de partidos

        public static void Inicializar()
        {
            // Cargar listas desde los archivos binarios
            eventos = eventoService.GetAll();
            partidos = partidoService.GetAll();
            solicitudes = solicitudesService.GetAll();

            // Sincronizar contadores con los datos existentes
            SincronizarContadores();
        }

        public static List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante { cifEstudiante = "23020386", nombreEstudiante = "David Sanchez", contraseñaEstudiante = "123" },
            new Estudiante { cifEstudiante = "123", nombreEstudiante = "123", contraseñaEstudiante = "123" }
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

            //eventos.Add(nuevoEvento);
            eventoService.Add(nuevoEvento);

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
            eventoService.SaveData();

            return $"Evento '{nombreEvento}' editado exitosamente.";
        }

        /// <summary>
        /// Elimina un evento basado en su índice.
        /// </summary>
        public static string EliminarEvento(int indice)
        {
            if (indice < 0 || indice >= eventos.Count)
            {
                return "Índice inválido. No se pudo eliminar el evento.";
            }

            var evento = eventos[indice]; // Obtener el evento por índice

            eventos.RemoveAt(indice); // Eliminar de la lista en memoria
            eventoService.SaveData(); // Persistir los cambios en el archivo binario

            return $"Evento '{evento.nombreEvento}' eliminado correctamente.";
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

            //partidos.Add(nuevoPartido);
            partidoService.Add(nuevoPartido);

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
            partidoService.SaveData();
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
            partidoService.SaveData();

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

            eventoService.SaveData();// Actualizar el evento en el archivo binario
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
            partidoService.SaveData(); // Actualizar el partido en el archivo binario
            // Retornar mensaje de éxito
            return $"El estado del partido '{partido.nombrePartido}' se cambió a {partido.estadoEvento}.";
        }


        // Método para registrar asistencia
        //public static string RegistrarAsistencia(int indiceEvento, string cifEstudiante)
        //{
        //    // Validar índice
        //    if (indiceEvento < 0 || indiceEvento >= eventos.Count)
        //    {
        //        throw new ArgumentOutOfRangeException("Índice fuera de rango.");
        //    }

        //    // Obtener el evento y validar su disponibilidad
        //    var evento = eventos[indiceEvento];
        //    if (evento.estadoEvento != Evento.EstadoEvento.Disponible)
        //    {
        //        return $"El evento '{evento.nombreEvento}' no está disponible para asistencia.";
        //    }

        //    // Buscar estudiante activo
        //    var estudiante = estudiantes.FirstOrDefault(e => e.cifEstudiante == cifEstudiante);
        //    if (estudiante == null)
        //    {
        //        return "El estudiante no existe.";
        //    }

        //    // Verificar si el estudiante ya asistió al evento
        //    if (estudiante.eventosAsistidos.Contains(evento.idEvento))
        //    {
        //        return $"El estudiante ya asistió al evento '{evento.nombreEvento}'.";
        //    }

        //    // Registrar asistencia
        //    estudiante.eventosAsistidos.Add(evento.idEvento);
        //    estudiante.HorasCompletadas += evento.cantidadConvalidar;

        //    // Actualizar cupos del evento
        //    evento.cupos--;
        //    if (evento.cupos <= 0)
        //    {
        //        evento.estadoEvento = Evento.EstadoEvento.No_Disponible;
        //    }

        //    return $"Asistencia registrada exitosamente para el evento '{evento.nombreEvento}'.";
        //}
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
            if (solicitudes.Any(s => s.EstudianteId == estudianteId && s.Evento.idEvento == evento.idEvento))
            {
                throw new InvalidOperationException("Ya existe una solicitud para este evento.");
            }

            // Validar si hay cupos disponibles en el evento
            if (evento.cupos <= 0)
            {
                throw new InvalidOperationException("El evento ya no tiene cupos disponibles.");
            }
            //validar si esta disponible
            if (evento.estadoEvento != Evento.EstadoEvento.Disponible)
            {
                throw new InvalidOperationException("El evento no está disponible para asistencia.");
            }
            // Crear y agregar la nueva solicitud
            solicitudesService.Add(new SolicitudAsistencia
            {
                Id = contadorSolicitudes++, // Generar un ID único
                EstudianteId = estudianteId,
                Evento = evento,
                EstadoSolicitud = SolicitudAsistencia.Estado.Pendiente,
                FechaSolicitud = DateTime.Now
            });

            // Disminuir el número de cupos del evento
            var eventoActualizado = eventos.FirstOrDefault(e => e.idEvento == evento.idEvento);
            if (eventoActualizado != null)
            {
                eventoActualizado.cupos--;
            }

            // Guardar cambios en solicitudes y eventos
            solicitudesService.SaveData();
            eventoService.SaveData();
        }
       

        // Obtener eventos asistidos por un estudiante
        public static List<Evento> ObtenerEventosAsistidos(string estudianteId)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.cifEstudiante == estudianteId);
            if (estudiante == null)
                return new List<Evento>();

            var eventosAprobados = solicitudes
                .Where(s => s.EstudianteId == estudianteId && s.EstadoSolicitud == SolicitudAsistencia.Estado.Aprobado)
                .Select(s => s.Evento)
                .ToList();

            // Sincronizar eventos aprobados con eventosAsistidos
            estudiante.eventosAsistidos = eventosAprobados.Select(e => e.idEvento).ToList();

            return eventosAprobados;
        }

        public static void GuardarEventosAsistidos(string cifEstudiante)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.cifEstudiante == cifEstudiante);
            if (estudiante != null)
            {
                estudiantesService.SaveData();
            }
        }
        public static void CargarSolicitudesEnListView(ListView listView)
        {
            listView.Items.Clear();
            foreach (var solicitud in solicitudes)
            {
                var item = new ListViewItem(solicitud.Id.ToString());
                item.SubItems.Add(solicitud.EstudianteId);
                string nombreEvento = string.Empty;
                if (solicitud.Evento is Partido partido) //Validacion para mostrar nombre de evento o partido
                {
                    nombreEvento = partido.nombrePartido;
                }
                else
                {
                    nombreEvento = solicitud.Evento.nombreEvento;
                }
                item.SubItems.Add(nombreEvento);

                item.SubItems.Add(solicitud.EstadoSolicitud.ToString());
                item.SubItems.Add(solicitud.FechaSolicitud.ToString("dd/MM/yyyy HH:mm"));
                listView.Items.Add(item);
            }
        }

        public static string ConfirmarSolicitud(int solicitudId)
        {
            var solicitud = solicitudes.FirstOrDefault(s => s.Id == solicitudId);
            if (solicitud == null)
                return "No se encontró la solicitud.";

            // Cambiar estado a Aprobado
            solicitud.EstadoSolicitud = SolicitudAsistencia.Estado.Aprobado;

            // Buscar al estudiante relacionado
            var estudiante = estudiantes.FirstOrDefault(e => e.cifEstudiante == solicitud.EstudianteId);
            if (estudiante == null)
                return "No se encontró el estudiante asociado.";

            // Validar si el evento ya está registrado como asistido
            if (solicitud.Evento != null && estudiante.eventosAsistidos.Contains(solicitud.Evento.idEvento))
                return "El evento ya está registrado como asistido para este estudiante.";

            // Agregar evento asistido al estudiante
            if (solicitud.Evento != null)
            {
                estudiante.eventosAsistidos.Add(solicitud.Evento.idEvento);
                //estudiante.HorasCompletadas += solicitud.Evento.cantidadConvalidar; // Incrementar horas completadas
            }

            

            // Guardar datos actualizados
            solicitudesService.SaveData();
            estudiantesService.SaveData();
            eventoService.SaveData();

            return "Solicitud confirmada, evento actualizado y agregado a los eventos asistidos del estudiante.";
        }



        // Rechazar una solicitud
        public static string RechazarSolicitud(int solicitudId)
        {
            var solicitud = solicitudes.FirstOrDefault(s => s.Id == solicitudId);
            if (solicitud == null)
                return "No se encontró la solicitud.";

            // Cambiar estado a Rechazado
            solicitud.EstadoSolicitud = SolicitudAsistencia.Estado.Rechazado;

            // Guardar cambios
            solicitudesService.SaveData();
            return "Solicitud rechazada correctamente.";
        }

        public static void CargarEventosAsistidos(ListView listView, List<Evento> eventosAsistidos)
        {
            listView.Items.Clear(); // Limpiar el control antes de cargar nuevos datos

            foreach (var evento in eventosAsistidos)
            {
                var item = new ListViewItem(evento.idEvento); // ID del evento
                item.SubItems.Add(evento.nombreEvento);       // Nombre del evento
                item.SubItems.Add(evento.tipoBeneficio);  // Tipo de convalidación
                item.SubItems.Add(evento.cantidadConvalidar.ToString()); // Horas convalidadas
                item.SubItems.Add(evento.horaEvento);         // Hora del evento
                item.SubItems.Add(evento.fechaEvento);        // Fecha del evento
                item.SubItems.Add(evento.lugarEvento);        // Lugar del evento
                item.SubItems.Add(evento.tipoEvento.ToString());         // Tipo del evento
                listView.Items.Add(item);
            }
        }

        public static List<Estudiante> CargarEstudiantesSincronizados()
        {
            var estudiantes = estudiantesService.GetAll();

            // Sincronizar eventos asistidos con solicitudes aprobadas
            foreach (var estudiante in estudiantes)
            {
                var eventosAprobados = solicitudes
                    .Where(s => s.EstudianteId == estudiante.cifEstudiante && s.EstadoSolicitud == SolicitudAsistencia.Estado.Aprobado)
                    .Select(s => s.Evento.idEvento)
                    .ToList();

                estudiante.eventosAsistidos = eventosAprobados;
            }

            return estudiantes;
        }

        //public static List<Estudiante> estudiantes = CargarEstudiantesSincronizados();

        private static void SincronizarContadores()
        {
            if (eventos.Count > 0)
            {
                // Obtener el número más alto entre los IDs de eventos existentes
                eventoCounter = eventos.Max(e => int.Parse(e.idEvento.TrimStart('E'))) + 1;
            }

            if (partidos.Count > 0)
            {
                // Obtener el número más alto entre los IDs de partidos existentes
                partidoCounter = partidos.Max(p => int.Parse(p.idEvento.TrimStart('P'))) + 1;
            }
        }

    }
}
