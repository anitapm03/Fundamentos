namespace Fundamentos
{
    partial class Form08ValidarISBN
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
            lblResultado = new Label();
            txtISBN = new TextBox();
            label1 = new Label();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(27, 114);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(56, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "resultado";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(27, 43);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(179, 23);
            txtISBN.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 5;
            label1.Text = "Introduce el ISBN";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(27, 72);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 4;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form08ValidarISBN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtISBN);
            Controls.Add(label1);
            Controls.Add(btnValidar);
            Name = "Form08ValidarISBN";
            Text = "Form08ValidarISBN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private TextBox txtISBN;
        private Label label1;
        private Button btnValidar;
    }
}