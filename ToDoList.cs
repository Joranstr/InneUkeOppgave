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
            
        }


        public List<TaskToDo> AddTask(TaskToDo task)
        {
            _tasks = new List<TaskToDo>(){task};
            return _tasks;
        }
    }
}
