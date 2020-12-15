using System;
using System.Collections.Generic;
using System.Text;
using static InneUkeOppgave.ToDo;

namespace InneUkeOppgave
{
    public class TaskToDo
    {
        
        public static void Show(List<ToDo> toDos)
        {
            WritHeader();
            foreach (var toDo in toDos)
            {
                IsDone(toDo);
                Console.WriteLine(WriteTodo(toDo)); 
            }
        }

        private static string WriteTodo(ToDo toDo)
        {
            var sb = new StringBuilder();
            sb.Append(toDo.TaskName + "; ");
            sb.Append(toDo.Description + "; ");
            sb.Append(toDo.DuoDate + "; ");
            sb.Append(toDo.IsDone);
            return sb.ToString();
        }

        private static void IsDone(ToDo toDo)
        {
            if (toDo.IsDone)
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