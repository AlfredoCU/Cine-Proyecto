//Framework c# son como las Bibliotecas en C++ la diferencia es que son más potentes
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Para poder utilizar comandos SQL SERVER
using System.Data.SqlClient;
//Mandamos a llamar las clases, pantallas y propiedad que son las carpetas que se realizaron ->
using Cine.Clases;
using Cine.Pantallas;
using Cine.Properties;
using Cine.Capa_de_Datos;
using Cine.Capa_de_Negocio;
using Cine.Capa_de_Presentación;
//MaterialSkin Para mejorar la vista al usuario
using MaterialSkin;
using MaterialSkin.Controls;

namespace Cine.Capa_de_Presentación
{
    public partial class VerCartelera : MaterialForm
    {
        ProcesosAsignarPeliculas funcionesAsignar = new ProcesosAsignarPeliculas();

        public VerCartelera()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE);
        }

        private void VerCartelera_Load(object sender, EventArgs e)
        {
            dgvListaCartelera.DataSource = funcionesAsignar.ListaCartelera();
            dgvListaCartelera.Columns[0].HeaderText = "Cartelera";
            dgvListaCartelera.Columns[2].HeaderText = "Película";
            dgvListaCartelera.Columns[4].HeaderText = "Hora de Fin";
        }

        private void dgvListaCartelera_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
