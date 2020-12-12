using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExercicio7
{
    public partial class frmConversorDeDolarParaReal : Form
    {
        public frmConversorDeDolarParaReal()
        {
            InitializeComponent();
            lblReal.Text = "R$ 0";
        }

        private void clickou_converter(object sender, EventArgs e)
        {
            Dolar n1 = new Dolar(double.Parse(txtCotacao.Text), double.Parse(txtDolar.Text));
            n1.ConverterDolarParaReal();
            lblReal.Text = "R$ " + n1.GetConvertido().ToString();
        }
    }
}
