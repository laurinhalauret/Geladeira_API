using System;
using System.Collections.Generic;

namespace GeladeiraOO
{
    class Andar
    {
        public string Descricao { get; }
        private readonly List<Container> containers;

        public Andar(string descricao)
        {
            Descricao = descricao;
            containers = new List<Container> { new Container(), new Container() };
        }

        public void AdicionarItemNoContainer(int containerIndex, string item)
        {
            if (containerIndex < 0 || containerIndex >= containers.Count)
            {
                Console.WriteLine("Container inválido.");
                return;
            }

            containers[containerIndex].AdicionarItemNoContainer(item);
        }

        public void ImprimirItens()
        {
            Console.WriteLine($"Andar ({Descricao}):");

            for (int i = 0; i < containers.Count; i++)
            {
                Console.WriteLine($"  Container {i}:");
                containers[i].ImprimirItens();
            }
        }
    }
}
