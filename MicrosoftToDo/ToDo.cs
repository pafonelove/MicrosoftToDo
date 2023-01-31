using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MicrosoftToDo
{
    internal class ToDo
    {
        Screen display = new Screen();
        List<string> tasks = new List<string>();

        string input;
        public void StartProgram()
        {
            while(true)
            {
                display.DrawMenu();
                Console.Write("> ");
                input = display.Input();
                Console.WriteLine();

                if (input == "1")
                {
                    ShowTasks();
                }
                else if (input == "2")
                {
                    Console.Write("Введите новую задачу: ");
                    input = display.Input();
                    AddTask(input);
                } 
                else if (input == "3")
                {
                    Console.WriteLine("Выход из программы");
                    return;
                }
                else
                {
                    Console.WriteLine("Выберите корректное действие!");
                }
            }
        }

        public void AddTask(string task)
        {
            string path = "D:\\Development\\.NET\\Projects\\MicrosoftToDo\\MicrosoftToDo\\MicrosoftToDo\\test.txt";
            string text = task;

            File.AppendAllText(path, text + "\n");
        }

        public void ShowTasks()
        {
            //if (tasks.Count <= 0)
            //{
            //    Console.WriteLine("Список задач пуст!");
            //    return;
            //}

            //int i = 1;
            //foreach(string s in tasks)
            //{
            //    Console.WriteLine($"Task {i}: {s}.");
            //    i++;
            //}
            string path = "D:\\Development\\.NET\\Projects\\MicrosoftToDo\\MicrosoftToDo\\MicrosoftToDo\\test.txt";
            string[] lines = File.ReadAllLines(path);

            if (lines.Length <= 0)
            {
                Console.WriteLine("Список задач пуст!");
                return;
            }

            int i = 1;
            foreach (string s in lines)
            {
                Console.WriteLine($"Task {i}: {s}.");
                i++;
            }
        }
    }
}
