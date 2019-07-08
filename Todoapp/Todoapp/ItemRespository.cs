using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;

namespace Todoapp
{
    class ItemRespository
    {
        ItemContext context;

        public ItemRespository()
        {
            context = new ItemContext();
            context.Database.EnsureCreated();
        }

        //List all my ToDo itmes

        public List<Todoitem> GetToDoItems()
        {
            IEnumerable<Todoitem> list = context.ToDoList;
            return list.ToList();
        }

        public void AddItem(string description, string status)
        {
            Todoitem item = new Todoitem(description, status);
            context.ToDoList.Add(item);
            context.SaveChanges();
        }

        public void updateItem(int id, string newDescription, string newStatus)
        {
            Todoitem oldItem = context.ToDoList.Where(item => item.Id == id).FirstOrDefault();

            oldItem.Description = newDescription;
            oldItem.Status = newStatus;
            context.Update(oldItem);
            context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            Todoitem toDoItem = context.ToDoList.Where(item => item.Id == id).FirstOrDefault();
            context.Remove(toDoItem);
            context.SaveChanges();
        }
    }
}
