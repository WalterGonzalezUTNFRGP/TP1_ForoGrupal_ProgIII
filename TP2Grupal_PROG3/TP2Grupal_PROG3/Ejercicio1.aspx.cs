﻿using System;
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

            if (!IsPostBack)
            {
                ViewState["bdNumCantidad1Valido"] = numCantidad1Valido;
                ViewState["bdcadProd1Inhabilitada"] = cadenaProducto1Inhabilitada;
                ViewState["bdNumCantidad2Valido"] = numCantidad2Valido;
                ViewState["bdcadProd2Inhabilitada"] = cadenaProducto2Inhabilitada;
            }

        }

        protected void BTNgenerar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(TXTproducto1.Text.Trim()) || string.IsNullOrEmpty(TXTcantidad1.Text.Trim()) ||
            string.IsNullOrEmpty(TXTproducto2.Text.Trim()) || string.IsNullOrEmpty(TXTcantidad2.Text.Trim())))
            {
                lblCamposVacios.Text = "";

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
                lblValidacionProducto1.Text = "";
                TXTproducto2.Text = "";
                lblValidacionProducto2.Text = "";
                TXTcantidad1.Text = "";
                lblValidacionCantidad1.Text = "";
                TXTcantidad2.Text = "";
                lblValidacionCantidad2.Text = "";
            }
            else
            {
                lblCamposVacios.Text = "¡NO PUEDE DEJAR CAMPOS VACÍOS!. POR FAVOR INGRESE TODOS LOS CAMPOS.";
            }
        }

        protected void TXTproducto1_TextChanged(object sender, EventArgs e)
        {
            string producto1 = TXTproducto1.Text.Trim();
            char[] cadProducto1 = producto1.ToCharArray();
            cadenaProducto1Inhabilitada = (bool)ViewState["bdcadProd1Inhabilitada"];
            cadenaProducto2Inhabilitada = (bool)ViewState["bdcadProd2Inhabilitada"];
            numCantidad1Valido = (bool)ViewState["bdNumCantidad1Valido"];
            numCantidad2Valido = (bool)ViewState["bdNumCantidad2Valido"];

            for (int i = 0; i < cadProducto1.Length && !carProducto1Invalidos; i++)
            {
                carProducto1Invalidos = (!char.IsLetter(cadProducto1[i]) && cadProducto1[i] != 32) ? true : false;
            }


            if (carProducto1Invalidos)
            {
                lblValidacionProducto1.ForeColor = Color.Red;
                lblValidacionProducto1.Text = "Caracteres inválidos";
                imgProducto1.Visible = true;
                imgProducto1.ImageUrl = "imagenes/error.png";
                BTNgenerar.Enabled = false;
                cadenaProducto1Inhabilitada = true;
                ViewState["bdcadProd1Inhabilitada"] = cadenaProducto1Inhabilitada;
            }
            else
            {
                lblValidacionProducto1.ForeColor = Color.Green;
                lblValidacionProducto1.Text = "Caracteres Válidos";
                imgProducto1.Visible = true;
                imgProducto1.ImageUrl = "imagenes/marca-de-verificacion.png";
                cadenaProducto1Inhabilitada = false;
                ViewState["bdcadProd1Inhabilitada"] = cadenaProducto1Inhabilitada;
            }

            BTNgenerar.Enabled = (!(cadenaProducto1Inhabilitada) && !(cadenaProducto2Inhabilitada) && numCantidad1Valido && numCantidad2Valido) ? true : false;
        }

        protected void TXTcantidad1_TextChanged(object sender, EventArgs e)
        {
            cadenaProducto1Inhabilitada = (bool)ViewState["bdcadProd1Inhabilitada"];
            cadenaProducto2Inhabilitada = (bool)ViewState["bdcadProd2Inhabilitada"];
            numCantidad1Valido = (bool)ViewState["bdNumCantidad1Valido"];
            numCantidad2Valido = (bool)ViewState["bdNumCantidad2Valido"];


            if (!string.IsNullOrEmpty(TXTcantidad1.Text.Trim()))
            {
                if (TXTcantidad1.Text.Contains(",") || TXTcantidad1.Text.Contains("."))
                {
                    lblValidacionCantidad1.ForeColor = Color.Red;
                    lblValidacionCantidad1.Text = "No se pueden ingresar números con parte decimal (ni positivos, ni negativos)";
                    imgCantidad1.Visible = true;
                    imgCantidad1.ImageUrl = "imagenes/error.png";
                    BTNgenerar.Enabled = false;
                    numCantidad1Valido = false;
                    ViewState["bdNumCantidad1Valido"] = numCantidad1Valido;
                }
                else if (Convert.ToInt32(TXTcantidad1.Text) <= 0)
                {
                    lblValidacionCantidad1.ForeColor = Color.Red;
                    lblValidacionCantidad1.Text = "No se debe ingresar números negativos o nulos";
                    imgCantidad1.Visible = true;
                    imgCantidad1.ImageUrl = "imagenes/error.png";
                    BTNgenerar.Enabled = false;
                    numCantidad1Valido = false;
                    ViewState["bdNumCantidad1Valido"] = numCantidad1Valido;
                }
                else
                {
                    lblValidacionCantidad1.ForeColor = Color.Green;
                    lblValidacionCantidad1.Text = "Valor correcto";
                    imgCantidad1.Visible = true;
                    imgCantidad1.ImageUrl = "imagenes/marca-de-verificacion.png";
                    numCantidad1Valido = true;
                    ViewState["bdNumCantidad1Valido"] = numCantidad1Valido;
                }
            }

            BTNgenerar.Enabled = (!(cadenaProducto1Inhabilitada) && !(cadenaProducto2Inhabilitada) && numCantidad1Valido && numCantidad2Valido) ? true : false;

        }

        protected void TXTproducto2_TextChanged(object sender, EventArgs e)
        {
            string producto2 = TXTproducto2.Text.Trim();
            char[] cadProducto2 = producto2.ToCharArray();
            cadenaProducto1Inhabilitada = (bool)ViewState["bdcadProd1Inhabilitada"];
            cadenaProducto2Inhabilitada = (bool)ViewState["bdcadProd2Inhabilitada"];
            numCantidad1Valido = (bool)ViewState["bdNumCantidad1Valido"];
            numCantidad2Valido = (bool)ViewState["bdNumCantidad2Valido"];

            for (int i = 0; i < cadProducto2.Length && !carProducto2Invalidos; i++)
            {
                carProducto2Invalidos = (!char.IsLetter(cadProducto2[i]) && cadProducto2[i] != 32) ? true : false;
            }


            if (carProducto2Invalidos)
            {
                lblValidacionProducto2.ForeColor = Color.Red;
                lblValidacionProducto2.Text = "Caracteres inválidos";
                imgProducto2.Visible = true;
                imgProducto2.ImageUrl = "imagenes/error.png";
                BTNgenerar.Enabled = false;
                cadenaProducto2Inhabilitada = true;
                ViewState["bdcadProd2Inhabilitada"] = cadenaProducto2Inhabilitada;
            }
            else
            {
                lblValidacionProducto2.ForeColor = Color.Green;
                lblValidacionProducto2.Text = "Caracteres Válidos";
                imgProducto2.Visible = true;
                imgProducto2.ImageUrl = "imagenes/marca-de-verificacion.png";
                cadenaProducto2Inhabilitada = false;
                ViewState["bdcadProd2Inhabilitada"] = cadenaProducto2Inhabilitada;
            }

            BTNgenerar.Enabled = (!(cadenaProducto1Inhabilitada) && !(cadenaProducto2Inhabilitada) && numCantidad1Valido && numCantidad2Valido) ? true : false;
        }

        protected void TXTcantidad2_TextChanged(object sender, EventArgs e)
        {
            cadenaProducto1Inhabilitada = (bool)ViewState["bdcadProd1Inhabilitada"];
            cadenaProducto2Inhabilitada = (bool)ViewState["bdcadProd2Inhabilitada"];
            numCantidad1Valido = (bool)ViewState["bdNumCantidad1Valido"];
            numCantidad2Valido = (bool)ViewState["bdNumCantidad2Valido"];


            if (!string.IsNullOrEmpty(TXTcantidad2.Text.Trim()))
            {
                if (TXTcantidad2.Text.Contains(",") || TXTcantidad2.Text.Contains("."))
                {
                    lblValidacionCantidad2.ForeColor = Color.Red;
                    lblValidacionCantidad2.Text = "No se pueden ingresar números con parte decimal (ni positivos, ni negativos)";
                    imgCantidad2.Visible = true;
                    imgCantidad2.ImageUrl = "imagenes/error.png";
                    BTNgenerar.Enabled = false;
                    numCantidad2Valido = false;
                    ViewState["bdNumCantidad2Valido"] = numCantidad2Valido;
                }
                else if (Convert.ToInt32(TXTcantidad2.Text) <= 0)
                {
                    lblValidacionCantidad2.ForeColor = Color.Red;
                    lblValidacionCantidad2.Text = "No se debe ingresar números negativos o nulos";
                    imgCantidad2.Visible = true;
                    imgCantidad2.ImageUrl = "imagenes/error.png";
                    BTNgenerar.Enabled = false;
                    numCantidad1Valido = false;
                    ViewState["bdNumCantidad2Valido"] = numCantidad2Valido;
                }
                else
                {
                    lblValidacionCantidad2.ForeColor = Color.Green;
                    lblValidacionCantidad2.Text = "Valor correcto";
                    imgCantidad2.Visible = true;
                    imgCantidad2.ImageUrl = "imagenes/marca-de-verificacion.png";
                    numCantidad2Valido = true;
                    ViewState["bdNumCantidad2Valido"] = numCantidad2Valido;
                }
            }

            BTNgenerar.Enabled = (!(cadenaProducto1Inhabilitada) && !(cadenaProducto2Inhabilitada) && numCantidad1Valido && numCantidad2Valido) ? true : false;

        }

        private bool numCantidad1Valido = false;
        private bool numCantidad2Valido = false;
        private bool carProducto1Invalidos = false;
        private bool carProducto2Invalidos = false;
        private bool cadenaProducto1Inhabilitada = true;
        private bool cadenaProducto2Inhabilitada = true;
    }
}














































































































