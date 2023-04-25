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

                cn.Open();

                string consulta;

                consulta = "SELECT * FROM Libros";
                SqlCommand cmd = new SqlCommand(consulta, cn);

                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    grdVConsultaLibros.DataSource = rdr;
                    grdVConsultaLibros.DataBind();
                }

                cn.Close();
            }
        }
    }
}