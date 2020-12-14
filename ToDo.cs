using System;

namespace InneUkeOppgave
{
    public class ToDo
    {
        public readonly string TaskName;
        public readonly string Description;
        public readonly string DuoDate;
        public readonly bool IsDone;

        public ToDo(string taskName, string description, string duoDate, bool isDone)
        {
            TaskName = taskName;
            Description = description;
            DuoDate = duoDate;
            IsDone = isDone;
        }
    }
}