namespace Fundamentos
{
    partial class Form02PosicionColores
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
            txtPosX = new TextBox();
            txtPosY = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCambiarPos = new Button();
            label3 = new Label();
            label4 = new Label();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnColor = new Button();
            txtAzul = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(101, 49);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(100, 23);
            txtPosX.TabIndex = 10;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(101, 76);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(100, 23);
            txtPosY.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 79);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 8;
            label2.Text = "Posición Y: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 49);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 7;
            label1.Text = "Posición X: ";
            // 
            // btnCambiarPos
            // 
            btnCambiarPos.Location = new Point(29, 115);
            btnCambiarPos.Name = "btnCambiarPos";
            btnCambiarPos.Size = new Size(75, 23);
            btnCambiarPos.TabIndex = 6;
            btnCambiarPos.Text = "Mover!";
            btnCambiarPos.UseVisualStyleBackColor = true;
            btnCambiarPos.Click += btnCambiarPos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 18);
            label3.Name = "label3";
            label3.Size = new Size(157, 15);
            label3.TabIndex = 12;
            label3.Text = "Cambiar posición del botón ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 176);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 18;
            label4.Text = "Cambiar color del fondo";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(101, 207);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 17;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(101, 234);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 237);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 15;
            label5.Text = "Verde:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 207);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 14;
            label6.Text = "Rojo:";
            // 
            // btnColor
            // 
            btnColor.Location = new Point(43, 305);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(122, 23);
            btnColor.TabIndex = 13;
            btnColor.Text = "Cambiar color!";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(101, 264);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 272);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 19;
            label7.Text = "Azul:";
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAzul);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(txtRojo);
            Controls.Add(txtVerde);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btnColor);
            Controls.Add(label3);
            Controls.Add(txtPosX);
            Controls.Add(txtPosY);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCambiarPos);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            Load += Form02PosicionColores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPosX;
        private TextBox txtPosY;
        private Label label2;
        private Label label1;
        private Button btnCambiarPos;
        private Label label3;
        private Label label4;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private Label label5;
        private Label label6;
        private Button btnColor;
        private TextBox txtAzul;
        private Label label7;
    }
}