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
    public partial class VistaSala : MaterialForm
    {
        ProcesosPeliculas funciones = new ProcesosPeliculas();
        ProcesosVenta funVentas = new ProcesosVenta();
        ProcesosAsignarPeliculas funAsignar = new ProcesosAsignarPeliculas();
        AsignarPelicula datos = new AsignarPelicula();

        public int codSala;
        int codCartelera;
        DataTable tabla;

        public VistaSala()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE);
        }

        private void VistaSala_Load(object sender, EventArgs e)
        {
            PeliculasPorSala();
            GenerarButon();
            this.btnVaciarSala.Enabled = false;
        }

        public int DarCodPelicula()
        {
            try
            {
                int i = Convert.ToInt32(cbPeliculas.SelectedValue.ToString());
                return i;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de dar código de películas: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public void PeliculasPorSala()
        {
            try
            {
                tabla = funciones.PeliculasPorSala(codSala, cbPeliculas);
                for (int i = 0; i <= tabla.Rows.Count -1; i++)
                {
                    if ((Convert.ToInt32(tabla.Rows[i][1].ToString()) == DarCodPelicula()))
                    {
                        lblHora.Text = tabla.Rows[i][2].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de películas por sala: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int DarCodCartelera()
        {
            try
            {
                datos.CodSala = codSala;
                datos.CodPelicula = DarCodPelicula();
                datos.HoraInicio = lblHora.Text;
                DataTable tabla = new DataTable();
                tabla = funVentas.DetalleSalida(datos);
                codCartelera = Convert.ToInt32(tabla.Rows[0][2].ToString());
                return codCartelera;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de dar código de cartelera: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public void CargarSala()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = funVentas.CargarSala(DarCodCartelera());
                foreach (Button boton in gbPreferencial.Controls)
                {
                    if (boton.GetType() == typeof(Button))
                    {
                        boton.BackColor = Color.Transparent;
                    }
                }
                foreach (Button boton in gbTradicional.Controls)
                {
                    if (boton.GetType() == typeof(Button))
                    {
                        boton.BackColor = Color.Transparent;
                    }

                }
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    foreach (Control boton in gbPreferencial.Controls)
                    {
                        if (boton.GetType() == typeof(Button))
                        {
                            if (dt.Rows[i][1].ToString() == boton.Name)
                            {
                                boton.BackColor = Color.Red;
                            }
                        }
                    }
                    foreach (Control boton in gbTradicional.Controls)
                    {
                        if (boton.GetType() == typeof(Button))
                        {
                            if (dt.Rows[i][1].ToString() == boton.Name)
                            {
                                boton.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No carga salas: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerarButon()
        {
            int b = 1;
            //int extraf = 0;
            int extrac = 0;
            for (int x = 0; x <= 270; x = x + 30)
            {
                if (x > 250 / 2)
                {
                    extrac = 20;
                }

                for (int i = 0; i <= 120; i = i + 30)
                {
                    Detalle_buttonTradicional(("T" + b.ToString()), (x + extrac), i, gbTradicional);
                    Detalle_buttonPreferencial(("P" + b.ToString()), (x + extrac), i, gbPreferencial);
                    b++;
                }
            }
        }

        //================================ DETALLE DE LOS BOTONES DE ASIENTOS POR CREAR ===========================
        private void Detalle_buttonTradicional(string nombre, int x, int y, Control tipo)
        {
            Button btn = new Button();
            Label la = new Label();

            btn.Name = "btn" + nombre;
            btn.Text = nombre;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(30, 25);

            // AddHandler btn.Click, AddressOf ButtonTradicional_Click
            tipo.Controls.Add(btn);
        }

        private void Detalle_buttonPreferencial(string nombre, int x, int y, Control tipo)
        {
            Button btn = new Button();
            Label la = new Label();

            btn.Name = "btn" + nombre;
            btn.Text = nombre;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(30, 25);

            // AddHandler btn.Click, AddressOf ButtonPreferencial_Click
            tipo.Controls.Add(btn);
        }

        private void cbPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= tabla.Rows.Count - 1; i++)
                {
                    if ((Convert.ToInt32(tabla.Rows[i][1].ToString()) == DarCodPelicula()))
                    {
                        lblHora.Text = tabla.Rows[i][2].ToString();
                    }
                }
                btnVer.BackColor = Color.Green;
                btnVaciarSala.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Mostrar Salas.", "Salas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            CargarSala();
            btnVer.BackColor = Color.Transparent;
            btnVaciarSala.Enabled = true;
        }

        private void btnVaciarSala_Click(object sender, EventArgs e)
        {
            if (funAsignar.EliminarCartelera(codCartelera))
            {
                MessageBox.Show("Cartelera Eliminada Exitosamente.", "Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cartelera No Eliminada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}