using System;
using System.IO;

namespace LoggingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\path\log.txt";
            var displayMessage = "Hello, user";
            File.WriteAllText(path, displayMessage);
            Console.WriteLine(displayMessage);
        }
    }
}


