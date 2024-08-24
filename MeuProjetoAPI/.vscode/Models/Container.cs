using System;
using System.Collections.Generic;
using System.Linq;

namespace GeladeiraAPI.Models
{
    public class Container
    {
        private readonly string[] posicoes;

        public Container()
        {
            posicoes = new string[3];
        }

        public void AdicionarItemNoContainer(string item)
        {
            for (int i = 0; i < posicoes.Length; i++)
            {
                if (string.IsNullOrEmpty(posicoes[i]))
                {
                    posicoes[i] = item;
                    return;
                }
            }
        }

        public List<string> GetItems()
        {
            return posicoes.Where(p => !string.IsNullOrEmpty(p)).ToList();
        }

        public string GetItemById(int id)
        {
            if (id >= 0 && id < posicoes.Length && !string.IsNullOrEmpty(posicoes[id]))
            {
                return $"Posição: {id}, Item: {posicoes[id]}";
            }
            return null;
        }

        public bool UpdateItem(int id, string newItem)
        {
            if (id >= 0 && id < posicoes.Length && !string.IsNullOrEmpty(posicoes[id]))
            {
                posicoes[id] = newItem;
                return true;
            }
            return false;
        }

        public bool DeleteItem(int id)
        {
            if (id >= 0 && id < posicoes.Length && !string.IsNullOrEmpty(posicoes[id]))
            {
                posicoes[id] = null;
                return true;
            }
            return false;
        }
    }
}
