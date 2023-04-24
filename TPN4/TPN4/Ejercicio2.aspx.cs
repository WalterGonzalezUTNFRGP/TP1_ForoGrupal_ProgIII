using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TPN4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)
            {
                SqlConnection conexion = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");

                conexion.Open();

                string consulta;

                consulta = "SELECT * FROM Productos";
                SqlCommand cmd = new SqlCommand(consulta, conexion);

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    grdProductos.DataSource = rdr;
                    grdProductos.DataBind();
                }

                conexion.Close();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";
            string Producto = txtIdProducto.Text;
            string categoria = TxtIdCategoria.Text;
            string comp = ddlProductos.SelectedValue;
            string consulta = "SELECT * FROM Productos WHERE 1=1";

            grdProductos.Visible = true;
            lblMensaje.Text = "";

            if (!string.IsNullOrEmpty(Producto))
            {
                switch (comp)
                {
                    case "=":
                        consulta += "and IdProducto =" + Producto;
                        break;
                    case ">":
                        consulta += "and IdProducto >" + Producto;
                        break;
                    case "<":
                        consulta += "and IdProducto <" + Producto;
                        break;
                }
            }
            
            if (!string.IsNullOrEmpty(categoria))
            {
                if (ddlCategoria.SelectedValue == "=")
                {
                    consulta += "and IdCategoría =" + categoria;
                }
                else if (ddlCategoria.SelectedValue == ">")
                {
                    consulta += "and IdCategoría >" + categoria;
                }
                else if (ddlCategoria.SelectedValue == "<")
                {
                    consulta += "and IdCategoría <" + categoria;
                }
            }

            SqlCommand cmd = new SqlCommand(consulta, conexion);
            conexion.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                grdProductos.DataSource = rdr;
                grdProductos.DataBind();
            }
            else
            {
                grdProductos.Visible = false;
                lblMensaje.Text = "No se encontraron productos con los valores ingresados";
            }

            txtIdProducto.Text = "";
            TxtIdCategoria.Text = "";

            conexion.Close();
        }

        protected void btnQuitarTodo_Click(object sender, EventArgs e)
        {
            txtIdProducto.Text = "";
            TxtIdCategoria.Text = "";  
            lblMensaje.Text = "";            

            SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
            
            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", cn);
            SqlDataReader dr = cmd.ExecuteReader();

            grdProductos.DataSource = dr;
            grdProductos.DataBind();

            cn.Close();
        }       
    }
}