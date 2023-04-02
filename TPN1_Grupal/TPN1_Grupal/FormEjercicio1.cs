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
    public partial class FormEjercicio1 : Form
    {
        public FormEjercicio1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxAgregar.Text.Trim()))
            {
                tmrClock1.Start();
                ptbxImagenEstado.Image = Properties.Resources.cancelar;
                lblMensajeUsuario.ForeColor = Color.Red;
                lblMensajeUsuario.Text = "Debe Ingresar un Nombre";
                btnAgregar.Enabled = false;
            }
            else
            {
                int cantNombres, i;
                bool repetido = false;
                cantNombres = listNombre.Items.Count; // Cuenta la cantidad de nombres cargados en el List Box.

                for (i = 0; i < cantNombres; i++)
                {
                    // Compara el nombre ingresado en el text box con cada uno de los nombres del list box. Antes pasa toda la cadena de ambos nombres a MAYÚSCULAS.
                    if (txtBoxAgregar.Text.ToUpper().Trim() == listNombre.Items[i].ToString().ToUpper())
                    {
                        MessageBox.Show("¡EL NOMBRE INGRESADO YA SE ENCUENTRA EN LA LISTA!", "ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        repetido = true;
                    }
                }
                // Si no hay repetido agrega el nombre a la lista.
                if (repetido == false)
                {
                    listNombre.Items.Add(txtBoxAgregar.Text.Trim());    /// Quita los espacios del inicio y final de la cadena
                    txtBoxAgregar.Text = "";                            /// al momento de agregar el nombre al List Box.
                }                                                      /// Vuelve a poner en blanco el Text Box

            }
        }       

        private void BtnFlechita_Click(object sender, EventArgs e)
        {
            if (listNombre.Items.Count > 0)
            {
                if (listNombre.SelectedItem == null)
                {
                    MessageBox.Show("¡Seleccione un nombre de la lista izquierda para transferirlo a la derecha!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int index = listNombre.SelectedIndex;
                    listNombreAgregado.Items.Add(listNombre.SelectedItem);
                    listNombre.Items.RemoveAt(index);
                }
            }
            else
            {
                MessageBox.Show("LA LISTA ESTÁ VACÍA. NO SE PUEDEN TRANSFERIR ELEMENTOS", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFechitaTodo_Click(object sender, EventArgs e)
        {
            if(listNombre.Items.Count > 0)
            {
                 listNombreAgregado.Items.AddRange(listNombre.Items);
                 listNombre.Items.Clear();
            }
            else
            {
                MessageBox.Show("¡No hay ningun nombre en la lista izquierda para transferirlo a la derecha, Por favor ingrese un nombre!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBoxAgregar_TextChanged(object sender, EventArgs e)
        {
            char[] cadenatxt = txtBoxAgregar.Text.Trim().ToCharArray();
            bool carInvalido = cadenatxt.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c));

            if (!carInvalido)
            {
                ptbxImagenEstado.Image = Properties.Resources.cheque;
                lblMensajeUsuario.ForeColor = Color.Green;
                lblMensajeUsuario.Text = "Nombre Válido";
                btnAgregar.Enabled = true;
            }
            else
            {
                ptbxImagenEstado.Image = Properties.Resources.cancelar;
                lblMensajeUsuario.ForeColor = Color.Red;
                lblMensajeUsuario.Text = "Nombre no Válido";
                btnAgregar.Enabled = false;

            }

            if (string.IsNullOrEmpty(txtBoxAgregar.Text.Trim()))
            {
                ptbxImagenEstado.Image = null;
                lblMensajeUsuario.Text = "";
            }
        }

        private void tmrClock1_Tick(object sender, EventArgs e)
        {
            ptbxImagenEstado.Image = null;
            lblMensajeUsuario.Text = "";
            tmrClock1.Stop();
        }
    }
}
