using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    class Program
    {
        static void  Main(string[] args)
        {
            var toDos = new List<ToDo>();
            for (int i = 0; i < 2; i++)
            {
                toDos = SetAsDone(toDos);
            }
            
            
            TaskToDo.Show(toDos);
        }

        private static List<ToDo> SetAsDone(List<ToDo> toDos)
        {
            Console.WriteLine("Har du lagd middag? y/n");
            var lagdmiddag =Console.ReadLine();
            if (lagdmiddag == "y")
            {
                toDos.Add(new ToDo("Middag", "Lag Middag", DateTime.Now.ToString("dd/mm/yy"), true));
            }
            else
            {
                toDos.Add(new ToDo("Middag", "Lag Middag", DateTime.Now.ToString("dd/mm/yy"), false));
            }

            return toDos;
        }
    }
}