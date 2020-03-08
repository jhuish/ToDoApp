using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class ToDoRepository : IToDoTaskRepository
    {
        private readonly AppDbContext appDbContext;

        public ToDoRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public ToDoTask GetDoTaskById(int taskId)
        {
            return appDbContext.Todos.FirstOrDefault(t => t.Id == taskId);
        }

        public IEnumerable<ToDoTask> GetToDoTasks()
        {
            return appDbContext.Todos;
        }
        public void AddTodo(ToDoTask toDo)
        {
            appDbContext.Add(toDo);
            appDbContext.SaveChanges();
        }
                          
        public void updateComplete(int taskId)
        {
            ToDoTask dbEntry = appDbContext.Todos.FirstOrDefault(t => t.Id == taskId);
            appDbContext.Remove(dbEntry);
            appDbContext.SaveChanges();
        }

        public void removeCategory(string catName)
        {
            foreach(ToDoTask dbEntry in appDbContext.Todos)
            {
                if (dbEntry.ToDoCategory.ToLower() == catName.ToLower() )
                {
                    appDbContext.Remove(dbEntry);
                }
            }
            appDbContext.SaveChanges();
        }

    }
}
