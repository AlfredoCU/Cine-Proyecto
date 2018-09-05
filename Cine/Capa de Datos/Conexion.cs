//Framework c# son como las Bibliotecas en C++ la diferencia es que son más potentes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Clases SQL
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
//Tomar el string de app.config
using Cine.Properties;
using System.Configuration;
//Mandamos a llamar las clases, pantallas y propiedad que son las carpetas que se realizaron ->
using Cine.Clases;
using Cine.Pantallas;

namespace Cine.Clases
{
    class Conexion : Form
    {
        //Clases para utilizar comandos SQL en C#
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        //Obtiene el valor string del app.config.
        public static string obtenerString()
        {
            return Settings.Default.CineConnectionString;
        }

        //Realizamos en el constructor la conexión de la base de datos Cine
        public Conexion()
        {
          //Validamos con Exception para evitar que truene el programa
          //try
          //{
                cn = new SqlConnection(obtenerString());
                cn.Open();
                //MessageBox.Show("Está contactado a la base de datos ", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
          //}
          /*
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó a la base de datos " + ex.ToString(), "No hay conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        //Es el metodo para Logear a Empleados
        public void LogearEmpleados(string usuario, string password)
        {
            try
            {
                //Tomamos 3 elementos de la tabla Empleados y colocamos una condiccion en la cual debe de ser los valores de la base de datos igual
                //a la que se ingresara en los Texbox.
                cmd = new SqlCommand("SELECT Acceso, Usuario, Password FROM Empleado WHERE Usuario = @usuario AND Password = @password", cn);
                //Los parametros del método se pasan a los valores @usuario y @password y esos se evaluan si estan en la base de datos.
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("password", password);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    //Colección de filas [0] y columnas [0] que es Acceso
                    if (dt.Rows[0][0].ToString() == "Gerente")
                    {
                        new SistemaEmpleados(dt.Rows[0][0].ToString()).ShowDialog();
                    }
                    else if (dt.Rows[0][0].ToString() == "Cartelera")
                    {
                        new SistemaEmpleados(dt.Rows[0][0].ToString()).ShowDialog();
                    }
                    else if (dt.Rows[0][0].ToString() == "Taquilla")
                    {
                        new SistemaEmpleados(dt.Rows[0][0].ToString()).ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña son erróneos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Conectar la base de datos: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }
        
        //Es el metodo para Logear a Clientes lo mismo que en Empleados sólo que cambia la tabla
        public void LogearClientes(string usuario, string password)
        {
            try
            {
                cmd = new SqlCommand("SELECT Acceso, Usuario, Password FROM ClienteDatos WHERE Usuario = @usuario AND Password = @password", cn);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("password", password);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][0].ToString() == "Cliente Socio")
                    {
                        new SistemaClientes(dt.Rows[0][0].ToString()).ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña son erróneos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Conectar la base de datos: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conexion));
            this.SuspendLayout();
            // 
            // Conexion
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Conexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexión";
            this.ResumeLayout(false);

        }
    }
}