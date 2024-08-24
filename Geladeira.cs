using System;
using System.Collections.Generic;

namespace GeladeiraOO
{
    class Geladeira
    {
        private readonly List<Andar> andares;

        public Geladeira()
        {
            andares = new List<Andar>
            {
                new Andar("Hortifrutis"),
                new Andar("Laticínios e Enlatados"),
                new Andar("Charcutaria, Carnes e Ovos")
            };
        }

        public void AdicionarItemNoContainer(int andarIndex, int containerIndex, string item)
        {
            if (andarIndex < 0 || andarIndex >= andares.Count)
            {
                Console.WriteLine("Andar inválido.");
                return;
            }

            andares[andarIndex].AdicionarItemNoContainer(containerIndex, item);
        }

        public void ImprimirItens()
        {
            foreach (var andar in andares)
            {
                andar.ImprimirItens();
            }
        }
    }
}
