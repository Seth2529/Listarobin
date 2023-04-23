using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public abstract class Forma
    {
        public double Area;
        public double Perimetro;

        public abstract  void CalcularArea();        
        public abstract  void CalcularPerimetro();
    }
}
