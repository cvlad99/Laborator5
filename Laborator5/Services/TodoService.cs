using Laborator5.Model;
using Laborator5.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator5.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _repository;

        public TodoService(ITodoRepository repository)
        {
            _repository = repository;
        }

        public void DeleteTodo(Todo todo)
        {
            _repository.DeleteTodo(todo);
        }

        public IEnumerable<Todo> GetActiveTodos()
        {
            return _repository.GetTodos()
                    .Where(todo => !todo.IsDone)
                    .ToList();
        }

        public IEnumerable<Todo> GetAllTodos()
        {
            return _repository.GetTodos();
        }

        public IEnumerable<Todo> GetDoneTodos()
        {
            return _repository.GetTodos()
                    .Where(todo => todo.IsDone)
                    .ToList();
        }

        public Todo GetTodoById(int id)
        {
            return _repository.GetById(id);
        }

        public void UpdateTodo(Todo todo)
        {
            _repository.UpdateTodo(todo);
        }
        public void AddTodo(Todo todo)
        {
            _repository.AddTodo(todo);
        }
    }
}
