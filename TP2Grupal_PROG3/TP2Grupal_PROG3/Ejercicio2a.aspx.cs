using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2Grupal_PROG3
{
    public partial class Ejercicio2a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            //nombre = Request.QueryString["Nom"];

            nombre = Request["txtNombre"];
            apellido = Request["txtApellido"];
            lblNombreForm.Text = nombre;
            lblApellidoForm.Text = apellido;
        }
    }
}