using ProyectoClases.Helpers;
using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form24Compras : Form
    {
        HelperCompra helper;

        public Form24Compras()
        {
            InitializeComponent();
            this.helper = new HelperCompra();
        }

        private void DibujarCompraLista()
        {
            this.lstProductos.Items.Clear();

            foreach (Compra compra in this.helper.Compras)
            {
                this.lstProductos.Items.Add(compra.Nombre + ", " + compra.Precio + "€");
            }
        }
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();

            compra.Nombre = this.txtNombre.Text;
            compra.Precio = int.Parse(this.txtPrecio.Text); 

            this.helper.Compras.Add(compra);

            this.DibujarCompraLista();
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;

                await this.helper.ReadComprasAsync(path);
                this.DibujarCompraLista();

            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();

            if (svf.ShowDialog() == DialogResult.OK)
            {
                string path = svf.FileName; 

                await this.helper.WriteComprasAsync(path);
                MessageBox.Show("Compra guardada");
            }
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstProductos.SelectedIndex;

            if (indice != -1)
            {
                Compra compra = this.helper.Compras[indice];

                this.txtNombre.Text = compra.Nombre;
                this.txtPrecio.Text = compra.Precio.ToString();
            }
        }
    }
}
