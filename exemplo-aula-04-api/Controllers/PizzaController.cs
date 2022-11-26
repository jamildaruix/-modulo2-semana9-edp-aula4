using exemplo_aula_04_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace exemplo_aula_04_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaContext _pizzaContext;

        public PizzaController(PizzaContext pizzaContext)
        {
            _pizzaContext = pizzaContext;
        }

        [HttpGet]
        public ActionResult<List<PizzaEntity>> Get()
        {
            return Ok(new List<PizzaEntity>());
        }

        [HttpPost]
        public ActionResult<PizzaEntity> Post(PizzaEntity pizzaEntity)
        {
            _pizzaContext.PizzaEntities.Add(pizzaEntity);
            _pizzaContext.SaveChanges();
            return Ok(new PizzaEntity { });
        }

        [HttpPut]
        public ActionResult<PizzaEntity> Put(PizzaEntity pizzaEntity)
        {
            return Ok(new PizzaEntity { });
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
