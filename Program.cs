using System;

namespace GeladeiraOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Geladeira geladeira = new Geladeira();

            // Adiciona itens até encher um container
            geladeira.AdicionarItemNoContainer(0, 0, "Maçã");
            geladeira.AdicionarItemNoContainer(0, 0, "Banana");
            geladeira.AdicionarItemNoContainer(0, 0, "Cenoura");
            geladeira.AdicionarItemNoContainer(0, 0, "Tomate");

            // Tenta adicionar mais um item ao container já cheio
            geladeira.AdicionarItemNoContainer(0, 0, "Laranja");

            // Exibe o estado atual da geladeira
            geladeira.ImprimirItens();
        }
    }
}
