using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteLibrary;

namespace RouletteConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All possible Winning bets!");

            WheelSpin wheelSpin = new WheelSpin();
            Result result = wheelSpin.Bins();
            wheelSpin.Spin(result);

            StraightUp su = new StraightUp();
            su.Straight(result);

            Colors colors = new Colors();
            colors.Color(result);

            OddEven oddEven = new OddEven();
            oddEven.Odd(result);

            Half half = new Half();
            half.Halfs(result);

            Dozen dozen = new Dozen();
            dozen.Doz(result);

            Columns columns = new Columns();
            columns.Column(result);

            SixLine sixLine = new SixLine();
            sixLine.Line(result);

            Corner corner = new Corner();
            corner.Corners(result);

            Street street = new Street();
            street.Streets(result);

            Split split = new Split();
            split.Splits(result);

            Basket basket = new Basket();
            basket.Baskets(result);
            Console.ReadLine();


        }
    }
}
