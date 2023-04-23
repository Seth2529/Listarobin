using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Hexagono : Forma
    {
        public double ladohex;
        public override void CalcularArea()
        {
            Area = ((3 * Math.Sqrt(3)) / 2) * Math.Pow(ladohex, 2);
        }

        public override void CalcularPerimetro()
        {
            Perimetro = ladohex * 6;
        }
    }
}
