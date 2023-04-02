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
            String salida;            

            if (chlOcupacion.CheckedItems.Count == 0)
            {
                MessageBox.Show("¡NO SELECCIONO NINGÚN OFICIO!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                lblSalida.Text = "";
                salida = "Usted seleccionó los siguientes elementos:\n";

                if (rbFem.Checked)
                {
                    salida += "Sexo: Femenino\n";
                }
                if (rbMas.Checked)
                {
                    salida += "Sexo: Masculino\n";
                }
                if (rbCas.Checked)
                {
                    salida += "Estado Civil: Casado\n";
                }
                if (rbSol.Checked)
                {
                    salida += "Estado Civil: Soltero\n";
                }

                salida += "Oficio:\n\n";

                for(int i=0; i < chlOcupacion.Items.Count; i++)
                {
                    if (chlOcupacion.GetItemChecked(i))
                    {
                        salida += "   -" + chlOcupacion.Items[i].ToString() + "\n";
                    }
                                        
                }

                lblSalida.Text = salida;                
            }
        }

        
    }
}
