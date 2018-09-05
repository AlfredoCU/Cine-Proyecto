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

namespace Cine.Capa_de_Presentación
{
    public partial class Paso2DatosCliente : MaterialForm
    {
        public int cod_Cartelera;
        public string NomPelicula;
        public int mpex;
        public int mtex;
        private int tap;
        private int tat;
        Codigos datosCod = new Codigos();
        Validar v = new Validar();

        public Paso2DatosCliente()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if ((validarPreferecial() == false))
            {
                MessageBox.Show("Asiento preferencial excedidos, ingrese de nuevo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmp1.Text = "";
                txtmp2.Text = "";
                txtmp3.Text = "";
            }
            else if ((validarTradicional() == false))
            {
                MessageBox.Show("Asiento tradicional excedidos, ingrese de nuevo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmt1.Text = "";
                txtmt2.Text = "";
                txtmt3.Text = "";
            }
            else
            {
                if (((txtNombre.Text.Trim() == "") || ((txtApellido.Text.Trim() == "") || (txtDni.Text.Trim() == ""))))
                {
                    MessageBox.Show("Faltan completar datos del cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (((tap == 0) && (tat == 0)))
                {
                    MessageBox.Show("No hay asientos seleccionados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Se ingresó correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Paso3SelecciónAsiento V3SeleccionAsiento = new Paso3SelecciónAsiento();
                V3SeleccionAsiento.codCartelera = this.cod_Cartelera;
                V3SeleccionAsiento.NomCliente = txtNombre.Text;
                V3SeleccionAsiento.ApeCliente = txtApellido.Text;
                V3SeleccionAsiento.Dni = txtDni.Text;
                V3SeleccionAsiento.AsiPre = tap;
                V3SeleccionAsiento.AsiTra = tat;
                V3SeleccionAsiento.MontoTotal = SumaMonto();
                V3SeleccionAsiento.NomPelicula = NomPelicula;
                this.Close();
                V3SeleccionAsiento.ShowDialog();
            }
        }

        public int SumaSubMonto(string d1, string d2)
        {
            int valor;
            int v1;
            int v2;
            if ((d1.Trim() == ""))
            {
                return 0;
            }
            try
            {
                v1 = Convert.ToInt32(d1);
                v2 = Convert.ToInt32(d2);
                valor = (v1 * v2);
                return valor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se realizó suma de subtotal: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public double SumaMonto()
        {
            string d1;
            string d2;
            string d3;
            string d4;
            string d5;
            string d6;
            d1 = lblmps1.Text;
            d2 = lblmps2.Text;
            d3 = lblmps3.Text;
            d4 = lblmts1.Text;
            d5 = lblmts2.Text;
            d6 = lblmts3.Text;
            double v1;
            double v2;
            double v3;
            double v4;
            double v5;
            double v6;
            double vt;
            v1 = double.Parse(d1);
            v2 = double.Parse(d2);
            v3 = double.Parse(d3);
            v4 = double.Parse(d4);
            v5 = double.Parse(d5);
            v6 = double.Parse(d6);
            vt = (v1 + (v2 + (v3 + (v4 + (v5 + v6)))));
            return vt;
        }

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        public bool validarPreferecial()
        {
            try
            {
                string d1;
                string d2;
                string d3;
                d1 = txtmp1.Text.Trim();
                d2 = txtmp2.Text.Trim();
                d3 = txtmp3.Text.Trim();
                int v1;
                int v2;
                int v3;
                int vt;
                if (IsNumeric(d1))
                {
                    v1 = Convert.ToInt32(d1);
                }
                else
                {
                    v1 = 0;
                }
                if (IsNumeric(d2))
                {
                    v2 = Convert.ToInt32(d2);
                }
                else
                {
                    v2 = 0;
                }
                if (IsNumeric(d3))
                {
                    v3 = Convert.ToInt32(d3);
                }
                else
                {
                    v3 = 0;
                }
                vt = (v1 + (v2 + v3));
                if ((vt < mpex))
                {
                    tap = vt;
                    return true;
                }
                else
                {
                    tap = vt;
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se validó asientos preferenciales: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool validarTradicional()
        {
            try
            {
                string d1;
                string d2;
                string d3;
                d1 = txtmt1.Text.Trim();
                d2 = txtmt2.Text.Trim();
                d3 = txtmt3.Text.Trim();
                int v1;
                int v2;
                int v3;
                int vt;
                if (IsNumeric(d1))
                {
                    v1 = Convert.ToInt32(d1);
                }
                else
                {
                    v1 = 0;
                }

                if (IsNumeric(d2))
                {
                    v2 = Convert.ToInt32(d2);
                }
                else
                {
                    v2 = 0;
                }

                if (IsNumeric(d3))
                {
                    v3 = Convert.ToInt32(d3);
                }
                else
                {
                    v3 = 0;
                }
                vt = (v1 + (v2 + v3));
                if ((vt < mtex))
                {
                    tat = vt;
                    return true;
                }
                else
                {
                    tat = vt;
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se validó asientos tradicionales: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void txtmp1_TextChanged(object sender, EventArgs e)
        {
            lblmps1.Text = Convert.ToString(SumaSubMonto(txtmp1.Text, lblmp1.Text));
            txtTotal.Text = Convert.ToString(SumaMonto());
        }

        private void txtmp2_TextChanged(object sender, EventArgs e)
        {
            lblmps2.Text = Convert.ToString(SumaSubMonto(txtmp2.Text, lblmp2.Text));
            txtTotal.Text = Convert.ToString(SumaMonto());
        }

        private void txtmp3_TextChanged(object sender, EventArgs e)
        {
            lblmps3.Text = Convert.ToString(SumaSubMonto(txtmp3.Text, lblmp3.Text));
            txtTotal.Text = Convert.ToString(SumaMonto());
        }

        private void txtmt1_TextChanged(object sender, EventArgs e)
        {
            lblmts1.Text = Convert.ToString(SumaSubMonto(txtmt1.Text, lblmt1.Text));
            txtTotal.Text = Convert.ToString(SumaMonto());
        }

        private void txtmt2_TextChanged(object sender, EventArgs e)
        {
            lblmts2.Text = Convert.ToString(SumaSubMonto(txtmt2.Text, lblmt2.Text));
            txtTotal.Text = Convert.ToString(SumaMonto());
        }

        private void txtmt3_TextChanged(object sender, EventArgs e)
        {
            lblmts3.Text = Convert.ToString(SumaSubMonto(txtmt3.Text, lblmt3.Text));
            txtTotal.Text = Convert.ToString(SumaMonto());
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Paso1Seleccióndepelículas V1SeleccionPelicula = new Paso1Seleccióndepelículas();
            V1SeleccionPelicula.ShowDialog();
        }
    }
}