using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPN4
{
    public partial class Ejercicio3a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbVerLibros_Click(object sender, EventArgs e)
        {
            Response.Redirect("ejercicio3b.aspx?Tema=" + ddlTemas.SelectedValue);
        }
    }
}