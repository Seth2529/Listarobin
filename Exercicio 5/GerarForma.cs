using System.Security.Cryptography.X509Certificates;

namespace Exercicio5
{
    internal class GerarForma
    {
        public void SolicitarForma()
        {
            int opcao = 0;

            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Quadrado");
                Console.WriteLine("2 - Triângulo");
                Console.WriteLine("3 - Circunferência");
                Console.WriteLine("4 - Hexágono");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Quadrado quadrado = new Quadrado();
                        Console.Write("\nDigite o Lado: ");
                        quadrado.ladoquad1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        quadrado.CalcularArea();
                        Console.WriteLine($"A área do Quadrado é {quadrado.Area}");
                        quadrado.CalcularPerimetro();
                        Console.WriteLine($"O perímetro do Quadrado é {quadrado.Perimetro}");
                        Console.WriteLine("");

                        break;

                    case 2:
                        Triangulo triangulo = new Triangulo();
                        Console.Write("\nDigite o primeiro lado do triângulo: ");
                        triangulo.Lado1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo lado do triângulo: ");
                        triangulo.Lado2 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o terceiro lado do triângulo: ");
                        triangulo.Lado3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        triangulo.CalcularArea();
                        Console.WriteLine($"A área do triângulo é {triangulo.Area}");
                        triangulo.CalcularPerimetro();
                        Console.WriteLine($"O perímetro do triângulo é {triangulo.Perimetro}");
                        Console.WriteLine("");

                        break;

                    case 3:
                        Circunferencia circunferencia = new Circunferencia();
                        Console.Write("\nDigite o valor do raio da circunferência: ");
                        circunferencia.raiocirc = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        circunferencia.CalcularArea();
                        Console.WriteLine($"A área da circunferência é {circunferencia.Area}");
                        circunferencia.CalcularPerimetro();
                        Console.WriteLine($"O perímetro da circunferência é {circunferencia.Perimetro}");
                        Console.WriteLine("");

                        break;

                    case 4:
                        Hexagono hexagono = new Hexagono();
                        Console.Write("\nDigite o lado do hexágono: ");
                        hexagono.ladohex = double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        hexagono.CalcularArea();
                        Console.WriteLine($"A área do hexágono é {hexagono.Area}");
                        hexagono.CalcularPerimetro();
                        Console.WriteLine($"O perímetro do hexágono é {hexagono.Perimetro}");
                        Console.WriteLine("");

                        break;

                    case 5:
                        Console.WriteLine("\nSaindo...");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!");
                        Console.WriteLine("");
                        break;

                }

            } while (opcao != 5);
        }
    }
}

         