using System;
using System.IO;

// SECURITY - check
namespace Cleaning
{

    public static class Security
    {
        private static bool progress = false;
        public static int count = 0;

        public static bool Progress { get => progress; set => progress = value; }

        /*

// Check signed folder's row by keywor and erase the folder if match
public static void Read3(string path)
{


// Destination folder location
// string path = @"x:\MES_Team\Lukas\testovaci\Security.cs";
// RecursiveFileProcessor.ProcessFile(path);


string key = @"x:\MES_Team\Cleaning"; //SECURE


try
{
string line1;
int counter = 0;
var a = false;

// Find the text to destination - key for secure erase
using (StreamReader sr = new StreamReader(path))
{
// Line by line reading - folder.txt
while ((line1 = sr.ReadLine()) != null)
{
counter++;
// Line checker
if (counter == 1 && line1 == key)
{
Console.WriteLine(line1);
a = true;
}
}
// memory saver
sr.Close();
}


// Use a try block to catch IOExceptions, to
// handle the case of the file already being
// opened by another process.
FileInfo fi = new FileInfo(path);
try
{

//Check security
if (a)
{
// Delete destination!
fi.Delete();
a = false;
}

}
catch (IOException e)
{
// Let the user know what went wrong.
Console.WriteLine("The file could not be read:");
Console.WriteLine(e.Message);
}
}

catch (Exception e)
{
Console.WriteLine("The process failed: {0}", e.ToString());
}
}
*/

        // Erase folders by keyword only
        public static void Read2(string path)
        {
            progress = true;
            // Console.WriteLine(path);
            FileInfo fi = new FileInfo(path);
            try
            {
                if (Search.Find(path))
                {                    
                    //Console.Write("*");
                    ++count;
                    fi.Delete();
                }
            }
            catch (IOException e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }    
    }
}
