using System;
// using static RecursiveFileProcessor;

namespace Cleaning
{
    class Program
    {
        public static bool check = true;
        static void Main(string[] args)
        {
            Example ex = new Example();
            ex.GetTime();
            Menu.InfoForUser();
            InfoToUser.Destination();
                     
            check = false;
                        
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(value: $"\n The amount erased files:   {Security.count}                        ");
            Console.ResetColor();

            if (check == false)            
            {
                Console.Beep();
                Console.WriteLine("\n\n\n\n\n\n\n---------------Press Enter---------------");
                Console.WriteLine("\n There's no any folder need to be processed");
                Console.Beep();
                Console.WriteLine("        Application going to shut \n");
                Console.Beep();
                Console.WriteLine("---------------Press Enter---------------");
                Console.Beep();
                Console.ReadLine();
                Environment.Exit(1);
            }
        }
    }
}
