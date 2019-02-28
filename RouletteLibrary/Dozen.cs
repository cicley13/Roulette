using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class Dozen
    {
        public void Doz(Result result)
        {
            if(result.Number >= 1 && result.Number <= 12)
            {
                Console.WriteLine("The bet on First Dozen(1-12) is 2:1");
            }
            else if (result.Number >= 13 && result.Number <= 24)
            {
                Console.WriteLine("The bet on Second Dozen(13-24) is 2:1");
            }
            else if (result.Number >= 25 && result.Number <= 36)
            {
                Console.WriteLine("The bet on Third Dozen(25-36) is 2:1");
            }
        }
    }
}
