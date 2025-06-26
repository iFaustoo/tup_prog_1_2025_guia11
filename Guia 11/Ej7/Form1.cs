namespace Ej7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sumaExcelente = 0, sumaBueno = 0, sumaInsuficiente = 0;
        int sumaBase = 0, sumaFULL = 0;
        private void btnVotar_Click(object sender, EventArgs e)
        {



            if (rbExcelente.Checked)
            {
                sumaExcelente++;
            }
            if (rbBueno.Checked)
            {
                sumaBueno++;
            }
            if (rbInsuficiente.Checked)
            {
                sumaInsuficiente++;
            }
            if (rbBase.Checked)
            {
                sumaBase++;
            }
            if (rbFULL.Checked)
            {
                sumaFULL++;
            }


            lbExcelentes.Text = $"{sumaExcelente}";
            lbBuenos.Text = $"{sumaBueno}";
            lbInsuficientes.Text = $"{sumaInsuficiente}";
            lbBase.Text = $"{sumaBase}";
            lbFULL.Text = $"{sumaFULL}";
            int sumaVotosTotales = sumaExcelente + sumaBueno + sumaInsuficiente;
            lbTotal.Text = $"{sumaVotosTotales}";

        }
    }
}
