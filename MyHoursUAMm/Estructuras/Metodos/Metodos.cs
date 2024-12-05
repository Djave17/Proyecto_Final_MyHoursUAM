
using Microsoft.Reporting.WinForms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static MyHours_UAMApp.Estructuras.Evento;

namespace MyHours_UAMApp.Estructuras.Metodos
{
   internal static class Metodos
   {
      //MARK: - Instancias de CRUD
      #region Instancias de CRUD
      // Instancias de CRUD para archivos globales
      private static CrudService<SolicitudAsistencia> solicitudesService = new CrudService<SolicitudAsistencia>("solicitudes.dat");
      private static CrudService<Evento> eventoService = new CrudService<Evento>("eventos.dat");
      private static CrudService<Partido> partidoService = new CrudService<Partido>("partidos.dat");
      private static CrudService<SolicitudAsistencia> solicitudesEventosService = new CrudService<SolicitudAsistencia>("solicitudesEventos.dat");
      private static CrudService<SolicitudAsistencia> solicitudesPartidosService = new CrudService<SolicitudAsistencia>("solicitudesPartidos.dat");
      private static CrudService<Estudiante> estudiantesService = new CrudService<Estudiante>("estudiantes.dat");
      private static CrudService<Administrador> administradoresService = new CrudService<Administrador>("administradores.dat");
      //ANDREAAAAA AGREGA ESTOOOOOO
      // Listas públicas cargadas desde los archivos

      public static List<SolicitudAsistencia> solicitudesEventos = solicitudesEventosService.GetAll() ?? new List<SolicitudAsistencia>();
      public static List<SolicitudAsistencia> solicitudesPartidos = solicitudesPartidosService.GetAll() ?? new List<SolicitudAsistencia>();
      public static List<Evento> eventos = eventoService.GetAll() ?? new List<Evento>();
      public static List<Partido> partidos = partidoService.GetAll() ?? new List<Partido>();
      public static List<Estudiante> estudiantes = new List<Estudiante>();
      public static List<Administrador> administradores = new List<Administrador>();
      //{
      //    //new Estudiante { cifEstudiante = "23020386", nombreEstudiante = "David Sanchez", contraseñaEstudiante = "123" },
      //    new Estudiante { cifEstudiante = "123", nombreEstudiante = "123", contraseñaEstudiante = "123" }
      //};



      #endregion Instancias de CRUD

      //MARK: - Contadores
      #region Contadores
      //Contadores para IDs de eventos y partidos
      private static int contadorSolicitudesEventos = 1; // Contador global para IDs únicos de las solicitud eventos
      private static int contadorSolicitudesPartidos = 1; // Contador global para IDs únicos de las solicitud partidos
      private static int eventoCounter = 1; // Contador para IDs de eventos
      private static int partidoCounter = 1; // Contador para IDs de partidos
      #endregion Contadores

