using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class Basket
    {
        public void Baskets(Result result)
        {
            if (result.Number <= 1 || result.Number == 3 || result.Number == 37)
            {
                if (result.Number == 37)
                {
                    Console.WriteLine("The Basket bet on 00/3 is 6:1");
                }
                if (result.Number == 3)
                {
                    Console.WriteLine($"The Basket bet on {result.Number}/00 is 6:1");
                }
                if (result.Number==1)
                {
                    Console.WriteLine($"The Basket bet on {result.Number}/0 is 6:1");
                }
                if (result.Number == 0)
                {
                    Console.WriteLine($"The Basket bet on {result.Number}/1 is 6:1");
                }
            }
        }
    }
}
