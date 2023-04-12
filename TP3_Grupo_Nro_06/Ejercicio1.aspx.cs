using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace TP3_Grupo_Nro_06
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnCuardarLocalidad_Click(object sender, EventArgs e)
        {
    
                
                ddlLocalidades.Items.Add(txtNombreLocalidad.Text);
            lblLocAgregada.Text = "Localidad Agregada";
                 
        }
    }
}