using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc7
{
	public class Horista : Empregado
	{
		private double precoHora { get; set; }
		private double horasTrabalhadas { get; set; }
		public Horista(string nome, string sobrenome, string cpf, double precohora, double horastrabalhadas)
		: base(nome, sobrenome, cpf)
		{
			precoHora = precohora;
			horasTrabalhadas = horastrabalhadas;
		}

		public override double Vencimento()
		{
			return horasTrabalhadas * precoHora;
		}
	}
}
