using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class Columns
    {
        int[] FirstColumn = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        int[] SecondColumn = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        int[] ThirdColumn = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

        public void Column(Result result)
        {
            int col1 = Array.IndexOf(FirstColumn, result.Number);
            int col2 = Array.IndexOf(SecondColumn, result.Number);
            int col3 = Array.IndexOf(ThirdColumn, result.Number);
            if (col1 > -1)
            {
                Console.WriteLine("The bet on Column One is 2:1");
            }

            if (col2 > -1)
            {
                Console.WriteLine("The bet on Column Two is 2:1");
            }

            if (col3 > -1)
            {
                Console.WriteLine("The bet on Column Three is 2:1");
            }

        }
    }
}
