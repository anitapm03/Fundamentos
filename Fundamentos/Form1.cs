namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click_1(object sender, EventArgs e)
        {
            //solo escribiremos aqui 
            this.txtNombre.Location = new Point(38, 10);

            //tenemos propiedades de tipos de datos primitivos
            //los primitivos directamente se escriben 

            this.txtNombre.Text = "Soy un texto";
            this.txtNombre.Width = 180;

            //Esto es una excepción en la norma
            //tener una clase o estructura final
            //no se instancia, se utilza.
            //por ejemplo, la clase color

            this.BackColor = Color.Green;

            //PONGAMOS QUE QUEREMOS ALINEAR EL 
            //TEXTO DE UNA CAJA
            this.txtNombre.TextAlign = HorizontalAlignment.Left;

        }
    }
}