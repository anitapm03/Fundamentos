namespace Fundamentos
{
    partial class Form04DateTime
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
            chkCambiar = new CheckBox();
            txtFecha = new TextBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnios = new RadioButton();
            groupBox1 = new GroupBox();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            label2 = new Label();
            txtNuevaFecha = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 31);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha Actual:";
            // 
            // chkCambiar
            // 
            chkCambiar.AutoSize = true;
            chkCambiar.Location = new Point(29, 104);
            chkCambiar.Name = "chkCambiar";
            chkCambiar.Size = new Size(149, 19);
            chkCambiar.TabIndex = 1;
            chkCambiar.Text = "Cambiar formato fecha";
            chkCambiar.UseVisualStyleBackColor = true;
            chkCambiar.CheckedChanged += chkCambiar_CheckedChanged;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(29, 63);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(293, 23);
            txtFecha.TabIndex = 2;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(24, 25);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Dias";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(24, 50);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 4;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnios
            // 
            rdbAnios.AutoSize = true;
            rdbAnios.Location = new Point(24, 75);
            rdbAnios.Name = "rdbAnios";
            rdbAnios.Size = new Size(52, 19);
            rdbAnios.TabIndex = 5;
            rdbAnios.TabStop = true;
            rdbAnios.Text = "Años";
            rdbAnios.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIncremento);
            groupBox1.Controls.Add(btnIncrementar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdbAnios);
            groupBox1.Controls.Add(rdbDias);
            groupBox1.Controls.Add(rdbMeses);
            groupBox1.Location = new Point(29, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 140);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Grupo Radiobuttons";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(164, 43);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 8;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(176, 75);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(88, 23);
            btnIncrementar.TabIndex = 7;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 19);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 6;
            label2.Text = "Incremento";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(29, 356);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(293, 23);
            txtNuevaFecha.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 328);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 8;
            label3.Text = "Nueva Fecha";
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtNuevaFecha);
            Controls.Add(groupBox1);
            Controls.Add(txtFecha);
            Controls.Add(chkCambiar);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            Load += Form04DateTime_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox chkCambiar;
        private TextBox txtFecha;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnios;
        private GroupBox groupBox1;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private Label label2;
        private TextBox txtNuevaFecha;
        private Label label3;
    }
}