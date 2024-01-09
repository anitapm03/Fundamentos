using System;
using System.Collections;
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
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();

            //declaramos una coleccion generica
            List<Button> botones = new List<Button>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            //accedemos directamente a las propiedades del objeto
            botones[1].BackColor = Color.Yellow;
            //Tenemos errores en compilación
            //botones.Add(this.textBox1);

            //coleccion no tipada
            ArrayList coleccion = new ArrayList();

            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);

            //añadimos un textbox a la coleccion
            coleccion.Add(this.textBox1);

            //si intentamos acceder a las propiedades, no podremos
            //debemos realizar el casting para poder alicar propiedades

            ((Button)coleccion[0]).Text = "Soy un boton";

            //mediante la abstraccion podemos recorrer todos los elementos
            //de una coleccion utilizando una clase en común 
            /*foreach (Button boton in coleccion)
            {
                boton.BackColor = Color.Green;
            }*/

            //si tenemos objeto que no sean de una familia directa 
            //debemos encontrar su familia común mediante la abstraccion
            foreach ( Control control in coleccion )
            {
                control.BackColor = Color.LightGreen;
                //dentro de la abstraccion, podemos convertir 
                //a su clas epara aplicar sus propiedades o métodos
                //deseamos usar el metodo Paste() del TextBox
                
                //preguntamos por la clase del objeto
                if (control is TextBox )
                {
                    //realizamos un casting para aplicar sobre el objeto
                    ((TextBox)control).Paste();
                }
            }


        }
    }
}
