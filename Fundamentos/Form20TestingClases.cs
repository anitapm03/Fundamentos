using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyectoClases;

namespace Fundamentos
{
    public partial class Form20TestingClases : Form
    {
        public Form20TestingClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.Nombre = "Ana";
            persona.Apellidos = "Pereira Molinero";
            persona.Edad = 20;
            persona.Nacionalidad = Paises.España;
            persona.Genero = TipoGenero.Femenino;

            persona.MetodoParametrosOpcionales(77);
            persona.MetodoParametrosOpcionales(88, 777);
            persona.MetodoParametrosOpcionales(1,2,3);

            //solamente queremos enviar los param 1 y 3
            persona.MetodoParametrosOpcionales(1, numero3: 88);

            persona.Domicilio = new Direccion("Calle Tajamar, 12", "Madrid", 28005);

            persona[0] = "humilde";
            persona[1] = "pelo rojo";
            this.lstDatosClases.Items.Add("Descripción: " + persona[0] + ", " + persona[1]);


            this.lstDatosClases.Items.Add("Calle: " + persona.Domicilio.Calle);

            this.lstDatosClases.Items.Add(persona.GetNombreCompleto(true));

            this.lstDatosClases.Items.Add(
                "Nombre: " + persona.Nombre + " " + persona.Apellidos);
            this.lstDatosClases.Items.Add("Edad: " + persona.Edad);
            this.lstDatosClases.Items.Add("Género: " + persona.Genero);
            this.lstDatosClases.Items.Add("Nacionalidad: " + persona.Nacionalidad);
            
            this.lstDatosClases.Items.Add("Nombre completo: " + persona.GetNombreCompleto());


        }
    }
}
