using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator5.Model
{
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsDone { get; private set; }
        public void MarkAsDone()
        {
            this.IsDone = true;
        }
    }
}
