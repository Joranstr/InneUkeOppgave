using System;

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

        public static void Show( string toDo)
        {
            WritHeader();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(toDo);
            
            
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