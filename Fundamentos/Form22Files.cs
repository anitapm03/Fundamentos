using ProyectoClases.Helpers;
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
    public partial class Form22Files : Form
    {
        HelperFiles helper;
        //HelperMascotas helperMascotas;
        public Form22Files()
        {
            InitializeComponent();
            this.helper = new HelperFiles();
        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            //objeto para seleccionar el fichero
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //recuperamos la ruta del fichero
                string path = ofd.FileName;

                //string data = await this.helper.ReadFileAsync(path);

                /*//la clase Fileinfo nos devuelve un file 
                //con sus características
                FileInfo file = new FileInfo(path);

                //con la clase TextReader vamos a leer el fichero(abrirlo)
                //con el codigo using nos aseguramos que ha creado el 
                //obj antes de usarlo
                using (TextReader reader = file.OpenText())
                {
                    //leemos el contenido del File
                    //para llamar a metodos asincronos necesitamos
                    //la palabra await TBN METEMOS ASYNC EN EL METODO ARRIBA!!!!
                    string contenido = await reader.ReadToEndAsync();

                    //una vez finalizado, siempre cerramos los lectores
                    reader.Close();
                    this.txtContenido.Text = contenido;
                    this.DibujarNombresListBox(contenido);
                }*/
            }

        }

        //CUANDO LEAMOS EL FICHERO, PINTAMOS LOS NOMBRES EN EL LISTBOX
        public void DibujarNombresListBox(string data)
        {
            string[] nombres = data.Split(',');
            this.lstNombres.Items.Clear();

            foreach (string name in nombres)
            {
                this.lstNombres.Items.Add(name);
            }
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf =  new SaveFileDialog();
            if (svf.ShowDialog() == DialogResult.OK)
            {
                string path = svf.FileName;

                string data = this.GetNombresListBox();
                //await this.helper.WriteFileAsync(path, data);
                MessageBox.Show("datos almacenados");
               /* FileInfo file = new FileInfo(path);

                //en lugar de reader, necesitamos un textwritter
                using(TextWriter writer = file.CreateText())
                {
                    //recuperamos los nombres del listbox
                    string contenido = this.GetNombresListBox();

                    //escribimos el contenido de forma asincrona
                    await writer.WriteAsync(contenido);

                    //siempre que trabajemos con files debemos 
                    //indicar flush despues de escribir
                    await writer.FlushAsync();
                    writer.Close();
                    MessageBox.Show("Datos almacenados");
                }*/

            }
        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach (string name in  this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.TrimEnd(',');
            return data;
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
        }
    }
}
