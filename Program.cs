using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    class Program
    {
        static void  Main(string[] args)
        {
            var task = new TaskToDo("frokost");
            task = new TaskToDo("frokost", true);
            
            task.Show();
        }
    }
}