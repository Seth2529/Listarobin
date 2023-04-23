using System;
using System.Collections.Generic;

public class Funcionario
{
    public string Nome { get; set; }
    public decimal Salario { get; set; }
    public List<Dependente> Dependentes { get; set; }

    public Funcionario(string nome, decimal salario)
    {
        Nome = nome;
        Salario = salario;
        Dependentes = new List<Dependente>();
    }

    public void AdicionarDependente(Dependente dependente)
    {
        Dependentes.Add(dependente);
    }

    public void MostrarDependentes()
    {
        if (Dependentes.Count == 0)
        {
            Console.WriteLine($"{Nome} não possui dependentes.");
        }
        else
        {
            Console.WriteLine($"Dependentes de {Nome}:");
            foreach (Dependente dep in Dependentes)
            {
                Console.WriteLine($"{dep.Nome} ({dep.Parentesco})");
            }
        }
    }
}
