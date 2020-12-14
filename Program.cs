using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    class Program
    {
        static void  Main(string[] args)
        {
            var toDo = ($"Middag; Lag Middag; {DateTime.Now.ToString("dd/mm/yy")}; true");
            TaskToDo.Show(toDo);
        }
    }
}