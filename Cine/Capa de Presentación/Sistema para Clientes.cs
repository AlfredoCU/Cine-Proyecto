using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Cine.Capa_de_Datos;
using Cine.Capa_de_Negocio;
using Cine.Capa_de_Presentación;

namespace Cine.Pantallas
{
    public partial class SistemaClientes : MaterialForm
    {
        public SistemaClientes(string cliente)
        {
            InitializeComponent();
            lblCliente.Text = cliente;
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE);
        }

        private void pbDulceria_Click(object sender, EventArgs e)
        {
            VerCartelera abrirPantalla = new VerCartelera();
            abrirPantalla.ShowDialog(); 
        }

        private void pbPelicula_Click(object sender, EventArgs e)
        {
            ListaPeliculas abrirPantalla = new ListaPeliculas();
            abrirPantalla.ShowDialog();
        }

        private void pbComprar_Click(object sender, EventArgs e)
        {
            Paso1Seleccióndepelículas abriPantalla = new Paso1Seleccióndepelículas();
            abriPantalla.ShowDialog();
        }

        private void PbSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Quiere salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
