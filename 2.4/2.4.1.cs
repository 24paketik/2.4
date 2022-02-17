using System;

namespace _2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AB = " + args[0]); // Выводим на экран AB
            double AB = Convert.ToDouble(args[0]); // Конвертируем в тип double
            Console.WriteLine("AC = " + args[1]); // Выводим на экран AC
            double AC = Convert.ToDouble(args[1]); // Конвертируем в тип double
            Console.WriteLine("BC = " + args[2]); // Конвертируем в тип double
            double BC = Convert.ToDouble(args[2]); // Выводим на экран BC
            double P =AB+AC+BC; // Считаем периметр
            Console.WriteLine("P(ABC) = "+P); // Выводим на экран периметр
        }
    }
}
