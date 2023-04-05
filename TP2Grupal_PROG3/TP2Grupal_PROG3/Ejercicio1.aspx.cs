using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace TP2Grupal_PROG3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNgenerar_Click(object sender, EventArgs e)
        {
            if (TXTcantidad1.Text != "" && TXTcantidad2.Text != "")
            {
                int cant1 = int.Parse(TXTcantidad1.Text);
                int cant2 = int.Parse(TXTcantidad2.Text);
                int resultado = cant1 + cant2;
                string tabla = "<table border='1'>";
                tabla += "<tr><th>Producto</th><th>Cantidad</th></tr>";
                tabla += "<tr>";
                tabla += "<td>" + TXTproducto1.Text + "</td>";
                tabla += "<td>" + TXTcantidad1.Text + "</td>";
                tabla += "</tr>";
                tabla += "<tr>";
                tabla += "<td>" + TXTproducto2.Text + "</td>";
                tabla += "<td>" + TXTcantidad2.Text + "</td>";
                tabla += "</tr>";
                tabla += "<tr>";
                tabla += "<th>Total</th>";
                tabla += "<td>" + resultado + "</td>";
                tabla += "</tr>";
                tabla += "</table>";
                LBLtabla.Text = tabla;
                TXTproducto1.Text = "";
                TXTproducto2.Text = "";
                TXTcantidad1.Text = "";
                TXTcantidad2.Text = "";
                lblVerificacion.Text = "";
            }
            else
            {
                lblVerificacion.ForeColor = Color.Red;
                lblVerificacion.Text = "Debe completar todos los campos";
                //TXTcantidad1.BackColor = Color.Red;
                //TXTcantidad2.BackColor = Color.Red;
                if (TXTcantidad1.Text == "")
                {
                    TXTcantidad1.BackColor = Color.Red;
                }

                if (TXTcantidad2.Text == "")
                {
                    TXTcantidad2.BackColor = Color.Red;
                }
            }
        }

        protected void TXTcantidad1_TextChanged(object sender, EventArgs e)
        {
            if (TXTcantidad1.Text != "")
            {
                TXTcantidad1.BackColor = Color.White;
                if(TXTcantidad2.Text != "")
                {
                    lblVerificacion.Text = "";
                }
            }
        }

        protected void TXTcantidad2_TextChanged(object sender, EventArgs e)
        {
            if (TXTcantidad2.Text != "")
            {
                TXTcantidad2.BackColor  = Color.White;
                if (TXTcantidad1.Text != "")
                {
                    lblVerificacion.Text = "";
                }
            }
        }
    }
}