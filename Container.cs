using System;

namespace GeladeiraOO
{
    class Container
    {
        private readonly string[] posicoes;

        public Container()
        {
            posicoes = new string[4];
        }

        public void AdicionarItemNoContainer(string item)
        {
            for (int i = 0; i < posicoes.Length; i++)
            {
                if (string.IsNullOrEmpty(posicoes[i]))
                {
                    posicoes[i] = item;
                    Console.WriteLine($"Item '{item}' adicionado na posição {i}.");
                    return;
                }
            }

            Console.WriteLine("O container está cheio, não é possível adicionar mais itens.");
        }

        public void ImprimirItens()
        {
            for (int i = 0; i < posicoes.Length; i++)
            {
                string item = posicoes[i];
                Console.WriteLine($"    Posição {i}: {(string.IsNullOrEmpty(item) ? "Vazio" : item)}");
            }
        }
    }
}
