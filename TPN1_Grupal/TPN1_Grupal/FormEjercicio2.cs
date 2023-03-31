using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TPN1_Grupal
{
    public partial class FormEjercicio2 : Form
    {
        public FormEjercicio2()
        {
            InitializeComponent();
        }

        private void LblApellidoEj2_Click(object sender, EventArgs e)
        {

        }

        private void LblNombreEj2_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombre.Text.Trim()) || string.IsNullOrEmpty(TxtApellido.Text.Trim()))
            {
                MessageBox.Show("COMPLETE LOS CAMPOS OBLIGATORIOS", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtApellido.Text = "";
                TxtNombre.Text = "";
                TxtNombre.Focus();
            }
            else
            {
                string Nombre = TxtNombre.Text.Trim() + " " + TxtApellido.Text.Trim();
                int i, cantNombres;
                bool repetido = false;
                cantNombres = lbNombres.Items.Count;
                for (i = 0; i < cantNombres; i++)
                {
                    if (Nombre.ToUpper() == lbNombres.Items[i].ToString().ToUpper())
                    {
                        MessageBox.Show("El nombre ingresado ya se encuentra en la lista", "ATENCIÓN");
                        repetido = true;
                    }
                }
                if (repetido == false)
                {
                    lbNombres.Items.Add(Nombre);
                    lbNombres.Sorted = true;   // Ordena los elementos del List Box alfabeticamente.
                    TxtNombre.Text = "";
                    TxtApellido.Text = "";
                    TxtNombre.Focus();
                }
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(TxtNombre.Text.Trim(), "[^a-zA-ZáéíóúÁÉÍÓÚ ]"))
            {
                errorProvider1.SetError(TxtNombre, "Debe ingresar un nombre valido");
                BtnAgregar.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(TxtNombre, "");
                BtnAgregar.Enabled = true;
            }
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TxtApellido.Text.Trim(), "[^a-zA-ZáéíóúÁÉÍÓÚ ]"))
            {
                errorProvider2.SetError(TxtApellido, "Debe ingresar un nombre valido");
                BtnAgregar.Enabled = false;
            }
            else
            {
                errorProvider2.SetError(TxtApellido, "");
                BtnAgregar.Enabled = true;
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
           if (lbNombres.SelectedItem != null)
            {
                lbNombres.Items.RemoveAt(lbNombres.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un nombre de la lista!", "ATENCIÓN");
            }
        }
    }
}
