using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director: Empleado
    {

        public Director() 
        {
            Debug.WriteLine("constructor DIRECTOR");
            this.SalarioMinimo += 200;
        }

        //override
        public new int GetDiasVacaciones()
        {

            //necesitamos leer primero la clase base para
            //recuperar las vacaciones del empleado
            int vacaciones = base.GetDiasVacaciones();

            Debug.WriteLine("GetVacaciones DIRECTOR");
            return vacaciones + 8;
        }
    }
}
