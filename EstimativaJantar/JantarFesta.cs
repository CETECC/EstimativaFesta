using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimativaJantar
{
    public class JantarFesta
    {
        public const decimal CustoComidaPorPessoa = 25.00m;

        public int QtdPessoas { get; set; }
        public decimal CustoBebidas { get; private set; }
        public decimal CustoBebidaPorPessoa { get; private set; }
        public decimal CustoDecoracao { get; private set; }
        public decimal CustoDecoracaoPorPessoa { get; private set; }
        public bool OpcaoSaudavel { get; set; }
        public bool DecoracaoChique { get; set; }
        public decimal Taxa { get; private set; }
        public decimal Desconto { get; private set; }

        private void CalcularCustoDecoracao()
        {
            CustoDecoracaoPorPessoa = 0.0m;

            if (DecoracaoChique)
            {
                CustoDecoracaoPorPessoa = 15.00m;
                Taxa = 50.00m;
            }
            else
            {
                CustoDecoracaoPorPessoa = 7.50m;
                Taxa = 30.00m;
            }

            CustoDecoracao = (QtdPessoas * CustoDecoracaoPorPessoa) + Taxa;
        }

        private void CalcularCustoBebidas()
        {
            // Calcula o custo das bebidas
            if (OpcaoSaudavel)
            {
                CustoBebidaPorPessoa = 5.00m;
                Desconto = 0.05m;
            }
            else
            {
                CustoBebidaPorPessoa = 20.00m;
                Desconto = 0.0m;
            }

            CustoBebidas = QtdPessoas * CustoBebidaPorPessoa;
        }

        public decimal CalcularCusto()
        {
            CalcularCustoBebidas();
            CalcularCustoDecoracao();
            decimal custoComida = CustoComidaPorPessoa * QtdPessoas;
            decimal totalSemDesconto = custoComida + CustoBebidas + CustoDecoracao;
            decimal descontoTotal = totalSemDesconto * Desconto;
            decimal totalComDesconto = totalSemDesconto - descontoTotal;

            return totalComDesconto;
        }
    }
}
