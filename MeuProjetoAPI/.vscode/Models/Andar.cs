using System.Collections.Generic;
using NomeDoSeuNamespace;
namespace GeladeiraAPI.Models
{
    public class Andar
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
                return;
            }
            containers[containerIndex].AdicionarItemNoContainer(item);
        }

        public List<string> GetItems()
        {
            var items = new List<string>();
            foreach (var container in containers)
            {
                items.AddRange(container.GetItems());
            }
            return items;
        }

        public string GetItemById(int id)
        {
            foreach (var container in containers)
            {
                var item = container.GetItemById(id);
                if (item != null)
                {
                    return $"Andar: {Descricao}, {item}";
                }
            }
            return null;
        }

        public bool UpdateItem(int id, string newItem)
        {
            foreach (var container in containers)
            {
                if (container.UpdateItem(id, newItem))
                {
                    return true;
                }
            }
            return false;
        }

        public bool DeleteItem(int id)
        {
            foreach (var container in containers)
            {
                if (container.DeleteItem(id))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
