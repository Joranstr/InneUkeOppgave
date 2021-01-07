using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    public class TaskToDo
    {
        public string Description;
        private static bool IsDone;
        public DateTime DoDate;


        public TaskToDo(string description, DateTime doDate, bool isDone = false)
        {
            Description = description;
            DoDate = doDate;
            IsDone = isDone;
        }

        public void Show()
        {
            //Console.WriteLine(DateTime.Now.ToString("D"));
            var currentColor = Console.ForegroundColor;
            if (IsDone)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }

            Console.WriteLine(Description);

            Console.ForegroundColor = currentColor;

        }

        //private bool CheckIfIsToday(DateTime date)
        //{
        //    return DateTime.Now >= date;
        //}

        public void SetAsDone()
        {
            IsDone = true;
        }
    }
}