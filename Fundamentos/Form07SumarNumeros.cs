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
    public partial class Form07SumarNumeros : Form
    {
        public Form07SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string textoSuma = this.txtNumeros.Text;
            int suma = 0;

            for (int i = 0; i < textoSuma.Length; i++)
            {
                char caracter = textoSuma[i];

                //convertimos el char a numero
                // int numero = Convert.ToInt32(caracter.ToString())
                int numero = int.Parse(caracter.ToString());
                suma += numero;
            }

            this.lblResultado.Text = suma.ToString();
        }
    }
}
