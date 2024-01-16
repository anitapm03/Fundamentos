namespace Fundamentos
{
    partial class Form27ColeccionBinaryMascotas
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
            btnLeerDatos = new Button();
            lstMascotas = new ListBox();
            label4 = new Label();
            btnGuardarDato = new Button();
            btnNuevaMascota = new Button();
            txtEdad = new TextBox();
            label3 = new Label();
            txtRaza = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLeerDatos
            // 
            btnLeerDatos.Location = new Point(324, 28);
            btnLeerDatos.Name = "btnLeerDatos";
            btnLeerDatos.Size = new Size(113, 23);
            btnLeerDatos.TabIndex = 29;
            btnLeerDatos.Text = "Leer Datos";
            btnLeerDatos.UseVisualStyleBackColor = true;
            btnLeerDatos.Click += btnLeerDatos_Click;
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.ItemHeight = 15;
            lstMascotas.Location = new Point(178, 27);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(138, 214);
            lstMascotas.TabIndex = 28;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 9);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 27;
            label4.Text = "Mascotas:";
            // 
            // btnGuardarDato
            // 
            btnGuardarDato.Location = new Point(324, 64);
            btnGuardarDato.Name = "btnGuardarDato";
            btnGuardarDato.Size = new Size(113, 23);
            btnGuardarDato.TabIndex = 26;
            btnGuardarDato.Text = "Guardar Dato";
            btnGuardarDato.UseVisualStyleBackColor = true;
            btnGuardarDato.Click += btnGuardarDato_Click;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(12, 195);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(113, 23);
            btnNuevaMascota.TabIndex = 25;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(12, 143);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(113, 23);
            txtEdad.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 23;
            label3.Text = "Edad:";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(12, 82);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(113, 23);
            txtRaza.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 21;
            label2.Text = "Raza:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(113, 23);
            txtNombre.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 19;
            label1.Text = "Nombre:\r\n";
            // 
            // Form27ColeccionBinaryMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 273);
            Controls.Add(btnLeerDatos);
            Controls.Add(lstMascotas);
            Controls.Add(label4);
            Controls.Add(btnGuardarDato);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form27ColeccionBinaryMascotas";
            Text = "Form27ColeccionBinaryMascotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeerDatos;
        private ListBox lstMascotas;
        private Label label4;
        private Button btnGuardarDato;
        private Button btnNuevaMascota;
        private TextBox txtEdad;
        private Label label3;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
    }
}