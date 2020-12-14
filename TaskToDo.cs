using System;

namespace InneUkeOppgave
{
    public class TaskToDo
    {
        private string _beskrivelse;
        
        public TaskToDo(string beskrivelse)
        {
            _beskrivelse = beskrivelse;
        }
        public static void Show( string toDo)
        {
            // WritHeader();
            // Console.ForegroundColor= ConsoleColor.Green;
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