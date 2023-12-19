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
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            //siempre se escribe despues de este método
            this.txtFecha.Text = DateTime.Now.ToString();
        }

        private void Form04DateTime_Load(object sender, EventArgs e)
        {

        }

        private void chkCambiar_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFecha.Text);
            if (this.chkCambiar.Checked == true)
            {
                this.txtFecha.Text = fecha.ToLongDateString();

            }
            else
            {
                this.txtFecha.Text = fecha.ToShortDateString();
            }

        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFecha.Text);
            int incremento = int.Parse(this.txtIncremento.Text);

            if (this.rdbDias.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            }
            else if (this.rdbMeses.Checked == true)
            {
                fecha = fecha.AddMonths(incremento);
            } 
            else if (this.rdbAnios.Checked == true)
            {
                fecha = fecha.AddYears(incremento);
            }

            
            this.txtNuevaFecha.Text = fecha.ToString();
        }
    }
}
