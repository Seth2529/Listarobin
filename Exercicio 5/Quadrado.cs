namespace Exercicio5
{
    internal class Quadrado : Forma
    {
        public double ladoquad1;

        public override void CalcularArea()
        {
            Area = ladoquad1 * ladoquad1;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = ladoquad1 * 4;
        }
    }
}
