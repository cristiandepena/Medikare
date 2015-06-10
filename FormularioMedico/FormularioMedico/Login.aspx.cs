using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

namespace FormularioMedico
{
    public partial class Login : System.Web.UI.Page
    {
        private Usuario u = new Usuario();
        public Conexion con = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            String usuario = UserEmail.Text;
            String contrasena = UserPass.Text;

            try
            {
                if (u.Buscar(UserEmail.Text, UserPass.Text))
                {
                    FormsAuthentication.RedirectFromLoginPage(UserEmail.Text, Persist.Checked);
        
                    
                }
                else
                {
                    Msg.Text = "Datos incorrectos";
                }
            }
            catch (Exception)
            {
                
                Console.WriteLine(u.Buscar(usuario, contrasena));
            }
        }

        }
    }