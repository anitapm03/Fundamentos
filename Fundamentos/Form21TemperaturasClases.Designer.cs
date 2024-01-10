namespace Fundamentos
{
    partial class Form21TemperaturasClases
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
            txtMedia = new TextBox();
            txtMinima = new TextBox();
            txtMaxima = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            button2 = new Button();
            btnGenerar = new Button();
            label1 = new Label();
            lstMeses = new ListBox();
            SuspendLayout();
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(239, 397);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(109, 23);
            txtMedia.TabIndex = 19;
            // 
            // txtMinima
            // 
            txtMinima.Location = new Point(239, 319);
            txtMinima.Name = "txtMinima";
            txtMinima.Size = new Size(109, 23);
            txtMinima.TabIndex = 18;
            // 
            // txtMaxima
            // 
            txtMaxima.Location = new Point(239, 221);
            txtMaxima.Name = "txtMaxima";
            txtMaxima.Size = new Size(109, 23);
            txtMaxima.TabIndex = 17;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(257, 366);
            label16.Name = "label16";
            label16.Size = new Size(74, 15);
            label16.TabIndex = 16;
            label16.Text = "Media Anual";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(231, 275);
            label15.Name = "label15";
            label15.Size = new Size(117, 15);
            label15.TabIndex = 15;
            label15.Text = "Temperatura Mínima";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(229, 187);
            label14.Name = "label14";
            label14.Size = new Size(119, 15);
            label14.TabIndex = 14;
            label14.Text = "Temperatura Máxima";
            // 
            // button2
            // 
            button2.Location = new Point(239, 116);
            button2.Name = "button2";
            button2.Size = new Size(109, 49);
            button2.TabIndex = 13;
            button2.Text = "Mostrar Datos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(239, 42);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(109, 49);
            btnGenerar.TabIndex = 12;
            btnGenerar.Text = "Generar Meses";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 10;
            label1.Text = "Meses";
            // 
            // lstMeses
            // 
            lstMeses.FormattingEnabled = true;
            lstMeses.ItemHeight = 15;
            lstMeses.Location = new Point(26, 42);
            lstMeses.Name = "lstMeses";
            lstMeses.Size = new Size(169, 379);
            lstMeses.TabIndex = 20;
            // 
            // Form21TemperaturasClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 470);
            Controls.Add(lstMeses);
            Controls.Add(txtMedia);
            Controls.Add(txtMinima);
            Controls.Add(txtMaxima);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(button2);
            Controls.Add(btnGenerar);
            Controls.Add(label1);
            Name = "Form21TemperaturasClases";
            Text = "Form21TemperaturasClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMedia;
        private TextBox txtMinima;
        private TextBox txtMaxima;
        private Label label16;
        private Label label15;
        private Label label14;
        private Button button2;
        private Button btnGenerar;
        private Label label1;
        private ListBox lstMeses;
    }
}