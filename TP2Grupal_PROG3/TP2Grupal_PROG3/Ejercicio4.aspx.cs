using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2Grupal_PROG3
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            string usuario = "claudio";
            string contraseña = "casas";
            if(txtUsuario.Text.ToLower()==usuario && txtClave.Text.ToLower()==contraseña)
            {
                lblPrueba.Text = "Datos validos";
                Server.Transfer("Ejercicio4valido.aspx");
            }
            else
            {
                lblPrueba.Text = "Datos invalidos";
            }
        }
    }
}