using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperCompra
    {

        public List<Compra> Compras { get; set; }

        public HelperCompra() 
        { 
            this.Compras = new List<Compra>();
        }

        public async Task WriteComprasAsync(string path)
        {
            string data = this.ConvertComprasString();
            await HelperFiles.WriteFileAsync(path, data);
        }

        public async Task ReadComprasAsync(string path)
        {
            string data = await HelperFiles.ReadFileAsync(path);
            this.ConvertComprasList(data);
        }

        private string ConvertComprasString()
        {
            string data = "";

            foreach (Compra compra in this.Compras)
            {
                string temp = compra.Nombre + "," + compra.Precio;
                data += temp + "#";
            }
            data = data.Trim('#');
            return data;
        }

        private void ConvertComprasList(string data)
        {
            this.Compras.Clear();

            string[] datosCompras = data.Split('#');

            foreach (string compra in datosCompras)
            {
                string[] propiedades = compra.Split(",");

                Compra c = new Compra();
                c.Nombre = propiedades[0];
                c.Precio = int.Parse(propiedades[1]);

                this.Compras.Add(c);
            }
        }


    }
}
