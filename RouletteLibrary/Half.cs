using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class Half
    {
        public void Halfs(Result result)
        {
            if(result.Number >= 1 && result.Number <= 18)
            {
                Console.WriteLine("The bet on 1-18 is 1:1");
            }
            else if (result.Number >= 19 && result.Number <= 36)
            {
                Console.WriteLine("The bet on 19-36 is 1:1");
            }
        }
    }
}
