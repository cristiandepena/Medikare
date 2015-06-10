using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
   public class Paciente
    {
        public int IDPaciente;
        public string Nombre {get; set;}
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Cedula { get; set; }
        public String FechaNacimiento;
        public DateTime FechaIngreso;
        public string Sexo{get; set;}
        public string Ocupacion{get; set;}

        public Conexion con = new Conexion();

        public Paciente() {

            this.IDPaciente = 0;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Celular = Celular;
            this.Cedula = Cedula;
            this.FechaNacimiento = FechaNacimiento;
            this.FechaIngreso = DateTime.Now;
            this.Sexo = Sexo;
            this.Ocupacion = Ocupacion;
        }

        public bool insertar() {
            return con.EjecutarDB("insert into paciente (Nombre, Apellido, Direccion, Telefono, Celular, Cedula, FechaNacimiento, FechaIngreso, Sexo, Ocupacion) values('" + this.Nombre + "', '" + this.Apellidos + "', '" + this.Direccion + "', '" + this.Telefono + "', '" + this.Celular + "', '" + this.Cedula + "', '" + this.FechaNacimiento + "', '" + this.FechaIngreso.ToString("MM/dd/yyyy HH:mm:ss") + "', '" + this.Sexo + "', '" + this.Ocupacion + "')");
        }

        public bool modificar(int id) { 
            return con.EjecutarDB("update paciente set Nombre = '"+this.Nombre+"', Apellido = '"+this.Apellidos+"', Direccion = '"+this.Direccion+"', Telefono = '"+this.Telefono+"', Celular = '"+this.Celular+"', Cedula = '"+this.Cedula+"', FechaNacimiento = '"+this.FechaNacimiento+"', FechaIngreso = '"+this.FechaIngreso.ToString("MM/dd/yyyy HH:mm:ss")+"', Sexo '"+this.Sexo+"', Ocupacion = '"+this.Ocupacion+"' where IDPaciente = '"+id+"'");
        }
        public bool eliminar(int id) { 
            return con.EjecutarDB("delete * from paciente where IDPaciente = "+id);
        }
        public DataTable Buscar(int id)
        {
            DataTable dt = new DataTable();
            dt = con.BuscarDb("select * from paciente where IDPaciente = "+id);
            if(dt.Rows.Count > 0) {

                this.IDPaciente = (int)dt.Rows[0]["IDPaciente"];
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
                this.Apellidos = dt.Rows[0]["Apellido"].ToString();
                this.Direccion = dt.Rows[0]["Direccion"].ToString();
                this.Telefono = dt.Rows[0]["Telefono"].ToString();
                this.Celular = dt.Rows[0]["Celular"].ToString();
                this.Cedula = dt.Rows[0]["Cedula"].ToString();
                this.FechaNacimiento = dt.Rows[0]["FechaNacimiento"].ToString();
                this.FechaIngreso = (DateTime) dt.Rows[0]["FechaIngreso"];
                this.Sexo = dt.Rows[0]["Sexo"].ToString();
                this.Ocupacion = dt.Rows[0]["Ocupacion"].ToString();
            }
            return dt;
        }

        public bool BuscarL(int id)
        {
            DataTable dt = new DataTable();
            dt = con.BuscarDb("select * from paciente where IDPaciente = " + id);
            if (dt.Rows.Count > 0)
            {

                this.IDPaciente = (int)dt.Rows[0]["IDPaciente"];
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
                this.Apellidos = dt.Rows[0]["Apellido"].ToString();
                this.Direccion = dt.Rows[0]["Direccion"].ToString();
                this.Telefono = dt.Rows[0]["Telefono"].ToString();
                this.Celular = dt.Rows[0]["Celular"].ToString();
                this.Cedula = dt.Rows[0]["Cedula"].ToString();
                this.FechaNacimiento = dt.Rows[0]["FechaNacimiento"].ToString();
                this.FechaIngreso = (DateTime)dt.Rows[0]["FechaIngreso"];
                this.Sexo = dt.Rows[0]["Sexo"].ToString();
                this.Ocupacion = dt.Rows[0]["Ocupacion"].ToString();
            }
            return true;
        }

        public DataTable BuscarLista(String sql) {
            DataTable dt = new DataTable();
            dt = con.BuscarDb(sql);
            return dt;
        }


           
    }
}
