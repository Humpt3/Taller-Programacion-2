namespace Proyecto2._0
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
            this.LDni = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNya = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(35, 89);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(23, 13);
            this.LDni.TabIndex = 0;
            this.LDni.Text = "Dni";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(35, 199);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(35, 145);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "Apellido";
            this.LApellido.Click += new System.EventHandler(this.label3_Click);
            // 
            // LNya
            // 
            this.LNya.AutoSize = true;
            this.LNya.Location = new System.Drawing.Point(35, 33);
            this.LNya.Name = "LNya";
            this.LNya.Size = new System.Drawing.Size(95, 13);
            this.LNya.TabIndex = 3;
            this.LNya.Text = "Nombre y Apellido:";
            this.LNya.Click += new System.EventHandler(this.label4_Click);
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.ForeColor = System.Drawing.Color.Red;
            this.LModificar.Location = new System.Drawing.Point(150, 33);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(50, 13);
            this.LModificar.TabIndex = 4;
            this.LModificar.Text = "Modificar";
            // 
            // TDni
            // 
            this.TDni.Location = new System.Drawing.Point(122, 86);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(100, 20);
            this.TDni.TabIndex = 5;
            this.TDni.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(122, 145);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(100, 20);
            this.TApellido.TabIndex = 6;
            this.TApellido.TextChanged += new System.EventHandler(this.TApellido_TextChanged);
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(122, 199);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(100, 20);
            this.TNombre.TabIndex = 7;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(38, 261);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(75, 23);
            this.BGuardar.TabIndex = 8;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(147, 261);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(75, 23);
            this.BEliminar.TabIndex = 9;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 345);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.LModificar);
            this.Controls.Add(this.LNya);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LDni);
            this.Name = "Form1";
            this.Text = "Pequeño Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNya;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
    }
}

