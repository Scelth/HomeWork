using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model
{
    public class ToDo
    {
        public enum ToDoType
        {
            Work,
            Home,
            Emergency
        }

        public string? Name { get; set; }
        public string Description { get; set; }
        public ToDoType Type { get; set; }

        public ToDo(string name, string description, ToDoType type)
        {
            Name = name;
            Description = description;
            Type = type;
        }
    }
}
