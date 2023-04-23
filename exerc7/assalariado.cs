using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc7
{
    public class Assalariado : Empregado
    {
        private double Salario { get; set; }

        public Assalariado(string nome, string sobrenome, string cpf, double salario)
            : base(nome, sobrenome, cpf)
        {
            Salario = salario;
        }

        public override double Vencimento()
        {
            return Salario;
        }
    }
}
