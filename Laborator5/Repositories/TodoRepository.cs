using Laborator5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator5.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoDataContext _dataContext;
        public TodoRepository(TodoDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddTodo(Todo todo)
        {
            _dataContext.Add(todo);
        }

        public void DeleteTodo(Todo todo)
        {
            _dataContext.Remove(todo);
        }

        public Todo GetById(int id)
        {
            return _dataContext.Todos.Find(id);
        }

        public IEnumerable<Todo> GetTodos()
        {
            return _dataContext.Todos.ToList();
        }

        public void UpdateTodo(Todo todo)
        {
            _dataContext.Update(todo);
        }
    }
}
