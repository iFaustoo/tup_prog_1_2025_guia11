namespace Ej5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contadorExcelentes = 0;
        int contadorBuenos = 0;
        int contadorInsuficientes = 0;
        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (rbExcelente.Checked)
            {
                contadorExcelentes++;
            }
            else if (rbBueno.Checked)
            {
                contadorBuenos++;
            }
            else if (rbInsuficiente.Checked)
            {
                contadorInsuficientes++;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una opción.");
                return;
            }

            #region limpiando controles
            rbExcelente.Checked = false;
            rbBueno.Checked = false;
            rbInsuficiente.Checked = false;
            #endregion

            #region mostrar resultados
            int total = contadorExcelentes + contadorBuenos + contadorInsuficientes;
            lbTotal.Text = $"{total}";
            lbExcelentes.Text = $"{contadorExcelentes}";
            lbBuenos.Text = $"{contadorBuenos}";
            lbInsuficientes.Text = $"{contadorInsuficientes}";
            #endregion
        }
    }
}
