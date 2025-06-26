namespace Ej6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {

            bool rtaCorrecta = chbOpcion1.Checked && !chbOpcion2.Checked && !chbOpcion3.Checked;

            if (rtaCorrecta)
            {
                lbResultado.Text = "Respuesta correcta!";
            }
            else
            {
                lbResultado.Text = "Respuesta incorrecta:\r\n";
                if (chbOpcion1.Checked)
                {
                    lbResultado.Text += "No siempre se debe inicializarse, es falsa\r\n";
                }
                if (chbOpcion2.Checked)
                {
                    lbResultado.Text += "Nunca debe inicializarse, es falsa\r\n";
                }
                if (chbOpcion3.Checked)
                {
                    lbResultado.Text += "Siempre debe inicializarse, es verdadera";
                }
            }


        }
    }
}
