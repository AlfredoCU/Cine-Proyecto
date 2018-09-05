using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cine.Capa_de_Datos;
using Cine.Capa_de_Negocio;
using Cine.Capa_de_Presentación;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Cine.Pantallas
{
    public partial class SistemaEmpleados : MaterialForm
    {
        public SistemaEmpleados(string empleado)
        {
            InitializeComponent();
            lblEmpleado.Text = empleado;
            // Create a material theme manager and add the form to manage (this).
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            // Configure color schema 1.
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan900, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.Amber700, TextShade.WHITE);
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            GestionUsuario();
        }

        public void GestionUsuario()
        {
            if(lblEmpleado.Text == "Gerente")
            {
                //Empleado
                this.btnEmpleado.Enabled = true;

                //Cliente
                this.btnClientes.Enabled = true;

                //Control Salas
                this.btnAsignarCartelera.Enabled = true;
                this.btnVerSala1.Enabled = true;
                this.btnVerSala2.Enabled = true;

                //Películas
                this.btnAgregarPelicula.Enabled = true;
                this.btnMantenimiento.Enabled = true;
                this.btnVerTodas.Enabled = true;

                //Venta
                this.btnVenderBoletos.Enabled = true;
                this.btnReporteVentas.Enabled = true;
            }

            else if(lblEmpleado.Text == "Cartelera")
            {
                //Empleado
                this.btnEmpleado.Enabled = false;

                //Cliente
                this.btnClientes.Enabled = false;

                //Control Salas
                this.btnAsignarCartelera.Enabled = false;
                this.btnVerSala1.Enabled = false;
                this.btnVerSala2.Enabled = false;

                //Películas
                this.btnAgregarPelicula.Enabled = true;
                this.btnMantenimiento.Enabled = true;
                this.btnVerTodas.Enabled = true;

                //Venta
                this.btnVenderBoletos.Enabled = false;
                this.btnReporteVentas.Enabled = false;
            }

            else if(lblEmpleado.Text == "Taquilla")
            {
                //Empleado
                this.btnEmpleado.Enabled = false;

                //Cliente
                this.btnClientes.Enabled = false;

                //Control Salas
                this.btnAsignarCartelera.Enabled = false;
                this.btnVerSala1.Enabled = false;
                this.btnVerSala2.Enabled = false;

                //Películas
                this.btnAgregarPelicula.Enabled = false;
                this.btnMantenimiento.Enabled = false;
                this.btnVerTodas.Enabled = false;

                //Venta
                this.btnVenderBoletos.Enabled = true;
                this.btnReporteVentas.Enabled = false;
            }
            else
            {
                //Por si se necesita programar
            }
        }

        //Empleados
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            DatosEmpleados abrirPantalla = new DatosEmpleados();
            abrirPantalla.ShowDialog();
        }

        //Clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            DatosClientes abrirPantalla = new DatosClientes();
            abrirPantalla.ShowDialog();
        }

        //Asignar Cartelera
        private void btnAsignarCartelera_Click(object sender, EventArgs e)
        {
            AsignarCartelera abrirPantalla = new AsignarCartelera();
            abrirPantalla.ShowDialog();
        }

        private void btnVerSala1_Click(object sender, EventArgs e) //MODDIFICAR
        {
            VistaSala abrirPantalla = new VistaSala();
            abrirPantalla.codSala = 1;
            abrirPantalla.ShowDialog();
        }

        private void btnVerSala2_Click(object sender, EventArgs e) //MODIFICAR
        {
            VistaSala abrirPantalla = new VistaSala();
            abrirPantalla.codSala = 2;
            abrirPantalla.ShowDialog();
        }

        //Películas
        private void btnAgregarPelicula_Click(object sender, EventArgs e)
        {
            AgregarPeliculas abrirPantalla = new AgregarPeliculas();
            abrirPantalla.ShowDialog();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            MantenimientoPeliculas abrirPantalla = new MantenimientoPeliculas();
            abrirPantalla.ShowDialog();
        }

        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            ListaPeliculas abrirPantalla = new ListaPeliculas();
            abrirPantalla.ShowDialog();
        }

        //Ventas
        private void btnComprarBoletos_Click(object sender, EventArgs e)
        {
            Paso1Seleccióndepelículas abriPantalla = new Paso1Seleccióndepelículas();
            abriPantalla.ShowDialog();
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            ReporteVentas abrirPantalla = new ReporteVentas();
            abrirPantalla.ShowDialog();
        }

        private void pbInformacion_Click(object sender, EventArgs e)
        {
            string mensaje = "Este sistema esta creado por ArdComputer.\n\nProgramador: Alfredo CU\nEmpresa: La Perla de Occidente\nVersión: 1.0";
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pbRegresar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Quiere regresar la login?", "Regresar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}