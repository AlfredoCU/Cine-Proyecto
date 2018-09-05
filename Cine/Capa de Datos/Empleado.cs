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
    class Empleado
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

        public Empleado()
        {
            cn = new SqlConnection(obtenerString());
            cn.Open();
        }

        //Empleado.
        public string InsertarEmpleado(int idEmpleado, string nombreEmpleado, string apellidoEmpleado, string sexoEmpleado,
            string fechaNacimientoEmpleado, string direccionEmpleado, int telefonoEmpleado, string emailEmpleado, 
            string accesoEmpleado, string usuarioEmpleado, string passwordEmpleado)
        {
            string salida = "Se insertó la información correctamente";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("INSERT INTO Empleado ([Id Empleado], Nombre, Apellidos, Sexo, [Fecha de Nacimiento], Dirección, Teléfono, Email, Acceso, Usuario, Password) VALUES(" + idEmpleado + ", '" + nombreEmpleado + "', '" + apellidoEmpleado + "', '" + sexoEmpleado + "', '" + fechaNacimientoEmpleado + "', '" + direccionEmpleado + "', " + telefonoEmpleado + ", '" + emailEmpleado + "', '" + accesoEmpleado + "', '" + usuarioEmpleado + "', '" + passwordEmpleado + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conectó: " + ex.ToString();
                MessageBox.Show(salida, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public int EmpleadoRegistrado(int idEmpleado)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM Empleado WHERE [Id Empleado]=" + idEmpleado + "", cn);
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

        public void CargarEmpleados(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Empleado", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarUsuarioEmpleado(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT [Id Empleado], Nombre, Acceso, Usuario, Password FROM Empleado", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarTexBoxConsultaEmpleado(int idEmpleado, TextBox txtNombreEmpleado, TextBox txtApellidoEmpleado,
            ComboBox cbSexoEmpleado, DateTimePicker dtpFechaNacimientoEmpleado, TextBox txtDireccionEmpleado, 
            TextBox txtTelefonoEmpleado, TextBox txtEmailEmpleado, ComboBox cbAccesoEmpleado, TextBox txtUsuarioEmpleado,
            TextBox txtPasswordEmpleado)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Empleado WHERE [Id Empleado]=" + idEmpleado + "", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtNombreEmpleado.Text = dr["Nombre"].ToString();
                    txtApellidoEmpleado.Text = dr["Apellidos"].ToString();
                    cbSexoEmpleado.Text = dr["Sexo"].ToString();
                    dtpFechaNacimientoEmpleado.Text = dr["Fecha de Nacimiento"].ToString();
                    txtDireccionEmpleado.Text = dr["Dirección"].ToString(); 
                    txtTelefonoEmpleado.Text = dr["Teléfono"].ToString();   
                    txtEmailEmpleado.Text = dr["Email"].ToString();
                    cbAccesoEmpleado.Text = dr["Acceso"].ToString();
                    txtUsuarioEmpleado.Text = dr["Usuario"].ToString();
                    txtPasswordEmpleado.Text = dr["Password"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ActualizarEmpleado(int idEmpleado, string nombreEmpleado, string apellidoEmpleado, string sexoEmpleado,
            string fechaNacimientoEmpleado, string direccionEmpleado, int telefonoEmpleado, string emailEmpleado,
            string accesoEmpleado, string usuarioEmpleado, string passwordEmpleado)
        {
            string salida = "Se actualizaron los datos";
            MessageBox.Show(salida, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                cmd = new SqlCommand("UPDATE Empleado SET Nombre = '" + nombreEmpleado + "', Apellidos = '" + apellidoEmpleado + "', Sexo = '" + sexoEmpleado + "', [Fecha de Nacimiento] = '" + fechaNacimientoEmpleado + "', Dirección = '" + direccionEmpleado + "', Teléfono = " + telefonoEmpleado + ", Email = '" + emailEmpleado + "', Acceso = '" + accesoEmpleado + "', Usuario = '" + usuarioEmpleado + "', Password = '" + passwordEmpleado + "'  WHERE [Id Empleado] =" + idEmpleado + "", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo: " + ex.ToString();
                MessageBox.Show(salida, "Error de actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return salida;
        }

        public DataTable BuscarEmpleado(string nombre)
        {
            cmd = new SqlCommand(string.Format("SELECT * FROM Empleado WHERE Nombre LIKE '%{0}%'", nombre), cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            return ds.Tables["tabla"];
        }

        public bool EliminarEmpleado(string idEmpleado)
        {
            cmd = new SqlCommand(string.Format("DELETE FROM Empleado WHERE [Id Empleado]= {0}", idEmpleado), cn);
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
