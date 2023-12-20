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
    public partial class Form08ValidarISBN : Form
    {
        public Form08ValidarISBN()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = this.txtISBN.Text;

            if (isbn.Length < 10)
            {
                lblResultado.Text = "El ISBN debe tener 10 caracteres.";
            }

            int suma = 0; 

            for (int i = 0; i < 10; i++)
            {
                char caracter = isbn[i];

                int numero = int.Parse(caracter.ToString());

                int op = numero * (i+1);

                suma += op;

            }
            int ola = suma % 11;
            if (suma%11 == 0) 
            {
                lblResultado.Text = "El ISBN Es válido";
            }
            else
            {
                lblResultado.Text = "El ISBN no es válido";
            }


        }
    }
}
