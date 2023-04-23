using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc6
{
    class Impressora
    {
        private Documento documento;
        public int QtdDeCopia { get; set; }

        public Impressora()
        {
            this.QtdDeCopia = 1;
        }
        public void QuantidadeDeCopias()
        {
            Console.Write("Quantas cópias deseja imprimir? ");
            QtdDeCopia = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }

        public void Imprimir()
        {
            for (int i = 0; i < QtdDeCopia; i++)
            {
                Console.WriteLine(documento.texto);
            }
        }

        public void impressora(Documento documento)
        {
            this.documento = documento;
        }
    }
}

