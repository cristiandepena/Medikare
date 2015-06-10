using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using System.Data;
using System.Web.Security;

namespace FormularioMedico
{
    public partial class WFRevision : System.Web.UI.Page
    {
        DetallesRevision dr = new DetallesRevision();
        Paciente p = new Paciente();
        Revision r = new Revision();
        string sql = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();

            }
            else
            if (!IsPostBack)
            {
                sql = "Select Nombre,IDPaciente from paciente";
                ddlPaciente.DataSource = p.BuscarLista(sql);
                ddlPaciente.DataValueField = "IDPaciente";
                ddlPaciente.DataTextField = "Nombre";
                ddlPaciente.DataBind();

                sql = "Select Nombre, IdSistema from SistemasFisiologicos";
                ddlSistemas.DataSource = p.BuscarLista(sql);
                ddlSistemas.DataValueField = "IdSistema";
                ddlSistemas.DataTextField = "Nombre";
                ddlSistemas.DataBind();

                sql = "Select * from ConsultaDetalles";
                gvRevision.DataSource = dr.BuscarLista(sql);
                gvRevision.DataBind();
            }

            gvRevision.Dispose();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (!tbEstado.Text.Equals(string.Empty))
            //{
                
            //    dr.Estado = tbEstado.Text;
            //    dr.IdSistema = ddlSistemas.SelectedIndex;

            //    r.insertar();
            //}

            DataTable datos;
            

            if (Session["datos"] == null)
            {
                datos = new DataTable();
                datos.Columns.Add(new DataColumn("IdSistema"));
                datos.Columns.Add(new DataColumn("Estado"));

                }else{
                    datos = Session["datos"] as DataTable;

                }
                DataRow row = datos.NewRow();
                row["IdSistema"] = ddlSistemas.SelectedValue;
                row["Estado"] = tbEstado.Text;
                datos.Rows.Add(row);
                Session["datos"] = datos;
                gvRevision.DataSource = datos;
                gvRevision.DataBind();
                
                
            }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            r.Fecha = Convert.ToDateTime(tbFecha.Text);
            r.IdPaciente = Convert.ToInt32(ddlPaciente.SelectedValue);
            
            ddlPaciente.SelectedValue = r.IdPaciente.ToString();

            if (r.insertar())
            {
                if(r.BuscarIdRevision()) {
                    tbIdRevision.Text = r.IdConsulta.ToString();
                }
                DataTable datos = Session["datos"] as DataTable;
                foreach (DataRow row in datos.Rows)
                {
                    dr.IdSistema = Convert.ToInt32(row["IdSistema"].ToString());
                    dr.Estado = row["Estado"].ToString();

                    dr.insertar();
                }
            }
            Response.Write("Registro guardado!");
        }
        }
    }
