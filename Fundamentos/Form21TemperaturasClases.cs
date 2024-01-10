using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyectoClases;

namespace Fundamentos
{
    public partial class Form21TemperaturasClases : Form
    {

        List <Mes> meses;
        public Form21TemperaturasClases()
        {
            InitializeComponent();
            this.meses = new List <Mes>();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.meses.Clear();
            this.lstMeses.Items.Clear();

            Random rnd = new Random();
            DateTime fecha = DateTime.Parse("01/01/2024");

            for (int i = 0; i < 12; i++)
            {
                int min = rnd.Next(-20, 0);
                int max = rnd.Next(0, 41);
                string nombre = fecha.ToString("MMMM");

                Mes m = new Mes();

                m.Nombre = nombre;
                m.Minima = min;
                m.Maxima = max;

                this.meses.Add(m);

                this.lstMeses.Items.Add(m.Nombre);

                fecha = fecha.AddMonths(1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indice = this.lstMeses.SelectedIndex;
            Mes mesSel = this.meses[indice];

            this.txtMaxima.Text = mesSel.Maxima.ToString();
            this.txtMinima.Text = mesSel.Minima.ToString();
            this.txtMedia.Text = mesSel.GetMedia().ToString();

        }
    }
}
