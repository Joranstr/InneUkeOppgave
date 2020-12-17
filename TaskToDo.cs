using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    public class TaskToDo
    {
        private string _description { get; set; }


        public TaskToDo(string description, bool isDone)
        {
            _description = description;
        }

        public void Show(string task, bool isDone)
        {

            if (isDone)
            {
                SetAsDone();
            }
            Console.WriteLine(task);

        }

        private static void SetAsDone()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}