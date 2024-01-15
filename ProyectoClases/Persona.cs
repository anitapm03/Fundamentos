using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoClases
{

    public enum Paises { España, Alemania, Andorra}
    public enum TipoGenero { Masculino, Femenino }

    public class Persona
    {
        #region CONSTRUCTORES

        public Persona() 
        {
            Debug.WriteLine("Constructor VACIO Persona");
        }

        //la clase persona solo tiene un unico constructor con parametros
        public Persona(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor 2 param Persona");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        #endregion

        #region PROPIEDADES


        //conjunto para almacenar descripciones
        private string[] descripciones = new string[3];
        //propiedad indizada para almacenar descripciones
        public string this[int index]
        {
            get 
            { 
                //devolvemos la desc de una posicion
                return this.descripciones[index];
            }
            set 
            {
                //almacenamos en el indice del array la nueva desc
                this.descripciones[index] = value;
            }
        }



        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        //public int Edad;

        //campo de propiedad para edad 
        private int _Edad;
        public int Edad
        {
            get
            {
                return this._Edad;
            }
            set
            {
                //necesitamos comprobar el valor que 
                //se ha asignado a la propiedad edad

                
                if (value <= 0)
                {
                    //1) error silencioso
                    //this._Edad = 0;

                    //2) Lanzar una exception
                    throw new Exception("La edad no puede ser negativa " 
                        + value);

                }
                else
                {
                    this._Edad = value;
                }
            }
        }

        private TipoGenero _Genero;

        public TipoGenero Genero 
        {
            get
            {
                return this._Genero;
            }
            set
            {
                //debemos comprobar los valores de la enumeración
                if (value != TipoGenero.Masculino &&
                    value!= TipoGenero.Femenino)
                {
                    throw new Exception("Genero invalido");
                }
                else
                {
                    this._Genero = value;
                }
            }
        
        }
        public Paises Nacionalidad { get; set; }

        #endregion


        #region METODOS

        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public void MetodoParametrosOpcionales
            (int numero1, int numero2 = 444, int numero3 = 0)
        { }

        // SOBRECARGA
        public string GetNombreCompleto(bool orden)
        {
            if (orden == true)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else
            {
                //utilizamos el metodo anterior sin parametros
                return this.GetNombreCompleto();    
            }

        }

        #endregion
    }
}
