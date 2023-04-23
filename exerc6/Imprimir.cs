using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc6
{
    class Imprimir
    {
        private Impressora impressora;

        public Imprimir(Impressora impressora)
        {
            this.impressora = impressora;
        }
        public void pedirtexto()
        {
            Console.WriteLine("Digite um texto para ser impresso: ");
            Documento documento = new Documento();
            documento.texto = Console.ReadLine();
            impressora.impressora(documento);
        }

        public void EnviarImpressao()
        {
            impressora.Imprimir();
        }
    }
}
