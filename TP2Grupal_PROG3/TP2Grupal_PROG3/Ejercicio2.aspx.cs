using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace TP2Grupal_PROG3
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResumen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbTemas.SelectedValue))
            {
                btnResumen.Enabled = false;
                lblValidacionChBL.ForeColor = Color.Red;
                lblValidacionChBL.Text = "Debe seleccionar al menos un elemento de la lista de Temas";
                imgValidacionChBL.Visible = true;
                imgValidacionChBL.ImageUrl = "imagenes/error.png";
            }
            else
            {
                List<string> temasSeleccionados = new List<string>();

                foreach (ListItem item in cbTemas.Items)
                {
                    if (item.Selected)
                    {
                        temasSeleccionados.Add(item.Text);
                    }
                }

                Session["temasSeleccionados"] = temasSeleccionados;
                Server.Transfer("Ejercicio2a.aspx");
            }            
        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombre.Text.Trim();
            char[] cadNombre = nombreUsuario.ToCharArray();
            bool carNombreInvalidos = false;

            for (int i = 0; i < cadNombre.Length && !carNombreInvalidos; i++)
            {
                carNombreInvalidos = (!char.IsLetter(cadNombre[i]) && cadNombre[i] != 32) ? true : false;
            }


            if (carNombreInvalidos)
            {
                lblValidacionNombre.ForeColor = Color.Red;
                lblValidacionNombre.Text = "Caracteres inválidos";
                imgNombre.Visible = true;
                imgNombre.ImageUrl = "imagenes/error.png";
                btnResumen.Enabled = false;
            }
            else
            {
                lblValidacionNombre.ForeColor = Color.Green;
                lblValidacionNombre.Text = "Caracteres Válidos";
                imgNombre.Visible = true;
                imgNombre.ImageUrl = "imagenes/marca-de-verificacion.png";
                btnResumen.Enabled = true;
            }
        }

        protected void txtApellido_TextChanged(object sender, EventArgs e)
        {
            char[] cadenaTxt = txtApellido.Text.Trim().ToCharArray();
            bool carApellidoInvalidos = cadenaTxt.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c));
            if(!carApellidoInvalidos)
            {
                lblValidacionApellido.ForeColor = Color.Green;
                lblValidacionApellido.Text = "Caracteres Válidos";
                imgApellido.Visible = true;
                imgApellido.ImageUrl = "imagenes/marca-de-verificacion.png";
                btnResumen.Enabled = true;
            }
            else
            {
                lblValidacionApellido.ForeColor = Color.Red;
                lblValidacionApellido.Text = "Caracteres Inválidos";
                imgApellido.Visible = true;
                imgApellido.ImageUrl = "imagenes/error.png";
                btnResumen.Enabled = false;
            }
        }

        protected void cbTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnResumen.Enabled = true;
            lblValidacionChBL.Text = "";
            imgValidacionChBL.Visible = false;
        }
    }
}