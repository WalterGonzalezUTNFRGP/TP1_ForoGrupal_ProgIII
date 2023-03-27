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
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            FormEjercicio1 ventanaEj1 = new FormEjercicio1();

            this.Hide();
            ventanaEj1.ShowDialog();
            this.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            FormEjercicio2 ventanaEj2 = new FormEjercicio2();

            this.Hide();
            ventanaEj2.ShowDialog();
            this.Show();

        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            FormEjercicio3 ventanaEj3 = new FormEjercicio3();

            this.Hide();
            ventanaEj3.ShowDialog();
            this.Show();

        }
    }
}
