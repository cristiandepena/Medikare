using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;

namespace BLL
{
    public class Revision
    {
        public int IdConsulta;
        public DateTime Fecha{get; set;}
        public int IdPaciente { get; set; }

        public Conexion con = new Conexion();

        public Revision() {
            this.IdConsulta = 0;
            this.Fecha = Fecha;
            this.IdPaciente = 0;
        }

        public bool insertar() { return con.EjecutarDB("insert into Consulta (Fecha, IdPaciente) values ('"+this.Fecha.ToString("MM/dd/yyyy")+"', '"+this.IdPaciente+"')"); }

        public bool Buscar(int id) {
            DataTable dt = new DataTable();
            dt = con.BuscarDb("select * from Consulta where IdConsulta = " +id);
            if (dt.Rows.Count > 0)
            {
                this.IdConsulta = (int)dt.Rows[0]["IdConsulta"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.IdPaciente = (int)dt.Rows[0]["IdPaciente"];
            }
            return true;
        }

        public DataTable BuscarLista(String sql)
        {
            DataTable dt = new DataTable();
            dt = con.BuscarDb(sql);
            
            return dt;
        }

        public bool BuscarIdRevision()
        {
            DataTable dt = new DataTable();
            dt = con.BuscarDb("Select max(IdConsulta) as IdConsulta from Consulta");
            
            if (dt.Rows.Count > 0)
            {
                this.IdConsulta = (int)dt.Rows[0]["IdConsulta"];
            }
            return true;
        }
        
    }
}
