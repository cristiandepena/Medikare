using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL
{
   public class Conexion
    {
       SqlConnection con = new SqlConnection(@"Data Source=USUARIO-PC\SQLEXPRESS;Initial Catalog = DBMedic;Integrated Security=True");
        /// <summary>
        /// para ejecutar todos los codigos
        /// </summary>
        /// <param name="Codigo"></param>
        /// <returns></returns>
        public bool EjecutarDB(string codigo)
        {
            bool mensaje = false;
            SqlCommand cmd = new SqlCommand();

            try
            {
                con.Open();

                cmd.Connection = con;
                cmd.CommandText = codigo;
                cmd.ExecuteNonQuery();
            }
            catch (Exception) {
                throw;
            }
            finally
            {
                mensaje = true;
                con.Close();
            }

            return mensaje;
        }
        /// <summary>
        /// para buscar datos en la base de datos
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>

        public DataTable BuscarDb(string comando)
        {
            SqlDataAdapter adp;
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                adp = new SqlDataAdapter(comando, con);

                adp.Fill(dt);
            }
            catch (Exception) {
                throw;
            }
            finally
            {
                con.Close();
            }

            return dt;
        }
    }
}
