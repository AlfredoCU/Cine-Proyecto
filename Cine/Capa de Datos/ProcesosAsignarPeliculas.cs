using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Cine.Properties;
using System.Configuration;
using Cine.Clases;
using Cine.Capa_de_Negocio;


namespace Cine.Capa_de_Datos
{
    class ProcesosAsignarPeliculas
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public static string obtenerString()
        {
            return Settings.Default.CineConnectionString;
        }

        public ProcesosAsignarPeliculas()
        {
            cn = new SqlConnection(obtenerString());
            cn.Open();
        }

        public void Conectar()
        {
            try
            {
                if ((cn.State == ConnectionState.Closed))
                {
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo contectar a la base de datos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Desconectar()
        {
            try
            {
                if ((cn.State == ConnectionState.Open))
                {
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo descontectar a la base de datos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidarCartelera(AsignarPelicula datos)
        {
            try
            {
                Conectar();
                bool permitir = true;
                dt = new DataTable();
                da = new SqlDataAdapter("SELECT cod_Sala, HotaFin, HoraInicio FROM Cartelera", cn);
                da.Fill(dt);
                if ((dt.Rows.Count < 1))
                {
                    return true;
                }
                else
                {
                    for (int i = 0; (i <= (dt.Rows.Count - 1)); i++)
                    {
                        if ((Convert.ToInt32(dt.Rows[i][0]) == datos.CodSala))
                        {
                            if (Convert.ToDateTime(datos.HoraInicio) > Convert.ToDateTime(dt.Rows[i][1].ToString()))
                            {
                                permitir = true;
                            }
                            else if ((Convert.ToDateTime(datos.HoraFin) < Convert.ToDateTime(dt.Rows[i][2].ToString())))
                            {
                                permitir = true;
                            }
                            else
                            {
                                permitir = false;
                                break;
                            }
                        }
                    }
                }
                if (permitir)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la información: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Desconectar();
            }
        }

        public bool AgregarCartelera(AsignarPelicula datos)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("AgregarCartelera", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cod_Pelicula", datos.CodPelicula);
                cmd.Parameters.AddWithValue("@Cod_Sala", datos.CodSala);
                cmd.Parameters.AddWithValue("@horainicio", datos.HoraInicio);
                cmd.Parameters.AddWithValue("@HoraFin", datos.HoraFin);
                int filas = cmd.ExecuteNonQuery();
                if (filas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar los campos: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable ListaCartelera()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("ListaDetalleCartelera", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Desconectar();
            }
        }

        public bool EliminarCartelera(int cod)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand(("DELETE FROM Cartelera WHERE Cod_Cartelera = " + Convert.ToString(cod)), cn);
                DialogResult respuesta;
                respuesta = MessageBox.Show("¿Desea Eliminar la Cartelera?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == System.Windows.Forms.DialogResult.No)
                {
                    return false;
                }
                int filas = cmd.ExecuteNonQuery();
                if (filas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no se pudieron eliminar" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Desconectar();
            }
        }
    }
}