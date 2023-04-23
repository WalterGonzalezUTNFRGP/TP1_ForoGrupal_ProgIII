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

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
            string txtBox = txtIdProducto.Text.ToString();
            string consulta;
            conexion.Open();

            consulta = "SELECT * FROM Productos WHERE IdProducto= " + txtBox;



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
}