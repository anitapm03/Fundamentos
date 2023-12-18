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
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void Form02PosicionColores_Load(object sender, EventArgs e)
        {

        }

        private void btnCambiarPos_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(this.txtPosX.Text);
            int posY = int.Parse(this.txtPosY.Text);

            this.btnCambiarPos.Location = new Point(posX, posY);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);

            if(rojo < 0 || rojo >255)
            {
                MessageBox.Show("Un valor entre 0 y 255");
            }else if (verde < 0 || verde >255)
            {
                MessageBox.Show("Un valor entre 0 y 255");
            }else if (azul < 0 || azul > 255)
            {
                MessageBox.Show("Un valor entre 0 y 255");
            }
            else
            {
                this.BackColor = Color.FromArgb(rojo, verde, azul);
            }
        }
    }
}
