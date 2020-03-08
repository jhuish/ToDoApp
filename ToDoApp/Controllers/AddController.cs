using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class AddController : Controller
    {
        private readonly IToDoTaskRepository doTaskRepository;

        public AddController(IToDoTaskRepository doTaskRepository)
        {
            this.doTaskRepository = doTaskRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ToDoTask toDo)
        {
            if (ModelState.IsValid)
            {
                doTaskRepository.AddTodo(toDo);
                return Redirect("home/index");
            }
            return View();
        }

        public IActionResult TaskAdded()
        {
            return View();
        }
    }
}