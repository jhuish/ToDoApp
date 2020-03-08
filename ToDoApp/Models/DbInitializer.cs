using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public static class DbInitializer
    {
        public static void Seed (AppDbContext context)
        {
            if (!context.Todos.Any())
            {
                context.AddRange
                    (
                    new ToDoTask { ToDoName = "Wash car", ToDoCategory = "Auto", ToDoPriorityLevel = 2 },
                    new ToDoTask { ToDoName = "Get groceries", ToDoCategory = "Home", ToDoPriorityLevel = 1 },
                    new ToDoTask { ToDoName = "Do evals", ToDoCategory = "Work", ToDoPriorityLevel = 2 },
                    new ToDoTask { ToDoName = "Get a haircut", ToDoCategory = "Social", ToDoPriorityLevel = 2 },
                    new ToDoTask { ToDoName = "Get new tires", ToDoCategory = "Auto", ToDoPriorityLevel = 2 },
                    new ToDoTask { ToDoName = "Finish project scheduling", ToDoCategory = "Work", ToDoPriorityLevel = 3 },
                    new ToDoTask { ToDoName = "Clean gutters", ToDoCategory = "Home", ToDoPriorityLevel = 1 },
                    new ToDoTask { ToDoName = "Get wine for party", ToDoCategory = "Social", ToDoPriorityLevel = 3 },
                    new ToDoTask { ToDoName = "Review maintenance contracts", ToDoCategory = "Work", ToDoPriorityLevel = 2 }
                    );
                context.SaveChanges();
            }
        }
    }
}
