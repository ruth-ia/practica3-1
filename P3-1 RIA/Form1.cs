namespace P3_1_RIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int contarPalabras(string texto)
        {
            char[] delimitadores = new char[] { ',', '.', '\t', ';', ':', '\r', '\n' };
            int palabras = texto.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries).Length;
            return palabras;

        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste = 0.0;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            else
                tipoTelegrama = 'o';
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = contarPalabras(textoTelegrama);
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            }
            else if (tipoTelegrama == 'u')
            {
                //Si el telegrama es urgente
                if (tipoTelegrama == 'u')
                    if (numPalabras <= 10)
                        coste = 5;
                    else
                        coste = 5 + 0.75 * (numPalabras - 10);
            }
            else
            {
                coste = 0;
            }

            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}