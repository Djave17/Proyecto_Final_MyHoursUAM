using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHours_UAMApp.Estructuras;

namespace MyHours_UAMApp.Estructuras
{
    internal class SesionActual: Estudiante
    {
        // Propiedad para almacenar el usuario autenticado
        public static Estudiante EstudianteActual { get; set; }
        public static Administrador AdministradorActual { get; set; }

        // Método para determinar si es un estudiante activo
        public static bool EsEstudiante()
        {
            return EstudianteActual != null;
        }

        // Método para determinar si es un administrador activo
        public static bool EsAdministrador()
        {
            return AdministradorActual != null;
        }

        // Limpiar la sesión actual
        public static void LimpiarSesion()
        {
            EstudianteActual = null;
            AdministradorActual = null;
        }

    }
}
