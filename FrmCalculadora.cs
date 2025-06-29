using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public partial class FrmCalculadora : Form
    {
        FrmInicio formInicio;
        public FrmCalculadora(FrmInicio formOrigen)
        {
            InitializeComponent();
            formInicio = formOrigen;
        }

        private void BtnResultado_Click(object sender, EventArgs e)
        {

            double altura = double.Parse(TxtAltura.Text); //obtenemos los datos de los textbox
            double peso = double.Parse(TxtPeso.Text);

            double imc = peso / (altura * altura);

            if (altura <= 0)
            {
                LblResultado.Text = "La altura debe ser mayor que cero.";
                return;
            }

            string categoria;

            if (imc < 18.5)
                categoria = "Bajo peso";
            else if (imc < 24.9)
                categoria = "Normal";
            else if (imc < 29.9)
                categoria = "Sobrepeso";
            else
                categoria = "Obesidad";

            LblResultado.Text = $"IMC: {imc} - {categoria}";
        }
    }
}
