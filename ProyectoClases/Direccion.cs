using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {

        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }   

        //creamos un constructor vacio
        public Direccion() 
        {
            Debug.WriteLine("constructor DIRECCION sin params");
        }

        public Direccion(string calle, string ciudad)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("constructor DIRECCION con 2 params");
        }

        public Direccion (string calle, string ciudad, int codigoPostal)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = codigoPostal;
            Debug.WriteLine("constructor DIRECCION con todos los params");
        }
    }
}
