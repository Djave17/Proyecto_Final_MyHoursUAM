
using System;
using System.Collections.Generic;
using System.Linq;
using static MyHours_UAMApp.Estructuras.Evento;

namespace MyHours_UAMApp.Estructuras.Metodos
{
    internal static class Metodos
    {
        private static List<Evento> eventos = new List<Evento>();
        private static int eventoCounter = 1; // Contador para IDs de eventos

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
            
            string tipoDeporte,
            string nombrePartido,
            int cantidadAConvalidar,
            int cupo,
            string horaEnvio,
            string hora,
            string fecha,
            string lugar,
            string rival)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(tipoDeporte) ||
                string.IsNullOrWhiteSpace(nombrePartido) ||
                string.IsNullOrWhiteSpace(horaEnvio) ||
                string.IsNullOrWhiteSpace(hora) ||
                string.IsNullOrWhiteSpace(fecha) ||
                string.IsNullOrWhiteSpace(lugar) ||
                string.IsNullOrWhiteSpace(rival) ||
                cantidadAConvalidar <= 0 ||
                cupo <= 0)
            {
                return "Todos los campos obligatorios deben estar completos y válidos.";
            }

            // Crear un nuevo partido
            Partido nuevoPartido = new Partido
            {
                nombrePartido = nombrePartido,
                lugarPartido = lugar,
                rival = rival,
                deporte = Enum.TryParse(tipoDeporte, true, out Partido.TipoDeporte deporteEnum)
                    ? deporteEnum
                    : Partido.TipoDeporte.futbol, // Valor predeterminado
                fechaEvento = fecha,
                horaEvento = hora,
                descripcionEvento = $"{horaEnvio}",
                cantidadConvalidar = cantidadAConvalidar,
                cupos = cupo,
                organizadorEvento = "Administrador", // Puede ser dinámico
            };

            partidos.Add(nuevoPartido);

            return $"Partido '{nombrePartido}' registrado exitosamente.";
        }

        /// <summary>
        /// Edita un partido existente basado en su índice.
        /// </summary>
        public static string EditarPartido(
            int indice,
            string tipoDeporte,
            string nombrePartido,
            int cantidadAConvalidar,
            int cupo,
            string horaEnvio,
            string hora,
            string fecha,
            string lugar,
            string rival)
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
                string.IsNullOrWhiteSpace(rival) ||
                cantidadAConvalidar <= 0 ||
                cupo <= 0)
            {
                return "Todos los campos obligatorios deben estar completos y válidos.";
            }

            // Editar el partido existente
            partidos[indice] = new Partido
            {
                nombrePartido = nombrePartido,
                lugarPartido = lugar,
                rival = rival,
                deporte = Enum.TryParse(tipoDeporte, true, out Partido.TipoDeporte deporteEnum)
                    ? deporteEnum
                    : Partido.TipoDeporte.futbol, // Valor predeterminado
                fechaEvento = fecha,
                horaEvento = hora,
                cantidadConvalidar = cantidadAConvalidar,
                cupos = cupo,
                organizadorEvento = "Administrador",
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
                p.nombrePartido,
                p.lugarPartido,
                p.deporte.ToString(),
                p.horaEvento,
                p.fechaEvento,
                p.descripcionEvento,
                p.cantidadConvalidar.ToString(),
                p.cupos.ToString(),

            }).ToList();
        }
    }

}
