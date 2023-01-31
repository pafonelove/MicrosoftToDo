using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftToDo
{
    internal class Screen
    {
        public void DrawMenu()
        {
            Console.WriteLine("\n1. Посмотреть свои задачи.\n" +
                              "2. Записать новую задачу.\n" +
                              "3. Выйти из программы.");
        }

        public string? Input()
        {
            string? str = Console.ReadLine();
            if ((str == "R") || (str == "r")) {
                Process.GetCurrentProcess().Kill();
            }

            return str;
        }
    }
}
