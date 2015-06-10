using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;
using System.Web.Security;

namespace FormularioMedico
{
    public partial class WFConsultaPaciente : System.Web.UI.Page
    {
        Paciente p = new Paciente();
        string sql = "Select * from paciente";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();

            }
            else
            if (!IsPostBack)
            {
                gvPaciente.DataSource = p.BuscarLista(sql);
                gvPaciente.DataBind();

            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tbFiltro.Text != string.Empty)
            {
                gvPaciente.DataSource = p.BuscarLista("Select *  from paciente where " + ddlFiltros.SelectedItem.ToString() + " = '" + tbFiltro.Text + "'");
                gvPaciente.DataBind();
                //Response.Write("Select *  from paciente where " + ddlFiltros.SelectedItem.ToString() + " = '" + tbFiltro.Text+"'");
            }
            else
            {
                Response.Write("Nada!");
            }
        }
    }
}