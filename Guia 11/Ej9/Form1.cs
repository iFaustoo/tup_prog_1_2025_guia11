namespace Ej9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int seleccion = Convert.ToInt32(cmbServicios.SelectedIndex);
            if (seleccion > -1)
            {
                string item = Convert.ToString(cmbServicios.Items[seleccion]);
                lsbServiciosElegidos.Items.Add(item);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int seleccion = lsbServiciosElegidos.SelectedIndex;

            if (seleccion > -1)
            {
                lsbServiciosElegidos.Items.RemoveAt(seleccion);
            }
        }
    }
}
