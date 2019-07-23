using System.IO;
using System.Text.RegularExpressions;



namespace Cleaning
{
    // Searching the keyword of directorys and foldes - SECURITY
    public class Search
    {
        public static string Expression = null;
        
        public static bool Find(string arg)
        {
            // Console.WriteLine("*****" + arg);
            Regex regex = new Regex(Expression); //, RegexOptions.IgnoreCase);
            // bool stringEquals = String.Equals(subdirectory, "N-CP");
            Match m = regex.Match(arg);
            // Console.WriteLine("*****" + "N-FE-");
            // file extension
            string ext = Path.GetExtension(arg);

            // Equal extension of file & name
            if (ext == ".log" && m.Success)
            {
                return true;
            }
            else if (ext == ".txt" && m.Success)
            {
                return true;
            }
            else return false;

        }
    }
}


