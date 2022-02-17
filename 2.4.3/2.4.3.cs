using System;

namespace _2._4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool On = false;
            double a = Convert.ToDouble(args[0]);
            double b = Convert.ToDouble(args[1]);
            int ScoreA = 1, ScoreB = 1;
            while (On == false)
            {
                if (a > 0)
                {
                    a = a / 10;
                    ScoreA++;
                }
                else { On = true; } 
            }
            Console.WriteLine("ScoreB = " + ScoreB);
            On = false;
            while (false)
            {
                if (b > 0)
                {
                    b = b / 10;
                    ScoreB++;
                } 
                else
                {
                    On = true;
                    Console.WriteLine("ScoreB = " + ScoreB);
                }
            }
            if (ScoreA>ScoreB)
            {
                Console.WriteLine("У A больше цифр");
            } else
            {
                if (ScoreB>ScoreA)
                {
                    Console.WriteLine("У B больше цифр");
                } else
                {
                    Console.WriteLine("У чисел одинаковое количество цифр");
                }
            }
        }
    }
}
