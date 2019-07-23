using System;

public class Example
{
    public void GetTime()
    {
        Console.Clear();
        DateTime dat = DateTime.Now;
        Console.WriteLine("\nToday is {0:d} at {0:T}.\n", dat);
        // Console.Write("\nPress any key to continue... ");
        // Console.ReadLine();
    }
}