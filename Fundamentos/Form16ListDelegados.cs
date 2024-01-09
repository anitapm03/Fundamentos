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
    public partial class Form16ListDelegados : Form
    {
        //las colecciones se suelen declarar a nivel de clase 
        //por si necesitamos usarlas en varios metodos
        List<Button> botones;
        int contador;
        public Form16ListDelegados()
        {
            InitializeComponent();

            //queremos inclir todos los botones dentro 
            //de una coleccion para recorrerla y delegar 
            // su evento click
            //dentro de formd tenemos una propiedad llamada
            //controls que contiene todos los controles del formulario
            //dicha propiedad funciona por containers, es decir,
            //si tenemos un groupbox, debemos recorrer el controls
            //del contenedor Groupbox

            //podriamos realizar esto con la propiedad Controls,
            //pero por norma siempre crearemos colecciones propias
            this.botones = new List<Button>();
            this.contador = 0;

            //vamos a recorrer todos los controles del form
            foreach (Control control in this.Controls)
            {
                //debemos preguntar si vienen botones
                if(control is Button)
                {
                    //Almacenamos los botones, add casting
                    botones.Add((Button)control);
                }
                
            }

            //a continuacion, trabajamos con nuestra coleccion
            //recorremos los botones y los asociamos al evento
            foreach (Button boton in botones)
            {
                boton.Click += BotonPulsado;
            }
        }

        void BotonPulsado(object sender, EventArgs e)
        {
            this.contador++;
            this.txtContador.Text = "Contador: " + this.contador;

            //cuando pulsemos cualquier boton quiero cambiar su color
            //SENDER ES EL OBJ QUE HA REALIZADO LA LLAMADA
            Button boton = (Button)sender;
            boton.BackColor = Color.Coral;

            /*int numero = this.botones.Count;
            MessageBox.Show("AAAAAAAAAAAAAAAAAAA " + numero);*/
        }
    }
}
