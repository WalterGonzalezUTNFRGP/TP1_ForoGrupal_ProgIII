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
                //txtBoxAgregar.BackColor = Color.Red;
                errorProvider1.SetError(txtBoxAgregar, "Ingrese un nombre válido");
                btnAgregar.Enabled = false;
                
                //MessageBox.Show("¡Debe ingresar un nombre!","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                                 /// Después de mostrar cartel deja vacío el Text Box).
                                                 /// Más que nada cuando se ingresan sólo espacios en blanco.

                
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
                        MessageBox.Show("El nombre ingresado ya se encuentra en la lista", "ATENCIÓN");
                        repetido = true;
                    }
                }
                // Si no hay repetido agrega el nombre a la lista.
                if (repetido == false)
                {
                    //txtBoxAgregar.Text.Trim();
                    listNombre.Items.Add(txtBoxAgregar.Text.Trim());    /// Quita los espacios del inicio y final de la cadena
                                                                        /// al momento de agregar el nombre al List Box.
                    txtBoxAgregar.Text = "";                            /// Vuelve a poner en blanco el Text Box
                }

                //txtBoxAgregar.BackColor = System.Drawing.SystemColors.Control;
            }



        }

        /*private void txtBoxAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
                if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
                {
                    if (e.KeyChar != 32)
                    {
                        MessageBox.Show("SOLO LETRAS", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                    }
                }
        }*/

        private void BtnFlechita_Click(object sender, EventArgs e)
        {
            if (listNombre.Items.Count > 0)
            {
                if (listNombre.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un nombre de la lista izquierda para transferirlo a la derecha!", "ATENCIÓN");
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
                MessageBox.Show("No hay ningun nombre en la lista izquierda para transferirlo a la derecha, Por favor ingrese un nombre!", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        

        private void TxtBoxAgregar_KeyUp(object sender, KeyEventArgs e)
        {
            if (Regex.IsMatch(txtBoxAgregar.Text.Trim(), "[^a-zA-ZáéíóúÁÉÍÓÚü ]"))
            {
                errorProvider1.SetError(txtBoxAgregar, "Debe ingresar un nombre válido");
                btnAgregar.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txtBoxAgregar, "");
                btnAgregar.Enabled = true;
            }
        }
    }
}
