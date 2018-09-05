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
using System.Text.RegularExpressions;
using MaterialSkin;
using MaterialSkin.Controls;
using Cine.Capa_de_Datos;
using Cine.Capa_de_Negocio;
using Cine.Capa_de_Presentación;

namespace Cine.Capa_de_Presentación
{
    public partial class DatosEmpleados : MaterialForm
    {
        Empleado em = new Empleado();
        Validar v = new Validar();

        public DatosEmpleados()
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

        private void DatosEmpleados_Load(object sender, EventArgs e)
        {
            this.rbtRegistrarEmpleado.Checked = true;
            cbSexoEmpleado.Items.Add("M");
            cbSexoEmpleado.Items.Add("F");
            cbAccesoEmpleado.Items.Add("Gerente");
            cbAccesoEmpleado.Items.Add("Cartelera");
            cbAccesoEmpleado.Items.Add("Taquilla");
            em.CargarEmpleados(dgvTablaEmpleados);
            em.CargarUsuarioEmpleado(dgvUsuarioEmpleado);

            this.MensajeAyuda.SetToolTip(this.txtIdEmpleado, "Ingrese números: 1, 2, 3, 4, 5...");
            this.MensajeAyuda.SetToolTip(this.txtNombreEmpleado, "Ingrese letras: A, b, c...");
            this.MensajeAyuda.SetToolTip(this.txtApellidoEmpleado, "Ingrese letras: A, b, c...");
            this.MensajeAyuda.SetToolTip(this.cbSexoEmpleado, "Elija entre M o F.");
            this.MensajeAyuda.SetToolTip(this.dtpFechaNacimiento, "Elija una fecha.");
            this.MensajeAyuda.SetToolTip(this.txtDireccionEmpleado, "Ingrese letras, números o signos si es necesario: Trinidad #3092.");
            this.MensajeAyuda.SetToolTip(this.txtTelefonoEmpleado, "Ingrese números: 1, 2, 3, 4, 5...");
            this.MensajeAyuda.SetToolTip(this.txtEmailEmpleado, "Ingrese un correo con @: alf@hotmail.com");
            this.MensajeAyuda.SetToolTip(this.cbAccesoEmpleado, "Elija un perfil de empleado.");
            this.MensajeAyuda.SetToolTip(this.txtUsuarioEmpleado, "Ingrese letras, números o signos si es necesario.");
            this.MensajeAyuda.SetToolTip(this.txtPasswordEmpleado, "Ingrese letras, números o signos si es necesario.");
            this.MensajeAyuda.SetToolTip(this.txtBuscarNombreEmpleado, "Ingrese letras: A, b, c...");
            this.MensajeAyuda.SetToolTip(this.txtEliminarIdEmpleado, "Ingrese números: 1, 2, 3, 4, 5...");
            this.MensajeAyuda.SetToolTip(this.txtModificarIdEmpleado, "Ingrese números: 1, 2, 3, 4, 5...");
        }

        public void LimpiarEmpleadosTxt()
        {
            this.txtIdEmpleado.Clear();
            this.txtNombreEmpleado.Clear();
            this.txtApellidoEmpleado.Clear();
            this.cbSexoEmpleado.SelectedIndex = -1;
            this.txtDireccionEmpleado.Clear();
            this.txtTelefonoEmpleado.Clear();
            this.txtEmailEmpleado.Clear();
            this.cbAccesoEmpleado.SelectedIndex = -1;
            this.txtUsuarioEmpleado.Clear();
            this.txtPasswordEmpleado.Clear();
            this.txtBuscarNombreEmpleado.Clear();
            this.txtEliminarIdEmpleado.Clear();
            this.txtModificarIdEmpleado.Clear();

            this.txtIdEmpleado.BackColor = Color.White;
            this.txtEmailEmpleado.BackColor = Color.White;
            this.txtBuscarNombreEmpleado.BackColor = Color.White;
            this.txtEliminarIdEmpleado.BackColor = Color.White;
            this.txtModificarIdEmpleado.BackColor = Color.White;
        }

        private void ActivarEmpleadoTxt()
        {
            this.txtIdEmpleado.Enabled = true;
            this.txtNombreEmpleado.Enabled = true;
            this.txtApellidoEmpleado.Enabled = true;
            this.cbSexoEmpleado.Enabled = true;
            this.dtpFechaNacimiento.Enabled = true;
            this.txtDireccionEmpleado.Enabled = true;
            this.txtTelefonoEmpleado.Enabled = true;
            this.txtEmailEmpleado.Enabled = true;
            this.cbAccesoEmpleado.Enabled = true;
            this.txtUsuarioEmpleado.Enabled = true;
            this.txtPasswordEmpleado.Enabled = true;
        }

        private void DesactivarEmpleadoTxt()
        {
            this.txtIdEmpleado.Enabled = false;
            this.txtNombreEmpleado.Enabled = false;
            this.txtApellidoEmpleado.Enabled = false;
            this.cbSexoEmpleado.Enabled = false;
            this.dtpFechaNacimiento.Enabled = false;
            this.txtDireccionEmpleado.Enabled = false;
            this.txtTelefonoEmpleado.Enabled = false;
            this.txtEmailEmpleado.Enabled = false;
            this.cbAccesoEmpleado.Enabled = false;
            this.txtUsuarioEmpleado.Enabled = false;
            this.txtPasswordEmpleado.Enabled = false;
        }

