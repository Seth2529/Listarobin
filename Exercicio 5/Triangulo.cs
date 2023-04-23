namespace Exercicio5
{
    internal class Triangulo : Forma
    {
        public double Lado1;
        public double Lado2;
        public double Lado3;

        public override void CalcularArea()
        {
            double p = (Lado1 + Lado2 + Lado3) / 2;
            
            Area = Math.Sqrt(p * (p - Lado1) * (p - Lado2) * (p - Lado3)); 
        }

        public override void CalcularPerimetro()
        {   
            Perimetro = Lado1 + Lado2 + Lado3;
        }
    }
}
