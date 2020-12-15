using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    class Program
    {
        static void  Main(string[] args)
        {
            var toDos = new List<TaskToDo>();
            toDos.Add(new TaskToDo($"Lag Middag;", true));
            toDos.Add(new TaskToDo($"Lag Middag;", false));
            TaskToDo.Show(toDos);
        }
    }
}