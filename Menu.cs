using System;
using System.Threading;

namespace Cleaning
{
    public class Menu
    {
        private const string ENG = "N-EN-";
        private const string FCM = "N-FC-";
        private const string RCM = "N-RC-";
        private const string FEM = "N-FE-";
        private const string CPM = "N-CP-";
        private const string FAX = "N-FA-";
        

        public static void InfoForUser()
        {
            Console.Clear();
            Console.WriteLine("\n Choice one of possibilities");
            Console.WriteLine("\n 1    2    3    4    5    6");
            Console.WriteLine("ENG  FCM  RCM  FEM  CPM  FAX");
            Console.WriteLine("\n");

            Console.Write("Your choice: ");
            ProcessUser(Console.ReadLine());
        }

        private static void ProcessUser(string arg)
        {
            try
            {
                int numVal = Int32.Parse(arg);

                if (numVal == 1)
                {
                    Search.Expression = ENG;
                }
                else if (numVal == 2)
                {
                    Search.Expression = FCM;
                }
                else if (numVal == 3)
                {
                    Search.Expression = RCM;
                }
                else if (numVal == 4)
                {
                    Search.Expression = FEM;
                }
                else if (numVal == 5)
                {
                    Search.Expression = CPM;
                }
                else if (numVal == 6)
                {
                    Search.Expression = FAX;
                }
                else if (numVal <= 0 | numVal >= 8)
                {
                    Catch(arg);
                }
            }
            catch (FormatException)
            {
                Catch(arg);
            }
            catch (OverflowException)
            {
                Catch(arg);
            }
        }

        private static void Catch(string arg)
        {
            Console.WriteLine("\n         Bad Format !!!        ");
            Console.Write(value: "\n          TRY AGAIN");
            Thread.Sleep(millisecondsTimeout: 1500);
            InfoForUser();
        }
    }
}
