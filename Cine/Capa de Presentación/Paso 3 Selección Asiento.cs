using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Cine.Capa_de_Datos;
using Cine.Capa_de_Negocio;
using Cine.Capa_de_Presentación;
using Cine.Capa_de_Ticked;

namespace Cine.Capa_de_Presentación
{
    public partial class Paso3SelecciónAsiento : MaterialForm
    {
        public int codCartelera;
        public string NomPelicula;
        public string NomCliente;
        public string ApeCliente;
        public string Dni;
        public int AsiTra;
        public int AsiPre;
        public double MontoTotal;
        private int At;
        private int Ap;

        Cliente datos = new Cliente();
        ProcesosVenta funcionV = new ProcesosVenta();

        public Paso3SelecciónAsiento()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE);
        }

        private void Paso3SelecciónAsiento_Load(object sender, EventArgs e)
        {
            GenerarButon();
            CargarSala();
            lblNompelicula.Text = NomPelicula.ToString();
            lblAsiTradiNum.Text = AsiTra.ToString();
            lblAsiPrefeNum.Text = AsiPre.ToString();
            this.btnRegistrar.Enabled = false;
        }

        public void CargarSala()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = funcionV.CargarSala(codCartelera);
                for (int i = 0; (i <= (dt.Rows.Count - 1)); i++)
                {
                    foreach (Control boton in gbPreferencial.Controls)
                    {
                        if ((boton.GetType() == typeof(Button)))
                        {
                            if ((dt.Rows[i][1].ToString() == boton.Name))
                            {
                                boton.Enabled = false;
                                boton.BackColor = Color.Red;
                            }
                        }
                    }
                    foreach (Control boton in gbTradicional.Controls)
                    {
                        if ((boton.GetType() == typeof(Button)))
                        {
                            if ((dt.Rows[i][1].ToString() == boton.Name))
                            {
                                boton.Enabled = false;
                                boton.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No la carga salas: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void registrarCliente()
        {
            try
            {
                datos.NomCliente = NomCliente;
                datos.ApeCliente = ApeCliente;
                datos.Dni = Dni;
                datos.AsiPreLi = AsiPre;
                datos.AsiTraLi = AsiTra;
                datos.Monto = MontoTotal;
                if (funcionV.RegistroCliente(datos, codCartelera))
                {

                }
                else
                {
                    MessageBox.Show("Error al Agregar Cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar Cliente: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RegistroAsientoCliente()
        {
            try
            {
                foreach (Control boton in gbPreferencial.Controls)
                {
                    if ((boton.GetType() == typeof(Button)))
                    {
                        if ((boton.BackColor == Color.Green))
                        {
                            funcionV.RegistroAsientoCliente(codCartelera, boton.Name, funcionV.DarCodCliente());
                        }
                    }
                }
                foreach (Control boton in gbTradicional.Controls)
                {
                    if ((boton.GetType() == typeof(Button)))
                    {
                        if ((boton.BackColor == Color.Green))
                        {
                            funcionV.RegistroAsientoCliente(codCartelera, boton.Name, funcionV.DarCodCliente());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de registrar asientos de cliente: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkValidarCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValidarCompra.Checked)
            {
                this.btnRegistrar.Enabled = true;
            }
            else
            {
                this.btnRegistrar.Enabled = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            registrarCliente();
            RegistroAsientoCliente();
            Boleto abrirPantalla = new Boleto();
            abrirPantalla.CodRegistro = Convert.ToInt32(funcionV.DarCodCliente());
            abrirPantalla.ShowDialog();
            MessageBox.Show("Registro completo.", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Paso1Seleccióndepelículas V1DatosPelicula = new Paso1Seleccióndepelículas();
            V1DatosPelicula.ShowDialog();
        }

        public void GenerarButon()
        {
            int b = 1;
            //int extraf = 0;
            int extrac = 0;
            for (int x = 0; (x <= 270); x = (x + 30))
            {
                if ((x > (250 / 2)))
                {
                    extrac = 20;
                }
                for (int i = 0; (i <= 120); i = (i + 30))
                {
                    Detalle_buttonTradicional(("T" + b.ToString()), (x + extrac), i, gbTradicional);
                    Detalle_buttonPreferencial(("P" + b.ToString()), (x + extrac), i, gbPreferencial);
                    b++;
                }
            }
        }

        // ================================ DETALLE DE LOS BOTONES DE ASIENTOS POR CREAR ===========================
        private void Detalle_buttonTradicional(string nombre, int x, int y, Control tipo)
        {
            Button btn = new Button();
            Label la = new Label();

            btn.Name = "btn" + nombre;
            btn.Text = nombre;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(30, 25);
            btn.Click += new System.EventHandler(this.ButtonTradicional_Click);
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
            btn.Click += new System.EventHandler(this.ButtonPreferencial_Click);
            tipo.Controls.Add(btn);
        }

        // ================================ EVENTOS DE LOS BOTONES DE ASIENTOS CREADOS ===========================
        private void ButtonTradicional_Click(object sender, EventArgs e)
        {
            // Private Sub Button_Click(ByVal sender As Button Object, ByVal e As EventArgs)
            foreach (Button boton in gbTradicional.Controls)
            {
                if ((boton.GetType() == typeof(Button)))
                {
                    if ((boton.Name == ((System.Windows.Forms.Button)(sender)).Name))
                    {
                        // MsgBox(sender.Text)
                        Button b = (Button)sender;
                        SeleccionarAsientosTra(b, AsiTra);
                        break;
                    }
                }
            }
        }

        private void ButtonPreferencial_Click(object sender, EventArgs e)
        {
            // Private Sub Button_Click(ByVal sender As Button Object, ByVal e As EventArgs)
            foreach (Button boton in gbPreferencial.Controls)
            {
                if ((boton.GetType() == typeof(Button)))
                {
                    if ((boton.Name == ((System.Windows.Forms.Button)(sender)).Name))
                    {
                        // MsgBox(sender.Text)
                        Button b = (Button)sender;
                        SeleccionarAsientosPre(b, AsiPre);
                        break;
                    }
                }
            }
        }

        // ================================ SUBPROCESOS DE LOS BOTONES DE ASIENTOS CREADOS ===========================
        public void SeleccionarAsientosTra(Button boton, int TotalAsiento)
        {
            if ((At < TotalAsiento))
            {
                if (!(boton.BackColor == Color.Green))
                {
                    boton.BackColor = Color.Green;
                    At++;
                }
                else if ((boton.BackColor == Color.Green))
                {
                    boton.BackColor = Color.Transparent;
                    At--;
                }
            }
            else if (((At >= TotalAsiento) && (boton.BackColor == Color.Green)))
            {
                boton.BackColor = Color.Transparent;
                At--;
            }
            // If At = TotalAsiento Then
            // MsgBox("Limite Alcanzado")
            // End If
        }

        public void SeleccionarAsientosPre(Button boton, int TotalAsiento)
        {
            if ((Ap < TotalAsiento))
            {
                if (!(boton.BackColor == Color.Green))
                {
                    boton.BackColor = Color.Green;
                    Ap++;
                }
                else if ((boton.BackColor == Color.Green))
                {
                    boton.BackColor = Color.Transparent;
                    Ap--;
                }
            }
            else if (((Ap >= TotalAsiento) && (boton.BackColor == Color.Green)))
            {
                boton.BackColor = Color.Transparent;
                Ap--;
            }
            // If Ap = TotalAsiento Then
            // MsgBox("Limite Alcanzado")
            // End If
        }
    }
}