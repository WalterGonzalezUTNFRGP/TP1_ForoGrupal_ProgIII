using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace TPN4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Viajes;Integrated Security=True");
                cn.Open();

                SqlCommand cmd = new SqlCommand("Select * from Provincias", cn);

                SqlDataReader dr = cmd.ExecuteReader();
                ddlProvincias.DataSource = dr;
                ddlProvincias.DataTextField = "NombreProvincia";
                ddlProvincias.DataValueField = "IdProvincia";
                ddlProvincias.DataBind();
                cn.Close();

                cn.Open();
                SqlCommand cmd2 = new SqlCommand("Select * from Localidades", cn);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                ddlLocalidades.DataSource = dr2;
                ddlLocalidades.DataTextField = "NombreLocalidad";
                ddlLocalidades.DataValueField = "IdProvincia";
                ddlLocalidades.DataBind();
                cn.Close();


                
            }
        }
    }
}