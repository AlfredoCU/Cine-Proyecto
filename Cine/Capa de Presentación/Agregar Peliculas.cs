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
    public partial class AgregarPeliculas : MaterialForm
    {
        Peliculas dato = new Peliculas();
        ProcesosPeliculas funcion = new ProcesosPeliculas();

        public AgregarPeliculas()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE);
        }

        private void AgregarPeliculas_Load(object sender, EventArgs e)
        {
            controlesInicio();
        }

        public void controlesInicio()
        {
            this.txtTitulo.Clear();
            this.txtDuracion.Clear();
            this.cbGenero.SelectedIndex = -1;
            this.cbClasificacion.SelectedIndex = -1;
            this.cbFormato.SelectedIndex = -1;
            this.pbPortada.Image = null;
            this.gbDatos.Enabled = false;
            this.gbPortada.Enabled = false;
            this.btnNuevo.Visible = true;
            this.btnGuardar.Visible = false;
            this.btnSalir.Visible = true;
            this.btnCancelar.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (((txtTitulo.Text.Trim().Length == 0) || ((txtDuracion.Text.Trim().Length == 1)
                    || (!(cbGenero.SelectedIndex > -1) || (!(cbGenero.SelectedIndex > -1) || (!(cbFormato.SelectedIndex > -1)
                    || (pbPortada.Image == null)))))))
                {
                    MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dato.Titulo = txtTitulo.Text;
                dato.Duracion = txtDuracion.Text;
                // dato.Duracion = TimeSpan.Parse(txtDuracion.Text)
                dato.Genero = cbGenero.Text;
                dato.Clasificacion = cbClasificacion.Text;
                dato.Formato = cbFormato.Text;
                MemoryStream ms = new MemoryStream();

                if (!(pbPortada == null))
                {
                    pbPortada.Image.Save(ms, pbPortada.Image.RawFormat);
                }
                dato.Portada = ms.GetBuffer();
                if (funcion.GuardarPelicula(dato))
                {
                    MessageBox.Show("Película agregada con éxito.", "Película Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    controlesInicio();
                }
                else
                {
                    MessageBox.Show("Error al agregar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.gbDatos.Enabled = true;
            this.gbPortada.Enabled = true;
            this.btnNuevo.Visible = false;
            this.btnGuardar.Visible = true; 
            this.btnSalir.Visible = false;
            this.btnCancelar.Visible = true;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "Imagenes(*.jpg)|*.jpg|Imagenes(*.png)|*.png";
            filedialog.Title = "Elije la portada de la película";
            if ((filedialog.ShowDialog() == System.Windows.Forms.DialogResult.OK))
            {
                pbPortada.Image = new Bitmap(filedialog.FileName);
                pbPortada.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            controlesInicio();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}