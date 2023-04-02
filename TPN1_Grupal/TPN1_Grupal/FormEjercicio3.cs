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
                    salida = "Usted seleccionó los siguientes elementos:\n" + "Sexo: " + (string)(rbFem.Checked ? "Femenino" : "Masculino") +
                        "\nEstado Civil: " + (string)(rbCas.Checked ? "Casado" : "Soltero") + "\nOficio:\n";
                    foreach (string item in chlOcupacion.CheckedItems)
                    {
                        salida += " -" + item.ToString() + "\n";
                    }


                    lblSalida.Text = salida;
                }
            }


        }
}
