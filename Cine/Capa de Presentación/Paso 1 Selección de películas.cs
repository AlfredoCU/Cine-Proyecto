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
    public partial class Paso1Seleccióndepelículas : MaterialForm
    {
        ProcesosPeliculas funcionesP = new ProcesosPeliculas();
        ProcesosVenta funVenta = new ProcesosVenta();
        AsignarPelicula datos = new AsignarPelicula();
        Codigos datosCod = new Codigos();
         
        public Paso1Seleccióndepelículas()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE);
        }

        private void Paso1Seleccióndepelículas_Load(object sender, EventArgs e)
        {
            funVenta.ListaPeliculas(cbPelicula);
        }
        
        public int Dar_Cod(ComboBox cbo)
        {
            int Cod = Convert.ToInt32(cbo.SelectedValue.ToString());
            return Cod;
        }

        public void DetalleSalida()
        {
            try
            {
                DataTable tabla = new DataTable();
                datos.CodPelicula = Dar_Cod(cbPelicula);
                datos.CodSala = Dar_Cod(cbSala);
                datos.HoraInicio = cbHora.Text;
                tabla = funVenta.DetalleSalida(datos);
                lblAP.Text = tabla.Rows[0][4].ToString();
                lblAT.Text = tabla.Rows[0][5].ToString();
                datosCod.CodCartelera = Convert.ToInt32(tabla.Rows[0][2].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error detalle salida: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = funcionesP.DetallePelicula(Dar_Cod(cbPelicula));
                lblDuracion.Text = tabla.Rows[0][1].ToString().Substring(1);
                lblGenero.Text = tabla.Rows[0][2].ToString();
                lblClasificacion.Text = tabla.Rows[0][3].ToString();
                lblFormato.Text = tabla.Rows[0][4].ToString();
                byte[] i = (byte[])tabla.Rows[0][5];

                MemoryStream ms = new MemoryStream(i);
                pbPortada.Image = Image.FromStream(ms);
                pbPortada.SizeMode = PictureBoxSizeMode.StretchImage;
                funVenta.ListaSalas(cbSala, Dar_Cod(cbPelicula));
                DetalleSalida();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargó las películas: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = funVenta.SalaDetalle(Dar_Cod(cbPelicula), Dar_Cod(cbSala));
                cbHora.DisplayMember = "HoraInicio";
                cbHora.DataSource = tabla;
                DetalleSalida();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargó las salas: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetalleSalida();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {  
            try
            {
                Paso2DatosCliente V2DatosCliente = new Paso2DatosCliente();
                V2DatosCliente.cod_Cartelera = Convert.ToInt32(datosCod.CodCartelera.ToString());
                V2DatosCliente.mpex = Convert.ToInt32(lblAP.Text);
                V2DatosCliente.mtex = Convert.ToInt32(lblAT.Text);
                V2DatosCliente.NomPelicula = cbPelicula.Text;
                this.Close();
                V2DatosCliente.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}