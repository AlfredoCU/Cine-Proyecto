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
    class Reportes
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public static string obtenerString()
        {
            return Settings.Default.CineConnectionString;
        }

        public Reportes()
        {
            cn = new SqlConnection(obtenerString());
            cn.Open();
        }

        public void CargarReportes(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT Cod_Cliente, NombreCl, ApellidoCl, Dni AS Tarejeta, Asi_Tradicional AS [Asiento Tradicional], Asi_Preferente AS [Asiento Preferente], Monto FROM Cliente", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarTotal(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT  SUM(Monto) AS Total FROM Cliente", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla de consultar: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable BuscarCliente(string nombre)
        {
            cmd = new SqlCommand(string.Format("SELECT Cod_Cliente, NombreCl, ApellidoCl, Dni AS Tarejeta, Asi_Tradicional AS [Asiento Tradicional], Asi_Preferente AS [Asiento Preferente], Monto FROM Cliente WHERE NombreCl LIKE '%{0}%'", nombre), cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "tabla");
            return ds.Tables["tabla"];
        }

        public bool EliminarReporte(string idReporte)
        {
            cmd = new SqlCommand(string.Format("DELETE FROM Cliente WHERE Cod_Cliente = {0}", idReporte), cn);
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