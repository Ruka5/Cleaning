using System;
using System.IO;
using System.Collections.Specialized;
using System.Threading;



namespace Cleaning
{
    // takes an array of file or directory names on the command line, 
    // determines what kind of name it is, and processes it appropriately

    public class RecursiveFileProcessor
    {
        
        public static int countFiles = 0;
        public static bool wait = false;
        
        public static void SearchFor(string args)
        {
            if (wait)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\n ----------WAIT---------");
            }
            
            wait = false;

            if (File.Exists(args))
            {
                // This path is a file
                ProcessFile(args);
            }
            else if (Directory.Exists(args))
            {
                // This path is a directory
                ProcessDirectory(args);
            }
            else
            {                
                Console.WriteLine("Incorrect path !!!");
                Thread.Sleep(millisecondsTimeout: 1500);
                InfoToUser.Destination();
            }
        }


        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        public static void ProcessDirectory(string targetDirectory)
        {
            // Create and initializes a new StringCollection.
            StringCollection myCol = new StringCollection();
            try
            {
                // Process the list of files found in the directory.
                string[] fileEntries = Directory.GetFiles(targetDirectory);
                foreach (string fileName in fileEntries)
                {
                    myCol.Add(fileName);
                    if (myCol.Count == fileEntries.Length)
                    {
                        SamplesStringCollection.PrintValues3(myCol);
                        //ProcessFile();                        
                    }
                    // Console.Write("fol*");                    
                }

                // Recurse into subdirectories of this directory.
                string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
                foreach (string subdirectory in subdirectoryEntries)
                {
                    ProcessDirectory(subdirectory);
                    countFiles = 0;
                    // Console.Write("fff*");                    
                }
            }
            catch (Exception e)
            {
                /*Console.WriteLine("The process failed: {0}", e.ToString());
                FileAttributes attr = (new FileInfo(targetDirectory)).Attributes;
                Console.Write("UnAuthorizedAccessException: Unable to access file. ");
                if ((attr & FileAttributes.ReadOnly) > 0)
                    Console.Write("The file is read-only.");*/
            }            
        }

        // Insert logic for processing found files here.
        public static void ProcessFile(string path)
        {
            // Console.WriteLine("Processed file '{0}'.", path);
            // Console.WriteLine("***************************************************************");
            Security.Read2(path);
            //Console.Clear();
        }
    }
}