using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Cine.Capa_de_Datos;
using Cine.Capa_de_Negocio;
using Cine.Capa_de_Presentación;
using Cine.Capa_de_Reporte;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Cine.Capa_de_Presentación
{
    public partial class ReporteVentas : MaterialForm
    {
        Reportes re = new Reportes();
        Validar v = new Validar();

        public ReporteVentas()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this).
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            // Configure color schema 1.
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE);
        }

        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            this.btnEliminar.Enabled = false;
            re.CargarReportes(dgvReporte);
            dgvReporte.Columns[0].HeaderText = "Código Reporte";
            dgvReporte.Columns[1].HeaderText = "Nombre";
            dgvReporte.Columns[2].HeaderText = "Apellido";
            re.CargarTotal(dgvTotal);
        }

        private void dgvReporte_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dgvTotal_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            if(txtNombreCliente.Text != " ")
            {
                dgvReporte.DataSource = re.BuscarCliente(txtNombreCliente.Text);
            }
        }

        private bool EliminarCodReporte()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtEliminar.Text);
        }

        private void txtEliminar_TextChanged(object sender, EventArgs e)
        {
            if (EliminarCodReporte())
            {
                this.txtEliminar.BackColor = Color.White;
                this.btnEliminar.Enabled = true;
            }
            else
            {
                this.txtEliminar.BackColor = Color.White;
                this.btnEliminar.Enabled = false;
            }
        }

        private void txtEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (re.EliminarReporte(txtEliminar.Text))
            {
                MessageBox.Show("Datos eliminados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                re.CargarReportes(dgvReporte);
                re.CargarTotal(dgvTotal);
            }
            else
            {
                MessageBox.Show("Los datos no se pudieron eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminar.Enabled = false;
            }
            this.txtEliminar.BackColor = Color.White;
            this.txtEliminar.Clear();
            this.txtNombreCliente.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ReporteVenta abrirPantalla = new ReporteVenta();
            abrirPantalla.ShowDialog();
        }

        private void btnSalirReporte_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}