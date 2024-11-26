﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using static MyHours_UAMApp.Estructuras.Evento;

namespace MyHours_UAMApp.Estructuras.Metodos
{
    internal static class Metodos
    {
        private static List<Evento> eventos = new List<Evento>();
        private static int eventoCounter = 1; // Contador para IDs de eventos
        private static int partidoCounter = 1; // Contador para IDs de partidos

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
        private static List<Partido> partidos = new List<Partido>();

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

            // Verificar si el estudiante ya ha asistido al evento
            var estudiante = BuscarEstudiante(cifEstudiante); // Método que busca al estudiante
            if (estudiante == null)
            {
                throw new InvalidOperationException("Estudiante no encontrado.");
            }

            if (estudiante.eventosAsistidos.Contains(evento.idEvento))
            {
                return $"El estudiante ya asistió al evento '{evento.nombreEvento}'.";
            }

            // Registrar asistencia
            estudiante.eventosAsistidos.Add(evento.idEvento);
            estudiante.asistencia.horasCompletadas += evento.cantidadConvalidar;

            // Actualizar cupos del evento
            evento.cupos--;
            if (evento.cupos <= 0)
            {
                evento.estadoEvento = Evento.EstadoEvento.No_Disponible;
            }

            return $"Asistencia registrada exitosamente para el evento '{evento.nombreEvento}'.";
        }

        // Método auxiliar para buscar un estudiante (simulación de búsqueda)
        private static Estudiante BuscarEstudiante(string cifEstudiante)
        {
            // Aquí se buscaría en la base de datos o lista de estudiantes
            // Por ahora, retornar un estudiante de ejemplo
            return new Estudiante
            {
                cifEstudiante = cifEstudiante,
                eventosAsistidos = new List<string>(),
                asistencia = new Asistencia()
            };
        }
    }

}
