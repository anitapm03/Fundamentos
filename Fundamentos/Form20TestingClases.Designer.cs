namespace Fundamentos
{
    partial class Form20TestingClases
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
            label1 = new Label();
            btnCrearPersona = new Button();
            lstDatosClases = new ListBox();
            btnCrearEmpleado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos de Clases:";
            // 
            // btnCrearPersona
            // 
            btnCrearPersona.Location = new Point(307, 48);
            btnCrearPersona.Name = "btnCrearPersona";
            btnCrearPersona.Size = new Size(127, 54);
            btnCrearPersona.TabIndex = 2;
            btnCrearPersona.Text = "Crear Persona";
            btnCrearPersona.UseVisualStyleBackColor = true;
            btnCrearPersona.Click += btnCrearPersona_Click;
            // 
            // lstDatosClases
            // 
            lstDatosClases.FormattingEnabled = true;
            lstDatosClases.ItemHeight = 15;
            lstDatosClases.Location = new Point(12, 48);
            lstDatosClases.Name = "lstDatosClases";
            lstDatosClases.Size = new Size(268, 259);
            lstDatosClases.TabIndex = 3;
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.Location = new Point(307, 149);
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.Size = new Size(127, 51);
            btnCrearEmpleado.TabIndex = 4;
            btnCrearEmpleado.Text = "Crear empleado";
            btnCrearEmpleado.UseVisualStyleBackColor = true;
            btnCrearEmpleado.Click += btnCrearEmpleado_Click;
            // 
            // Form20TestingClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 332);
            Controls.Add(btnCrearEmpleado);
            Controls.Add(lstDatosClases);
            Controls.Add(btnCrearPersona);
            Controls.Add(label1);
            Name = "Form20TestingClases";
            Text = "Form20TestingClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnCrearPersona;
        private ListBox lstDatosClases;
        private Button btnCrearEmpleado;
    }
}