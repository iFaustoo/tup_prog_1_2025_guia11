namespace Ej4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int hora = Convert.ToInt32(nudHora.Value);
            int minuto = Convert.ToInt32(nudMinuto.Value);
            int minutos = hora * 60 + minuto;
            lbMinutos.Text = $"{minutos}";
        }
    }
}
