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
    public partial class Form17SumarBotones : Form
    {
        List<Button> botones;
        int suma;
        public Form17SumarBotones()
        {
            InitializeComponent();

            this.botones = new List<Button>();
            this.suma = 0;

            foreach (Button button in this.panel1.Controls)
            {
                 botones.Add((Button)button);
            }

            Random rand = new Random();
            foreach (Button btn in botones)
            {
              
                int numeroAleatorio = rand.Next(0, 101); 
                btn.Text = numeroAleatorio.ToString();

                btn.Click += BotonPulsado;
            }
        }

        void BotonPulsado (object sender, EventArgs e)
        {
            //MessageBox.Show("ola");
            Button boton = (Button)sender;
            int numero = int.Parse(boton.Text.ToString());
            this.suma += numero;

            this.txtSuma.Text = suma.ToString();
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.suma = 0;
            this.txtSuma.Text = suma.ToString();

            Random rand = new Random();
            foreach (Button btn in botones)
            {

                int numeroAleatorio = rand.Next(0, 101);
                btn.Text = numeroAleatorio.ToString();

            }
        }
    }
}
