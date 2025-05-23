namespace Calculadora_IMC
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
        FrmCalculadora formCalc;

        public FrmCalculadora FormCalc
        {
            get
            {
                if (formCalc == null)
                    formCalc = new FrmCalculadora(this);

                return formCalc;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            FormCalc.Show();
            this.Hide();
        }
    }
}
