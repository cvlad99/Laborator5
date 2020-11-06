using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator5.Model
{
    public class TodoDataContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public TodoDataContext(DbContextOptions<TodoDataContext> options) : base(options)
        {

        }
    }
}
