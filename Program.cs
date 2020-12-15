using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    class Program
    {
        static void  Main(string[] args)
        {
            var toDos = new List<TaskToDo>();
            toDos.Add($"Lag Middag;", true);
            var toDo2 = ($"Lag Middag;", true);
            TaskToDo.Show(toDo);
        }
    }
}