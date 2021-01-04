using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    public class TaskToDo
    {
        private string Description { get; set; }
        private static bool IsDone { get; set; }


        public TaskToDo(string description, bool isDone = false)
        {
            Description = description;
            IsDone = isDone;
        }

        public void Show()
        {

            SetAsDone();
            Console.WriteLine(Description);
        }

        public void SetAsDone()
        {
            Console.ForegroundColor = IsDone ? ConsoleColor.Green : ConsoleColor.White;
        }
    }
}