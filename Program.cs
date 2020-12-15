using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    class Program
    {
        static void Main(string[] args)
        {
            var toDos = new List<ToDo>();
            toDos.Add(new ToDo("Fokost", "Lag fokost", DateTime.Now.ToString("dd/mm/yy"), true));
            toDos.Add(new ToDo("Middag", "Lag Middag", DateTime.Now.ToString("dd/mm/yy"), false));
            
            TaskToDo.Show(toDos);
        }
    }
}