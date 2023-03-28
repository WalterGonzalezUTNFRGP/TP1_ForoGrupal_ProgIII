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
    public partial class FormEjercicio1 : Form
    {
        public FormEjercicio1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxAgregar.Text))
            {
                MessageBox.Show("Debe ingresar un nombre!");
            }
            else
            {
                txtBoxAgregar.Text.Trim();
                listNombre.Items.Add(txtBoxAgregar.Text);
            }    
        }
    }
}
