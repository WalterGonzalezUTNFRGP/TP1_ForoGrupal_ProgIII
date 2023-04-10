using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace TP2Grupal_PROG3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbAccesorios.SelectedValue))
            {
                lblValidacionChBL.ForeColor = Color.Red;
                lblValidacionChBL.Text = "Debe elegir al menos un producto de la lista";
                imgValidacionChBL.Visible = true;
                imgValidacionChBL.ImageUrl = "imagenes/error.png";
                btnCalcular.Enabled = false;

            }
            else
            {
                float PrecioFinal = 0;
                PrecioFinal += float.Parse(ddlMemoria.SelectedValue);

                foreach (ListItem item in cbAccesorios.Items)
                {
                    if (item.Selected)
                    {
                        PrecioFinal += float.Parse(item.Value);
                    }
                }

                lblPrecio.Text = "El Precio Final es: $ " + PrecioFinal.ToString("0.00");
            }
        }

        protected void cbAccesorios_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  lblValidacionChBL.Text = "";
            imgValidacionChBL.Visible = false;
            btnCalcular.Enabled = true;*/
        }
    }
}