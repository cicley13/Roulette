using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class SixLine
    {
        public void Line(Result result)
        {
            int n = result.Number;
            int[] FirstColumn = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31};
            int col1 = Array.IndexOf(FirstColumn, result.Number);

            if (col1 > -1)
            {
                Console.WriteLine($"The Six Line bets are {n}/{n+1}/{n+2}/{n+3}/{n+4}/{n+5} is 5:1");
            }

            int[] ThirdColumn = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33 };
            int col3 = Array.IndexOf(ThirdColumn, result.Number);

            if (col3 > -1)
            {
                Console.WriteLine($"The Six Line bets are {n}/{n - 1}/{n - 2}/{n + 1}/{n + 2}/{n + 3} is 5:1");
            }
        }
    }
}
