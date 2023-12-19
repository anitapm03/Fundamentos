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
    public partial class Form05Char : Form
    {
        public Form05Char()
        {
            InitializeComponent();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++)
            {
                //convertimos el int a char
                char caracter = (char)i;

                if (char.IsLetter(caracter) == true)
                {
                    this.txtLetras.Text = this.txtLetras.Text + caracter;
                }
                else if (char.IsDigit(caracter) == true)
                {
                    this.txtDigitos.Text += caracter;
                }
                else if (char.IsSymbol(caracter) == true)
                {
                    this.txtSimbolos.Text += caracter;
                }
                else if (char.IsPunctuation(caracter) == true)
                {
                    this.txtPuntuacion.Text += caracter;
                }
            }
        }
    }
}
