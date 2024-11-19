using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHours_UAMApp.Estructuras.Metodos
{
    public static class Metodos

    {
        // ==================Lista para prueba===================
        private static List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante { cifEstudiante = "12345", contraseñaEstudiante = "password1" },
            new Estudiante { cifEstudiante = "67890", contraseñaEstudiante = "password2" }
        };

        // ==================Login===================
        // Función para login de estudiante
        static public bool LoginEstudiante(string usuario, string contrasena) // Esta es una prueba gente 
        {
            // Se busca el estudiante en la lista de estudiantes
            var estudiante = estudiantes.FirstOrDefault(e => e.cifEstudiante == usuario);

            // Si se encuentra, se verifica que la contraseña sea correcta
            if (estudiante != null)
            {
                if (estudiante.contraseñaEstudiante == contrasena)
                {
                    return true; // Contraseña correcta
                }
                else
                {
                    return false; // Contraseña incorrecta
                }
            }

            // Si no se encuentra el estudiante, se devuelve false
            return false;
        }

        // Función para login de administrador
        static public bool LoginAdmin(string usuario, string contrasena)
        {
            // Se verifica que el usuario y la contraseña sean correctos
            if (usuario == "admin" && contrasena == "admin")
            {
                return true; // Usuario y contraseña correctos
            }
            else
            {
                return false; // Usuario y/o contraseña incorrectos
            }
        }


        // ==================Eventos==================
        // Función para registrar un nuevo evento
        // Función para editar un evento existente en la lista
        // Función para eliminar un evento de la lista según el índice


        // ==================Partidos==================
        // Función para registrar un nuevo partido
        // Función para editar un partido existente en la lista
        // Función para eliminar un partido de la lista según el índice


        // ==================Estudiantes==================
        // Funcion para enviar compronante de asistencia a un evento
        // Funcion para enviar combrobante de asistencia a un partido
        // Funcion para ver la lista de eventos a los que ha asistido un estudiante
        // Funcion para ver la lista de partidos a los que ha asistido un estudiante
        // Funcion para ver la cantidad de horas completadas por un estudiante

        //==================CRUD==================
        //-----------------Eventos----------------
        // Función para guardar la lista de eventos en un archivo binario
        // Función para cargar la lista de eventos desde un archivo binario

        //-------------------Partidos-------------------
        // Función para guardar la lista de partidos en un archivo binario
        // Función para cargar la lista de partidos desde un archivo binario

        //-------------------Estudiantes-------------------
        // Función para guardar la asistencia de la lista de eventos a los que ha asistido un estudiante
        // Función para guardar la asistencia de la lista de partidos a los que ha asistido un estudiante
        // Función para guardar la cantidad de horas completadas por un estudiante



    }
}
