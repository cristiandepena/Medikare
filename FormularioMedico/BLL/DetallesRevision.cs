using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class DetallesRevision
    {
        public int Id;
        public int IdConsulta;
        public int IdSistema{get; set;}
        public string Estado {get; set;}

        public Conexion con = new Conexion();

        public DetallesRevision()
        {
            this.Id = 0;
            this.IdConsulta = 0;
            this.IdSistema = 0;
            this.Estado = Estado;
        }

        public bool insertar() { return con.EjecutarDB("insert into ConsultaDetalles ( IdSistema, Estado) values ( '"+this.IdSistema+"', '"+this.Estado+"')"); }

        public bool Buscar(int id) 
        {
            DataTable dt = new DataTable();
            dt = con.BuscarDb("select * from ConsultaDetalles where Id = " + id);
            if (dt.Rows.Count > 0)
            {
                this.Id = (int)dt.Rows[0]["Id"];
                this.IdConsulta = (int)dt.Rows[0]["IdConsulta"];
                this.IdSistema = (int)dt.Rows[0]["IdSistema"];
                this.Estado = dt.Rows[0]["Estado"].ToString();
            }
            return true;
        }

        public DataTable BuscarLista(string sql)
        {
            DataTable dt = new DataTable();
            dt = con.BuscarDb(sql);
            return dt;
        }
    }
}
