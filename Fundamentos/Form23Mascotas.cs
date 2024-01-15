using ProyectoClases.Helpers;
using ProyectoClases.Models;
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
    public partial class Form23Mascotas : Form
    {
        //paso 1 declarar el helper
        HelperMascotas helper;
        public Form23Mascotas()
        {
            InitializeComponent();
            this.helper = new HelperMascotas();
        }

        private void DibujarMascotasLista()
        {
            this.lstMascotas.Items.Clear();

            foreach (Mascota mascota in this.helper.Mascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();

            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;

            this.helper.Mascotas.Add(mascota);

            this.DibujarMascotasLista();
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;

                await this.helper.ReadMascotasAsync(path);
                this.DibujarMascotasLista();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();

            if (svf.ShowDialog() == DialogResult.OK)
            {
                string path = svf.FileName;

                await this.helper.WriteMascotasAsync(path);
                MessageBox.Show("Mascotas guardadas");
            }
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = this.lstMascotas.SelectedIndex;

            if (indiceSeleccionado != -1)
            {
                Mascota mascota = this.helper.Mascotas[indiceSeleccionado];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
            }
        }
    }
}
