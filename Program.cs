using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    class Program
    {
        static void  Main(string[] args)
        {
            var toDos = new List<TaskToDo> {new TaskToDo($"Lag Middag;", true), new TaskToDo($"Lag Middag;", false)};
            TaskToDo.Show(toDos);
        }
    }
}