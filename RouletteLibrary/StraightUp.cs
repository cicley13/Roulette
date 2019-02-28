using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class StraightUp
    {
        public void Straight(Result result)
        {
            if (result.Number >= 0 && result.Number <= 36)
            {
            Console.WriteLine($"The straight up bet on {result.Number} is 35:1");
            }
            else
            {
                Console.WriteLine($"The straight up bet on 00 is 35:1");
            }

        }
    }
}
