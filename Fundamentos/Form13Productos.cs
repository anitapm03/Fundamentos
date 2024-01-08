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
    public partial class Form13Productos : Form
    {
        public Form13Productos()
        {
            InitializeComponent();
            //cambiamos a seleccion multiple+
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
            //this.lstAlmacen.SelectionMode = SelectionMode.MultiExtended;

            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string prod = this.txtProducto.Text;
            this.lstTienda.Items.Add(prod);
            this.txtProducto.Focus();
            this.txtProducto.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int numSeleccionados = this.lstTienda.SelectedIndices.Count;
            //recorremos los indices seleccionados
            for (int i = numSeleccionados - 1; i >= 0; i--)
            {
                //recuperamos cada indice 
                int indice = this.lstTienda.SelectedIndices[i];

                //eliminamos cada elemento por su indice
                this.lstTienda.Items.RemoveAt(indice);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text.ToString();

            int indice = int.Parse(this.lstTienda.SelectedIndex.ToString());

            this.lstTienda.Items[indice] = producto;

        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            int numSeleccionados = this.lstTienda.SelectedIndices.Count;
            //recorremos los indices seleccionados
            for (int i = numSeleccionados - 1; i >= 0; i--)
            {
                //recuperamos cada indice 
                int indice = this.lstTienda.SelectedIndices[i];

                string producto = this.lstTienda.Items[i].ToString();

                this.lstAlmacen.Items.Add(producto);

                this.lstTienda.Items.RemoveAt(indice);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int numProductos = this.lstTienda.Items.Count;

            for (int i = numProductos - 1; i >= 0; i--)
            {
                string p = this.lstTienda.Items[i].ToString();

                this.lstAlmacen.Items.Add(p);

                this.lstTienda.Items.RemoveAt(i);
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            string prod = this.lstAlmacen.Items[indice].ToString();
            this.lstAlmacen.Items.RemoveAt(indice);
            this.lstAlmacen.Items.Insert(indice - 1, prod);
            this.lstAlmacen.SelectedIndex = indice - 1;

        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int indice = this.lstAlmacen.SelectedIndex;
            string prod = this.lstAlmacen.Items[indice].ToString();
            this.lstAlmacen.Items.RemoveAt(indice);
            this.lstAlmacen.Items.Insert(indice + 1, prod);
            this.lstAlmacen.SelectedIndex = indice + 1;
        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = this.lstAlmacen.SelectedIndex;

            if (indiceSeleccionado == 0)
            {
                this.btnSubir.Enabled = false;
            }
            else
            {
                this.btnSubir.Enabled = true;
            }

            if (indiceSeleccionado == this.lstAlmacen.Items.Count - 1 )
            {
                this.btnSubir.Enabled = false;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
        }
    }
}
