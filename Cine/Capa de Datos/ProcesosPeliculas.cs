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
    class ProcesosPeliculas
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public static string obtenerString()
        {
            return Settings.Default.CineConnectionString;
        }

        public ProcesosPeliculas()
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

        public DataTable DetallePelicula(int Cod_Pelicula)
        {
            try
            {
                Conectar();
                dt = new DataTable();
                cmd = new SqlCommand("DetallePelicula", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cod_Pelicula", Cod_Pelicula);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
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

        public void CargarPeliculasLista(ListControl lbListaPeliculas)
        {
            try
            {
                Conectar();
                dt = new DataTable();
                string sql = "SELECT Cod_Pelicula, TituloPelicula FROM Peliculas";
                da = new SqlDataAdapter(sql, cn);
                da.Fill(dt);

                lbListaPeliculas.DisplayMember = "TituloPelicula";
                lbListaPeliculas.ValueMember = "Cod_Pelicula";
                lbListaPeliculas.DataSource = dt;
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

        public void CargarSalaLista(ListControl listasala)
        {
            try
            {
                Conectar();
                dt = new DataTable();
                string sql = "SELECT Cod_Sala, NomSala FROM Sala";
                da = new SqlDataAdapter(sql, cn);
                da.Fill(dt);

                listasala.DisplayMember = "NomSala";
                listasala.ValueMember = "Cod_Sala";
                listasala.DataSource = dt;
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

        public bool GuardarPelicula(Peliculas datos)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("AgregarPelicula", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@titulo", datos.Titulo);
                cmd.Parameters.AddWithValue("@duracion", datos.Duracion);
                cmd.Parameters.AddWithValue("@genero", datos.Genero);
                cmd.Parameters.AddWithValue("@clasificacion", datos.Clasificacion);
                cmd.Parameters.AddWithValue("@formato", datos.Formato);
                cmd.Parameters.AddWithValue("@portada", datos.Portada);
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
                MessageBox.Show("No se pudo a guardar la información: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Desconectar();
            }
        }

        public bool EditarPelicula(int cod, Peliculas datos)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("EditarPelicula", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cod_Pelicula", cod);
                cmd.Parameters.AddWithValue("@titulo", datos.Titulo);
                cmd.Parameters.AddWithValue("@duracion", datos.Duracion);
                cmd.Parameters.AddWithValue("@genero", datos.Genero);
                cmd.Parameters.AddWithValue("@clasificacion", datos.Clasificacion);
                cmd.Parameters.AddWithValue("@formato", datos.Formato);
                cmd.Parameters.AddWithValue("@portada", datos.Portada);
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
                MessageBox.Show("No se pudo editar la información: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Desconectar();
            }
        }

        public bool EliminarPelicula(int cod)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("EliminarPelicula", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod_pelicula", cod);
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
                MessageBox.Show("No se pudo a eliminar la información: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable ListaPeliculas()
        {
            try
            {
                Conectar();
                dt = new DataTable();
                cmd = new SqlCommand("SELECT TituloPelicula, Duracion, Genero, Clasificacion, Formato FROM Peliculas", cn);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
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

        public DataTable BuscarPelicula(string nombre)
        {
            cmd = new SqlCommand(string.Format("SELECT TituloPelicula, Duracion, Genero, Clasificacion, Formato FROM Peliculas WHERE TituloPelicula LIKE '%{0}%'", nombre), cn);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"tabla");
            return ds.Tables["tabla"];
        }

        public DataTable PeliculasPorSala(int codSala, ListControl cbo)
        {
            try
            {
                Conectar();
                dt = new DataTable();
                cmd = new SqlCommand("SELECT Cartelera.Cod_Sala, Cartelera.Cod_Pelicula, Cartelera.HoraInicio, Peliculas.TituloPelicula FROM Cartelera, Peliculas WHERE Cod_Sala = @CodSala AND Peliculas.Cod_Pelicula = Cartelera.Cod_Pelicula", cn);
                //cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CodSala", codSala);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                cbo.DisplayMember = "TituloPelicula";
                cbo.ValueMember = "Cod_Pelicula";
                cbo.DataSource = dt;
                return dt;
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