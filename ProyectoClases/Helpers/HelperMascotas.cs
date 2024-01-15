using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
        }

        public async Task WriteMascotasAsync(string path)
        {
            //al escribir debemos convertir la coleccion a string 
            string data = this.ConvertMascotasString();
            await HelperFiles.WriteFileAsync(path, data);
        }

        public async Task ReadMascotasAsync(string path)
        {
            //leemos el fichero que nos han dado
            string data = await HelperFiles.ReadFileAsync(path);
            this.ConvertMascotasList(data);
        }

        //en esta clase tenemos un conjunto de mascotas
        //necesitamos convertir un texto a una coleccion de objetos
        private string ConvertMascotasString()
        {
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                string temp = mascota.Nombre + "," + mascota.Raza;
                data += temp + "#";
            }
            data = data.Trim('#');
            return data;    
        }

        //tambien tendremos que leer de un fichero las mascotas
        //al leer debemos convertir el string en coleccion
        private void ConvertMascotasList(string data)
        {
            //Limpiar la colección de mascotas
            this.Mascotas.Clear();

            //separamos los datos de los obj en un array
            string[] datosMascotas = data.Split('#');

            foreach (string d in datosMascotas)
            {
                //volvemos a separar
                string[] propiedades = d.Split(",");

                //instanciamos cada mascota
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);

            }
        }
    }
}