/***************************************************************************************
 * 
 * Código Anterior - está comentado por si desean volver a tomar partes de él 

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
            if (IsPostBack == false)
            {
                imgCantidad1.Visible = false;
                imgCantidad2.Visible = false;
                imgProducto1.Visible = false;
                imgProducto2.Visible = false;
                lblError.Enabled = false;
                btnReiniciar.Enabled = false;
                btnReiniciar.Visible = false;
                TXTproducto1.Focus();
            }

        }

        //protected void BTNgenerar_Click(object sender, EventArgs e)
        //{
            //string tabla;
            //bool numCantidad1Valido = false;
            //bool numCantidad2Valido = false;


            /*if (!string.IsNullOrEmpty(TXTcantidad1.Text.Trim()))
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
            }*/

/*if (!string.IsNullOrEmpty(TXTcantidad2.Text.Trim()))
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
}*/

/*string producto2 = TXTproducto2.Text.Trim();
bool cadenaProducto2Vacia = string.IsNullOrEmpty(producto2);

bool carProducto2Invalidos = false;
foreach (char c in producto2)
{
    if (!char.IsLetter(c) && c != ' ')
    {
        carProducto2Invalidos = true;
        break;
    }
}

bool cadenaProducto2Inhabilitada = carProducto2Invalidos || cadenaProducto2Vacia;

string resultado

resultado = (cantidad > 100) ? "válido" : "no válido";

imgProducto2.ImageUrl = cadenaProducto2Inhabilitada ? "imagenes/error.png" : "imagenes/marca-de-verificacion.png";
imgProducto2.Visible = true;

if (cadenaProducto2Vacia)
{
    lblValidacionProducto2.ForeColor = Color.Red;
    lblValidacionProducto2.Text = "Este campo no puede estar vacío";
}
else if (carProducto2Invalidos)
{
    lblValidacionProducto2.ForeColor = Color.Red;
    lblValidacionProducto2.Text = "Caracteres inválidos";
}
else
{
    lblValidacionProducto2.ForeColor = Color.Green;
    lblValidacionProducto2.Text = "Caracteres Válidos";
}*/

