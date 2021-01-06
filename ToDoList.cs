using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InneUkeOppgave
{
    class ToDoList
    {
        private DateTime _date;
        private List<TaskToDo> _tasks = new List<TaskToDo>();

        public ToDoList()
        {
        }

        public void show()
        {
            foreach (var task in _tasks)
            {
                if (IsToday(task.DoDate))
                {
                    Console.WriteLine(task.Description);
                }
                
            }
        }

        private bool IsToday(DateTime date)
        {

            return DateTime.Now >= date;
        }
        public void AddTask(TaskToDo task)
        {
            _tasks.Add(task);

        }
    }
}
