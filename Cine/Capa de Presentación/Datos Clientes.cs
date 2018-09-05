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
    public partial class DatosClientes : MaterialForm
    {
        DCliente cl = new DCliente();
        Validar v = new Validar();

        public DatosClientes()
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

        private void DatosClientes_Load(object sender, EventArgs e)
        {
            this.rbtRegistrarCliente.Checked = true;
            cbSexoCliente.Items.Add("M");
            cbSexoCliente.Items.Add("F");
            cbAccesoCliente.Items.Add("Cliente Socio");
            cl.CargarClientes(dgvTablaClientes);
            cl.CargarUsuarioCliente(dgvUsuarioCliente);

            this.MensajeAyuda.SetToolTip(this.txtIdCliente, "Ingrese números: 1, 2, 3, 4, 5...");
            this.MensajeAyuda.SetToolTip(this.txtNombreCliente, "Ingrese letras: A, b, c...");
            this.MensajeAyuda.SetToolTip(this.txtApellidoCliente, "Ingrese letras: A, b, c...");
            this.MensajeAyuda.SetToolTip(this.cbSexoCliente, "Elija entre M o F.");
            this.MensajeAyuda.SetToolTip(this.dtpFechaNacimientoCliente, "Elija una fecha.");
            this.MensajeAyuda.SetToolTip(this.txtDireccionCliente, "Ingrese letras, números o signos si es necesario: Trinidad #3092.");
            this.MensajeAyuda.SetToolTip(this.txtTelefonoCliente, "Ingrese números: 1, 2, 3, 4, 5...");
            this.MensajeAyuda.SetToolTip(this.txtEmailCliente, "Ingrese un correo con @: alf@hotmail.com");
            this.MensajeAyuda.SetToolTip(this.txtTarjetaCliente, "Ingrese números: 1, 2, 3, 4, 5...");
            this.MensajeAyuda.SetToolTip(this.cbAccesoCliente, "Elija un perfil de empleado.");
            this.MensajeAyuda.SetToolTip(this.txtUsuarioCliente, "Ingrese letras, números o signos si es necesario.");
            this.MensajeAyuda.SetToolTip(this.txtPasswordCliente, "Ingrese letras, números o signos si es necesario.");
            this.MensajeAyuda.SetToolTip(this.txtBuscarNombreCliente, "Ingrese letras: A, b, c...");
            this.MensajeAyuda.SetToolTip(this.txtEliminarIdCliente, "Ingrese números: 1, 2, 3, 4, 5...");
            this.MensajeAyuda.SetToolTip(this.txtModificarIdCliente, "Ingrese números: 1, 2, 3, 4, 5...");
        }

        public void LimpiarClienteTxt()
        {
            this.txtIdCliente.Clear();
            this.txtNombreCliente.Clear();
            this.txtApellidoCliente.Clear();
            this.cbSexoCliente.SelectedIndex = -1;
            this.txtDireccionCliente.Clear();
            this.txtTelefonoCliente.Clear();
            this.txtEmailCliente.Clear();
            this.txtTarjetaCliente.Clear();
            this.cbAccesoCliente.SelectedIndex = -1;
            this.txtUsuarioCliente.Clear();
            this.txtPasswordCliente.Clear();
            this.txtBuscarNombreCliente.Clear();
            this.txtEliminarIdCliente.Clear();
            this.txtModificarIdCliente.Clear();

            this.txtIdCliente.BackColor = Color.White;
            this.txtEmailCliente.BackColor = Color.White;
            this.txtBuscarNombreCliente.BackColor = Color.White;
            this.txtEliminarIdCliente.BackColor = Color.White;
            this.txtModificarIdCliente.BackColor = Color.White;
        }

        private void ActivarClienteTxt()
        {
            this.txtIdCliente.Enabled = true;
            this.txtNombreCliente.Enabled = true;
            this.txtApellidoCliente.Enabled = true;
            this.cbSexoCliente.Enabled = true;
            this.dtpFechaNacimientoCliente.Enabled = true;
            this.txtDireccionCliente.Enabled = true;
            this.txtTelefonoCliente.Enabled = true;
            this.txtEmailCliente.Enabled = true;
            this.txtTarjetaCliente.Enabled = true;
            this.cbAccesoCliente.Enabled = true;
            this.txtUsuarioCliente.Enabled = true;
            this.txtPasswordCliente.Enabled = true;
        }

        private void DesactivarClienteTxt()
        {
            this.txtIdCliente.Enabled = false;
            this.txtNombreCliente.Enabled = false;
            this.txtApellidoCliente.Enabled = false;
            this.cbSexoCliente.Enabled = false;
            this.dtpFechaNacimientoCliente.Enabled = false;
            this.txtDireccionCliente.Enabled = false;
            this.txtTelefonoCliente.Enabled = false;
            this.txtEmailCliente.Enabled = false;
            this.txtTarjetaCliente.Enabled = false;
            this.cbAccesoCliente.Enabled = false;
            this.txtUsuarioCliente.Enabled = false;
            this.txtPasswordCliente.Enabled = false;
        }

        private void rbtRegistrarCliente_CheckedChanged(object sender, EventArgs e)
        {
            ActivarClienteTxt();
            LimpiarClienteTxt();
            this.txtEliminarIdCliente.Enabled = false;
            this.txtModificarIdCliente.Enabled = false;
            this.txtBuscarNombreCliente.Enabled = false;

            this.btnAceptarCliente.Enabled = false;
            this.btnCancelarCliente.Enabled = true;
            this.btnModificarCliente.Enabled = false;
            this.btnEliminarCliente.Enabled = false;
        }

        private void rbtModificarCliente_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarClienteTxt();
            LimpiarClienteTxt();
            this.txtEliminarIdCliente.Enabled = false;
            this.txtModificarIdCliente.Enabled = true;
            this.txtBuscarNombreCliente.Enabled = false;

            this.btnAceptarCliente.Enabled = false;
            this.btnCancelarCliente.Enabled = true;
            this.btnModificarCliente.Enabled = false;
            this.btnEliminarCliente.Enabled = false;
        }

        private void rbtBuscarCliente_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarClienteTxt();
            LimpiarClienteTxt();
            this.txtEliminarIdCliente.Enabled = false;
            this.txtModificarIdCliente.Enabled = false;
            this.txtBuscarNombreCliente.Enabled = true;

            this.btnAceptarCliente.Enabled = false;
            this.btnCancelarCliente.Enabled = false;
            this.btnModificarCliente.Enabled = false;
            this.btnEliminarCliente.Enabled = false;
        }

        private void rbtEliminarCliente_CheckedChanged(object sender, EventArgs e)
        {
            DesactivarClienteTxt();
            LimpiarClienteTxt();
            this.txtEliminarIdCliente.Enabled = true;
            this.txtModificarIdCliente.Enabled = false;
            this.txtBuscarNombreCliente.Enabled = false;

            this.btnAceptarCliente.Enabled = false;
            this.btnCancelarCliente.Enabled = false;
            this.btnModificarCliente.Enabled = false;
            this.btnEliminarCliente.Enabled = false;
        }

        private bool IdCliente()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtIdCliente.Text);
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (IdCliente())
            {
                this.txtIdCliente.BackColor = Color.White;
                this.btnAceptarCliente.Enabled = true;
            }
            else
            {
                this.txtIdCliente.BackColor = Color.Red;
                this.btnAceptarCliente.Enabled = false;
            }
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private void txtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void txtTarjetaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private bool EmailCliente()
        {
            return new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))" +
              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$").IsMatch(txtEmailCliente.Text);
        }

        private void txtEmailCliente_TextChanged(object sender, EventArgs e)
        {
            if (EmailCliente())
            {
                this.txtEmailCliente.BackColor = Color.White;
                if (rbtRegistrarCliente.Checked)
                {
                    this.btnAceptarCliente.Enabled = true;
                }
                else if (rbtModificarCliente.Checked)
                {
                    this.btnModificarCliente.Enabled = true;
                }
            }
            else
            {
                this.btnAceptarCliente.Enabled = false;
                this.btnModificarCliente.Enabled = false;
                this.txtEmailCliente.BackColor = Color.Red;
            }
        }

        private bool BuscarNombreCliente()
        {
            return new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}").IsMatch(txtBuscarNombreCliente.Text);
        }

        private void txtBuscarNombreCliente_TextChanged(object sender, EventArgs e)
        {
            if (BuscarNombreCliente())
            {
                this.txtBuscarNombreCliente.BackColor = Color.White;
                if (txtBuscarNombreCliente.Text != " ")
                {
                    dgvTablaClientes.DataSource = cl.BuscarCliente(txtBuscarNombreCliente.Text);
                }
            }
            else
            {
                this.txtBuscarNombreCliente.BackColor = Color.Red;
                cl.CargarClientes(dgvTablaClientes);
                cl.CargarUsuarioCliente(dgvUsuarioCliente);
            }
        }

        private void txtBuscarNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);
        }

        private bool EliminarIdCliente()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtEliminarIdCliente.Text);
        }

        private void txtEliminarIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (EliminarIdCliente())
            {
                this.txtEliminarIdCliente.BackColor = Color.White;
                this.btnEliminarCliente.Enabled = true;
            }
            else
            {
                this.txtEliminarIdCliente.BackColor = Color.Red;
                this.btnEliminarCliente.Enabled = false;
            }
        }

        private void txtEliminarIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private bool ModificarIdCliente()
        {
            return new Regex(@"(?:\d*\.)?\d+").IsMatch(txtModificarIdCliente.Text);
        }

        private void txtModificarIdCliente_TextChanged(object sender, EventArgs e)
        {
            txtIdCliente.Text = txtModificarIdCliente.Text;
            if (ModificarIdCliente())
            {
                this.txtModificarIdCliente.BackColor = Color.White;
                if (cl.ClienteRegistrado(Convert.ToInt32(txtModificarIdCliente.Text)) > 0)
                {
                    cl.LlenarTexBoxConsultaCliente(Convert.ToInt32(txtModificarIdCliente.Text), txtNombreCliente,
                        txtApellidoCliente, cbSexoCliente, dtpFechaNacimientoCliente, txtDireccionCliente, txtTelefonoCliente,
                        txtEmailCliente, txtTarjetaCliente, cbAccesoCliente, txtUsuarioCliente, txtPasswordCliente);
                    ActivarClienteTxt();
                    this.btnAceptarCliente.Enabled = false;
                    this.btnModificarCliente.Enabled = true;
                    this.btnEliminarCliente.Enabled = false;
                    this.txtIdCliente.Enabled = false;
                    this.txtModificarIdCliente.BackColor = Color.White;
                }
            }
            else
            {
                LimpiarClienteTxt();
                DesactivarClienteTxt();
                this.txtModificarIdCliente.BackColor = Color.Red;
                this.btnModificarCliente.Enabled = false;
            }
        }

        private void txtModificarIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloNumeros(e);
        }

        private void btnAceptarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text.Trim().Length == 0 || txtApellidoCliente.Text.Trim().Length == 0 ||
                !(cbSexoCliente.SelectedIndex > -1) || txtDireccionCliente.Text.Trim().Length == 0 || 
                txtTelefonoCliente.Text.Trim().Length == 0 || txtEmailCliente.Text.Trim().Length == 0 ||
                txtTarjetaCliente.Text.Trim().Length == 0 || !(cbAccesoCliente.SelectedIndex > -1) || 
                txtUsuarioCliente.Text.Trim().Length == 0 || txtPasswordCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cl.ClienteRegistrado(Convert.ToInt32(txtIdCliente.Text)) == 0)
            {
                cl.InsertarCliente(Convert.ToInt32(txtIdCliente.Text), txtNombreCliente.Text, txtApellidoCliente.Text,
                    cbSexoCliente.Text, dtpFechaNacimientoCliente.Text, txtDireccionCliente.Text, 
                    Convert.ToInt32(txtTelefonoCliente.Text), txtEmailCliente.Text, Convert.ToInt32(txtTarjetaCliente.Text), 
                    cbAccesoCliente.Text, txtUsuarioCliente.Text, txtPasswordCliente.Text);
                LimpiarClienteTxt();
                cl.CargarClientes(dgvTablaClientes);
                cl.CargarUsuarioCliente(dgvUsuarioCliente);
            }
            else
            {
                MessageBox.Show("No se pudo registrar, el registro ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            if (rbtRegistrarCliente.Checked)
            {
                LimpiarClienteTxt();
            }
            if (rbtModificarCliente.Checked)
            {
                LimpiarClienteTxt();
                DesactivarClienteTxt();
                this.txtModificarIdCliente.Enabled = true;
            }
        }

        private void dgvTablaClientes_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dgvUsuarioCliente_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (cl.EliminarCliente(txtEliminarIdCliente.Text))
            {
                MessageBox.Show("Datos eliminados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cl.CargarClientes(dgvTablaClientes);
                cl.CargarUsuarioCliente(dgvUsuarioCliente);
            }
            else
            {
                MessageBox.Show("Los datos no se pudieron eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnEliminarCliente.Enabled = false;
            }
            LimpiarClienteTxt();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text.Trim().Length == 0 || txtApellidoCliente.Text.Trim().Length == 0 ||
                !(cbSexoCliente.SelectedIndex > -1) || txtDireccionCliente.Text.Trim().Length == 0 ||
                txtTelefonoCliente.Text.Trim().Length == 0 || txtEmailCliente.Text.Trim().Length == 0 ||
                txtTarjetaCliente.Text.Trim().Length == 0 || !(cbAccesoCliente.SelectedIndex > -1) ||
                txtUsuarioCliente.Text.Trim().Length == 0 || txtPasswordCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rellene todos los datos por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cl.ActualizarCliente(Convert.ToInt32(txtIdCliente.Text), txtNombreCliente.Text, txtApellidoCliente.Text,
                       cbSexoCliente.Text, dtpFechaNacimientoCliente.Text, txtDireccionCliente.Text,
                       Convert.ToInt32(txtTelefonoCliente.Text), txtEmailCliente.Text, Convert.ToInt32(txtTarjetaCliente.Text),
                       cbAccesoCliente.Text, txtUsuarioCliente.Text, txtPasswordCliente.Text);
                LimpiarClienteTxt();
                cl.CargarClientes(dgvTablaClientes);
                cl.CargarUsuarioCliente(dgvUsuarioCliente);
            }
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}