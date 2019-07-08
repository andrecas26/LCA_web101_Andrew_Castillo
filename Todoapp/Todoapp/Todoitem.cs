using System;
using System.Collections.Generic;
using System.Text;

namespace Todoapp
{
    class Todoitem
    {
        public int Id { get; private set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }

        public Todoitem(string Description, string Status)
        {
            this.Description = Description;
            this.Status = Status;
        }
    }
}
