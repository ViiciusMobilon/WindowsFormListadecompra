using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntcal_Click(object sender, EventArgs e)
        {
            double renda= double.Parse(textRenda.Text);
            double n1 = double.Parse(textEnergia.Text);
            double n2 = double.Parse(textAgua.Text);
            double n3 = double.Parse(textTV.Text);
            double n4 = double.Parse(textAlimentacao.Text);
            double n5 = double.Parse(textMais.Text);

            double resultado = n1 + n2 + n3 +n4 +n5;
            double saldo =   renda-resultado;

            lbltotal.Text = resultado.ToString();
            lblsaldo.Text = saldo.ToString();
        }

        private void bntexcluir_Click(object sender, EventArgs e)
        {
            textRenda.Clear();
            textEnergia.Clear();
            textAgua.Clear();
            textTV.Clear();
            textAlimentacao.Clear();
            textMais.Clear();

            lblsaldo.Text = " ";
            lbltotal.Text = " ";

        }

        private void btnfe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
