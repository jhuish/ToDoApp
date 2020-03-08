using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
using ToDoApp.ViewModels;

namespace ToDoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IToDoTaskRepository todoRepository;

        public HomeController(IToDoTaskRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }
        public IActionResult Index()
        {
            var todos = todoRepository.GetToDoTasks().OrderBy(t => t.ToDoCategory).OrderByDescending(t => t.ToDoPriorityLevel);
            var todoCats = new List<ToDoTask>(todoRepository.GetToDoTasks().GroupBy(t => t.ToDoCategory.ToLower()).Select(t => t.First()));

            var homeViewModel = new HomeViewModel()
            {
                ToDos = todos.ToList(),
                ToDoCats = todoCats.ToList()

            };

            return View(homeViewModel);
        }
        [HttpPost]
        public IActionResult MarkComplete(int taskId)
        {
            todoRepository.updateComplete(taskId);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult RemoveCat(string catName)
        {
            todoRepository.removeCategory(catName);
            return RedirectToAction("Index");
        }
    }
}