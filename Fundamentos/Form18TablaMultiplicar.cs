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
    public partial class Form18TablaMultiplicar : Form
    {
        List<TextBox> cajas;
        int numero;

        public Form18TablaMultiplicar()
        {
            InitializeComponent();

            this.cajas = new List<TextBox>();

            foreach (TextBox t in this.panel1.Controls)
            {
                cajas.Add(t);
            }

            this.cajas.Reverse();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.numero = int.Parse(this.txtNumero.Text);

            int resultado = 0;
            for (int i = 0; i < this.cajas.Count; i++)
            {
                resultado = this.numero * i;

                string operacion = this.numero + " * " + i + " = " + resultado;

                this.cajas[i].Text = operacion;
            }

        }

        
    }
}
