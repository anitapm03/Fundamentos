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
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            //cambiamos a seleccion multiple+
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtNuevoElemento.Focus();
            this.txtNuevoElemento.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            foreach (int indice in this.lstElementos.SelectedIndices)
            {
                indices += indice + ",";
            }
            this.lblIndiceSeleccionado.Text = indices.Trim(',');

            string items = "";
            foreach (string elem in this.lstElementos.SelectedItems)
            {
                items += elem + ",";
            }
            this.lblSeleccionado.Text += items.Trim(',');
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //al eliminar multiples elementos de una coleccion siempre 
            //debemos hacerlo desde el último al primero por el 
            //reposicionamiento de los indices

            int numSeleccionados = this.lstElementos.SelectedIndices.Count;
            //recorremos los indices seleccionados
            for (int i = numSeleccionados -1; i >= 0; i--)
            {
                //recuperamos cada indice 
                int indice = this.lstElementos.SelectedIndices[i];

                //eliminamos cada elemento por su indice
                this.lstElementos.Items.RemoveAt(indice);
            }
        }
    }
}
