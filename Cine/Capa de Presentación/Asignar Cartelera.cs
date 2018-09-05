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
    public partial class AsignarCartelera : MaterialForm
    {
        AsignarPelicula dato = new AsignarPelicula();
        ProcesosAsignarPeliculas funcionesAsignar = new ProcesosAsignarPeliculas();
        ProcesosPeliculas funciones = new ProcesosPeliculas();
        Validar v = new Validar();

        public AsignarCartelera()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE);
        }

        private void AsignarCartelera_Load(object sender, EventArgs e)
        {
            this.txtHoraFin.Enabled = false;
            funciones.CargarPeliculasLista(cbPelicula);
            funciones.CargarSalaLista(cbSala);
            ControlesIniciales();
            this.btnEliminar.Enabled = false;
            dgvListaCartelera.DataSource = funcionesAsignar.ListaCartelera();
            dgvListaCartelera.Columns[0].HeaderText = "Código Cartelera";
            dgvListaCartelera.Columns[2].HeaderText = "Película";
            dgvListaCartelera.Columns[4].HeaderText = "Hora de Fin";
        }

        private void dgvListaCartelera_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void ControlesIniciales()
        {
            this.btnValidar.BackColor = Color.Transparent;
            this.gbDatos.Enabled = false;
            this.btnNuevo.Visible = true;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.txtHora.Clear();
            this.txtMinuto.Clear();
            this.txtHoraFin.Clear();
        }

        public int CodPelicula(ListControl ComboCod)
        {
            int Cod = Convert.ToInt32(ComboCod.SelectedValue.ToString());
            return Cod;
        }

        public bool PermisoGenerar()
        {
            if ((this.txtHora.Text.Trim() != "") && (this.txtMinuto.Text.Trim() != ""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void GenerarHoraFinal()
        {
            // SACAMOS LA HORA Y LOS MINUTOS DE LA HORA DURACION
            int i, hd, md;
            i = (txtDuracion.Text.IndexOf(":") + 1);
            hd = Convert.ToInt32(txtDuracion.Text.Substring(0, i - 1));
            md = Convert.ToInt32(txtDuracion.Text.Substring(i, 2));

            // SACAMOS LA HORA Y LOS MINUTOS DE LA HORA INICIAL
            int hi, mi;
            hi = Convert.ToInt32(this.txtHora.Text);
            mi = Convert.ToInt32(this.txtMinuto.Text);

            // CREAMOS LA HORA FINAL
            string mtexto;
            int he, Minutos, hf, mf;
            Minutos = (md + mi) + 30; // 30 minutos para limpiar la sala de cien.

            if ((hd + hi) > 23)
            {
                MessageBox.Show("Error de hora, escoja otra por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoraFin.Clear();
                return;
            }
            if (Minutos < 60)
            {
                hf = hd + hi;
                mf = Minutos;
            }
            else
            {
                he = Minutos / 60;
                hf = hd + hi + he;
                mf = Minutos % 60;
            }
            if (hf > 23)
            {
                MessageBox.Show("Error de hora, escoja otra por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoraFin.Clear();
                return;
            }
            if (mf < 10)
            {
                mtexto = "0" + Convert.ToString(mf);
            }
            else
            {
                mtexto = Convert.ToString(mf); //ToInt
            }
            txtHoraFin.Text = string.Concat(Convert.ToString(hf),":",mtexto); ///ERROR NO MUESTRA LA HORA FINAL
        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {
            if (PermisoGenerar())
            {
                GenerarHoraFinal();
                btnValidar.BackColor = Color.Green;
                btnGuardar.Enabled = false;
            }
            else
            {
                txtHoraFin.Clear();
            }
        }

        private void txtMinuto_TextChanged(object sender, EventArgs e)
        {
            if (PermisoGenerar())
            {
                GenerarHoraFinal();
                btnValidar.BackColor = Color.Green;
            }
            else
            {
                txtHoraFin.Clear();
            }
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
            {
                this.btnEliminar.Enabled = false;
            }
            else
            {
                this.btnEliminar.Enabled = true;
            }
        }

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtMinuto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void cbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = funciones.DetallePelicula(CodPelicula(cbPelicula));
                txtDuracion.Text = tabla.Rows[0][1].ToString().Substring(1); 
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
                // HabilitarControles(False)
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDuracion.Text.Trim() == "" || txtHora.Text.Trim() == "" || txtMinuto.Text.Trim() == ""
                    || txtHoraFin.Text.Trim() == "")
                {
                    MessageBox.Show("Verifique que las horas sean validas.", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dato.CodSala = CodPelicula(cbSala);
                dato.HoraInicio = (txtHora.Text + (":" + txtMinuto.Text));
                dato.HoraFin = txtHoraFin.Text;

                if (funcionesAsignar.ValidarCartelera(dato))
                {
                    MessageBox.Show("La hora es correcta.", "Hora correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("La hora se cruza con otra, por favor cambie la hora de inicio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGuardar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en validar la hora: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (((txtDuracion.Text.Trim() == "") || ((txtHora.Text.Trim() == "") || ((txtMinuto.Text.Trim() == "")
                    || (txtHoraFin.Text.Trim() == "")))))
                {
                    MessageBox.Show("Verifique que las horas sean validas.", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dato.CodSala = CodPelicula(cbSala);
                dato.CodPelicula = CodPelicula(cbPelicula);
                dato.HoraInicio = (txtHora.Text + (":" + txtMinuto.Text));
                dato.HoraFin = txtHoraFin.Text;

                if (funcionesAsignar.AgregarCartelera(dato))
                {
                    MessageBox.Show("Datos Agregados Correctamente.", "Agregados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvListaCartelera.DataSource = funcionesAsignar.ListaCartelera();
                    ControlesIniciales();
                }
                else
                {
                    MessageBox.Show("Datos No Agregados Correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgvListaCartelera.DataSource = funcionesAsignar.ListaCartelera();
                    ControlesIniciales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al a guardar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = false;
            btnGuardar.Visible = true;
            btnCancelar.Enabled = true;
            gbDatos.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtCod.Text);
            if (funcionesAsignar.EliminarCartelera(cod))
            {
                MessageBox.Show("Cartelera eliminada exitosamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListaCartelera.DataSource = funcionesAsignar.ListaCartelera();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar cartelera.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvListaCartelera.DataSource = funcionesAsignar.ListaCartelera();
            }
            this.btnEliminar.Enabled = false;
            this.txtCod.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControlesIniciales();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}