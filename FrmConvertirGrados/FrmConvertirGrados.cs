using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConvertirGrados
{
    public partial class FrmConvertirGrados : Form
    {
        public FrmConvertirGrados()
        {
            InitializeComponent();

        }

        private void btnConvertirCelciusEnFahrenheit_Click(object sender, EventArgs e)
        {
            LogicaOperadores logica = new LogicaOperadores();
            tbFahrenheit.Text = logica.Operar(tbCelcius.Text,
                                             btnConvertirCelciusEnFahrenheit.Text);
        }

        private void btnConvertirFahrenheitEnCelcius_Click(object sender, EventArgs e)
        {
            LogicaOperadores logica = new LogicaOperadores();
            tbCelcius.Text = logica.Operar(tbFahrenheit.Text,
                                             btnConvertirFahrenheitEnCelcius.Text);
        }
    }
}
