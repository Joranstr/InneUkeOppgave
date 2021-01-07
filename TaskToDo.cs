﻿using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    public class TaskToDo
    {
        public string Description;
        private static bool IsDone;
        public DateTime DoDate;


        public TaskToDo(string description, DateTime doDate)
        {
            Description = description;
            DoDate = doDate;
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

        public bool IsMatchDate(DateTime otherDate)
        {
            return DoDate.Equals(otherDate);
        }

        public void SetAsDone()
        {
            IsDone = true;
        }
    }
}