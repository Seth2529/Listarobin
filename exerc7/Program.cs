using exerc7;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Selecione o tipo de empregado:");
            Console.WriteLine("1 - Assalariado");
            Console.WriteLine("2 - Comissionado");
            Console.WriteLine("3 - Horista");
            Console.WriteLine("4 - Sair");
            int tipoEmpregado = int.Parse(Console.ReadLine());

            if (tipoEmpregado == 4)
            {
                Console.WriteLine("Saindo...");
                break;
            }

            Console.WriteLine("Digite o nome do empregado:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome do empregado:");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do empregado:");
            string cpf = Console.ReadLine();

            Empregado empregado = null;

            switch (tipoEmpregado)
            {

                case 1:
                    Console.WriteLine("Digite o salário do empregado:");
                    double salario = double.Parse(Console.ReadLine());
                    empregado = new Assalariado(nome, sobrenome, cpf, salario);
                    break;

                case 2:
                    Console.WriteLine("Digite o total de vendas do empregado:");
                    double totalVenda = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a porcentagem de comissão do empregado:");
                    double porcentagemComissao = double.Parse(Console.ReadLine());
                    empregado = new Comissionado(nome, sobrenome, cpf, totalVenda, porcentagemComissao);
                    break;

                case 3:
                    Console.WriteLine("Digite o preço da hora do empregado:");
                    double precoHora = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o total de horas trabalhadas do empregado:");
                    double horasTrabalhadas = double.Parse(Console.ReadLine());
                    empregado = new Horista(nome, sobrenome, cpf, precoHora, horasTrabalhadas);
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("");
                    break;
            }


            if (empregado != null)
            {
                Console.WriteLine($"Empregado: {nome} {sobrenome} - Salário: {empregado.Vencimento()}");
            }
        }

        Console.ReadKey();
    }
}