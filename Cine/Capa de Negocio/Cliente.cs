using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Capa_de_Negocio
{
    class Cliente
    {
        private string nomCliente;
        private string apeCliente;
        private string dni; //Cambiar por tarjeta
        private int asiTrasLi;
        private int asiPreLi;
        private double monto;

        public string NomCliente
        {
            get { return nomCliente; }
            set { nomCliente = value; }
        }

        public string ApeCliente
        {
            get { return apeCliente; }
            set { apeCliente = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public int AsiTraLi
        {
            get { return asiTrasLi; }
            set { asiTrasLi = value; }
        }

        public int AsiPreLi
        {
            get { return asiPreLi; }
            set { asiPreLi = value; }
        }

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }
    }
}
