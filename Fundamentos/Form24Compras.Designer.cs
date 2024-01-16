namespace Fundamentos
{
    partial class Form24Compras
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
            lstProductos = new ListBox();
            label3 = new Label();
            btnGuardar = new Button();
            btnLeer = new Button();
            btnNuevoProducto = new Button();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 15;
            lstProductos.Location = new Point(161, 40);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(254, 214);
            lstProductos.TabIndex = 17;
            lstProductos.SelectedIndexChanged += lstProductos_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 17);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 16;
            label3.Text = "Productos";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 226);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 23);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(12, 186);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(114, 23);
            btnLeer.TabIndex = 14;
            btnLeer.Text = "Leer Productos";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(12, 145);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(114, 23);
            btnNuevoProducto.TabIndex = 13;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(12, 96);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre:";
            // 
            // Form24Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 340);
            Controls.Add(lstProductos);
            Controls.Add(label3);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(btnNuevoProducto);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form24Compras";
            Text = "Form24Compras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstProductos;
        private Label label3;
        private Button btnGuardar;
        private Button btnLeer;
        private Button btnNuevoProducto;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
    }
}