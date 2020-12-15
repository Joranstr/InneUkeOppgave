﻿using System;
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
                SetAsDone(toDo);
                Console.WriteLine(toDo);
            }
        }

        private static void SetAsDone(TaskToDo toDo)
        {
            if (toDo._isDone)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static void WritHeader()
        {
            Console.Write("Name of Task; ");
            Console.Write("Description; ");
            Console.Write("Do Date; ");
            Console.Write("Is it Done; ");
            Console.WriteLine();
        }
    }
}