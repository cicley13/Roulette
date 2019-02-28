using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class Corner
    {
        int[] FirstColumn = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        int[] SecondColumn = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        int[] ThirdColumn = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

        public void Corners(Result result)
        {
            int n = result.Number;
            int col1 = Array.IndexOf(FirstColumn, n);
            int col2 = Array.IndexOf(SecondColumn, n);
            int col3 = Array.IndexOf(ThirdColumn, n);
            if (col1 > -1)
            {
                if (n == 1)
                {
                    Console.WriteLine($"The Corner bet on can win on {n}/{n+1}/{n+3}/{n+4} it's a 8:1 bet");
                }
                else if (n == 34)
                {
                    Console.WriteLine($"The Corner bet can win on {n}/{n + 1}/{n - 3}/{n - 4} it's a 8:1 bet");
                }
                else
                {
                    Console.WriteLine($"The Corner bet can win on {n}/{n + 1}/{n + 3}/{n + 4} and {n}/{n + 1}/{n - 2}/{n - 3} it's an 8:1 bet");
                }
            }

            if (col2 > -1)
            {
                if (n == 2)
                {
                    Console.WriteLine($"The Corner bet on can win on {n}/{n + 1}/{n + 3}/{n + 4} and {n}/{n - 1}/{n + 2}/{n + 3}it's a 8:1 bet");
                }
                else if (n == 35)
                {
                    Console.WriteLine($"The Corner bet on can win on {n}/{n + 1}/{n - 2}/{n - 3} and {n}/{n - 1}/{n - 3}/{n - 4} it's a 8:1 bet");
                }
                else
                {
                    Console.WriteLine($"The Corner bet can win on {n}/{n - 1}/{n - 3}/{n - 4} and {n}/{n + 1}/{n -2}/{n - 3} and {n}/{n - 1}/{n + 2}/{n + 3} and {n}/{n + 1}/{n + 3}/{n + 4}it's a 8:1 bet");
                }
            }

            if (col3 > -1)
            {
                if (n == 3)
                {
                    Console.WriteLine($"The Corner bet can win on {n}/{n - 1}/{n + 2}/{n + 3} it's a 8:1 bet");
                }
                else if (n == 36)
                {
                    Console.WriteLine($"The Corner bet can win on {n}/{n - 1}/{n - 3}/{n - 4} it's a 8:1 bet");
                }
                else
                {
                    Console.WriteLine($"The Corner bet can win on {n}/{n - 1}/{n - 3}/{n - 4} and {n}/{n - 1}/{n + 2}/{n + 3} it's a 8:1 bet");
                }
            }
        }
    }
}
