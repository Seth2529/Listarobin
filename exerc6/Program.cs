using exerc6;

Impressora impressora = new Impressora();
Imprimir imprimir = new Imprimir(impressora);

imprimir.pedirtexto();
impressora.QuantidadeDeCopias();
imprimir.EnviarImpressao();

Console.ReadKey();
