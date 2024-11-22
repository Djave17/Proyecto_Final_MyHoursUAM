using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyHours_UAMApp.Estructuras.Evento;

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
        private static List<HorasLaborales> eventos = new List<HorasLaborales>();


        // ==================Lista de partidos===================
        private static List<Partidos> partidos = new List<Partidos>();

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


        // Función para registrar un nuevo partido
         public static void RegistrarPartido(string nombrePartidos, string fechaPartidos, string horaPartidos, int horasConvalidas, string organizadorPartidos, string lugarPartidos, string rival, string deporteEvento, int cupos)
        {
            Partidos nuevoPartido = new Partidos
            {
                nombrePartidos = nombrePartidos,
                fechaPartidos = fechaPartidos,
                horaPartidos = horaPartidos,
                horasConvalidas = horasConvalidas,
                organizadorPartidos = organizadorPartidos,
                lugarPartidos = lugarPartidos,
                deporteEvento = deporteEvento,
                rival = rival,
                cupos = cupos
            };

            partidos.Add(nuevoPartido);
            //Forma de llamar en documentacion: Metodos.RegistrarPartido("nombrePartido", "fechaPartido", "horaPartido", "lugarPartido", "descripcionPartido", "organizador", horasConvalidas, "rival", "deporteEvento");
        }

        public static IEnumerable<object> ObtenerPartidosProyectados()
        {
            return partidos.Select(p => new
            {
                Nombre  = p.nombrePartidos,
                Fecha = p.fechaPartidos,
                Hora = p.horaPartidos,
                Organizador = p.organizadorPartidos,
                Lugar = p.lugarPartidos,
                Rival = p.rival,
                Deporte = p.deporteEvento,
                Cupos = p.cupos
            });
        }


        // Función para editar un partido existente
        static public void EditarPartido(int indice, string nombrePartidos, string fechaPartidos, string horaPartidos,  int horasConvalidas, string organizadorPartidos, string lugarPartidos, string rival, string deporteEvento, int cupos)
        {
            if (indice >= 0 && indice < partidos.Count)
            {
                partidos[indice].nombrePartidos = nombrePartidos;
                partidos[indice].fechaPartidos = fechaPartidos;
                partidos[indice].horaPartidos = horaPartidos;
                partidos[indice].horasConvalidas = horasConvalidas;
                partidos[indice].organizadorPartidos = organizadorPartidos;
                partidos[indice].lugarPartidos = lugarPartidos;
                partidos[indice].rival = rival;
                partidos[indice].deporteEvento = deporteEvento;
                partidos[indice].cupos = cupos;
            }
            else
            {
                throw new ArgumentOutOfRangeException("El índice proporcionado está fuera del rango de la lista de partidos.");
            }
        }

        // Función para eliminar un partido existente
        static public void EliminarPartido(int indice)
        {
            if (indice >= 0 && indice < partidos.Count)
            {
                partidos.RemoveAt(indice);
            }
            else
            {
                throw new ArgumentOutOfRangeException("El índice proporcionado está fuera del rango de la lista de partidos.");
            }
        }

        // Función para registrar nuevas horas laborales
        static public void RegistrarHoras(string area, string fecha, string horario, string lugar, string actividadDisponible, int cupos, int cantidadConvalidada, string descripcion)
        {
            HorasLaborales nuevaHora = new HorasLaborales
            {
                AreaHoras = area,
                FechaHoras = fecha,
                HorarioHoras = horario,
                LugarHoras = lugar,
                ActividadDispo = actividadDisponible,
                CuposHoras = cupos,
                CantidadConv = cantidadConvalidada,
                DescripcionHoras = descripcion 
            };

            eventos.Add(nuevaHora);
        }

        public static IEnumerable<object> ObtenerHorasLaborales()
        {
            return eventos.Select(e => new
            {
                Area = e.AreaHoras,
                Fecha = e.FechaHoras,
                Hora = e.HorarioHoras,
                Lugar = e.CuposHoras,
                Actividad = e.ActividadDispo,
                Cupos = e.CuposHoras,
                CantidadConvalidada = e.CantidadConv,
                Descripcion = e.DescripcionHoras
            });
        }

        // Función para editar horas laborales existentes
        static public void EditarHoras(int indice, string area, string fecha, string horario, string lugar, string actividadDisponible, int cupos, int cantidadConvalidada, string descripcion)
        {
            if (indice >= 0 && indice < eventos.Count)
            {
                eventos[indice].AreaHoras = area;
                eventos[indice].FechaHoras = fecha;
                eventos[indice].HorarioHoras = horario;
                eventos[indice].LugarHoras = lugar;
                eventos[indice].ActividadDispo = actividadDisponible;
                eventos[indice].CuposHoras = cupos;
                eventos[indice].CantidadConv = cantidadConvalidada;
                eventos[indice].DescripcionHoras = descripcion;
            }
            else
            {
                throw new ArgumentOutOfRangeException("El índice proporcionado está fuera del rango de la lista de horas laborales.");
            }
        }

        // Función para eliminar horas laborales existentes
        static public void EliminarHoras(int indice)
        {
            if (indice >= 0 && indice < eventos.Count)
            {
                eventos.RemoveAt(indice);
            }
            else
            {
                throw new ArgumentOutOfRangeException("El índice proporcionado está fuera del rango de la lista de horas laborales.");
            }
        }


        //====================Administrador====================
        // Funcion para aprobar solicitud de asistencia a un evento



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
