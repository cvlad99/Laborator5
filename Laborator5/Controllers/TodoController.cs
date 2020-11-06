using Laborator5.Model;
using Laborator5.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator5.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetAllTodos() => _todoService.GetAllTodos().ToList();
        [HttpGet("{id}")]
        public ActionResult<Todo> GetTodoById(int id) => _todoService.GetTodoById(id);
        [HttpPost]
        public ActionResult<Todo> AddNewTodo([FromBody] Todo todo)
        {
            _todoService.AddTodo(todo);
            return todo;
        }
        [HttpGet("/done")]
        public ActionResult<IEnumerable<Todo>> GetDoneTodos()
        {
            return _todoService.GetDoneTodos().ToList();
        }
        [HttpGet("/active")]
        public ActionResult<IEnumerable<Todo>> GetActiveTodos()
        {
            return _todoService.GetActiveTodos().ToList();
        }
        [HttpDelete]
        public void DeleteTodo([FromBody] Todo todo)
        {
            _todoService.DeleteTodo(todo);
        }
        [HttpPatch]
        public void UpdateTodo([FromBody] Todo todo)
        {
            _todoService.UpdateTodo(todo);
        }

    }
}
