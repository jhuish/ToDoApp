using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public interface IToDoTaskRepository
    {
        IEnumerable<ToDoTask> GetToDoTasks();
        ToDoTask GetDoTaskById(int taskId);
        void AddTodo(ToDoTask toDo);
        void updateComplete(int taskId);
        void removeCategory(string catName);
    }
}