      //MARK: - Inicializar
      //Esta funcion es llamada en main
      /// <summary>
      /// Inicializa los datos de la aplicación.
      /// </summary>
      public static void Inicializar()
      {
         try
         {
            //get all viene de CrudService que hace un deserialize para obtener los datos del archivo binario y los carga en la lista 
            eventos = eventoService.GetAll() ?? new List<Evento>();
            partidos = partidoService.GetAll() ?? new List<Partido>();
            solicitudesEventos = solicitudesEventosService.GetAll() ?? new List<SolicitudAsistencia>();
            solicitudesPartidos = solicitudesPartidosService.GetAll() ?? new List<SolicitudAsistencia>();
            estudiantes = estudiantesService.GetAll() ?? new List<Estudiante>();
            administradores = administradoresService.GetAll() ?? new List<Administrador>();

            // Se asegura que los archivos existan al guardar datos iniciales vacíos
            if (solicitudesEventos.Count == 0) solicitudesEventosService.SaveData();
            if (solicitudesPartidos.Count == 0) solicitudesPartidosService.SaveData();
            if (estudiantes.Count == 0)
            {
               //MessageBox.Show("La lista de estudiantes está vacía. Inicializando valores por defecto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
               estudiantes = new List<Estudiante>
                    {
                    new Estudiante { cifEstudiante = "23020386", nombreEstudiante = "David Sanchez", contraseñaEstudiante = "123" },
                    new Estudiante { cifEstudiante = "123", nombreEstudiante = "123", contraseñaEstudiante = "123" }
                    };
               estudiantesService.SaveData(); // Guarda los datos inicializados
            }
            if (administradores.Count == 0)
            {
               administradores = new List<Administrador>
                    {
                    new Administrador { cifAdministrador = "admin", nombreAdministrador = "admin", contraseñaAdministrador = "123" },
                    new Administrador { cifAdministrador = "1234", nombreAdministrador = "Kristhel", contraseñaAdministrador = "123" }
                    };
               administradoresService.SaveData(); // Guarda los datos inicializados
            }
            
            

            SincronizarContadores(); // Actualiza los contadores de IDs
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error al inicializar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }



      //MARK : - LLamado de eventos y partidos
      public static (List<string[]>, List<string[]>) EventosPartidos()
      {
         var eventos = GetEventosAsString();
         var partidos = GetPartidosAsStringArray();
         return (eventos, partidos);
      }




      //MARK : - CRUD de eventos
      #region CRUD de eventos

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
      #endregion CRUD de eventos

      //MARK: - CRUD de partidos
      #region CRUD de partidos
      /// <summary>
      /// Registra un nuevo partido con validaciones de campos obligatorios.
      /// </summary>
      /// <param name="idEvento"></param>
      /// <param name="tipoDeporte"></param>
      /// <param name="nombrePartido"></param>
      /// <param name="cantidadAConvalidar"></param>
      /// <param name="cupo"></param>
      /// <param name="horaEnvio"></param>
      /// <param name="hora"></param>
      /// <param name="fecha"></param>
      /// <param name="lugar"></param>
      /// <param name="estadoEvento"></param>
      /// <returns></returns>
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
      /// Eliminar un partido basado en su índice.
      /// </summary>
      /// <param name="indice"></param>
      /// <returns></returns>
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
      #endregion CRUD de partidos

      //MARK: - Get partidos Get eventos
      #region Getters partidos
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
      #endregion Getters partidos

      //MARK: - Cambiar estado del evento
      #region Cambiar estados

      /// <summary>
      /// Cambiar el estado de un evento.
      /// </summary>
      /// <param name="indice"></param>
      /// <returns></returns>
      /// <exception cref="ArgumentOutOfRangeException"></exception>
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

      //MARK: - Métodos de autenticación


      /// <summary>
      /// Cambiar el estado de un partido.
      /// </summary>
      /// <param name="indice"></param>
      /// <returns></returns>
      /// <exception cref="ArgumentOutOfRangeException"></exception>
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
      #endregion Cambiar estados


      //MARK: - Métodos de autenticación
      #region Métodos de autenticación
      /// <summary>
      /// Validar las credenciales de un usuario.
      /// </summary>
      /// <param name="usuario"></param>
      /// <param name="contraseña"></param>
      /// <returns></returns>
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
      #endregion Métodos de autenticación

      //MARK : - Métodos para calcular horas y partidos
      #region Metodos para calcular horas y partidos
      /// <summary>
      /// Calcular las horas laborales de un estudiante.
      /// </summary>
      /// <param name="cifEstudiante"></param>
      /// <returns></returns>
      public static int CalcularHorasLaborales(string cifEstudiante)
      {
         var estudiante = SesionActual.EstudianteActual;
         if (estudiante == null) return 0;

         var eventosAsistidos = ObtenerEventosAsistidos(cifEstudiante);
         return eventosAsistidos.Sum(e => e.cantidadConvalidar); // Suponiendo que cantidadConvalidar representa las horas
      }



      // MARK: - Calcular el beneficio acumulado de partidos

      /// <summary>
      /// Calcular el beneficio acumulado de partidos.
      /// </summary>
      /// <param name="cifEstudiante"></param>
      /// <returns></returns>
      public static int CalcularBeneficioPartidos(string cifEstudiante)
      {
         var estudiante = SesionActual.EstudianteActual;
         if (estudiante == null) return 0;

         var partidosAsistidos = ObtenerPartidosAsistidos(cifEstudiante);

         return partidosAsistidos.Sum(p => p.cantidadConvalidar); // Calculando cantidad de partidos asistidos como beneficio
      }
      #endregion Metodos para calcular horas y partidos

      // MARK: Envios de asistencia 

      #region Envio de solicitudes de asistencia
      //MARK: - Envio de solicitudes de asistencia
      //CAMBIOOOOO ANDREAAAAA COPIALO EN TU CODIGO
      // Enviar solicitud de asistencia
      public static void EnviarSolicitudEvento(string estudianteId, Evento evento)
      {
         if (solicitudesEventos.Any(s => s.EstudianteId == estudianteId && s.Eventos.idEvento == evento.idEvento))
            throw new InvalidOperationException("Ya existe una solicitud para este evento.");

         if (evento.cupos <= 0)
            throw new InvalidOperationException("El evento ya no tiene cupos disponibles.");

         if (evento.estadoEvento != Evento.EstadoEvento.Disponible)
            throw new InvalidOperationException("El evento no está disponible para asistencia.");

         solicitudesEventosService.Add(new SolicitudAsistencia
         {
            Id = "SE" + contadorSolicitudesEventos++, // Genera un ID único
            EventoId = evento.idEvento,
            EstudianteId = estudianteId,
            Eventos = evento,
            EstadoSolicitud = SolicitudAsistencia.Estado.Pendiente,
            FechaSolicitud = DateTime.Now
         });

         // Disminuir el número de cupos del evento
         //var eventoActualizado = eventos.FirstOrDefault(e => e.idEvento == evento.idEvento);
         //if (eventoActualizado != null)
         //{
         //    eventoActualizado.cupos--;
         //}

         evento.cupos--; // Actualiza los cupos del evento
         eventoService.SaveData();
         solicitudesEventosService.SaveData();
      }




      // Enviar solicitud de asistencia de partido //David: ANDREAAAAA AGREGA ESTOOOOO 
      /// <summary>
      /// Enviar solicitud de asistencia a un partido.
      /// </summary>
      /// <param name="estudianteId"></param>
      /// <param name="partido"></param>
      /// <exception cref="InvalidOperationException"></exception>
      public static void EnviarSolicitudPartido(string estudianteId, Partido partido)
      {
         if (solicitudesPartidos.Any(s => s.EstudianteId == estudianteId && s.Partidos?.idEvento == partido.idEvento))
            throw new InvalidOperationException("Ya existe una solicitud para este partido.");

         if (partido.cupos <= 0)
            throw new InvalidOperationException("El partido ya no tiene cupos disponibles.");

         if (partido.estadoEvento != Partido.EstadoEvento.Disponible)
            throw new InvalidOperationException("El partido no está disponible para asistencia.");

         solicitudesPartidosService.Add(new SolicitudAsistencia
         {
            Id = "SP" + contadorSolicitudesPartidos++,
            EventoId = partido.idEvento,
            EstudianteId = estudianteId,
            Partidos = partido,
            EstadoSolicitud = SolicitudAsistencia.Estado.Pendiente,
            FechaSolicitud = DateTime.Now
         });

         //var partidoActualizado = partidos.FirstOrDefault(e => e.idEvento == partido.idEvento);
         //if (partidoActualizado != null)
         //{
         //    partidoActualizado.cupos--;
         //}

         partido.cupos--;
         partidoService.SaveData();
         solicitudesPartidosService.SaveData();
      }
      #endregion Envio de solicitudes de asistencia


      // MARK: Obtener eventos asistidos y partidos asistidos por un estudiante
      #region Obtener eventos asistidos y partidos asistidos
      /// <summary>
      /// Obtener eventos asistidos por un estudiante.
      /// </summary>
      /// <param name="estudianteId"></param>
      /// <returns></returns>
      public static List<Evento> ObtenerEventosAsistidos(string estudianteId)
      {
         var estudiante = estudiantes.FirstOrDefault(e => e.cifEstudiante == estudianteId);
         if (estudiante == null)
            return new List<Evento>();

         var eventosAprobados = solicitudesEventos
             .Where(s => s.EstudianteId == estudianteId && s.EstadoSolicitud == SolicitudAsistencia.Estado.Aprobado)
             .Select(s => s.Eventos)
             .ToList();

         // Sincronizar eventos aprobados con eventosAsistidos
         estudiante.eventosAsistidos = eventosAprobados.Select(e => e.idEvento).ToList();

         return eventosAprobados;
      }
      //DAVID: ANDREAAAAA AGREGA ESTOOOOO
      /// <summary>
      /// Obtener partidos asistidos por un estudiante.
      /// </summary>
      /// <param name="estudianteId"></param>
      /// <returns></returns>
      public static List<Partido> ObtenerPartidosAsistidos(string estudianteId)
      {
         if (estudiantes == null || estudiantes.Count == 0)
         {
            throw new InvalidOperationException("La lista de estudiantes no está inicializada.");
         }

         var estudiante = estudiantes.FirstOrDefault(e => e.cifEstudiante == estudianteId);
         if (estudiante == null)
            return new List<Partido>();

         if (solicitudesPartidos == null || solicitudesPartidos.Count == 0)
            return new List<Partido>();

         // Filtrar solicitudesEventos aprobadas y verificar que los partidos no sean nulos
         var partidosAprobados = solicitudesPartidos
             .Where(s => s.EstudianteId == estudianteId && s.EstadoSolicitud == SolicitudAsistencia.Estado.Aprobado && s.Partidos != null)
             .Select(s => s.Partidos)
             .Where(p => p != null) // Validar partidos no nulos
             .ToList();

         estudiante.partidosAsistidos = partidosAprobados
             .Select(p => p.idEvento)
             .ToList();

         return partidosAprobados;
      }

      #endregion Obtener eventos asistidos y partidos asistidos


      // MARK: Cargar solicitudes en ListView
      #region Cargar solicitudes en ListView
      /// <summary>
      /// Cargar las solicitudes de asistencia en un ListView.
      /// </summary>
      /// <param name="listView"></param>
      /// <exception cref="ArgumentNullException"></exception>
      /// <exception cref="InvalidOperationException"></exception>
      public static void CargarSolicitudesEnListViewEvento(ListView listView)
      {
         // Validar que el ListView no sea nulo
         if (listView == null)
         {
            throw new ArgumentNullException(nameof(listView), "El ListView proporcionado es nulo.");
         }

         // Validar que la lista de solicitudesEventos esté inicializada
         if (solicitudesEventos == null)
         {
            throw new InvalidOperationException("La lista de solicitudes no ha sido inicializada.");
         }

         // Limpiar el contenido del ListView
         listView.Items.Clear();

         // Iterar sobre las solicitudesEventos con índice
         foreach (var solicitud in solicitudesEventos)
         {
            var item = new ListViewItem(solicitud.Id.ToString());
            string nombreEvento = string.Empty;
            string idEvento = string.Empty;
            nombreEvento = solicitud.Eventos.nombreEvento;
            idEvento = solicitud.Eventos.idEvento;
            item.SubItems.Add(nombreEvento);
            item.SubItems.Add(idEvento);
            item.SubItems.Add(nombreEvento);
            item.SubItems.Add(solicitud.EstadoSolicitud.ToString());
            item.SubItems.Add(solicitud.FechaSolicitud.ToString("dd/MM/yyyy HH:mm"));
            listView.Items.Add(item);
         }
      }
      public static void CargarSolicitudesEnListViewPartidos(ListView listView)
      {
         // Validar que el ListView no sea nulo
         if (listView == null)
         {
            throw new ArgumentNullException(nameof(listView), "El ListView proporcionado es nulo.");
         }

         // Validar que la lista de solicitudesEventos esté inicializada
         if (solicitudesEventos == null)
         {
            throw new InvalidOperationException("La lista de solicitudes no ha sido inicializada.");
         }

         // Limpiar el contenido del ListView
         listView.Items.Clear();

         // Iterar sobre las solicitudesEventos con índice
         foreach (var solicitud in solicitudesPartidos)
         {
            var item = new ListViewItem(solicitud.Id.ToString());
            string nombreEvento = string.Empty;
            string idEvento = string.Empty;
            nombreEvento = solicitud.Partidos.nombreEvento;
            idEvento = solicitud.Partidos.idEvento;
            item.SubItems.Add(nombreEvento);
            item.SubItems.Add(idEvento);
            item.SubItems.Add(nombreEvento);
            item.SubItems.Add(solicitud.EstadoSolicitud.ToString());
            item.SubItems.Add(solicitud.FechaSolicitud.ToString("dd/MM/yyyy HH:mm"));
            listView.Items.Add(item);
         }
      }
      #endregion Cargar solicitudes en ListView


      //MARK: - Confirmar y rechazar solicitudes de asistencia
      #region Confirmar y rechazar solicitudes de asistencia
      /// <summary>
      /// Confirmar una solicitud de asistencia a un evento.
      /// </summary>
      /// <param name="solicitudId"></param>
      /// <returns></returns>
      public static string ConfirmarSolicitudEvento(string solicitudId)
      {
         var solicitud = solicitudesEventos.FirstOrDefault(s => s.Id == solicitudId);
         if (solicitud == null) return "No se encontró la solicitud.";

         if (solicitud.EstadoSolicitud == SolicitudAsistencia.Estado.Aprobado)
            return "La solicitud ya fue aprobada previamente.";

         var estudiante = estudiantes.FirstOrDefault(e => e.cifEstudiante == solicitud.EstudianteId);
         if (estudiante == null) return "No se encontró el estudiante asociado.";

         solicitud.EstadoSolicitud = SolicitudAsistencia.Estado.Aprobado;
         estudiante.eventosAsistidos.Add(solicitud.Eventos.idEvento); // Asigna el evento al estudiante
         estudiantesService.SaveData();
         solicitudesEventosService.SaveData();

         return "Solicitud confirmada y evento asignado al estudiante.";
      }

      public static string ConfirmarSolicitudPartidos(string solicitudId)
      {
         var solicitud = solicitudesPartidos.FirstOrDefault(s => s.Id == solicitudId);
         if (solicitud == null) return "No se encontró la solicitud.";

         if (solicitud.EstadoSolicitud == SolicitudAsistencia.Estado.Aprobado)
            return "La solicitud ya fue aprobada previamente.";

         var estudiante = estudiantes.FirstOrDefault(e => e.cifEstudiante == solicitud.EstudianteId);
         if (estudiante == null) return "No se encontró el estudiante asociado.";

         solicitud.EstadoSolicitud = SolicitudAsistencia.Estado.Aprobado;
         estudiante.partidosAsistidos.Add(solicitud.Partidos.idEvento); // Asigna el partido al estudiante
         estudiantesService.SaveData();
         solicitudesPartidosService.SaveData();

         return "Solicitud confirmada y partido asignado al estudiante.";
      }


      // Rechazar una solicitud
      public static string RechazarSolicitudEvento(string solicitudId)
      {
         var solicitud = solicitudesEventos.FirstOrDefault(s => s.Id == solicitudId);
         if (solicitud == null)
            return "No se encontró la solicitud.";

         // Cambiar estado a Rechazado
         solicitud.EstadoSolicitud = SolicitudAsistencia.Estado.Rechazado;

         // Guardar cambios
         solicitudesEventosService.SaveData();
         return "Solicitud rechazada correctamente.";
      }
      public static string RechazarSolicitudPartido(string solicitudId)
      {
         var solicitud = solicitudesPartidos.FirstOrDefault(s => s.Id == solicitudId);
         if (solicitud == null)
            return "No se encontró la solicitud.";

         // Cambiar estado a Rechazado
         solicitud.EstadoSolicitud = SolicitudAsistencia.Estado.Rechazado;

         // Guardar cambios
         solicitudesPartidosService.SaveData();
         return "Solicitud rechazada correctamente.";
      }

      #endregion Confirmar y rechazar solicitudes de asistencia

      //MARK: - Cargar eventos y partidos asistidos en ListView
      #region Cargar eventos y partidos asistidos en ListView
      /// <summary>
      /// Cargar eventos asistidos en un ListView.
      /// </summary>
      /// <param name="listView"></param>
      /// <param name="eventosAsistidos"></param>
      public static void CargarEventosAsistidos(ListView listView, List<Evento> eventosAsistidos)
      {
         listView.Items.Clear(); // Limpiar el control antes de cargar nuevos datos

         foreach (var evento in eventosAsistidos)
         {
            var item = new ListViewItem(evento.idEvento); // ID del evento
            item.SubItems.Add(evento.nombreEvento);       // Nombre del evento
            item.SubItems.Add(evento.tipoBeneficio.ToString());  // Tipo de convalidación
            item.SubItems.Add(evento.cantidadConvalidar.ToString()); // Horas convalidadas
            item.SubItems.Add(evento.horaEvento);         // Hora del evento
            item.SubItems.Add(evento.fechaEvento);        // Fecha del evento
            item.SubItems.Add(evento.lugarEvento);        // Lugar del evento
            item.SubItems.Add(evento.tipoEvento.ToString());         // Tipo del evento
            listView.Items.Add(item);
         }
      }

      //Cargar partidos asistidos en ListView
      public static void CargarPartidosAsistidos(ListView listView, List<Partido> partidosAsistidos)
      {
         listView.Items.Clear();

         if (partidosAsistidos == null || partidosAsistidos.Count == 0)
         {
            MessageBox.Show("No hay partidos asistidos registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
         }

         foreach (var partido in partidosAsistidos)
         {
            if (partido == null) continue; // Validar partidos no nulos

            var item = new ListViewItem(partido.idEvento); // ID del evento
            item.SubItems.Add(partido.nombrePartido ?? "N/A"); // Manejar nulos
            item.SubItems.Add(partido.cantidadConvalidar.ToString() ?? "0");
            item.SubItems.Add(partido.horaEvento ?? "N/A");
            item.SubItems.Add(partido.fechaEvento ?? "N/A");
            item.SubItems.Add(partido.lugarPartido ?? "N/A");
            item.SubItems.Add(partido.deporte.ToString());

            listView.Items.Add(item);
         }
      }

      #endregion Cargar eventos y partidos asistidos en ListView
      //public static List<Estudiante> estudiantes = CargarEstudiantesSincronizados();

      //MARK: - Sincronizar contadores
      /// <summary>
      /// Sincronizar los contadores de IDs de eventos y partidos.
      /// </summary>
      private static void SincronizarContadores()
      {
         if (eventos != null && eventos.Count > 0)
         {
            // Obtener el número más alto entre los IDs de eventos existentes
            eventoCounter = eventos.Max(e => int.Parse(e.idEvento.TrimStart('E'))) + 1;
         }

         if (partidos != null && partidos.Count > 0)
         {
            // Obtener el número más alto entre los IDs de partidos existentes
            partidoCounter = partidos.Max(p => int.Parse(p.idEvento.TrimStart('P'))) + 1;
         }

         if (solicitudesEventos != null && solicitudesEventos.Count > 0)
         {
            contadorSolicitudesEventos = solicitudesEventos.Max(s => int.Parse(s.Id.TrimStart("SE".ToCharArray()))) + 1;
         }

         if (solicitudesPartidos != null && solicitudesPartidos.Count > 0)
         {
            contadorSolicitudesPartidos = solicitudesPartidos.Max(s => int.Parse(s.Id.TrimStart("SP".ToCharArray()))) + 1;
         }
      }

      //MARK: - Configurar ReportViewer
      #region Configurar ReportViewer
      /// <summary>
      /// Configurar el ReportViewer con los eventos asistidos por un estudiante.
      /// </summary>
      /// <param name="reportViewer"></param>
      /// <param name="eventosAsistidos"></param>
      public static void ConfigurarReportViewer(ReportViewer reportViewer, List<Evento> eventosAsistidos)
      {
         // Crear un DataTable para los datos del reporte
         DataTable tablaEventos = new DataTable();
         tablaEventos.Columns.Add("TipoBeneficio", typeof(string));
         tablaEventos.Columns.Add("TipoEvento", typeof(string));
         tablaEventos.Columns.Add("NombreEvento", typeof(string));
         tablaEventos.Columns.Add("HoraEvento", typeof(string));
         tablaEventos.Columns.Add("LugarEvento", typeof(string));
         tablaEventos.Columns.Add("IdEvento", typeof(string));
         tablaEventos.Columns.Add("FechaEvento", typeof(string));

         // Llenar el DataTable con los eventos asistidos
         foreach (var evento in eventosAsistidos)
         {
            tablaEventos.Rows.Add(
                evento.tipoBeneficio,
                evento.tipoEvento.ToString(),
                evento.nombreEvento,
                evento.horaEvento,
                evento.lugarEvento,
                evento.idEvento,
                evento.fechaEvento
            );
         }

         // Configurar el ReportViewer
         reportViewer.LocalReport.DataSources.Clear();
         reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DsEvento", tablaEventos));
         reportViewer.RefreshReport();
      }

      public static void ConfigurarReportViewerParaPartidos(ReportViewer reportViewer, List<Partido> partidosAsistidos)
      {
         // Crear un DataTable para los datos del reporte
         DataTable tablaPartidos = new DataTable();
         tablaPartidos.Columns.Add("NombrePartido", typeof(string));
         tablaPartidos.Columns.Add("LugarPartido", typeof(string));
         tablaPartidos.Columns.Add("Rival", typeof(string));
         tablaPartidos.Columns.Add("Deporte", typeof(string));
         tablaPartidos.Columns.Add("TipoBeneficio", typeof(string));
         tablaPartidos.Columns.Add("TipoEvento", typeof(string));
         tablaPartidos.Columns.Add("NombreEvento", typeof(string));
         tablaPartidos.Columns.Add("HoraEvento", typeof(string));
         tablaPartidos.Columns.Add("LugarEvento", typeof(string));
         tablaPartidos.Columns.Add("IdEvento", typeof(string));
         tablaPartidos.Columns.Add("FechaEvento", typeof(string));

         // Llenar el DataTable con los partidos asistidos
         foreach (var partido in partidosAsistidos)
         {
            tablaPartidos.Rows.Add(
                partido.nombrePartido,
                partido.lugarPartido,
                partido.rival,
                partido.deporte.ToString(),
                partido.tipoBeneficio,
                partido.tipoEvento.ToString(),
                partido.nombreEvento,
                partido.horaEvento,
                partido.lugarEvento,
                partido.idEvento,
                partido.fechaEvento
            );
         }

         // Configurar el ReportViewer
         reportViewer.LocalReport.DataSources.Clear();
         reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DsPartidos", tablaPartidos));
         reportViewer.RefreshReport();
      }




      #endregion Configurar ReportViewer


      public static ReportViewer ConfigurarReportViewer()
      {
         ReportViewer reportViewer = new ReportViewer();

         // Configurar el reporte embebido
         reportViewer.LocalReport.ReportEmbeddedResource = "NombreProyecto.RptEvento.rdlc"; // Ajusta el namespace y nombre

         // Refrescar el reporte
         reportViewer.RefreshReport();

         return reportViewer;
      }

      public static void ExportarReporte(ReportViewer reportViewer, string formato)
      {
         try
         {
            string mimeType, encoding, fileNameExtension;
            Warning[] warnings;
            string[] streamIds;

            // Renderizar el reporte en el formato seleccionado
            byte[] bytes = reportViewer.LocalReport.Render(
                formato.ToUpper(), // Formato de exportación
                null,              // Parámetros del dispositivo
                out mimeType,
                out encoding,
                out fileNameExtension,
                out streamIds,
                out warnings);

            // Ruta donde se guardará el archivo exportado (en el escritorio)
            string rutaArchivo = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                $"RptEvento.{fileNameExtension}");

            // Guardar el archivo
            File.WriteAllBytes(rutaArchivo, bytes);

            // Mensaje de éxito
            MessageBox.Show($"Reporte exportado correctamente a {rutaArchivo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
         catch (Exception ex)
         {
            // Manejo de errores
            MessageBox.Show($"Error al exportar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
      }

      public static DataSet ObtenerDataSet()
      {
         // Crear un nuevo DataSet
         DataSet dataSet = new DataSet();

         // Crear una nueva DataTable para los datos de partidos
         DataTable tablaPartidos = new DataTable("NombreDeLaTabla");

         // Definir las columnas de la tabla (ajustar nombres y tipos según sea necesario)
         tablaPartidos.Columns.Add("IdEvento", typeof(string));
         tablaPartidos.Columns.Add("NombrePartido", typeof(string));
         tablaPartidos.Columns.Add("LugarPartido", typeof(string));
         tablaPartidos.Columns.Add("Deporte", typeof(string));
         tablaPartidos.Columns.Add("HoraEvento", typeof(string));
         tablaPartidos.Columns.Add("FechaEvento", typeof(string));
         tablaPartidos.Columns.Add("CantidadConvalidar", typeof(int));
         tablaPartidos.Columns.Add("Cupos", typeof(int));
         tablaPartidos.Columns.Add("EstadoEvento", typeof(string));

         // Obtener los datos de los partidos desde el servicio
         List<Partido> partidos = partidoService.GetAll() ?? new List<Partido>();

         // Llenar la DataTable con los datos de los partidos
         foreach (var partido in partidos)
         {
            tablaPartidos.Rows.Add(
                partido.idEvento,
                partido.nombrePartido,
                partido.lugarPartido,
                partido.deporte.ToString(),
                partido.horaEvento,
                partido.fechaEvento,
                partido.cantidadConvalidar,
                partido.cupos,
                partido.estadoEvento.ToString()
            );
         }

         // Agregar la DataTable al DataSet
         dataSet.Tables.Add(tablaPartidos);

         return dataSet;
      }


      //MARK: Registrar Usuario
      public static string RegistrarEstudiante(string cif, string contraseña, string nombre)
      {
         if (string.IsNullOrWhiteSpace(cif) || string.IsNullOrWhiteSpace(contraseña) || 
            string.IsNullOrWhiteSpace(nombre))
         {
            return "Todos los campos obligatorios deben estar completos y válidos.";
         }

         Estudiante nuevoEstudiante = new Estudiante
         {
            nombreEstudiante = nombre,
            cifEstudiante = cif,
            contraseñaEstudiante = contraseña

         };

         estudiantesService.Add(nuevoEstudiante);

         return $"Estudiante '{nombre}' registrado exitosamente con ID {cif}";
      }
      public static string RegistrarAdministrador(string cif, string contraseña, string nombre)
      {
         if (string.IsNullOrWhiteSpace(cif) || string.IsNullOrWhiteSpace(contraseña) ||
            string.IsNullOrWhiteSpace(nombre))
         {
            return "Todos los campos obligatorios deben estar completos y válidos.";
         }

         Administrador nuevoAdministrador = new Administrador
         {
            nombreAdministrador = nombre,
            cifAdministrador = cif,
            contraseñaAdministrador = contraseña

         };

         administradoresService.Add(nuevoAdministrador);

         return $"Estudiante '{nombre}' registrado exitosamente con ID {cif}";
      }
   }

   
}
