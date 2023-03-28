﻿using System;
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
            if (string.IsNullOrEmpty(txtBoxAgregar.Text) || txtBoxAgregar.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre!");
                txtBoxAgregar.Text = "";        /// Después de mostrar cartel deja vacío el Text Box).
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
            }

        }

        private void txtBoxAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO LETRAS", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void btnFlechita_Click(object sender, EventArgs e)
        {
            if (listNombre.Items.Count > 0)
            {
                int index = listNombre.SelectedIndex;
                listNombreAgregado.Items.Add(listNombre.SelectedItem);
                listNombre.Items.RemoveAt(index);
            }
        }
    }
}
