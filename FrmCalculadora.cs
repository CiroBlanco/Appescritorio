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
   
      
        }
    }
}
