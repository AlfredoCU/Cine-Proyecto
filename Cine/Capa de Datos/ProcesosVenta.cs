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
    class ProcesosVenta
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public static string obtenerString()
        {
            return Settings.Default.CineConnectionString;
        }

        public ProcesosVenta()
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

        public void ListaPeliculas(ComboBox cbo)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("ListaPelicula", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                cbo.DisplayMember = "TituloPelicula";
                cbo.ValueMember = "Cod_Pelicula";
                cbo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la información: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }

        public void ListaSalas(ComboBox cbo, int cod)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("ListaSala", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodPelicula", cod);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                cbo.DisplayMember = "NomSala";
                cbo.ValueMember = "Cod_Sala";
                cbo.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la información: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }
        //se puede cambiar
        public DataTable SalaDetalle(int codPelicula, int codSala)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Pelicula, Cod_Sala, HoraInicio FROM Cartelera WHERE Cod_Pelicula = @Cod_Pelicula AND Cod_Sala = @Cod_Sala", cn);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cod_Pelicula", codPelicula);
                cmd.Parameters.AddWithValue("@Cod_Sala", codSala);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();

                if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                {
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la información: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable DetalleSalida(AsignarPelicula datos)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Pelicula, Cod_Sala, Cartelera.Cod_Cartelera, HoraInicio, AsTraLibres, AsPreLibres FROM Cartelera, DetalleSala WHERE Cod_Pelicula = @Cod_Pelicula AND Cod_Sala = @Cod_Sala AND HoraInicio = @HoraInicio", cn);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cod_Pelicula", datos.CodPelicula);
                cmd.Parameters.AddWithValue("@Cod_Sala", datos.CodSala);
                cmd.Parameters.AddWithValue("@HoraInicio", datos.HoraInicio);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();

                if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                {
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la información: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Desconectar();
            }
        }

        public int DarCodCliente()
        {
            try
            {
                int codCliente;
                Conectar();
                cmd = new SqlCommand("SELECT TOP 1 Cod_Cliente FROM Cliente ORDER BY Cod_Cliente DESC", cn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                codCliente = Convert.ToInt32(dt.Rows[0][0].ToString());
                return codCliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la información: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                Desconectar();
            }
        }

        public bool RegistroCliente(Cliente datos, int cod)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Cliente ( NombreCl, ApellidoCl, Dni, Asi_Tradicional, Asi_Preferente, Monto) VALUES(@NombreCl, @ApellidoCl, @DNI, @AsiTradicional, @AsiPreferencial, @MontoTotal)", cn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@CodCartelera", cod);
                cmd.Parameters.AddWithValue("@NombreCl", datos.NomCliente);
                cmd.Parameters.AddWithValue("@ApellidoCl", datos.ApeCliente);
                cmd.Parameters.AddWithValue("@DNI", datos.Dni);
                cmd.Parameters.AddWithValue("@AsiTradicional", datos.AsiTraLi);
                cmd.Parameters.AddWithValue("@AsiPreferencial", datos.AsiPreLi);
                cmd.Parameters.AddWithValue("@MontoTotal", datos.Monto);

                if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
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
                MessageBox.Show("No se pudo registrar el cliente: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Desconectar();
            }
        }

        public void RegistroAsientoCliente(int codCartelera, string numero, int codCliente)
        {
            try
            {
                Conectar(); //Proceso
                cmd = new SqlCommand("INSERT INTO RAsientos(Cod_Cartelera, Nro_Asiento, Cod_Cliente) VALUES(@CodCartelera, @Numero, @CodCliente)", cn);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodCartelera", codCartelera);
                cmd.Parameters.AddWithValue("@Numero", numero);
                cmd.Parameters.AddWithValue("@CodCliente", codCliente);

                if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                {
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("No se pudo a guardar los asientos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar los asientos del cliente: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable CargarSala(int codCartelera)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT Cod_Cartelera, Nro_Asiento FROM RAsientos WHERE Cod_Cartelera = @CodCartelera", cn);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodCartelera", codCartelera);

                if (Convert.ToBoolean(cmd.ExecuteNonQuery()))
                {
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar la información: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
    }
}