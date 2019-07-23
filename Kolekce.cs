using System.Collections.Specialized;

namespace Cleaning
{
    public class SamplesStringCollection
    {
        
        // Uses the Count and Item properties.
        public static void PrintValues3(StringCollection myCol)
        {              
            if (myCol.Count < 3)
            {
                for (int i = 0; i < myCol.Count; i++)
                {
                    //Console.WriteLine("lll"+myCol[i]);
                    //RecursiveFileProcessor.ProcessFile(myCol[i]);
                }
            }
            else
            {
                for (int i = 0; i < myCol.Count - 3; i++)
                {                    
                    RecursiveFileProcessor.ProcessFile(myCol[i]);
                }                
            }
        }
    }
}
