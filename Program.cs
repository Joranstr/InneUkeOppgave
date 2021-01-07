using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    class Program
    {
        static void  Main(string[] args)
        {
            var todoList = new ToDoList();
            var toDo = new TaskToDo("Froskost", DateTime.Now);
            todoList.AddTask(toDo);
            todoList.Show();
        }
    }
}