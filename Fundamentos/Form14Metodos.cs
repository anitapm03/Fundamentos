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
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            this.GetDobleValor(numero);
            this.lblResultado.Text = numero.ToString();
        }

        //recibimos el parametro wrapper por valor
        void GetDobleValor(int num)
        {
            num = num * 2;

        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleRef);
            this.CambiarColor(this.btnDobleValor);
        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.Yellow;
        }

        private void btnDobleRef_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            //tanto en el metodo como en la llamada hay
            //que usar la palabra ref
            //this.GetDobleReferencia(ref numero);

            //esta es la manera buena
            int doble = this.GetDobleOK(numero);
            this.lblResultado.Text = numero.ToString();
        }

        int GetDobleOK(int num)
        {
            int doble = num * 2;

            return doble;
        }

        void GetDobleReferencia(ref int num)
        {
            num = num * 2;
        }

        private void Form14Metodos_Load(object sender, EventArgs e)
        {

        }

        private void Form14Metodos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMouse.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //handled desactiva los eventos sucesivos del
            //metodo keychar es la tecla pulsada

            char teclaBorrar = (char)Keys.Back;

            this.lblResultado.Text = e.KeyChar.ToString();

            if (char.IsDigit(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            //handled desactiva los eventos sucesivos del
            //metodo keychar es la tecla pulsada

            char teclaBorrar = (char)Keys.Back;

            this.lblResultado.Text = e.KeyChar.ToString();

            if (char.IsDigit(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
