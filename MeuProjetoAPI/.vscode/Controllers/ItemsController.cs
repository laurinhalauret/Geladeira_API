using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using GeladeiraAPI.Models;

namespace GeladeiraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private static readonly List<Andar> Andares = new List<Andar>
        {
            new Andar("Hortifrutis"),
            new Andar("Laticínios e Enlatados"),
            new Andar("Charcutaria, Carnes e Ovos")
        };

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var items = new List<string>();
            foreach (var andar in Andares)
            {
                items.AddRange(andar.GetItems());
            }
            return Ok(items);
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            foreach (var andar in Andares)
            {
                var item = andar.GetItemById(id);
                if (item != null)
                {
                    return Ok(item);
                }
            }
            return NotFound("Item não encontrado.");
        }

        [HttpPost]
        public ActionResult Post([FromBody] ItemDto itemDto)
        {
            if (itemDto.AndarIndex < 0 || itemDto.AndarIndex >= Andares.Count)
            {
                return BadRequest("Andar inválido.");
            }

            Andares[itemDto.AndarIndex].AdicionarItemNoContainer(itemDto.ContainerIndex, itemDto.Item);
            return Ok("Item adicionado com sucesso.");
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ItemDto itemDto)
        {
            foreach (var andar in Andares)
            {
                if (andar.UpdateItem(id, itemDto.Item))
                {
                    return Ok("Item atualizado com sucesso.");
                }
            }
            return NotFound("Item não encontrado.");
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            foreach (var andar in Andares)
            {
                if (andar.DeleteItem(id))
                {
                    return Ok("Item removido com sucesso.");
                }
            }
            return NotFound("Item não encontrado.");
        }
    }
}
