namespace Formulario_Registro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbEstatura = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbEstatura = new System.Windows.Forms.TextBox();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(143, 43);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(53, 46);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre: ";
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(53, 90);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(52, 13);
            this.lbApellidos.TabIndex = 2;
            this.lbApellidos.Text = "Apellidos:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(53, 133);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(52, 13);
            this.lbTelefono.TabIndex = 3;
            this.lbTelefono.Text = "Telefono:";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(53, 179);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(35, 13);
            this.lbEdad.TabIndex = 4;
            this.lbEdad.Text = "Edad:";
            // 
            // lbEstatura
            // 
            this.lbEstatura.AutoSize = true;
            this.lbEstatura.Location = new System.Drawing.Point(53, 227);
            this.lbEstatura.Name = "lbEstatura";
            this.lbEstatura.Size = new System.Drawing.Size(49, 13);
            this.lbEstatura.TabIndex = 5;
            this.lbEstatura.Text = "Estatura:";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(143, 87);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(100, 20);
            this.tbApellidos.TabIndex = 6;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(143, 130);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 7;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(143, 176);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(100, 20);
            this.tbEdad.TabIndex = 8;
            // 
            // tbEstatura
            // 
            this.tbEstatura.Location = new System.Drawing.Point(143, 224);
            this.tbEstatura.Name = "tbEstatura";
            this.tbEstatura.Size = new System.Drawing.Size(100, 20);
            this.tbEstatura.TabIndex = 9;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(143, 273);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(62, 17);
            this.rbHombre.TabIndex = 10;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(211, 273);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 11;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(105, 311);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 12;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(211, 311);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 13;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 428);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.rbMujer);
            this.Controls.Add(this.rbHombre);
            this.Controls.Add(this.tbEstatura);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.lbEstatura);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.tbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbEstatura;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbEstatura;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btBorrar;
    }
}

