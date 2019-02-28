using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class Colors
    {
        public void Color(Result result)
        {
            if (result.Number >= 1 && result.Number <= 36)
            {
                Console.WriteLine($"The color bet on {result.Color} is 1:1");
            }
        }
    }
}
