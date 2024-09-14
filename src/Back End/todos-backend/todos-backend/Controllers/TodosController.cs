using Microsoft.AspNetCore.Mvc;
using todos_backend.Models;
using todos_backend.Service.Todos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todos_backend.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodosService _todosService;

        public TodosController(ITodosService todosService)
        {
            _todosService = todosService;
        }


        // GET: api/<TodosController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_todosService.GetTodos());
        }

        // GET api/<TodosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TodosController>
        [HttpPost]
        public IActionResult Post([FromBody] Todo todo )
        {
            return Ok(_todosService.AddTodos(todo));
        }

        // PUT api/<TodosController>/5
        [HttpPut]
        public IActionResult Put(int id, [FromBody] Todo todo)
        {
            return Ok(_todosService.UpdateTodos(todo));
        }

        // DELETE api/<TodosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_todosService.DelTodos(id));
        }
    }
}
