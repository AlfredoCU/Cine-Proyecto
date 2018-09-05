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
    public partial class MantenimientoPeliculas : MaterialForm
    {
        ProcesosPeliculas funciones = new ProcesosPeliculas();
        Peliculas datos = new Peliculas();

        public MantenimientoPeliculas()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE);
        }

        private void MantenimientoPeliculas_Load(object sender, EventArgs e)
        {
            funciones.CargarPeliculasLista(lbListaPeliculas);
            HabilitarControles(false);
        }

        public int CodPelicula()
        {
            int Cod = Convert.ToInt32(lbListaPeliculas.SelectedValue.ToString());
            return Cod;
        }

        public void HabilitarControles(bool valor)
        {
            this.txtTitulo.Enabled = valor;
            this.txtDuracion.Enabled = valor;
            this.cbClasificacion.Enabled = valor;
            this.cbGenero.Enabled = valor;
            this.cbFormato.Enabled = valor;
            this.btnBuscar.Enabled = valor;
            this.btnEditar.Visible = !valor;
            this.btnGuardar.Visible = valor;
            this.btnEliminar.Visible = !valor;
            this.btnCancelar.Visible = valor;
        }

        private void lbListaPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = funciones.DetallePelicula(CodPelicula());
                txtTitulo.Text = tabla.Rows[0][0].ToString();
                txtDuracion.Text = tabla.Rows[0][1].ToString().Substring(1);
                //MsgBox(tabla.Rows(0).Item(1).ToString)
                //txtDuracion.Text = tabla.Rows(0).Item(1).ToString
                cbGenero.Text = tabla.Rows[0][2].ToString();
                cbClasificacion.Text = tabla.Rows[0][3].ToString();
                cbFormato.Text = tabla.Rows[0][4].ToString();
                byte[] i = (byte[])tabla.Rows[0][5];
                MemoryStream ms = new MemoryStream(i);
                pbPortada.Image = Image.FromStream(ms);
                pbPortada.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargó las películas: " + ex.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                HabilitarControles(false);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            HabilitarControles(false);
            try
            {
                if (((txtTitulo.Text.Trim().Length == 0) || ((txtDuracion.Text.Trim().Length == 1) 
                    || (!(cbGenero.SelectedIndex > -1) || (!(cbGenero.SelectedIndex > -1) || (!(cbFormato.SelectedIndex > -1)
                    || (pbPortada.Image == null)))))))
                {
                    MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ((MessageBox.Show("¿Desea Guardar los Datos Cambiados?", "A guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                {

                }
                else
                {
                    HabilitarControles(false);
                    return;
                }

                datos.Titulo = txtTitulo.Text;
                datos.Duracion = txtDuracion.Text;
                datos.Genero = cbGenero.Text;
                datos.Clasificacion = cbClasificacion.Text;
                datos.Formato = cbFormato.Text;

                MemoryStream ms = new MemoryStream();
                if (!(pbPortada.Image == null))
                {
                    pbPortada.Image.Save(ms, pbPortada.Image.RawFormat);
                }

                datos.Portada = ms.GetBuffer();
                if (funciones.EditarPelicula(CodPelicula(), datos))
                {
                    MessageBox.Show("Detalles guardados.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funciones.CargarPeliculasLista(lbListaPeliculas);
                }
                else
                {
                    MessageBox.Show("Detalles no guardados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarControles(true);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "Imagenes *.jpg|*.jpg|Imagenes *.png|*.png";
            if ((openfiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK))
            {
                pbPortada.Image = new Bitmap(openfiledialog.FileName);
                pbPortada.SizeMode = PictureBoxSizeMode.StretchImage;
                // PicPortada.ImageLocation = openfiledialog.FileName
            }
            else
            {
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Desea eliminar esta película?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
            {

            }
            else
            {
                HabilitarControles(false);
                return;
            }
            try
            {
                if (funciones.EliminarPelicula(CodPelicula()))
                {
                    MessageBox.Show("Película Eliminada.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funciones.CargarPeliculasLista(lbListaPeliculas);
                }
                else
                {
                    MessageBox.Show("Película No Eliminada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(false);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}