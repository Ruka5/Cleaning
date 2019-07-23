using System;


namespace Cleaning
{
    class InfoToUser
    {
        public static void Destination()
        {
            RecursiveFileProcessor.wait = true;
            Console.Write("Put the path: ");
            string io = Console.ReadLine();
            RecursiveFileProcessor.SearchFor(io);
            // Read2("x:\\MES_Team\\Lukas\\Cleaning\\Cleaning\\Add.cs");
            // Console.Clear();
        }        
    }
}
