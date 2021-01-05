using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    class Program
    {
        static void  Main(string[] args)
        {
            var task = new TaskToDo("frokost", DateTime.Now);
            task.Show();
            task = new TaskToDo("frokost", DateTime.Now);
            task.SetAsDone();
            task.Show();
        }
    }
}