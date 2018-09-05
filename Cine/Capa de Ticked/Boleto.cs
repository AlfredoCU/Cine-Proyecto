using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.Capa_de_Ticked
{
    public partial class Boleto : Form
    {
        private int codRegistro;
        public int CodRegistro
        {
            get { return codRegistro; }
            set { codRegistro = value; }
        }

        public Boleto()
        {
            InitializeComponent();
        }

        private void Boleto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbBoleto.Boletos' Puede moverla o quitarla según sea necesario.
            this.BoletosTableAdapter.Fill(this.dbBoleto.Boletos, codRegistro);
            this.rvBoleto.RefreshReport();
        }
    }
}
