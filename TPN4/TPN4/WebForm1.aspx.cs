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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Viajes;Integrated Security=True");
                
                cn.Open();

                SqlDataAdapter consultaDataAdapter = new SqlDataAdapter("SELECT * FROM Provincias",cn);
                
                DataTable tabla = new DataTable();

                consultaDataAdapter.Fill(tabla);

                ddlProvinciasDestInicio.DataSource = tabla;

                ddlProvinciasDestInicio.DataTextField = "NombreProvincia";
                ddlProvinciasDestInicio.DataValueField = "IdProvincia";
                ddlProvinciasDestInicio.DataBind();
                ddlProvinciasDestInicio.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));

                ddlProvinciasDestFinal.DataSource = tabla;

                ddlProvinciasDestFinal.DataTextField = "NombreProvincia";
                ddlProvinciasDestFinal.DataValueField = "IdProvincia";
                ddlProvinciasDestFinal.DataBind();
                ddlProvinciasDestFinal.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));

                cn.Close();                
            }
        }

        protected void ddlProvinciasDestInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList listaProvincia = (DropDownList) sender;

            if (listaProvincia.SelectedIndex > 0)
            {
                SqlConnection conexion = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True");
                conexion.Open();

                int identificadorProv;
                identificadorProv = Convert.ToInt32(listaProvincia.SelectedIndex);

                SqlDataAdapter consultaAdpt = new SqlDataAdapter("SELECT IdProvincia,NombreProvincia FROM Provincias WHERE IdProvincia !=" + identificadorProv, conexion);
                DataTable tabla = new DataTable();

                consultaAdpt.Fill(tabla);

                ddlProvinciasDestFinal.DataSource = tabla;

                ddlProvinciasDestFinal.DataTextField = "NombreProvincia";
                ddlProvinciasDestFinal.DataValueField = "IdProvincia";

                ddlProvinciasDestFinal.DataBind();
                ddlProvinciasDestFinal.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));
                

                SqlCommand consultacmd = new SqlCommand("SELECT IdLocalidad,NombreLocalidad FROM Localidades WHERE idProvincia =" + identificadorProv, conexion);

                SqlDataReader dr = consultacmd.ExecuteReader();

                ddlLocalidadesDestInicio.DataSource = dr;

                ddlLocalidadesDestInicio.DataTextField = "NombreLocalidad";
                ddlLocalidadesDestInicio.DataValueField = "IdLocalidad";

                ddlLocalidadesDestInicio.DataBind();
                ddlLocalidadesDestInicio.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));

                conexion.Close();
            }
        }

        protected void ddlProvinciasDestFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList listaProvincia = (DropDownList)sender;

            if (listaProvincia.SelectedIndex > 0)
            {
                SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True");
                cn.Open();

                int identificadorProv;
                identificadorProv = listaProvincia.SelectedIndex;

                SqlDataAdapter consulta = new SqlDataAdapter("SELECT * FROM Provincias WHERE IdProvincia !=" + identificadorProv, cn);
                DataTable tabla = new DataTable();

                consulta.Fill(tabla);

                ddlProvinciasDestInicio.DataSource = tabla;

                ddlProvinciasDestInicio.DataTextField = "NombreProvincia";
                ddlProvinciasDestInicio.DataValueField = "IdProvincia";

                ddlProvinciasDestInicio.DataBind();
                ddlProvinciasDestInicio.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));

                cn.Close();
            }


        }
    }
}