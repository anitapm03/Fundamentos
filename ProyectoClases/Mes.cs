using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    //public enum Meses { Enero, Febrero, Marzo, Abril, Mayo, Junio, 
      //  Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre}
    public class Mes
    {
        public string Nombre { get; set; }
        public int Maxima { get; set; }
        public int Minima { get; set; }

        public int GetMedia ()
        {
            return (this.Maxima + this.Minima) / 2;
        }

        public Mes() { }

        public Mes(string nombre)
        {
            this.Nombre = Nombre;
        }

        public Mes(string nombre, int maxima, int minima)
        {
            this.Nombre = nombre;
            this.Maxima = maxima;
            this.Minima = minima;
        }
    }
}
