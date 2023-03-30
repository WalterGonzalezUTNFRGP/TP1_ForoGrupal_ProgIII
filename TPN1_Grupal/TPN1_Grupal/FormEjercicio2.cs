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
            lbNombres.Items.Add(TxtNombre.Text.Trim() + " " + TxtApellido.Text.Trim());
            lbNombres.Sorted = true;   // Ordena los elementos del List Box alfabeticamente.
            TxtNombre.Text = "";
            TxtApellido.Text = "";
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(TxtNombre.Text.Trim(), "[^a-zA-ZáéíóúÁÉÍÓÚ]"))
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
            if (Regex.IsMatch(TxtApellido.Text.Trim(), "[^a-zA-ZáéíóúÁÉÍÓÚ]"))
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
    }
}
