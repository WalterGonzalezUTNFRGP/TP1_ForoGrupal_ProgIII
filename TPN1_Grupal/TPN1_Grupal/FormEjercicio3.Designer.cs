
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
            this.LBLtexto = new System.Windows.Forms.Label();
            this.LBLoficio = new System.Windows.Forms.Label();
            this.LBLestado = new System.Windows.Forms.Label();
            this.LBLgenero = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMas);
            this.groupBox1.Controls.Add(this.rbFem);
            this.groupBox1.Location = new System.Drawing.Point(35, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbMas
            // 
            this.rbMas.AutoSize = true;
            this.rbMas.Location = new System.Drawing.Point(15, 50);
            this.rbMas.Name = "rbMas";
            this.rbMas.Size = new System.Drawing.Size(73, 17);
            this.rbMas.TabIndex = 1;
            this.rbMas.Text = "Masculino";
            this.rbMas.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Checked = true;
            this.rbFem.Location = new System.Drawing.Point(15, 28);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(71, 17);
            this.rbFem.TabIndex = 0;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Femenino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSol);
            this.groupBox2.Controls.Add(this.rbCas);
            this.groupBox2.Location = new System.Drawing.Point(261, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Civil";
            // 
            // rbSol
            // 
            this.rbSol.AutoSize = true;
            this.rbSol.Location = new System.Drawing.Point(12, 50);
            this.rbSol.Name = "rbSol";
            this.rbSol.Size = new System.Drawing.Size(58, 17);
            this.rbSol.TabIndex = 3;
            this.rbSol.Text = "Soltero";
            this.rbSol.UseVisualStyleBackColor = true;
            // 
            // rbCas
            // 
            this.rbCas.AutoSize = true;
            this.rbCas.Checked = true;
            this.rbCas.Location = new System.Drawing.Point(12, 28);
            this.rbCas.Name = "rbCas";
            this.rbCas.Size = new System.Drawing.Size(61, 17);
            this.rbCas.TabIndex = 2;
            this.rbCas.TabStop = true;
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
            this.chlOcupacion.Location = new System.Drawing.Point(125, 179);
            this.chlOcupacion.Margin = new System.Windows.Forms.Padding(2);
            this.chlOcupacion.Name = "chlOcupacion";
            this.chlOcupacion.Size = new System.Drawing.Size(194, 94);
            this.chlOcupacion.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(125, 284);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(194, 26);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar lo que se seleccionó";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(74, 333);
            this.lblMostrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(0, 13);
            this.lblMostrar.TabIndex = 4;
            // 
            // LBLtexto
            // 
            this.LBLtexto.AutoSize = true;
            this.LBLtexto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLtexto.Location = new System.Drawing.Point(35, 320);
            this.LBLtexto.Name = "LBLtexto";
            this.LBLtexto.Size = new System.Drawing.Size(352, 22);
            this.LBLtexto.TabIndex = 6;
            this.LBLtexto.Text = "Usted Seleccionó los siguientes elementos:";
            // 
            // LBLoficio
            // 
            this.LBLoficio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLoficio.Location = new System.Drawing.Point(35, 377);
            this.LBLoficio.Name = "LBLoficio";
            this.LBLoficio.Size = new System.Drawing.Size(352, 92);
            this.LBLoficio.TabIndex = 9;
            this.LBLoficio.Text = "Oficio:";
            // 
            // LBLestado
            // 
            this.LBLestado.AutoSize = true;
            this.LBLestado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLestado.Location = new System.Drawing.Point(35, 358);
            this.LBLestado.Name = "LBLestado";
            this.LBLestado.Size = new System.Drawing.Size(115, 22);
            this.LBLestado.TabIndex = 8;
            this.LBLestado.Text = "Estado Civil:";
            // 
            // LBLgenero
            // 
            this.LBLgenero.AutoSize = true;
            this.LBLgenero.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLgenero.Location = new System.Drawing.Point(35, 339);
            this.LBLgenero.Name = "LBLgenero";
            this.LBLgenero.Size = new System.Drawing.Size(54, 22);
            this.LBLgenero.TabIndex = 7;
            this.LBLgenero.Text = "Sexo:";
            // 
            // FormEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(445, 529);
            this.Controls.Add(this.LBLoficio);
            this.Controls.Add(this.LBLestado);
            this.Controls.Add(this.LBLgenero);
            this.Controls.Add(this.LBLtexto);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.chlOcupacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Label LBLtexto;
        private System.Windows.Forms.Label LBLoficio;
        private System.Windows.Forms.Label LBLestado;
        private System.Windows.Forms.Label LBLgenero;

    }
        
}
