using Laborator5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator5.Repositories
{
    public interface ITodoRepository
    {
        Todo GetById(int id);
        IEnumerable<Todo> GetTodos();
        void AddTodo(Todo todo);
        void UpdateTodo(Todo todo);
        void DeleteTodo(Todo todo);
    }
}
