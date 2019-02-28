using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteLibrary
{
    public class WheelSpin
    {

        public Result Bins()
        {
            Result result = new Result();
            int[] red = { 0, 1, 3, 5, 7, 9, 12, 14, 15, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 3, 33, 35, 37 };
            Random ran = new Random();

            int num = ran.Next(1, 50);
            if (num > 25)
            {
                result.Color = "Red";
                result.Number = red[ran.Next(0, 19)];
            }
            else
            {
                result.Color = "Black";
                result.Number = black[ran.Next(0, 19)];
            }
            return result;
        }

        public void Spin(Result result)
        {
            if(result.Number >= 1 && result.Number <= 36)
            {
            Console.WriteLine($"\nThe ball landed in bin {result.Color} {result.Number}");
            }
            if (result.Number == 0)
            {
                Console.WriteLine("\nThe ball landed in bin Green 0");
            }
            if (result.Number == 37)
            {
                Console.WriteLine("\nThe ball landed in bin Green 00");
            }
            
        }
    }
}
