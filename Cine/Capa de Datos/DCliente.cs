using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using Cine.Properties;
using System.Configuration;
using Cine.Clases;
using Cine.Pantallas;

namespace Cine.Capa_de_Datos
{
    class DCliente
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public static string obtenerString()
        {
            return Settings.Default.CineConnectionString;
        }

        public DCliente()
        {
            cn = new SqlConnection(obtenerString());
            cn.Open();
        }

        public string InsertarCliente(int idCliente, string nombreCliente, string apellidoCliente, string sexoCliente,
            string fechaNacimientoCliente, string direccionCliente, int telefonoCliente, string emailCliente,
            int tarjetaCliente, string accesoCliente, string usuarioCliente, string passwordCliente)
        {
            string salida = "Se insertó la información correctamente";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("INSERT INTO ClienteDatos ([Id Cliente], Nombre, Apellidos, Sexo, [Fecha de Nacimiento], Dirección, Teléfono, Email, [Número de Tarjeta], Acceso, Usuario, Password) VALUES(" + idCliente + ", '" + nombreCliente + "', '" + apellidoCliente + "', '" + sexoCliente + "', '" + fechaNacimientoCliente + "', '" + direccionCliente + "', " + telefonoCliente + ", '" + emailCliente + "', " + tarjetaCliente + ", '" + accesoCliente + "', '" + usuarioCliente + "', '" + passwordCliente + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
                MessageBox.Show(salida, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public int ClienteRegistrado(int idCliente)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM ClienteDatos WHERE [Id Cliente]=" + idCliente + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la información: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return contador;
        }

        public void CargarClientes(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM ClienteDatos", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarUsuarioCliente(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT [Id Cliente], Nombre, Acceso, Usuario, Password FROM ClienteDatos", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarTexBoxConsultaCliente(int idCliente, TextBox txtNombreCliente, TextBox txtApellidoCliente,
           ComboBox cbSexoCliente, DateTimePicker dtpFechaNacimientoCliente, TextBox txtDireccionCliente,
           TextBox txtTelefonoCliente, TextBox txtEmailCliente, TextBox txtTarjetaCliente, ComboBox cbAccesoCliente, 
           TextBox txtUsuarioCliente, TextBox txtPasswordCliente)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM ClienteDatos WHERE [Id Cliente]=" + idCliente + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombreCliente.Text = dr["Nombre"].ToString();
                    txtApellidoCliente.Text = dr["Apellidos"].ToString();
                    cbSexoCliente.Text = dr["Sexo"].ToString();
                    dtpFechaNacimientoCliente.Text = dr["Fecha de Nacimiento"].ToString();
                    txtDireccionCliente.Text = dr["Dirección"].ToString();
                    txtTelefonoCliente.Text = dr["Teléfono"].ToString();
                    txtEmailCliente.Text = dr["Email"].ToString();
                    txtTarjetaCliente.Text = dr["Número de Tarjeta"].ToString();
                    cbAccesoCliente.Text = dr["Acceso"].ToString();
                    txtUsuarioCliente.Text = dr["Usuario"].ToString();
                    txtPasswordCliente.Text = dr["Password"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ActualizarCliente(int idCliente, string nombreCliente, string apellidoCliente, string sexoCliente,
            string fechaNacimientoCliente, string direccionCliente, int telefonoCliente, string emailCliente,
            int tarjetaCliente, string accesoCliente, string usuarioCliente, string passwordCliente)
        {
            string salida = "Se actualizaron los datos";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("UPDATE ClienteDatos SET Nombre = '" + nombreCliente + "', Apellidos = '" + apellidoCliente + "', Sexo = '" + sexoCliente + "', [Fecha de Nacimiento] = '" + fechaNacimientoCliente + "', Dirección = '" + direccionCliente + "', Teléfono = " + telefonoCliente + ", Email = '" + emailCliente + "', [Número de Tarjeta] = " + tarjetaCliente + ", Acceso = '" + accesoCliente + "', Usuario = '" + usuarioCliente + "', Password = '" + passwordCliente + "'  WHERE [Id Cliente] =" + idCliente + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
                MessageBox.Show(salida, "Error de actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public DataTable BuscarCliente(string nombre)
        {
            cmd = new SqlCommand(string.Format("SELECT * FROM ClienteDatos WHERE Nombre LIKE '%{0}%'", nombre), cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            return ds.Tables["tabla"];
        }

        public bool EliminarCliente(string idCliente)
        {
            cmd = new SqlCommand(string.Format("DELETE FROM ClienteDatos WHERE [Id Cliente]= {0}", idCliente), cn);
            int filasafectadas = cmd.ExecuteNonQuery();
            if (filasafectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}