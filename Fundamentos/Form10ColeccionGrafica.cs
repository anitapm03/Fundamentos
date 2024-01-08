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
    public partial class Form10ColeccionGrafica : Form
    {
        public Form10ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtNuevoElemento.Text;
            this.lstElementos.Items.Add(elem);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //para eliminar tenemos dos opciones:
            //1 - Remove(objeto) Elimina un elemento enviando el objeto
            //2 - RemoveAt(indice) Elimina un elemento por su índice
            // recuperamos el indice seleccionado del listbox

            int indice = this.lstElementos.SelectedIndex;
            this.lstElementos.Items.RemoveAt(indice);

        }
        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();

        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndiceSeleccionado.Text =
                   this.lstElementos.SelectedIndex.ToString();

                this.lblSeleccionado.Text =
                    this.lstElementos.SelectedItem.ToString();
            }
        }
    }
}
