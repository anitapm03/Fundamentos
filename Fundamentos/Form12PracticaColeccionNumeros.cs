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
    public partial class Form12PracticaColeccionNumeros : Form
    {
        public Form12PracticaColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {

                int num = rnd.Next(0, 100);
                this.lstNumeros.Items.Add(num);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int sumaPar = 0;
            int sumaImpar = 0;

            foreach (int num in this.lstNumeros.Items) 
            {
                suma += num;

                if (num % 2 == 0)
                {
                    sumaPar += num;
                }else
                {
                    sumaImpar += num;
                }
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = sumaPar.ToString();
            this.txtImpares.Text = sumaImpar.ToString();
        }
    }
}
