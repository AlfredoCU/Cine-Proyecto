//Framework c# son como las Bibliotecas en C++ la diferencia es que son más potentes
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Para poder utilizar comandos SQL SERVER
using System.Data.SqlClient;
//Mandamos a llamar las clases, pantallas y propiedad que son las carpetas que se realizaron ->
using Cine.Clases;
using Cine.Pantallas;
using Cine.Properties;
using Cine.Capa_de_Datos;
using Cine.Capa_de_Negocio;
using Cine.Capa_de_Presentación;
//MaterialSkin Para mejorar la vista al usuario
using MaterialSkin;
using MaterialSkin.Controls;

namespace Cine
{
    public partial class Login : MaterialForm
    {
        Conexion c = new Conexion();
        ProcesosAsignarPeliculas funcionesAsignar = new ProcesosAsignarPeliculas();

        public Login()
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

        private void Login_Load(object sender, EventArgs e)
        {
            //Si es necesario programar.
        }

        private void btnInicioCine_Click(object sender, EventArgs e)
        {
            if (chkCliente.Checked)
            {
                c.LogearClientes(txtUsuarioCine.Text, txtPasswordCine.Text);
            }
            else
            {
                c.LogearEmpleados(txtUsuarioCine.Text, txtPasswordCine.Text);
            }
            txtUsuarioCine.Clear();
            txtPasswordCine.Clear();
            chkCliente.Checked = false;
        }

        private void pbVer_Click(object sender, EventArgs e)
        {
            VerCartelera abrirPantalla = new VerCartelera();
            abrirPantalla.ShowDialog();
        }

        private void pbAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si necesita ayuda con la aplicación contacte con el Administrador.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnSalirCine_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Quiere salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}