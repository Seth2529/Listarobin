using System;
using System.Collections.Generic;

public class Dependente
{
    public string Nome { get; set; }
    public string Parentesco { get; set; }

    public Dependente(string nome, string parentesco)
    {
        Nome = nome;
        Parentesco = parentesco;
    }
}
