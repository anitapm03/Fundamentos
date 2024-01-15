using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        protected int SalarioMinimo { get; set; }

        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones Empleado");
            return 22;
        }

        //modificamos para leer el constructor con parametros
        //de persona
        public Empleado():base("Nombre", "Apellidos")
        {
            Debug.WriteLine("Constructor VACIO Empleado");
            this.SalarioMinimo = 2000;
        }

        public int GetSalarioMinimmo()
        {
            return this.SalarioMinimo;
        }

        public Empleado(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor 2 param Empleado");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
    }
}
