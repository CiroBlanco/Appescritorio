namespace Calculadora_IMC
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FrmCalculadora.Show();
            this.Hide();
        }
    }
}
