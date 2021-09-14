using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modulo (%) says how many times a
            //number fits into an another number
            //If it prints 0 it's even
            //1 if it's odd
            int num1 = 64;
            int num2 = 8;
            int DividedNum = num1 % num2;
            int AbNum = -8;
            int SqrtNum = 128;
            //Dont forget the m
            decimal RoundNum = 48.658m;
            double MinNum = 0.965;
            int MaxNum = 360;
            int funy = 0;

            Console.WriteLine(DividedNum);

            //Math.Abs() finds the absolute value of a number
            Console.WriteLine(Math.Abs(AbNum));

            //Math.Pow() raises #1 by the power of #2
            Console.WriteLine(Math.Pow(10, 1000));

            //Math.Sqrt() finds the square root of a number
            Console.WriteLine(Math.Sqrt(SqrtNum));

            //Math.Ceiling() rounds up decimals and doubles
            Console.WriteLine(Math.Ceiling(RoundNum));

            //Math.Floor() rounds down decimals and doubles
            Console.WriteLine(Math.Floor(RoundNum));

            //Math.Min() finds the smaller number of 2
            Console.WriteLine(Math.Min(MinNum, 36));

            //Math.Max() finds the bigger number of 2
            Console.WriteLine(Math.Max(MaxNum, 25));

            //You can use multiple methods at once
            Console.WriteLine(Math.Floor(Math.Max(7.84, 52.652)));

            //Increments and decrements +1 is ++ and -1 is -- more than that is
            //+= and -=
            funy += 2;
            funy--;
            Console.WriteLine(funy);

            //Math.Round() rounds doubles up
            Console.WriteLine(Math.Round(6.98562));
            Console.WriteLine(Math.Round(3.14469823, 2));
        }
    }
}