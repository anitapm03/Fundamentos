using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Fundamentos
{
    public partial class Form25ObjetoXMLMascota : Form
    {
        //necesitamos el obj para serializar XML
        XmlSerializer serializer;
        public Form25ObjetoXMLMascota()
        {
            InitializeComponent();

            //esta clase al ser instanciada necesita que  
            //le indiquemos la clase que va a serializar
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private void btnLeerDato_Click(object sender, EventArgs e)
        {
            //La lectura con este objeto usa un reader
            //de la clase streamreader
            Mascota mascota = null;

            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                //dentro del fichero tendremos un string con formato
                // xml que representa una mascota. Debemos recuperar
                //dicho string y convertirlo a objeto, esto lo realiza 
                //de forma automática mediante un método llamado Deserialize()
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
            }

            this.txtNombre.Text = mascota.Nombre;
            this.txtRaza.Text = mascota.Raza;
            this.txtEdad.Text = mascota.Years.ToString();
        }

        private async void btnGuardarDato_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();

            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtEdad.Text);

            //para escribir se utiliza la clase StreamWriter
            using(StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                this.serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }

            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtEdad.Clear();

        }
    }
}
