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
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anio = int.Parse(this.txtAnio.Text);

            if(mes == 1)
            {
                mes = 13;
                anio = anio - 1;
            }else if(mes == 2)
            {
                mes = 14;
                anio = anio - 1;
            }

            //paso 1
            int paso1 = ((mes + 1) * 3) / 5;

            //paso 2
            int paso2 = anio / 4;

            //paso 3
            int paso3 = anio / 100;

            //paso 4
            int paso4 = anio / 400;

            //paso 5
            int paso5 = dia + (mes * 2) + anio + paso1 + paso2 - paso3 + paso4 + 2;

            //paso 6
            int paso6 = paso5 / 7;

            //paso 7 
            int paso7 = paso5 - (paso6 * 7);

            string diaSemana = "";
            //switch
            switch(paso7)
            {
                case 0:
                    diaSemana = "SABADO";
                    this.lblResultado.Text = diaSemana;
                    break;

                case 1:
                    diaSemana = "DOMINGO";
                    this.lblResultado.Text = diaSemana;
                    break;

                case 2:
                    diaSemana = "LUNES";
                    this.lblResultado.Text = diaSemana;
                    break;

                case 3:
                    diaSemana = "MARTES";
                    this.lblResultado.Text = diaSemana;
                    break;

                case 4:
                    diaSemana = "MIERCOLES";
                    this.lblResultado.Text = diaSemana;
                    break;

                case 5:
                    diaSemana = "JUEVES";
                    this.lblResultado.Text = diaSemana;
                    break;

                case 6:
                    diaSemana = "VIERNES";
                    this.lblResultado.Text = diaSemana;
                    break;
            }
        }
    }
}
