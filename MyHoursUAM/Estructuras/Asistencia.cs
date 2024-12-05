using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHours_UAMApp.Estructuras
{
   [Serializable]
   internal class Asistencia
    {
        //Aca se debe de guadar el comprobante de la asistencia (imagen) y al estudiante que pertenece

        public bool asistencia { get; set; }
        public byte[] comprobanteAsistencia { get; set; }
        public int cantidadDePartidosAsistidos { get; set; }
        public string eventosAsistidos { get; set; }
        public string partidosAsistidos { get; set; }
        public int horasCompletadas { get; set; }

        public SolicitudAsistencia solicitudAsistencia { get; set; }




    }
}
