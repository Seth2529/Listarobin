using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc7
{
    public abstract class Empregado
    {
        private string Nome { get; set; }
        private string Sobrenome { get; set; }
        private string CPF { get; set; }

        public Empregado(string nome, string sobrenome, string cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cpf;
        }

        public abstract double Vencimento();
    }
}