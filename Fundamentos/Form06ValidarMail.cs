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
    public partial class Form06ValidarMail : Form
    {
        public Form06ValidarMail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string mail = txtmail.Text;
            int longitud = mail.Length;
            bool valido1 = false;
            bool valido2 = false;
            bool valido3 = false;
            bool valido4 = false;
            bool valido5 = false;
            bool valido6 = false;

            if (mail.Contains('@') == true)
            {
                valido1 = true;
            }
            else
            {
                valido1 = false;
            }

            if (mail.Contains('.') == true)
            {
                valido2 = true;

                int posPunto = mail.LastIndexOf('.');

                int posDom = longitud - posPunto;

                string dom = mail.Substring(posDom);

                this.lblResultado.Text = dom;

            } else
            {
                valido2 = false;
            }

            if (mail.StartsWith("@") == false || mail.EndsWith("@") == false)
            {
                valido3 = true;
            } 
            else
            {
                valido3 = false;
            }

            int contadorArrobas = mail.Count(c => c == '@');
            if (contadorArrobas != 1)
            {
                valido4 = false; // Más de una @
            }

            this.lblResultado.Text = "No es válido";
        }

        static bool ValidarMail(string correo)
        {
            

            // No más de una @
            int contadorArrobas = correo.Count(c => c == '@');
            if (contadorArrobas != 1)
            {
                return false; // Más de una @
            }

            // Exista un punto
            if (!correo.Contains("."))
            {
                return false; // No hay punto
            }

            // Exista un punto después de @
            int posicionArroba = correo.IndexOf('@');
            if (!correo.Substring(posicionArroba).Contains("."))
            {
                return false; // No hay punto después de @
            }

            // Dominio de 2 a 4 caracteres
            string dominio = correo.Substring(correo.LastIndexOf('.'));
            if (dominio.Length < 3 || dominio.Length > 5)
            {
                return false; // Dominio no tiene entre 2 y 4 caracteres
            }

            // Si pasa todas las validaciones, es un correo válido
            return true;
        }
    }
}