        private void rbtRegistrarEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            ActivarEmpleadoTxt();
            LimpiarEmpleadosTxt();
            this.txtEliminarIdEmpleado.Enabled = false;
            this.txtModificarIdEmpleado.Enabled = false;
            this.txtBuscarNombreEmpleado.Enabled = false;

            this.btnAceptarEmpleado.Enabled = false;
            this.btnCancelarEmpleado.Enabled = true;
            this.btnModificarEmpleado.Enabled = false;
            this.btnEliminarEmpleado.Enabled = false;
        }

        private void rbtModificarEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarEmpleadoTxt();
            LimpiarEmpleadosTxt();
            this.txtEliminarIdEmpleado.Enabled = false;
            this.txtModificarIdEmpleado.Enabled = true;
            this.txtBuscarNombreEmpleado.Enabled = false;

            this.btnAceptarEmpleado.Enabled = false;
            this.btnCancelarEmpleado.Enabled = true;
            this.btnModificarEmpleado.Enabled = false;
            this.btnEliminarEmpleado.Enabled = false;
        }

        private void rbtBuscarEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarEmpleadoTxt();
            LimpiarEmpleadosTxt();
            this.txtEliminarIdEmpleado.Enabled = false;
            this.txtModificarIdEmpleado.Enabled = false;
            this.txtBuscarNombreEmpleado.Enabled = true;

            this.btnAceptarEmpleado.Enabled = false;
            this.btnCancelarEmpleado.Enabled = false;
            this.btnModificarEmpleado.Enabled = false;
            this.btnEliminarEmpleado.Enabled = false;
        }

        private void rbtEliminarEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarEmpleadoTxt();
            LimpiarEmpleadosTxt();
            this.txtEliminarIdEmpleado.Enabled = true;
            this.txtModificarIdEmpleado.Enabled = false;
            this.txtBuscarNombreEmpleado.Enabled = false;

            this.btnAceptarEmpleado.Enabled = false;
            this.btnCancelarEmpleado.Enabled = false;
            this.btnModificarEmpleado.Enabled = false;
            this.btnEliminarEmpleado.Enabled = false;
        }

        private bool IdEmpleado()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtIdEmpleado.Text);
        }

        private void txtIdEmpleado_TextChanged(object sender, EventArgs e)
        {
            if(IdEmpleado())
            {
                this.txtIdEmpleado.BackColor = Color.White;
                this.btnAceptarEmpleado.Enabled = true;
            }
            else
            {
                this.txtIdEmpleado.BackColor = Color.Red;
                this.btnAceptarEmpleado.Enabled = false;
            }
        }

        private void txtIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtApellidoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtTelefonoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private bool EmailEmpleado()
        {
            return new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$").IsMatch(txtEmailEmpleado.Text);
        }

        private void txtEmailEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (EmailEmpleado())
            {
                this.txtEmailEmpleado.BackColor = Color.White;
                if (rbtRegistrarEmpleado.Checked)
                {
                    this.btnAceptarEmpleado.Enabled = true;
                }
                else if (rbtModificarEmpleado.Checked)
                {
                    this.btnModificarEmpleado.Enabled = true;
                }
            }
            else
            {
                this.btnAceptarEmpleado.Enabled = false;
                this.btnModificarEmpleado.Enabled = false;
                this.txtEmailEmpleado.BackColor = Color.Red;
            }
        }

        private bool BuscarNombreEmpleado()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtBuscarNombreEmpleado.Text);
        }

        private void txtBuscarNombreEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (BuscarNombreEmpleado())
            {
                this.txtBuscarNombreEmpleado.BackColor = Color.White;
                if (txtBuscarNombreEmpleado.Text != " ")
                {
                    dgvTablaEmpleados.DataSource = em.BuscarEmpleado(txtBuscarNombreEmpleado.Text);
                }
            }
            else
            {
                this.txtBuscarNombreEmpleado.BackColor = Color.Red;
                em.CargarEmpleados(dgvTablaEmpleados);
                em.CargarUsuarioEmpleado(dgvUsuarioEmpleado);
            }
        }

        private void txtBuscarNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private bool EliminarIdEmpleado()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtEliminarIdEmpleado.Text);
        }

        private void txtEliminarIdEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (EliminarIdEmpleado())
            {
                this.txtEliminarIdEmpleado.BackColor = Color.White;
                this.btnEliminarEmpleado.Enabled = true;
            }
            else
            {
                this.txtEliminarIdEmpleado.BackColor = Color.Red;
                this.btnEliminarEmpleado.Enabled = false;
            }
        }

        private void txtEliminarIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private bool ModificarIdEmpleado()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtModificarIdEmpleado.Text);
        }

        private void txtModificarIdEmpleado_TextChanged(object sender, EventArgs e)
        {
            txtIdEmpleado.Text = txtModificarIdEmpleado.Text;
            if (ModificarIdEmpleado())
            {
                this.txtModificarIdEmpleado.BackColor = Color.White;
                if (em.EmpleadoRegistrado(Convert.ToInt32(txtModificarIdEmpleado.Text)) > 0)
                {
                    em.LlenarTexBoxConsultaEmpleado(Convert.ToInt32(txtModificarIdEmpleado.Text), txtNombreEmpleado,
                        txtApellidoEmpleado, cbSexoEmpleado, dtpFechaNacimiento, txtDireccionEmpleado, txtTelefonoEmpleado,
                        txtEmailEmpleado, cbAccesoEmpleado, txtUsuarioEmpleado, txtPasswordEmpleado);
                    ActivarEmpleadoTxt();
                    this.btnAceptarEmpleado.Enabled = false;
                    this.btnModificarEmpleado.Enabled = true;
                    this.btnEliminarEmpleado.Enabled = false;
                    this.txtIdEmpleado.Enabled = false;
                    this.txtModificarIdEmpleado.BackColor = Color.White;
                }
            }
            else
            {
                LimpiarEmpleadosTxt();
                DesactivarEmpleadoTxt();
                this.txtModificarIdEmpleado.BackColor = Color.Red;
                this.btnModificarEmpleado.Enabled = false;
            }
        }

        private void txtModificarIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void btnAceptarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtNombreEmpleado.Text.Trim().Length == 0 || txtApellidoEmpleado.Text.Trim().Length == 0 ||
                !(cbSexoEmpleado.SelectedIndex > -1) || txtDireccionEmpleado.Text.Trim().Length == 0 || 
                txtTelefonoEmpleado.Text.Trim().Length == 0 || txtEmailEmpleado.Text.Trim().Length == 0 ||
                !(cbAccesoEmpleado.SelectedIndex > -1) || txtUsuarioEmpleado.Text.Trim().Length == 0 ||
                txtPasswordEmpleado.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (em.EmpleadoRegistrado(Convert.ToInt32(txtIdEmpleado.Text)) == 0)
            {
                em.InsertarEmpleado(Convert.ToInt32(txtIdEmpleado.Text), txtNombreEmpleado.Text, txtApellidoEmpleado.Text,
                    cbSexoEmpleado.Text, dtpFechaNacimiento.Text, txtDireccionEmpleado.Text, Convert.ToInt32(txtTelefonoEmpleado.Text),
                    txtEmailEmpleado.Text, cbAccesoEmpleado.Text, txtUsuarioEmpleado.Text, txtPasswordEmpleado.Text);
                LimpiarEmpleadosTxt();
                em.CargarEmpleados(dgvTablaEmpleados);
                em.CargarUsuarioEmpleado(dgvUsuarioEmpleado);
            }
            else
            {
                MessageBox.Show("No se pudo registrar, el registro ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarEmpleado_Click(object sender, EventArgs e)
        {
            if (rbtRegistrarEmpleado.Checked)
            {
                LimpiarEmpleadosTxt();
            }
            if (rbtModificarEmpleado.Checked)
            {
                LimpiarEmpleadosTxt();
                DesactivarEmpleadoTxt();
                this.txtModificarIdEmpleado.Enabled = true;
            }
        }

        private void dgvTablaEmpleados_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dgvUsuarioEmpleado_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (em.EliminarEmpleado(txtEliminarIdEmpleado.Text))
            {
                MessageBox.Show("Datos eliminados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                em.CargarEmpleados(dgvTablaEmpleados);
                em.CargarUsuarioEmpleado(dgvUsuarioEmpleado);
            }
            else
            {
                MessageBox.Show("Los datos no se pudieron eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminarEmpleado.Enabled = false;
            }
            LimpiarEmpleadosTxt();
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtNombreEmpleado.Text.Trim().Length == 0 || txtApellidoEmpleado.Text.Trim().Length == 0 ||
                !(cbSexoEmpleado.SelectedIndex > -1) || txtDireccionEmpleado.Text.Trim().Length == 0 ||
                txtTelefonoEmpleado.Text.Trim().Length == 0 || txtEmailEmpleado.Text.Trim().Length == 0 ||
                !(cbAccesoEmpleado.SelectedIndex > -1) || txtUsuarioEmpleado.Text.Trim().Length == 0 ||
                txtPasswordEmpleado.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                em.ActualizarEmpleado(Convert.ToInt32(txtIdEmpleado.Text), txtNombreEmpleado.Text, txtApellidoEmpleado.Text,
                    cbSexoEmpleado.Text, dtpFechaNacimiento.Text, txtDireccionEmpleado.Text, Convert.ToInt32(txtTelefonoEmpleado.Text),
                    txtEmailEmpleado.Text, cbAccesoEmpleado.Text, txtUsuarioEmpleado.Text, txtPasswordEmpleado.Text);
                LimpiarEmpleadosTxt();
                DesactivarEmpleadoTxt();
                em.CargarEmpleados(dgvTablaEmpleados);
                em.CargarUsuarioEmpleado(dgvUsuarioEmpleado);
            }
        }

        private void btnSalirEmpleados_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}