/*string producto1 = TXTproducto1.Text.Trim();
bool cadenaProducto1Vacia = string.IsNullOrEmpty(producto1);

bool carProducto1Invalidos = false;
foreach (char c in producto1)
{
    if (!char.IsLetter(c) && c != ' ')
    {
        carProducto1Invalidos = true;
        break;
    }
}

bool cadenaProducto1Inhabilitada = carProducto1Invalidos || cadenaProducto1Vacia;

imgProducto1.ImageUrl = cadenaProducto1Inhabilitada ? "imagenes/error.png" : "imagenes/marca-de-verificacion.png";
imgProducto1.Visible = true;

if (cadenaProducto1Vacia)
{
    lblValidacionProducto1.ForeColor = Color.Red;
    lblValidacionProducto1.Text = "Este campo no puede estar vacío";
}
else if (carProducto1Invalidos)
{
    lblValidacionProducto1.ForeColor = Color.Red;
    lblValidacionProducto1.Text = "Caracteres inválidos";
}
else
{
    lblValidacionProducto1.ForeColor = Color.Green;
    lblValidacionProducto1.Text = "Caracteres Válidos";
}*/


/*if (!cadenaProducto1Inhabilitada && !cadenaProducto2Inhabilitada && numCantidad1Valido && numCantidad2Valido)
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
    lblError.Text = "Debe ingresar parámetros válidos en todos los campos";
}
}

protected void btnReiniciar_Click(object sender, EventArgs e)
{
Response.Redirect("Ejercicio1.aspx");
}

//----------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------
protected void TXTcantidad1_TextChanged(object sender, EventArgs e)
{
//string tabla;
//bool numCantidad1Valido = false;


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
        //numCantidad1Valido = true;
    }
    TXTproducto2.Focus();
}
else
{
    imgCantidad1.Visible = true;
    imgCantidad1.ImageUrl = "imagenes/error.png";
    lblValidacionCantidad1.ForeColor = Color.Red;
    lblValidacionCantidad1.Text = "Este campo no puede estar vacío";
}
}

protected void TXTcantidad2_TextChanged(object sender, EventArgs e)
{
//bool numCantidad2Valido = false;
if (!string.IsNullOrEmpty(TXTcantidad2.Text.Trim()))
{
    if (TXTcantidad2.Text.Contains(",") || TXTcantidad2.Text.Contains("."))
    {
        imgCantidad2.Visible = true;
        imgCantidad2.ImageUrl = "imagenes/error.png";
        lblValidacionCantidad2.ForeColor = Color.Red;
        lblValidacionCantidad2.Text = "No se pueden ingresar números con parte decimal (ni positivos, ni negativos)";
        //BTNgenerar.Enabled = false;
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
        //numCantidad2Valido = true;
    }
}
else
{
    imgCantidad2.Visible = true;
    imgCantidad2.ImageUrl = "imagenes/error.png";
    lblValidacionCantidad2.ForeColor = Color.Red;
    lblValidacionCantidad2.Text = "Este campo no puede estar vacío";
    BTNgenerar.Focus();
}
BTNgenerar.Focus();
}

protected void TXTproducto1_TextChanged(object sender, EventArgs e)
{
string producto1 = TXTproducto1.Text.Trim();
bool cadenaProducto1Vacia = string.IsNullOrEmpty(producto1);

bool carProducto1Invalidos = false;
foreach (char c in producto1)
{
    if (!char.IsLetter(c) && c != ' ')
    {
        carProducto1Invalidos = true;
        break;
    }
}

bool cadenaProducto1Inhabilitada = carProducto1Invalidos || cadenaProducto1Vacia;

imgProducto1.ImageUrl = cadenaProducto1Inhabilitada ? "imagenes/error.png" : "imagenes/marca-de-verificacion.png";
imgProducto1.Visible = true;

if (cadenaProducto1Vacia)
{
    lblValidacionProducto1.ForeColor = Color.Red;
    lblValidacionProducto1.Text = "Este campo no puede estar vacío";
}
else if (carProducto1Invalidos)
{
    lblValidacionProducto1.ForeColor = Color.Red;
    lblValidacionProducto1.Text = "Caracteres inválidos";
}
else
{
    lblValidacionProducto1.ForeColor = Color.Green;
    lblValidacionProducto1.Text = "Caracteres Válidos";
}
TXTcantidad1.Focus();
}

protected void TXTproducto2_TextChanged(object sender, EventArgs e)
{
string producto2 = TXTproducto2.Text.Trim();
bool cadenaProducto2Vacia = string.IsNullOrEmpty(producto2);

bool carProducto2Invalidos = false;
foreach (char c in producto2)
{
    if (!char.IsLetter(c) && c != ' ')
    {
        carProducto2Invalidos = true;
        break;
    }
}

bool cadenaProducto2Inhabilitada = carProducto2Invalidos || cadenaProducto2Vacia;

imgProducto2.ImageUrl = cadenaProducto2Inhabilitada ? "imagenes/error.png" : "imagenes/marca-de-verificacion.png";
imgProducto2.Visible = true;

if (cadenaProducto2Vacia)
{
    lblValidacionProducto2.ForeColor = Color.Red;
    lblValidacionProducto2.Text = "Este campo no puede estar vacío";
}
else if (carProducto2Invalidos)
{
    lblValidacionProducto2.ForeColor = Color.Red;
    lblValidacionProducto2.Text = "Caracteres inválidos";
}
else
{
    lblValidacionProducto2.ForeColor = Color.Green;
    lblValidacionProducto2.Text = "Caracteres Válidos";
}
TXTcantidad2.Focus();
}

protected void BTNgenerar_Click(object sender, EventArgs e)
{
string tabla;
//bool numCantidad1Valido = false;
//bool numCantidad2Valido = false;
if (lblValidacionProducto1.ForeColor == Color.Green && lblValidacionProducto2.ForeColor == Color.Green
    && lblValidacionCantidad1.ForeColor == Color.Green && lblValidacionCantidad2.ForeColor == Color.Green)
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
    lblValidacionCantidad1.Text = "";
    lblValidacionCantidad2.Text = "";
    lblValidacionProducto1.Text = "";
    lblValidacionProducto2.Text = "";
    imgCantidad1.Visible = false;
    imgCantidad2.Visible = false;
    imgProducto1.Visible = false;
    imgProducto2.Visible = false;
    lblError.Text = "";
    TXTproducto1.Focus();
}
else
{
    if (string.IsNullOrEmpty(TXTproducto1.Text.Trim()))
    {
        imgProducto1.ImageUrl = "imagenes/error.png";
        imgProducto1.Visible = true;
        lblValidacionProducto1.ForeColor = Color.Red;
        lblValidacionProducto1.Text = "Este campo no puede estar vacío";
    }

    if (string.IsNullOrEmpty(TXTproducto2.Text.Trim()))
    {
        imgProducto2.ImageUrl = "imagenes/error.png";
        imgProducto2.Visible = true;
        lblValidacionProducto2.ForeColor = Color.Red;
        lblValidacionProducto2.Text = "Este campo no puede estar vacío";
    }

    if (string.IsNullOrEmpty(TXTcantidad1.Text.Trim()))
    {
        imgCantidad1.Visible = true;
        imgCantidad1.ImageUrl = "imagenes/error.png";
        lblValidacionCantidad1.ForeColor = Color.Red;
        lblValidacionCantidad1.Text = "Este campo no puede estar vacío";
    }

    if (string.IsNullOrEmpty(TXTcantidad2.Text.Trim()))
    {
        imgCantidad2.Visible = true;
        imgCantidad2.ImageUrl = "imagenes/error.png";
        lblValidacionCantidad2.ForeColor = Color.Red;
        lblValidacionCantidad2.Text = "Este campo no puede estar vacío";
    }

    lblError.Enabled = true;
    lblError.Text = "Debe ingresar parámetros válidos en todos los campos";
}

}


}
}*/
