using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    public class TaskToDo
    {
        public string Description { get; set; }
        private static bool IsDone { get; set; }
        public DateTime DoDate { get; set; }


        public TaskToDo(string description, DateTime doDate, bool isDone = false)
        {
            Description = description;
            DoDate = doDate;
            IsDone = isDone;
        }

        public void Show(List<TaskToDo> tasks)
        {
            Console.WriteLine(DateTime.Now.ToString("D"));
            var currentColor = Console.ForegroundColor;
            if (IsDone)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }

            foreach (var task in tasks)
            {
                //if (IsToday(task.DoDate)) Console.WriteLine(task);
            }
            Console.ForegroundColor = currentColor;

        }

        public void SetAsDone()
        {
            IsDone = true;
        }
    }
}