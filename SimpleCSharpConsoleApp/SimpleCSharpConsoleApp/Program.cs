using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpConsoleApp
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Title = "My First App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************");
            Console.WriteLine("*** Welcome to My First App ***");
            Console.WriteLine("*******************************");
            Console.BackgroundColor = ConsoleColor.Black;

            // Wait for the key to be pressed
            Console.ReadLine();

            // Return an arbitrary error code
            return -1;
        }
    }
}
