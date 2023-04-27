using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TPN4
{
    public partial class Ejercicio3b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection cn = new SqlConnection("Data Source = localhost\\sqlexpress; Initial Catalog = Libreria; Integrated Security = True");
                
                string valor = Request.QueryString["Tema"];
                string consultaTemas = "select * from Libros where IdTema =" + valor;
                SqlCommand cmd = new SqlCommand(consultaTemas, cn);
                cn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    grdVConsultaLibros.DataSource = rdr;
                    grdVConsultaLibros.DataBind();
                }

                cn.Close();
            }
        }

        protected void lnkBOtraConsulta_Click(object sender, EventArgs e)
        {

            Response.Redirect("ejercicio3a.aspx");
        }
    }
}