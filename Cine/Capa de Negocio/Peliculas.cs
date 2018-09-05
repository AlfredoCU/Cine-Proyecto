using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Capa_de_Negocio
{
    class Peliculas
    {
        private string titulo;
        private string duracion;
        private string genero;
        private string clasificacio;
        private string formato;
        private byte[] portada;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
    
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public string Clasificacion
        {
            get { return clasificacio; }
            set { clasificacio = value; }
        }

        public string Formato
        {
            get { return formato; }
            set { formato = value; }
        }

        public byte[] Portada
        {
            get { return portada; }
            set { portada = value; }
        }
    }
}
