using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2Grupal_PROG3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNgenerar_Click(object sender, EventArgs e)
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
            tabla += "<td>"+ resultado+"</td>";
            tabla += "</tr>";
            tabla += "</table>";
            LBLtabla.Text = tabla;
        }
            
        
    }
}