using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Usuario
    {
        private int id { get; set;}
        private string nombreUsuario { get; set; }
        private string contrasena { get; set; }

        public Conexion con = new Conexion();

        public Usuario()
        {
            this.id = 0;
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
        }

        public bool insertar() 
        {
            return con.EjecutarDB("insert into Usuario (nombreUsuario, contrasena) values ('" + this.nombreUsuario + "', '" + this.contrasena + "')");
        }

        public bool Buscar(string usuario, string contrasena)
        {
            DataTable dt;
            bool msj = false;
            
            try
            
            {

                dt = con.BuscarDb("select nombreUsuario, contrasena from Usuario where nombreUsuario = '" +usuario+ "' and contrasena = '" + contrasena+ "'");

                if (dt.Rows.Count > 0)

                    msj = true;

                
            }
            catch (Exception e)
            {
                
                Console.WriteLine(e.Message);
            }

            return msj;
        }
    }
}
