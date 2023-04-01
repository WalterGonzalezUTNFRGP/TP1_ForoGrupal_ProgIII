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

        

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = TxtNombre.Text.Trim();
            string Apellido = TxtApellido.Text.Trim();

            if (string.IsNullOrEmpty(Nombre) && string.IsNullOrEmpty(Apellido))
            {
<<<<<<< HEAD
                MessageBox.Show("¡DEBE INGRESAR NOMBRE Y APELLIDO!", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombre.Focus();                
=======
                MessageBox.Show("Debe ingresar el nombre y apellido!", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombre.Focus();
>>>>>>> 150028828d866bfc2fd6e472371b010f5f699724
            }
            else if (string.IsNullOrEmpty(Nombre))
            {
                MessageBox.Show("¡DEBE INGRESAR UN NOMBRE!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombre.Focus();
            }
            else if (string.IsNullOrEmpty(Apellido))
            {
                MessageBox.Show("¡DEBE INGRESAR UN APELLIDO!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtApellido.Focus();
            }
            else
            {
                string NombreCompleto = Nombre + " " + Apellido;
                int i, cantNombres;
                bool repetido = false;
                cantNombres = lbNombres.Items.Count;
                for (i = 0; i < cantNombres; i++)
                {
                    if (NombreCompleto.ToUpper() == lbNombres.Items[i].ToString().ToUpper())
                    {
                        MessageBox.Show("LOS DATOS INGRESADOS SE ENCUENTRAN EN LA LISTA", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        repetido = true;
                    }
                }
                if (repetido == false)
                {
                    lbNombres.Items.Add(NombreCompleto);
                    lbNombres.Sorted = true;   // Ordena los elementos del List Box alfabeticamente.
                    TxtNombre.Text = "";
                    TxtApellido.Text = "";
                    TxtNombre.Focus();
                }
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            bool carInvalido = false;
            char[] cadenatxt = TxtNombre.Text.Trim().ToCharArray();

            for (int i = 0; i < cadenatxt.Length && !carInvalido; i++)
            {
                carInvalido = ((char.IsControl(cadenatxt[i]) || char.IsNumber(cadenatxt[i]) || char.IsPunctuation(cadenatxt[i]) ||
                    char.IsSymbol(cadenatxt[i])) && cadenatxt[i] != 32) ? true : false;
            }

            if (!carInvalido)
            {
                pctbxValidacionNombre.Image = Properties.Resources.cheque;
                lblValidacionNombre.ForeColor = Color.Green;
                lblValidacionNombre.Text = "Nombre Válido";
                BtnAgregar.Enabled = true;
            }
            else
            {
                pctbxValidacionNombre.Image = Properties.Resources.cancelar;
                lblValidacionNombre.ForeColor = Color.Red;
                lblValidacionNombre.Text = "Nombre no Válido";
                BtnAgregar.Enabled = false;

            }

            if (string.IsNullOrEmpty(TxtNombre.Text.Trim()))
            {
                pctbxValidacionNombre.Image = null;
                lblValidacionNombre.Text = "";
            }
        }


        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            bool carInvalido = false;
            char[] cadenatxt = TxtApellido.Text.Trim().ToCharArray();

            for (int i = 0; i < cadenatxt.Length && !carInvalido; i++)
            {

                carInvalido = ((char.IsControl(cadenatxt[i]) || char.IsNumber(cadenatxt[i]) || char.IsPunctuation(cadenatxt[i]) ||
                    char.IsSymbol(cadenatxt[i])) && cadenatxt[i] != 32) ? true : false;

            }

            if (!carInvalido)
            {
                pctbxValidacionApellido.Image = Properties.Resources.cheque;
                lblValidacionApellido.ForeColor = Color.Green;
                lblValidacionApellido.Text = "Apellido Válido";
                BtnAgregar.Enabled = true;
            }
            else
            {
                pctbxValidacionApellido.Image = Properties.Resources.cancelar;
                lblValidacionApellido.ForeColor = Color.Red;
                lblValidacionApellido.Text = "Apellido no Válido";
                BtnAgregar.Enabled = false;

            }

            if (string.IsNullOrEmpty(TxtApellido.Text.Trim()))
            {
                pctbxValidacionApellido.Image = null;
                lblValidacionApellido.Text = "";
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
                if(lbNombres.Items.Count == 0)
                {
                    MessageBox.Show("LISTA VACÍA. NO SE PUEDEN BORRAR ELEMENTOS", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("¡DEBE SELECCIONAR UN NOMBRE DE LA LISTA!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
    
}
