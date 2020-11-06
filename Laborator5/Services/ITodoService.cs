using Laborator5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator5.Services
{
    public interface ITodoService
    {
        Todo GetTodoById(int id);
        IEnumerable<Todo> GetAllTodos();
        IEnumerable<Todo> GetActiveTodos();
        IEnumerable<Todo> GetDoneTodos();
        void AddTodo(Todo todo);
        void DeleteTodo(Todo todo);
        void UpdateTodo(Todo todo);
    }
}
