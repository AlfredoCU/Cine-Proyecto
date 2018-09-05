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

namespace Cine.Capa_de_Presentación
{
    public partial class ListaPeliculas : MaterialForm
    {
        ProcesosPeliculas funcion = new ProcesosPeliculas();

        public ListaPeliculas()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE);
        }

        private void ListaPeliculas_Load(object sender, EventArgs e)
        {
            dgvPeliculas.DataSource = funcion.ListaPeliculas();
            dgvPeliculas.Columns[0].HeaderText = "Titulo de Película";
            dgvPeliculas.Columns[1].HeaderText = "Duración";
            dgvPeliculas.Columns[2].HeaderText = "Clasificación";
        }

        private void dgvPeliculas_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void txtTituloBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtTituloBuscar.Text != " ")
            {
                dgvPeliculas.DataSource = funcion.BuscarPelicula(txtTituloBuscar.Text);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
