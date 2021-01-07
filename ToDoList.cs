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
        private List<TaskToDo> _tasks;

        public ToDoList()
        {
            _tasks = new List<TaskToDo>();
            _date = DateTime.Now;
        }

        public void Show()
        {
            foreach (var task in _tasks)
            {
                //if (IsMatchDate(task.DoDate))
                //{
                    
                //}

                
            }
            Console.WriteLine(_date.ToString("D"));
        }
         
        public void AddTask(TaskToDo task)
        {
            _tasks.Add(task);
        }
    }
}