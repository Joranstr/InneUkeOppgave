using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    class Program
    {
        static void  Main(string[] args)
        {
            var task = new TaskToDo("frokost");
            task.Show();
            task = new TaskToDo("frokost", true);
            task.SetAsDone();
            task.Show();
        }
    }
}