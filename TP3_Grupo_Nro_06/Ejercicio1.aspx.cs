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
            if(hfRepeticionLocalidad.Value == "NO REPETIDO" && hfLocalidadCorrecta.Value == "LOCALIDAD CORRECTA")
            {
                ddlLocalidades.Items.Add(txtNombreLocalidad.Text);
            }
            
            //lblLocAgregada.Text = "Localidad Agregada";            
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            bool ENCONTRADO = false;
            for(int i =0; i < ddlLocalidades.Items.Count && !ENCONTRADO; i++)
            {
                ENCONTRADO = (txtNombreLocalidad.Text.Trim() == ddlLocalidades.Items[i].Text) ? true : false;
            }

            if (ENCONTRADO)
            {
                args.IsValid = false;
                hfRepeticionLocalidad.Value = "REPETIDO";
            }
            else
            {
                args.IsValid = true;
                hfRepeticionLocalidad.Value = "NO REPETIDO";
            }

        }

        protected void cvLocalidadCorrecta_ServerValidate(object source, ServerValidateEventArgs args)
        {
            char[] cadenaLocalidad = txtNombreLocalidad.Text.Trim().ToCharArray();
            bool carInvalidos = false;

            for(int i=0; i < cadenaLocalidad.Length && !carInvalidos; i++)
            {
                carInvalidos=(!(char.IsLetterOrDigit(cadenaLocalidad[i]) && !(cadenaLocalidad[i] == 186 || cadenaLocalidad[i] == 170)) && cadenaLocalidad[i] != 32) ? true : false;
            }

            if (carInvalidos)
            {
                args.IsValid = false;
                hfLocalidadCorrecta.Value = "LOCALIDAD INCORRECTA";
            }
            else
            {
                args.IsValid = true;
                hfLocalidadCorrecta.Value = "LOCALIDAD CORRECTA";    
            }
        }
    }
}