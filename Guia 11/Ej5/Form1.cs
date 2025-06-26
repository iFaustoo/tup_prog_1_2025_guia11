namespace Ej5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sumExcellent = 0, sumGood = 0, sumIns = 0;

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (rbExcelente.Checked)
            {
                sumExcellent++;
            }
            else if (rbBueno.Checked)
            {
                sumGood++;
            }
            else if (rbInsuficiente.Checked)
            {
                sumIns++;
            }
            else
            {
                MessageBox.Show("Seleccione una opción válida");
                return;
            }

            int sum = sumExcellent + sumGood + sumIns;
        
            lbTotal.Text = $"{sum}";
            lbExcelentes.Text = $"{sumExcellent}";
            lbBuenos.Text = $"{sumGood}";
            lbInsuficientes.Text = $"{sumIns}";
        }
    }
}
