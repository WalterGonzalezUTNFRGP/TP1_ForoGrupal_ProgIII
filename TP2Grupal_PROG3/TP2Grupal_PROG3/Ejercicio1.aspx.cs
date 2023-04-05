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
            imgCantidad1.Visible = false;
            imgCantidad2.Visible = false;
            imgProducto1.Visible = false;
            imgProducto2.Visible = false;
            lblError.Enabled = false;
            btnReiniciar.Enabled = false;
            btnReiniciar.Visible = false;
            
        }

        protected void BTNgenerar_Click(object sender, EventArgs e)
        {
            string tabla;
            bool numCantidad1Valido = false;
            bool numCantidad2Valido = false;
            bool carProducto1Invalidos = false;
            bool carProducto2Invalidos = false;
            bool cadenaProducto1Vacia;
            bool cadenaProducto2Vacia;
            bool cadenaProducto1Inhabilitada = false;
            bool cadenaProducto2Inhabilitada = false;

            if (!string.IsNullOrEmpty(TXTcantidad1.Text.Trim()))
            {
                if (TXTcantidad1.Text.Contains(",") || TXTcantidad1.Text.Contains("."))
                {
                    imgCantidad1.Visible = true;
                    imgCantidad1.ImageUrl = "imagenes/error.png";
                    lblValidacionCantidad1.ForeColor = Color.Red;
                    lblValidacionCantidad1.Text = "No se pueden ingresar números con parte decimal (ni positivos, ni negativos)";
                }
                else if (Convert.ToInt32(TXTcantidad1.Text) <= 0)
                {
                    imgCantidad1.Visible = true;
                    imgCantidad1.ImageUrl = "imagenes/error.png";
                    lblValidacionCantidad1.ForeColor = Color.Red;
                    lblValidacionCantidad1.Text = "No se debe ingresar números negativos o nulos";
                }
                else
                {
                    imgCantidad1.Visible = true;
                    imgCantidad1.ImageUrl = "imagenes/marca-de-verificacion.png";
                    lblValidacionCantidad1.ForeColor = Color.Green;
                    lblValidacionCantidad1.Text = "Valor correcto";
                    numCantidad1Valido = true;
                }
            }
            else
            {
                imgCantidad1.Visible = true;
                imgCantidad1.ImageUrl = "imagenes/error.png";
                lblValidacionCantidad1.ForeColor = Color.Red;
                lblValidacionCantidad1.Text = "Este campo no puede estar vacío";
            }

            if (!string.IsNullOrEmpty(TXTcantidad2.Text.Trim()))
            {
                if (TXTcantidad2.Text.Contains(",") || TXTcantidad2.Text.Contains("."))
                {
                    imgCantidad2.Visible = true;
                    imgCantidad2.ImageUrl = "imagenes/error.png";
                    lblValidacionCantidad2.ForeColor = Color.Red;
                    lblValidacionCantidad2.Text = "No se pueden ingresar números con parte decimal (ni positivos, ni negativos)";
                    BTNgenerar.Enabled = false;
                }
                else if (Convert.ToInt32(TXTcantidad2.Text) <= 0)
                {
                    imgCantidad2.Visible = true;
                    imgCantidad2.ImageUrl = "imagenes/error.png";
                    lblValidacionCantidad2.ForeColor = Color.Red;
                    lblValidacionCantidad2.Text = "No se debe ingresar números negativos o nulos";
                }
                else
                {
                    imgCantidad2.Visible = true;
                    imgCantidad2.ImageUrl = "imagenes/marca-de-verificacion.png";
                    lblValidacionCantidad2.ForeColor = Color.Green;
                    lblValidacionCantidad2.Text = "Valor correcto";
                    numCantidad2Valido = true;
                }
            }
            else
            {
                imgCantidad2.Visible = true;
                imgCantidad2.ImageUrl = "imagenes/error.png";
                lblValidacionCantidad2.ForeColor = Color.Red;
                lblValidacionCantidad2.Text = "Este campo no puede estar vacío";
            }

            string producto2 = TXTproducto2.Text.Trim();
            char[] cadProducto2 = producto2.ToCharArray();

            for (int i = 0; i < cadProducto2.Length && !carProducto2Invalidos; i++)
            {
                carProducto2Invalidos = (!char.IsLetter(cadProducto2[i]) && cadProducto2[i] != 32) ? true : false;
            }

            cadenaProducto2Vacia = (cadProducto2.Length == 0) ? true : false;
            

            cadenaProducto2Inhabilitada = (carProducto2Invalidos || cadenaProducto2Vacia) ? true : false;

            if (cadenaProducto2Vacia)
            {
                imgProducto2.Visible = true;
                imgProducto2.ImageUrl = "imagenes/error.png";
                lblValidacionProducto2.ForeColor = Color.Red;
                lblValidacionProducto2.Text = "Este campo no puede estar vacío";
            }
            else
            {
                imgProducto2.Visible = true;
                imgProducto2.ImageUrl = "imagenes/marca-de-verificacion.png";
                lblValidacionProducto2.ForeColor = Color.Green;
                lblValidacionProducto2.Text = "Caracteres Válidos";
            }

            if (carProducto2Invalidos)
            {
                imgProducto2.Visible = true;
                imgProducto2.ImageUrl = "imagenes/error.png";
                lblValidacionProducto2.ForeColor = Color.Red;
                lblValidacionProducto2.Text = "Caracteres inválidos";
            }
            else
            {
                imgProducto2.Visible = true;
                imgProducto2.ImageUrl = "imagenes/marca-de-verificacion.png";
                lblValidacionProducto2.ForeColor = Color.Green;
                lblValidacionProducto2.Text = "Caracteres Válidos";
            }

            string producto1 = TXTproducto1.Text.Trim();
            char[] cadProducto1 = producto1.ToCharArray();

            for (int i = 0; i < cadProducto1.Length && !carProducto1Invalidos; i++)
            {
                carProducto1Invalidos = (!char.IsLetter(cadProducto1[i]) && cadProducto1[i] != 32) ? true : false;
            }

            cadenaProducto1Vacia = (string.IsNullOrEmpty(producto1)) ? true : false;

            cadenaProducto1Inhabilitada = (carProducto1Invalidos || cadenaProducto1Vacia) ? true : false;

            if (cadenaProducto1Vacia == true)
            {
                imgProducto1.Visible = true;
                imgProducto1.ImageUrl = "imagenes/error.png";
                lblValidacionProducto1.ForeColor = Color.Red;
                lblValidacionProducto1.Text = "Este campo no puede estar vacío";
            }
            else
            {
                imgProducto1.Visible = true;
                imgProducto1.ImageUrl = "imagenes/marca-de-verificacion.png";
                lblValidacionProducto1.ForeColor = Color.Green;
                lblValidacionProducto1.Text = "Caracteres Válidos";
            }

            if (carProducto1Invalidos == true)
            {
                imgProducto1.Visible = true;
                imgProducto1.ImageUrl = "imagenes/error.png";
                lblValidacionProducto1.ForeColor = Color.Red;
                lblValidacionProducto1.Text = "Caracteres inválidos";
            }
            else
            {
                imgProducto1.Visible = true;
                imgProducto1.ImageUrl = "imagenes/marca-de-verificacion.png";
                lblValidacionProducto1.ForeColor = Color.Green;
                lblValidacionProducto1.Text = "Caracteres Válidos";
            }


            if (!cadenaProducto1Inhabilitada && !cadenaProducto2Inhabilitada && numCantidad1Valido && numCantidad2Valido)
            {
                int cant1 = int.Parse(TXTcantidad1.Text);
                int cant2 = int.Parse(TXTcantidad2.Text);
                int resultado = cant1 + cant2;
                tabla = "<table border='1'>";
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
            }
            else
            {
                lblError.Enabled = true;
                btnReiniciar.Visible = true;
                btnReiniciar.Enabled = true;
                lblError.Text = "Ha ingresado valores no válidos. Debe Reiniciar la página";               
            }
        }

        protected void btnReiniciar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio1.aspx");
        }
        
    }
        

        

        
       

       

        
    }
