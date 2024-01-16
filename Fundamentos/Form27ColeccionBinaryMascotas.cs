using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form27ColeccionBinaryMascotas : Form
    {
        BinaryFormatter binaryFormatter;
        ColeccionMascotas mascotasList;
        public Form27ColeccionBinaryMascotas()
        {
            InitializeComponent();

            this.binaryFormatter = new BinaryFormatter();
            this.mascotasList = new ColeccionMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();

            foreach (Mascota mascota in this.mascotasList)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();

            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtEdad.Text);

            this.mascotasList.Add(mascota);

            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtEdad.Clear();

            this.DibujarMascotas();
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("listamascotas.bin", FileMode.Open))
            {
                //this.mascotasList = (ColeccionMascotas)this.binaryFormatter.Deserialize(fileStream);
            }
            this.DibujarMascotas();
        }

        private void btnGuardarDato_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream("listamascotas.bin", FileMode.Create))
            {
               // this.binaryFormatter.Serialize(fileStream, this.mascotasList);
            }

            this.lstMascotas.Items.Clear();
            this.mascotasList.Clear();
         
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMascotas.SelectedIndex;

            if (index != -1)
            {
                Mascota mascota = this.mascotasList[index];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Years.ToString();
            }
        }
    }
}
