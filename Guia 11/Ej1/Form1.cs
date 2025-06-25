using System.Configuration;

namespace Ej1
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int numero = random.Next(1, 101);
            lbNumero.Text = $"{numero}";
        }
    }
}
