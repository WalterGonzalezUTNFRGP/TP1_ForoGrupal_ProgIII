using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2Grupal_PROG3
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkBRojo_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Red;
        }

        protected void lnkBAzul_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Blue;
        }

        protected void lnkBVerde_Click(object sender, EventArgs e)
        {
            lblTexto.ForeColor = System.Drawing.Color.Green;
        }
    }
}