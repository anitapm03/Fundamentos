using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form09LetraDNI : Form
    {
        public Form09LetraDNI()
        {
            InitializeComponent();
        }

        private void Form09LetraDNI_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(this.txtNumeros.Text);


            // Calcular el valor de la resta
            int resto = dni - ((dni / 23) * 23);

            // Tabla de equivalencia
            char[] letrasDNI = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            // Obtener la letra correspondiente
            char letra = letrasDNI[resto];

            this.lblResultado.Text = letra.ToString();
        }
    }
}
