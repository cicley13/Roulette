using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class OddEven
    {
        public void Odd(Result result)
        {
            if (result.Number >= 1 && result.Number <= 36)
            {
                if (result.Number % 2 == 0)
                {
                    Console.WriteLine("The bet on Even is 1:1");
                }
                else
                {
                    Console.WriteLine("The bet on Odd is 1:1");
                }
            }

        }
    }
}
