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
    public partial class FormEjercicio3 : Form
    {
        public FormEjercicio3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            if (chlOcupacion.CheckedItems.Count == 0)
            {
                MessageBox.Show("NO SELECCIONO NINGUN OFICIO!", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                LBLgenero.Visible = true;
                LBLestado.Visible = true;

                if (rbFem.Checked == true)
                {
                    LBLgenero.Text = "Sexo: Femenino";
                }
                if (rbMas.Checked == true)
                {
                    LBLgenero.Text = "Sexo: Masculino";
                }
                if (rbCas.Checked == true)
                {
                    LBLestado.Text = "Estado Civil: Casado";
                }
                if (rbSol.Checked == true)
                {
                    LBLestado.Text = "Estado Civil: Soltero";
                }
            }
        }        


    }
}
