using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpConsoleApp
{
    class Program
    {
        static void ShowEnvironmentDetails() {
            // Print out the drives on this machine,
            // and other interesting details.
            foreach(string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
        }

        static int Main(string[] args)
        {
            Console.Title = "My First App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************");
            Console.WriteLine("*** Welcome to My First App ***");
            Console.WriteLine("*******************************");
            Console.BackgroundColor = ConsoleColor.Black;

            // Processing Command line arguments
            for(int i=0; i < args.Length; i++)
            {
                Console.WriteLine("Arg: {0}", args[i]);
            }

            // Using foreach loop
            foreach (string arg in args)
                Console.WriteLine("Arg : {0}", arg);

            // Get arguments using System.Environment
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach(string arg in theArgs)
                Console.WriteLine("Arg: {0}", arg);

            // Helper method within the Program class.
            ShowEnvironmentDetails();

            // Wait for the key to be pressed
            Console.ReadLine();

            // Return an arbitrary error code
            return -1;
        }
    }
}
