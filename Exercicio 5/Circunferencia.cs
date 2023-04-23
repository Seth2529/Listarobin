namespace Exercicio5
{
    internal class Circunferencia : Forma
    {
        public double raiocirc;

        public override void CalcularArea()
        {
            Area = 3.14 * Math.Pow(raiocirc, 2); 

        }

        public override void CalcularPerimetro()
        {
            Perimetro = (2 * 3.14) * raiocirc;
        }

    }
}
