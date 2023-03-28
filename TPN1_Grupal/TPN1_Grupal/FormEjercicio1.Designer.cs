
namespace TPN1_Grupal
{
    partial class FormEjercicio1
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
            this.lblAgregarNombre = new System.Windows.Forms.Label();
            this.txtBoxAgregar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listNombre = new System.Windows.Forms.ListBox();
            this.listNombreAgregado = new System.Windows.Forms.ListBox();
            this.btnFlechita = new System.Windows.Forms.Button();
            this.btnFechitaTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAgregarNombre
            // 
            this.lblAgregarNombre.AutoSize = true;
            this.lblAgregarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarNombre.Location = new System.Drawing.Point(127, 42);
            this.lblAgregarNombre.Name = "lblAgregarNombre";
            this.lblAgregarNombre.Size = new System.Drawing.Size(143, 16);
            this.lblAgregarNombre.TabIndex = 0;
            this.lblAgregarNombre.Text = "Ingrese un Nombre:";
            // 
            // txtBoxAgregar
            // 
            this.txtBoxAgregar.Location = new System.Drawing.Point(272, 41);
            this.txtBoxAgregar.Name = "txtBoxAgregar";
            this.txtBoxAgregar.Size = new System.Drawing.Size(352, 20);
            this.txtBoxAgregar.TabIndex = 1;
            this.txtBoxAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAgregar_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(630, 37);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 27);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listNombre
            // 
            this.listNombre.FormattingEnabled = true;
            this.listNombre.Location = new System.Drawing.Point(130, 129);
            this.listNombre.Name = "listNombre";
            this.listNombre.Size = new System.Drawing.Size(217, 264);
            this.listNombre.TabIndex = 3;
            // 
            // listNombreAgregado
            // 
            this.listNombreAgregado.FormattingEnabled = true;
            this.listNombreAgregado.Location = new System.Drawing.Point(488, 129);
            this.listNombreAgregado.Name = "listNombreAgregado";
            this.listNombreAgregado.Size = new System.Drawing.Size(217, 264);
            this.listNombreAgregado.TabIndex = 4;
            // 
            // btnFlechita
            // 
            this.btnFlechita.Location = new System.Drawing.Point(379, 193);
            this.btnFlechita.Name = "btnFlechita";
            this.btnFlechita.Size = new System.Drawing.Size(75, 39);
            this.btnFlechita.TabIndex = 5;
            this.btnFlechita.Text = ">";
            this.btnFlechita.UseVisualStyleBackColor = true;
            this.btnFlechita.Click += new System.EventHandler(this.btnFlechita_Click);
            // 
            // btnFechitaTodo
            // 
            this.btnFechitaTodo.Location = new System.Drawing.Point(379, 268);
            this.btnFechitaTodo.Name = "btnFechitaTodo";
            this.btnFechitaTodo.Size = new System.Drawing.Size(75, 38);
            this.btnFechitaTodo.TabIndex = 6;
            this.btnFechitaTodo.Text = ">>";
            this.btnFechitaTodo.UseVisualStyleBackColor = true;
            // 
            // FormEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechitaTodo);
            this.Controls.Add(this.btnFlechita);
            this.Controls.Add(this.listNombreAgregado);
            this.Controls.Add(this.listNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBoxAgregar);
            this.Controls.Add(this.lblAgregarNombre);
            this.Name = "FormEjercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarNombre;
        private System.Windows.Forms.TextBox txtBoxAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listNombre;
        private System.Windows.Forms.ListBox listNombreAgregado;
        private System.Windows.Forms.Button btnFlechita;
        private System.Windows.Forms.Button btnFechitaTodo;
    }
}