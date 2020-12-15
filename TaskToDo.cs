using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    public class TaskToDo
    {
        private string _beskrivelse;
        private bool _isDone;

        public TaskToDo(string beskrivelse, bool isDone)
        {
            _beskrivelse = beskrivelse;
            _isDone = isDone;
        }

        public static void Show(List<TaskToDo> toDos)
        {
            foreach (var toDo in toDos)
            {
                SetAsDone(toDo._isDone);
                Console.WriteLine(toDo._beskrivelse);
            }
        }

        private static void SetAsDone(bool isDone)
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