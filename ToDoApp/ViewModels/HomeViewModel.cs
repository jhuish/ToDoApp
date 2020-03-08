using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.ViewModels
{
    public class HomeViewModel
    {
        public List<ToDoTask>ToDos { get; set; }
        public string Title { get; set; }
        public List<ToDoTask> ToDoCats { get; set; }
    }
}
