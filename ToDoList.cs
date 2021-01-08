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
        private int _selectedIndex;

        public ToDoList()
        {
            _tasks = new List<TaskToDo>();
            _date = DateTime.Now;
        }

        public void Show()
        {
            Console.WriteLine(_date.ToString("D"));
            
            foreach (var task in _tasks)
            {
                if(task.IsMatchDate(_date)) 
                    task.Show();
            }
        }
         
        public void AddTask(TaskToDo task)
        {
            _tasks.Add(task);
        }

        public void MoveDays(int deltaDays)
        {
            _date = _date.AddDays(deltaDays);
        }

        public void MoveSelection(int Move)
        {
            throw new NotImplementedException();
        }
    }
}