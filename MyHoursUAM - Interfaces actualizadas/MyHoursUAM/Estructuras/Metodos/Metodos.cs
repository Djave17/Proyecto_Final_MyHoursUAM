using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//private System.Windows.Forms.Panel pnlPieArriba;
//private System.Windows.Forms.Label label1;
//private System.Windows.Forms.Panel pnlAreaAdministrador;
//private System.Windows.Forms.Panel panel1;
//private System.Windows.Forms.Panel panel2;
//private System.Windows.Forms.Button btnAjustes;
//private System.Windows.Forms.Button btnAsistencia;
//private System.Windows.Forms.Button btnVerEventos;
//private System.Windows.Forms.Button btnAñadirEventos;
//private System.Windows.Forms.Panel pnlIcon;
//private System.Windows.Forms.PictureBox pictureBox1;
//private System.Windows.Forms.GroupBox gpbNuevoEvento;
//private System.Windows.Forms.Button btnCancel;
//private System.Windows.Forms.Button btnGuardar;
//private System.Windows.Forms.TextBox txbCupos;
//private System.Windows.Forms.Label lblCupos;
//private System.Windows.Forms.TextBox txbLugar;
//private System.Windows.Forms.Label lblLugar;
//private System.Windows.Forms.Label lblRotulo2;
//private System.Windows.Forms.TextBox txbHorario;
//private System.Windows.Forms.Label lblHorario;
//private System.Windows.Forms.TextBox txbNameEvento;
//private System.Windows.Forms.Label nombreEvento;
//private System.Windows.Forms.RadioButton rbtAcademico;
//private System.Windows.Forms.RadioButton rbtExtracurricular;
//private System.Windows.Forms.RadioButton rbtClub;
//private System.Windows.Forms.Label lblTipodeEvento;
//private System.Windows.Forms.RadioButton rbtPartidos;
//private System.Windows.Forms.RadioButton rbtHorasLaborales;
//private System.Windows.Forms.Label lblTypeBeneficios;
//private System.Windows.Forms.Label lblCerrarSesion;
//private System.Windows.Forms.PictureBox pcbLogOutIcon;
//private System.Windows.Forms.Label lblAdmin;
//private System.Windows.Forms.PictureBox pictureBox2;
//private System.Windows.Forms.TextBox textBox1;
//private System.Windows.Forms.Label label2;

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

        // ==================Lista de eventos===================
        private static List<Evento> eventos = new List<Evento>();

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
        static public void RegistrarEvento(string nombreEvento, string fechaEvento, string horaEvento, string lugarEvento, string descripcionEvento, string organizador, int horasConvalidas)
        {

            Evento nuevoEvento = new Evento
            {
                nombreEvento = nombreEvento,
                fechaEvento = fechaEvento,
                horaEvento = horaEvento,
                lugarEvento = lugarEvento,
                descripcionEvento = descripcionEvento,
                organizadorEvento = organizador,
                horasConvalidas = horasConvalidas
            };

            eventos.Add(nuevoEvento);

            //Forma de llamar en documentacion: Metodos.RegistrarEvento("nombreEvento", "fechaEvento", "horaEvento", "lugarEvento", "descripcionEvento", "organizador", horasConvalidas);

        }
        // Función para editar un evento existente en la lista
        static public void EditarEvento(int indice, string nombreEvento, string fechaEvento, string horaEvento, string lugarEvento, string descripcionEvento, string organizador, int horasConvalidas)
        {
            if (indice >= 0 && indice < eventos.Count)
            {
                //Guardar la lista
                eventos[indice].nombreEvento = nombreEvento;
                eventos[indice].fechaEvento = fechaEvento;
                eventos[indice].horaEvento = horaEvento;
                eventos[indice].lugarEvento = lugarEvento;
                eventos[indice].descripcionEvento = descripcionEvento;
                eventos[indice].organizadorEvento = organizador;
                eventos[indice].horasConvalidas = horasConvalidas;

            }
            else
            {
                throw new ArgumentOutOfRangeException("El índice proporcionado está fuera del rango de la lista de eventos.");
            }

            //Forma de llamar en documentacion: Metodos.EditarEvento(indice, "nombreEvento", "fechaEvento", "horaEvento", "lugarEvento", "descripcionEvento", "organizador", horasConvalidas);
        }

        // Función para eliminar un evento de la lista según el índice
        static public void EliminarEvento(int indice)
        {
            if (indice >= 0 && indice < eventos.Count)
            {
                eventos.RemoveAt(indice);
            }
            else
            {
                throw new ArgumentOutOfRangeException("El índice proporcionado está fuera del rango de la lista de eventos.");
            }
            //Forma de llamar en documentacion: Metodos.EliminarEvento(indice);
        }

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
