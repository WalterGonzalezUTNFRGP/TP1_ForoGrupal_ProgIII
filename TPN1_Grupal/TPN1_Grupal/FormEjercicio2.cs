using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
