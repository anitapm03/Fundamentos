namespace Fundamentos
{
    partial class Form14Metodos
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
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnDobleValor = new Button();
            btnDobleRef = new Button();
            btnObjetoReferencia = new Button();
            lblMouse = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNum = new TextBox();
            txtLetras = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(24, 53);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(55, 99);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "label2";
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(24, 136);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(108, 23);
            btnDobleValor.TabIndex = 3;
            btnDobleValor.Text = "Doble valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleRef
            // 
            btnDobleRef.Location = new Point(24, 165);
            btnDobleRef.Name = "btnDobleRef";
            btnDobleRef.Size = new Size(108, 23);
            btnDobleRef.TabIndex = 4;
            btnDobleRef.Text = "Doble Referencia";
            btnDobleRef.UseVisualStyleBackColor = true;
            btnDobleRef.Click += btnDobleRef_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(24, 194);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(108, 23);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto Ref";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // lblMouse
            // 
            lblMouse.BackColor = SystemColors.MenuHighlight;
            lblMouse.Location = new Point(211, 153);
            lblMouse.Name = "lblMouse";
            lblMouse.Size = new Size(256, 241);
            lblMouse.TabIndex = 6;
            lblMouse.Text = "lblMouse";
            lblMouse.MouseMove += lblMouse_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 35);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Solo num";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 78);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 8;
            label3.Text = "Solo letras";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(278, 27);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 9;
            txtNum.KeyPress += txtNum_KeyPress;
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(278, 70);
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(100, 23);
            txtLetras.TabIndex = 10;
            txtLetras.KeyPress += txtLetras_KeyPress;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLetras);
            Controls.Add(txtNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblMouse);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleRef);
            Controls.Add(btnDobleValor);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            FormClosed += Form14Metodos_FormClosed;
            Load += Form14Metodos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnDobleValor;
        private Button btnDobleRef;
        private Button btnObjetoReferencia;
        private Label lblMouse;
        private Label label2;
        private Label label3;
        private TextBox txtNum;
        private TextBox txtLetras;
    }
}