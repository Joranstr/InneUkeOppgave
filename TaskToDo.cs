using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    public class TaskToDo
    {
        private string _description { get; set; }
        private bool _isDone { get; set; }
        

        // public TaskToDo(string description, bool isDone)
        // {
        //     _description = description;
        //     _isDone = isDone;
        // }

        public void Show(string task, bool isDone)
        {
            
                SetAsDone(isDone);
                Console.WriteLine(task);
            
        }

        private static void SetAsDone(bool isDone)
        {
            Console.ForegroundColor = isDone ? ConsoleColor.Green : ConsoleColor.White;
        }
    }
}