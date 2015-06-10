using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using System.Data.SqlClient;
using System.Web.Security;

namespace FormularioMedico
{
    public partial class WFRegistroPaciente : System.Web.UI.Page
    {
        Paciente p = new Paciente();
        int id;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();

            }else
            
                if (!IsPostBack)
            {
                ddlSexo.SelectedIndex = -1;

                int IDPaciente = 0;
                int.TryParse(Request.QueryString["IDPaciente"], out IDPaciente);

                if (p.BuscarL(IDPaciente))
                {

                    tbBuscar.Text = p.IDPaciente.ToString();
                    tbNombre.Text = p.Nombre;
                    tbApellido.Text = p.Apellidos;
                    tbDireccion.Text = p.Direccion;
                    tbCedula.Text = p.Cedula;
                    tbTelefono.Text = p.Telefono;
                    tbCelular.Text = p.Celular;
                    tbFechaNacimiento.Text = p.FechaNacimiento;
                    tbOcupacion.Text = p.Ocupacion;

                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                p = new Paciente();

                p.Nombre = tbNombre.Text;
                p.Apellidos = tbApellido.Text;
                p.Direccion = tbDireccion.Text;
                p.Telefono = tbTelefono.Text;
                p.Celular = tbCelular.Text;
                p.Cedula = tbCedula.Text;
                p.FechaNacimiento =  tbFechaNacimiento.Text;
                p.FechaIngreso = DateTime.Now;
                p.Sexo = ddlSexo.SelectedValue;

                p.Ocupacion = tbOcupacion.Text;

                if (p.insertar())
                {
                    Response.Write("Success!");
                }
                else
                {
                    Response.Write("Nope!");
                }
                
            }
            catch (SqlException sq) {
                Response.Write(sq.Message);
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            tbNombre.Enabled = false;
            tbApellido.Enabled = false;
            tbDireccion.Enabled = false;
            tbTelefono.Enabled = false;
            tbFechaNacimiento.Enabled = false;
            tbCedula.Enabled = false;
            tbTelefono.Enabled = false;
            tbOcupacion.Enabled = false;
            ddlSexo.Enabled = false;

            if (!tbBuscar.Text.Equals(string.Empty))
            {
                int.TryParse(tbBuscar.Text, out id);
                p.BuscarL(id);
                tbNombre.Text = p.Nombre;
                tbApellido.Text = p.Apellidos;
                tbDireccion.Text = p.Direccion;
                tbCedula.Text = p.Cedula;
                tbTelefono.Text = p.Telefono;
                tbCelular.Text = p.Celular;
                tbFechaNacimiento.Text = p.FechaNacimiento;
                tbOcupacion.Text = p.Ocupacion;
            }
        }

    }
}