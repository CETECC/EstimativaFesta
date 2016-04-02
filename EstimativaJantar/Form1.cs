using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstimativaJantar
{
    public partial class Form1 : Form
    {
        private JantarFesta _jantarFesta;

        public Form1()
        {
            InitializeComponent();
            _jantarFesta = new JantarFesta();
        }

        private void numQtdPessoas_ValueChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void chkDecoracaoChique_CheckedChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void chkOpcaoSaudavel_CheckedChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            _jantarFesta.QtdPessoas = (int)numQtdPessoas.Value;
            _jantarFesta.DecoracaoChique = chkDecoracaoChique.Checked;
            _jantarFesta.OpcaoSaudavel = chkOpcaoSaudavel.Checked;
            decimal custo = _jantarFesta.CalcularCusto();

            lblCusto.Text = string.Format("{0:C}", custo);
        }

        private void btnDetalhes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string txt = string.Format(
@"Detalhes do Cálculo:
    Quantidade de Pessoas:          {0},
    Custo de Bebida por Pessoa:     {1:C},
    Custo de Decoração por Pessoa:  {2:C},
    Taxa:                           {3:C},
    Desconto:                       {4}%,
    TOTAL:                          {5:C}",
                _jantarFesta.QtdPessoas,
                _jantarFesta.CustoBebidaPorPessoa,
                _jantarFesta.CustoDecoracaoPorPessoa,
                _jantarFesta.Taxa,
                _jantarFesta.Desconto * 100,
                lblCusto.Text);

            MessageBox.Show(txt);
        }
    }
}
