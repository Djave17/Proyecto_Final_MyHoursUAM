
using System;
using System.Collections.Generic;
using System.Linq;
using MyHours_UAMApp.Estructuras;

namespace MyHours_UAMApp.Estructuras.Metodos
{
    internal static class Metodos
    {
        private static List<Evento> eventos = new List<Evento>();
        private static int eventoCounter = 1; // Contador para IDs de eventos

        /// <summary>
        /// Devuelve todos los eventos como una lista.
        /// </summary>
        public static List<Evento> GetEventos()
        {
            return eventos;
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
            string tipoEvento,
            string tipoBeneficio,
            string nombreEvento,
            int cantidadConvalidar,
            int cupos,
            string horaEnvio,
            string hora,
            string fecha,
            string lugar)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(tipoEvento) ||
                string.IsNullOrWhiteSpace(tipoBeneficio) ||
                string.IsNullOrWhiteSpace(nombreEvento) ||
                string.IsNullOrWhiteSpace(horaEnvio) ||
                string.IsNullOrWhiteSpace(hora) ||
                string.IsNullOrWhiteSpace(fecha) ||
                string.IsNullOrWhiteSpace(lugar) ||
                cantidadConvalidar <= 0 ||
                cupos <= 0)
            {
                return "Todos los campos obligatorios deben estar completos y válidos.";
            }

            // Crear un nuevo evento
            Evento nuevoEvento = new Evento
            {
                idEvento = "E" + eventoCounter++,
                nombreEvento = nombreEvento,
                fechaEvento = fecha,
                horaEvento = hora,
                lugarEvento = lugar,
                descripcionEvento = $"Tipo: {tipoEvento}, Beneficio: {tipoBeneficio}",
                horasConvalidas = cantidadConvalidar,
                organizadorEvento = "Administrador", // Puede ser dinámico
            };

            eventos.Add(nuevoEvento);

            return $"Evento '{nombreEvento}' registrado exitosamente con ID {nuevoEvento.idEvento}.";
        }

        /// <summary>
        /// Edita un evento existente basado en su índice y nuevos datos.
        /// </summary>
        public static string EditarEvento(
            int indice,
            string tipoEvento,
            string tipoBeneficio,
            string nombreEvento,
            int cantidadConvalidar,
            int cupos,
            string horaEnvio,
            string hora,
            string fecha,
            string lugar)
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
                string.IsNullOrWhiteSpace(horaEnvio) ||
                string.IsNullOrWhiteSpace(hora) ||
                string.IsNullOrWhiteSpace(fecha) ||
                string.IsNullOrWhiteSpace(lugar) ||
                cantidadConvalidar <= 0 ||
                cupos <= 0)
            {
                return "Todos los campos obligatorios deben estar completos y válidos.";
            }

            // Editar el evento existente
            eventos[indice] = new Evento
            {
                idEvento = eventos[indice].idEvento, // Mantener el ID existente
                nombreEvento = nombreEvento,
                fechaEvento = fecha,
                horaEvento = hora,
                lugarEvento = lugar,
                descripcionEvento = $"Tipo: {tipoEvento}, Beneficio: {tipoBeneficio}",
                horasConvalidas = cantidadConvalidar,
                organizadorEvento = "Administrador",
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
            int cantidadConvalidar,
            int cupos,
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
                cantidadConvalidar <= 0 ||
                cupos <= 0)
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
                horasConvalidas = cantidadConvalidar,
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
            int cantidadConvalidar,
            int cupos,
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
                cantidadConvalidar <= 0 ||
                cupos <= 0)
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
                descripcionEvento = $"Hora de Envío: {horaEnvio}",
                horasConvalidas = cantidadConvalidar,
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
                p.descripcionEvento
            }).ToList();
        }
    }

}
