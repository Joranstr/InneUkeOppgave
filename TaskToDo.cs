using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    public class TaskToDo
    {
        private string _description;
        private bool _isDone;

        public TaskToDo(string description, bool isDone)
        {
            _description = description;
            _isDone = isDone;
        }

        public static void Show(List<TaskToDo> toDos)
        {
            foreach (var toDo in toDos)
            {
                SetColorOfTekst(toDo._isDone);
                Console.WriteLine(toDo._description);
            }
        }

        private static void SetColorOfTekst(bool isDone)
        {
            if (isDone)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}