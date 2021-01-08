﻿using System;
using System.Collections.Generic;

namespace InneUkeOppgave
{
    class Program
    {
        static void Main(string[] args)
        {
            var todoList = new ToDoList();
            var toDo = new TaskToDo("Froskost", DateTime.Now);
            todoList.AddTask(toDo);
            do
            {
                var keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    todoList.MoveDays(-1);
                else if(keyInfo.Key == ConsoleKey.RightArrow)
                    todoList.MoveDays(1);
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                    todoList.MoveDays(-1);
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                    todoList.MoveDays(1);
                todoList.Show();
            } while (true);
        }
    }
}