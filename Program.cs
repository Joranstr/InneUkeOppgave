using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    class Program
    {
        static void  Main(string[] args)
        {
            var task = new TaskToDo("frokost", DateTime.Now);
            var toDoList = new ToDoList();
            var tasks = toDoList.AddTask(task);
            task.Show();
            
        }
    }
}