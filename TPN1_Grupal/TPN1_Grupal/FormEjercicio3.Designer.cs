
namespace TPN1_Grupal
{
    partial class FormEjercicio3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMas = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSol = new System.Windows.Forms.RadioButton();
            this.rbCas = new System.Windows.Forms.RadioButton();
            this.chlOcupacion = new System.Windows.Forms.CheckedListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMas);
            this.groupBox1.Controls.Add(this.rbFem);
            this.groupBox1.Location = new System.Drawing.Point(47, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(185, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbMas
            // 
            this.rbMas.AutoSize = true;
            this.rbMas.Location = new System.Drawing.Point(20, 62);
            this.rbMas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMas.Name = "rbMas";
            this.rbMas.Size = new System.Drawing.Size(92, 21);
            this.rbMas.TabIndex = 1;
            this.rbMas.TabStop = true;
            this.rbMas.Text = "Masculino";
            this.rbMas.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(20, 34);
            this.rbFem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(91, 21);
            this.rbFem.TabIndex = 0;
            this.rbFem.Text = "Femenino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSol);
            this.groupBox2.Controls.Add(this.rbCas);
            this.groupBox2.Location = new System.Drawing.Point(348, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(191, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Civil";
            // 
            // rbSol
            // 
            this.rbSol.AutoSize = true;
            this.rbSol.Location = new System.Drawing.Point(16, 62);
            this.rbSol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSol.Name = "rbSol";
            this.rbSol.Size = new System.Drawing.Size(74, 21);
            this.rbSol.TabIndex = 3;
            this.rbSol.Text = "Soltero";
            this.rbSol.UseVisualStyleBackColor = true;
            // 
            // rbCas
            // 
            this.rbCas.AutoSize = true;
            this.rbCas.Location = new System.Drawing.Point(16, 34);
            this.rbCas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCas.Name = "rbCas";
            this.rbCas.Size = new System.Drawing.Size(77, 21);
            this.rbCas.TabIndex = 2;
            this.rbCas.Text = "Casado";
            this.rbCas.UseVisualStyleBackColor = true;
            // 
            // chlOcupacion
            // 
            this.chlOcupacion.CheckOnClick = true;
            this.chlOcupacion.FormattingEnabled = true;
            this.chlOcupacion.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.chlOcupacion.Location = new System.Drawing.Point(167, 220);
            this.chlOcupacion.Name = "chlOcupacion";
            this.chlOcupacion.Size = new System.Drawing.Size(258, 123);
            this.chlOcupacion.TabIndex = 2;
            this.chlOcupacion.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(167, 349);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(258, 32);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar lo que se seleccionó";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(99, 410);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(0, 17);
            this.lblMostrar.TabIndex = 4;
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(593, 651);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.chlOcupacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEjercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMas;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSol;
        private System.Windows.Forms.RadioButton rbCas;
        private System.Windows.Forms.CheckedListBox chlOcupacion;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblMostrar;
    }
}