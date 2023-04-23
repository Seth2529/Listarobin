using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc7
{
    public class Comissionado : Empregado
    {
        private double totalVenda { get; set; }
        private double totalComissao { get; set; }

        public Comissionado(string nome, string sobrenome, string cpf, double totalvenda, double totalcomissao)
            : base(nome, sobrenome, cpf)
        {
            totalVenda = totalvenda;
            totalComissao = totalcomissao;
        }
        public override double Vencimento()
        {
            return totalVenda * (totalComissao / 100);
        }
    }
}
