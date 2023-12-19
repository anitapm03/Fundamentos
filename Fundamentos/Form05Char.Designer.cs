namespace Fundamentos
{
    partial class Form05Char
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtLetras = new TextBox();
            txtSimbolos = new TextBox();
            txtDigitos = new TextBox();
            txtPuntuacion = new TextBox();
            btnRecorrer = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 32);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Letras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 32);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Digitos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 201);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "Puntuacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 201);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Simbolos";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(29, 50);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(149, 101);
            txtLetras.TabIndex = 4;
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(29, 219);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(149, 101);
            txtSimbolos.TabIndex = 5;
            // 
            // txtDigitos
            // 
            txtDigitos.Location = new Point(265, 50);
            txtDigitos.Multiline = true;
            txtDigitos.Name = "txtDigitos";
            txtDigitos.Size = new Size(149, 101);
            txtDigitos.TabIndex = 6;
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(265, 219);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(149, 101);
            txtPuntuacion.TabIndex = 7;
            // 
            // btnRecorrer
            // 
            btnRecorrer.Location = new Point(158, 366);
            btnRecorrer.Name = "btnRecorrer";
            btnRecorrer.Size = new Size(135, 47);
            btnRecorrer.TabIndex = 8;
            btnRecorrer.Text = "Recorrer ASCII";
            btnRecorrer.UseVisualStyleBackColor = true;
            btnRecorrer.Click += btnRecorrer_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRecorrer);
            Controls.Add(txtPuntuacion);
            Controls.Add(txtDigitos);
            Controls.Add(txtSimbolos);
            Controls.Add(txtLetras);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtLetras;
        private TextBox txtSimbolos;
        private TextBox txtDigitos;
        private TextBox txtPuntuacion;
        private Button btnRecorrer;
    }
}