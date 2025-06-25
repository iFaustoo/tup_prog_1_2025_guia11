namespace Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimirNombre_Click(object sender, EventArgs e)
        {
            string name = tbNombre.Text;
            tbInvitaciones.Text += $"{name}\r\n";
            tbNombre.Clear();
        }
    }
}
