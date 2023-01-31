using System;
using System.Security.Cryptography.X509Certificates;
/*
*  Написать консольное приложение To-Do.
*/


namespace MicrosoftToDo;

class Program
{
    static void Main()
    {
        ToDo ob = new ToDo();
        ob.StartProgram();
    }
}