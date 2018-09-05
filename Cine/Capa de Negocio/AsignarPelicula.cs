using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Capa_de_Negocio
{
    class AsignarPelicula
    {
        private int codPelicula;
        private int codSala;
        private string horaInicio;
        private string horaFin;

        public int CodPelicula
        {
            get { return codPelicula; }
            set { codPelicula = value; }
        }

        public int CodSala
        {
            get { return codSala; }
            set { codSala = value; }
        } 

        public string HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }

        public string HoraFin
        {
            get { return horaFin; }
            set { horaFin = value; }
        }
    }
}