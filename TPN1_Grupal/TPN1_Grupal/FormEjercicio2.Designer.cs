
namespace TPN1_Grupal
{
    partial class FormEjercicio2
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
            this.components = new System.ComponentModel.Container();
            this.LblNombreEj2 = new System.Windows.Forms.Label();
            this.LblApellidoEj2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.pApellido = new System.Windows.Forms.Panel();
            this.pNombre = new System.Windows.Forms.Panel();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombreEj2
            // 
            this.LblNombreEj2.AutoSize = true;
            this.LblNombreEj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreEj2.Location = new System.Drawing.Point(24, 136);
            this.LblNombreEj2.Name = "LblNombreEj2";
            this.LblNombreEj2.Size = new System.Drawing.Size(91, 24);
            this.LblNombreEj2.TabIndex = 1;
            this.LblNombreEj2.Text = "Nombre:";
            this.LblNombreEj2.Click += new System.EventHandler(this.LblNombreEj2_Click);
            // 
            // LblApellidoEj2
            // 
            this.LblApellidoEj2.AutoSize = true;
            this.LblApellidoEj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidoEj2.Location = new System.Drawing.Point(24, 188);
            this.LblApellidoEj2.Name = "LblApellidoEj2";
            this.LblApellidoEj2.Size = new System.Drawing.Size(93, 24);
            this.LblApellidoEj2.TabIndex = 2;
            this.LblApellidoEj2.Text = "Apellido:";
            this.LblApellidoEj2.Click += new System.EventHandler(this.LblApellidoEj2_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.pApellido);
            this.GroupBox1.Controls.Add(this.pNombre);
            this.GroupBox1.Controls.Add(this.TxtApellido);
            this.GroupBox1.Controls.Add(this.TxtNombre);
            this.GroupBox1.Controls.Add(this.BtnAgregar);
            this.GroupBox1.Controls.Add(this.LblNombreEj2);
            this.GroupBox1.Controls.Add(this.LblApellidoEj2);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(384, 426);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Ingreso De Datos";
            // 
            // pApellido
            // 
            this.pApellido.BackColor = System.Drawing.Color.DarkGray;
            this.pApellido.Location = new System.Drawing.Point(119, 212);
            this.pApellido.Name = "pApellido";
            this.pApellido.Size = new System.Drawing.Size(253, 3);
            this.pApellido.TabIndex = 7;
            // 
            // pNombre
            // 
            this.pNombre.BackColor = System.Drawing.Color.DarkGray;
            this.pNombre.Location = new System.Drawing.Point(119, 157);
            this.pNombre.Name = "pNombre";
            this.pNombre.Size = new System.Drawing.Size(253, 3);
            this.pNombre.TabIndex = 6;
            // 
            // TxtApellido
            // 
            this.TxtApellido.BackColor = System.Drawing.Color.White;
            this.TxtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(121, 189);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(251, 21);
            this.TxtApellido.TabIndex = 2;
            this.TxtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.White;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(121, 135);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(251, 21);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(119, 283);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(147, 49);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBorrar);
            this.groupBox2.Controls.Add(this.lbNombres);
            this.groupBox2.Location = new System.Drawing.Point(414, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 426);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elementos";
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.Location = new System.Drawing.Point(119, 356);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(147, 49);
            this.BtnBorrar.TabIndex = 5;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            // 
            // lbNombres
            // 
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.Location = new System.Drawing.Point(64, 29);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(252, 303);
            this.lbNombres.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FormEjercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "FormEjercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nombre y apellido";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblNombreEj2;
        private System.Windows.Forms.Label LblApellidoEj2;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.ListBox lbNombres;
        private System.Windows.Forms.Panel pApellido;
        private System.Windows.Forms.Panel pNombre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}