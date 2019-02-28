using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class Street
    {
        int[] FirstColumn = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        int[] ThirdColumn = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

        public void Streets(Result result)
        {
            int n = result.Number;
            int col1 = Array.IndexOf(FirstColumn, result.Number);
            int col3 = Array.IndexOf(ThirdColumn, result.Number);
            if (col1 > -1)
            {
                Console.WriteLine($"The Street bet is {n}/{n+1}/{n+2} it's an 11:1");
            }

            if (col3 > -1)
            {
                Console.WriteLine($"The Street bet is {n}/{n-1}/{n-2} it's an 11:1");
            }
        }
    }
}
