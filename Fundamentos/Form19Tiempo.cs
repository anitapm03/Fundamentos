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
    public partial class Form19Tiempo : Form
    {
        List<Label> meses;
        int[] temperaturas = new int[12];
        public Form19Tiempo()
        {
            InitializeComponent();

            this.meses = new List<Label>();

            string[] textoMeses = { "Enero: ", "Febrero: ", "Marzo: ", "Abril: ", "Mayo: ", "Junio: ", "Julio: ", "Agosto: ", "Septiembre: ", "Octubre: ", "Noviembre: ", "Diciembre: " };

            foreach (Label label in this.panel1.Controls)
            {
                meses.Add(label);
            }

            this.meses.Reverse();

            for (int i = 0; i < textoMeses.Length; i++)
            {
                this.meses[i].Text = textoMeses[i];
            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();


            int cont = 0;

            foreach (Label lbl in meses)
            {
                int num = rnd.Next(-20, 41);

                this.temperaturas[cont] = num;

                lbl.Text += num.ToString();

                cont++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int minima = 0;
            int maxima = 0;


            for (int i = 0; i < 12; i++)
            {
                suma += this.temperaturas[i];

                if (this.temperaturas[i] < minima)
                {
                    minima = this.temperaturas[i];
                }

                if (this.temperaturas[i] > maxima)
                {
                    maxima = this.temperaturas[i];
                }
            }

            int media = suma / 12;

            this.txtMedia.Text = media.ToString();
            this.txtMaxima.Text = maxima.ToString();
            this.txtMinima.Text = minima.ToString();
        }
    }
}
