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
                string consulta = "SELECT IdProvincia,NombreProvincia FROM Provincias";

                cargarDatosProvincias(ddlProvinciasDestInicio, consulta);
            }
        }

        protected void ddlProvinciasDestInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList listaProvincia = (DropDownList)sender;
            string consulta;

            if (Convert.ToInt32(listaProvincia.SelectedValue) > 0)
            {
                consulta = "SELECT IdProvincia,NombreProvincia FROM Provincias WHERE IdProvincia !=" + listaProvincia.SelectedValue;

                if (cargarDatosProvincias(ddlProvinciasDestFinal, consulta))
                {
                    ddlLocalidadesDestFinal.Items.Clear();
                    ddlLocalidadesDestFinal.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));
                }

                consulta = "SELECT IdLocalidad,NombreLocalidad FROM Localidades WHERE idProvincia=" + listaProvincia.SelectedValue;

                cargarDatosLocalidades(ddlLocalidadesDestInicio, consulta);
            }
            else
            {
                ddlProvinciasDestFinal.Items.Clear();
                ddlProvinciasDestFinal.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));

                ddlLocalidadesDestFinal.Items.Clear();
                ddlLocalidadesDestFinal.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));

                ddlLocalidadesDestInicio.Items.Clear();
                ddlLocalidadesDestInicio.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));
            }
        }

        protected void ddlProvinciasDestFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList listaProvincia = (DropDownList)sender;

            string consulta;

            if (Convert.ToInt32(listaProvincia.SelectedValue) > 0)
            {
                consulta = "SELECT IdLocalidad,NombreLocalidad FROM Localidades WHERE IdProvincia=" + listaProvincia.SelectedValue;

                cargarDatosLocalidades(ddlLocalidadesDestFinal, consulta);
            }
            else
            {
                ddlLocalidadesDestFinal.Items.Clear();
                ddlLocalidadesDestFinal.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));
            }
        }

        private bool cargarDatosProvincias(DropDownList elemento, string consultaSql)
        {
            string baseDatos = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(baseDatos);

            bool salida;

            conexion.Open();

            SqlDataAdapter cmdDataAdapter = new SqlDataAdapter(consultaSql, conexion);
            DataTable tabla = new DataTable();

            cmdDataAdapter.Fill(tabla);

            if (tabla.Rows.Count > 0)
            {
                elemento.DataSource = tabla;
                elemento.DataTextField = "NombreProvincia";
                elemento.DataValueField = "IdProvincia";
                elemento.DataBind();
                elemento.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));
                salida = true;
            }
            else
            {
                salida = false;
            }

            conexion.Close();

            return salida;
        }

        private bool cargarDatosLocalidades(DropDownList elemento, string consultaSql)
        {
            string baseDatos = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(baseDatos);

            bool salida;

            conexion.Open();

            SqlCommand cmd = new SqlCommand(consultaSql, conexion);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                elemento.DataSource = rdr;
                elemento.DataTextField = "NombreLocalidad";
                elemento.DataValueField = "IdLocalidad";
                elemento.DataBind();
                elemento.Items.Insert(0, new ListItem("-- Seleccionar --", "0"));
                salida = true;
            }
            else
            {
                salida = false;
            }

            conexion.Close();

            return salida;
        }
    }
}