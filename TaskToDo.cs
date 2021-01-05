using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    public class TaskToDo
    {
        private string Description { get; set; }
        private static bool IsDone { get; set; }
        private  DateTime DoDate { get; set; }


        public TaskToDo(string description, DateTime doDate, bool isDone = false)
        {
            Description = description;
            DoDate = doDate;
            IsDone = isDone;
        }

        public void Show()
        {
            var currentColor = Console.ForegroundColor;
            if (IsDone)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }

            Console.WriteLine(Description);
            Console.ForegroundColor = currentColor;

        }

        public void SetAsDone()
        {
            IsDone = true;
        }
    }
}