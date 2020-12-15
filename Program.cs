using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    class Program
    {
        static void  Main(string[] args)
        {
            var task = new TaskToDo();
            
            task.Show("forkost",false);
            task.Show("forkost",true);
        }
    }
}