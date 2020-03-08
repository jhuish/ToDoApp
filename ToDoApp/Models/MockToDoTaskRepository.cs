using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class MockToDoTaskRepository  /*: IToDoTaskRepository*/
    {
        private List<ToDoTask> _todos;

        public MockToDoTaskRepository()
        {
            if (_todos == null)
            {
                InitializeTodos();
            }
        }

        private void InitializeTodos()
        {
            _todos = new List<ToDoTask>
           {
               new ToDoTask {Id = 1, ToDoName = "Take out Garbage" , ToDoCategory="Home", ToDoPriorityLevel=4},
               new ToDoTask {Id = 2, ToDoName = "Get new tires" , ToDoCategory="Car", ToDoPriorityLevel=2},
               new ToDoTask {Id = 1, ToDoName = "Do evals" , ToDoCategory="Work", ToDoPriorityLevel=5},
               new ToDoTask {Id = 1, ToDoName = "Clean Attic" , ToDoCategory="Home", ToDoPriorityLevel=1}
           };
        }

        public ToDoTask GetDoTaskById(int taskId)
        {
            return _todos.FirstOrDefault(t => t.Id == taskId);
        }

        public IEnumerable<ToDoTask> GetToDoTasks()
        {
            return _todos;
        }

        public void AddTodo(ToDoTask toDo)
        {
            throw new NotImplementedException();
        }

        public void RemoveTodo(ToDoTask toDo)
        {
            throw new NotImplementedException();
        }

        public void updateComplete(int taskId)
        {
            throw new NotImplementedException();
        }
    }
}
