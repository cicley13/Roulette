using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class Split
    {
        int[] FirstColumn = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        int[] SecondColumn = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        int[] ThirdColumn = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

        public void Splits(Result result)
        {
            int n = result.Number;
            int col1 = Array.IndexOf(FirstColumn, n);
            int col2 = Array.IndexOf(SecondColumn, n);
            int col3 = Array.IndexOf(ThirdColumn, n);
            if (col1 > -1)
            {
                if (n == 1)
                {
                    Console.WriteLine($"The Split bet can win on {n}/{n + 3} and {n}/{n + 1} it's a 17:1 bet");
                }
                else if (n == 34)
                {
                    Console.WriteLine($"The Split bet can win on {n}/{n - 3} and {n}/{n + 1} it's a 17:1 bet");
                }
                else
                {
                    Console.WriteLine($"The Split bet can win on {n}/{n + 3} and {n}/{n - 3} and {n}/{n + 1} it's a 17:1 bet");
                }
            }

            if (col2 > -1)
            {
                if (n == 2)
                {
                    Console.WriteLine($"The Split bet can win on {n}/{n + 3} and {n}/{n - 1} and {n}/{n + 1} it's a 17:1 bet");
                }
                else if (n == 35)
                {
                    Console.WriteLine($"The Split bet can win on {n}/{n - 3} and {n}/{n + 1} and {n}/{n - 1} it's a 17:1 bet");
                }
                else
                {
                    Console.WriteLine($"The Split bet can win on {n}/{n + 3} and {n}/{n - 3} and {n}/{n + 1} and {n}/{n - 1} it's a 17:1 bet");
                }
            }

            if (col3 > -1)
            {
                if (n == 3)
                {
                    Console.WriteLine($"The Split bet can win on {n}/{n + 3} and {n}/{n - 1} it's a 17:1 bet");
                }
                else if (n == 36)
                {
                    Console.WriteLine($"The Split bet can win on {n}/{n - 3} and {n}/{n - 1} it's a 17:1 bet");
                }
                else
                {
                    Console.WriteLine($"The Split bet can win on {n}/{n + 3} and {n}/{n - 3} and {n}/{n - 1} it's a 17:1 bet");
                }
            }

            if (n == 0)
            {
                Console.WriteLine($"The Split bet can win on {n}/00 it's a 17:1 bet");
            }
            if (n == 37)
            {
                Console.WriteLine($"The Split bet can win on 00/0 it's a 17:1 bet");
            }
        }
    }
}
