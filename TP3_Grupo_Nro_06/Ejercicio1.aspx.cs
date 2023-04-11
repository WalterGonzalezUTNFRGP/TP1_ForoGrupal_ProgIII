using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP3_Grupo_Nro_06
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCuardarLocalidad_Click(object sender, EventArgs e)
        {
            string localidad = txtNombreLocalidad.Text.Trim();
            char[] cadNombreLocalidad = localidad.ToCharArray();
            bool carLocalidadInvalidos = false;

            for (int i = 0; i < cadNombreLocalidad.Length && !carLocalidadInvalidos; i++)
            {
                carLocalidadInvalidos = (!(char.IsLetterOrDigit(cadNombreLocalidad[i]) && !(cadNombreLocalidad[i] == 186 || cadNombreLocalidad[i] == 170)) && cadNombreLocalidad[i] != 32) ? true : false;
            }        
        }
    }
}