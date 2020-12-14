using System;
using System.Collections.Generic;
using static InneUkeOppgave.ToDo;

namespace InneUkeOppgave
{
    public class TaskToDo
    {
        
        private readonly string _taskName;
        private string _description;
        private DateTime _duoDate;

        public TaskToDo(string taskName, string description, DateTime duoDate)
        {
            _taskName = taskName;
            _description = description;
            _duoDate = duoDate;
        }

        public static void Show(List<ToDo>toDos)
        {
            WritHeader();
            foreach (var toDo in toDos)
            {
                if (toDo.IsDone)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                
                Console.Write(toDo.TaskName+"; ");
                Console.Write(toDo.Description+"; ");
                Console.Write(toDo.DuoDate+"; ");
                Console.Write(toDo.IsDone);
                Console.WriteLine();
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