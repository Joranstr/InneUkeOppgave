using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    public class TaskToDo
    {
        private string Description { get; set; }
        private bool IsDone { get; }


        public TaskToDo(string description, bool isDone = false)
        {
            Description = description;
            IsDone = isDone;
        }

        public void Show()
        {

            if (IsDone)
            {
                SetAsDone();
            }
            Console.WriteLine(Description);

        }

        private static void SetAsDone()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}