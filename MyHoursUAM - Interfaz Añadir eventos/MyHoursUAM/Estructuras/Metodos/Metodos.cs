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
    internal static class Metodos
    {
        private static List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante { cifEstudiante = "12345", contraseñaEstudiante = "password1" },
            new Estudiante { cifEstudiante = "67890", contraseñaEstudiante = "password2" }
        };

        private static List<Evento> eventos = new List<Evento>();
        private static List<Partido> partidos = new List<Partido>();

        public static bool LoginEstudiante(string usuario, string contrasena)
        {
            var estudiante = estudiantes.FirstOrDefault(e => e.cifEstudiante == usuario);
            if (estudiante != null)
            {
                if (estudiante.contraseñaEstudiante == contrasena)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static bool LoginAdmin(string usuario, string contrasena)
        {
            if (usuario == "admin" && contrasena == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void RegistrarEvento(string nombreEvento, string fechaEvento, string horaEvento, string lugarEvento, string descripcionEvento, string organizador, int horasConvalidas)
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
        }

        public static void EditarEvento(int indice, string nombreEvento, string fechaEvento, string horaEvento, string lugarEvento, string descripcionEvento, string organizador, int horasConvalidas)
        {
            if (indice >= 0 && indice < eventos.Count)
            {
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
        }

        public static void EliminarEvento(int indice)
        {
            if (indice >= 0 && indice < eventos.Count)
            {
                eventos.RemoveAt(indice);
            }
            else
            {
                throw new ArgumentOutOfRangeException("El índice proporcionado está fuera del rango de la lista de eventos.");
            }
        }

        public static void RegistrarPartido(string nombrePartido, string fechaPartido, string horaPartido, string lugarPartido, string descripcionPartido, string organizador, int horasConvalidas, string rival, Partido.TipoDeporte deporte)
        {
            Partido nuevoPartido = new Partido
            {
                nombreEvento = nombrePartido,
                fechaEvento = fechaPartido,
                horaEvento = horaPartido,
                lugarEvento = lugarPartido,
                descripcionEvento = descripcionPartido,
                organizadorEvento = organizador,
                horasConvalidas = horasConvalidas,
                rival = rival,
                deporte = (Partido.TipoDeporte)deporte
            };

            partidos.Add(nuevoPartido);
        }

        public static void EditarPartido(int indice, string nombrePartido, string fechaPartido, string horaPartido, string lugarPartido, string descripcionPartido, string organizador, int horasConvalidas, string rival, string deporteEvento)
        {
            if (indice >= 0 && indice < partidos.Count)
            {
                partidos[indice].nombreEvento = nombrePartido;
                partidos[indice].fechaEvento = fechaPartido;
                partidos[indice].horaEvento = horaPartido;
                partidos[indice].lugarEvento = lugarPartido;
                partidos[indice].descripcionEvento = descripcionPartido;
                partidos[indice].organizadorEvento = organizador;
                partidos[indice].horasConvalidas = horasConvalidas;
                partidos[indice].rival = rival;
            }
            else
            {
                throw new ArgumentOutOfRangeException("El índice proporcionado está fuera del rango de la lista de partidos.");
            }
        }

        public static void EliminarPartido(int indice)
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
    }
 
    
}
