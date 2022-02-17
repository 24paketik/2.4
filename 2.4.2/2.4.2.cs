using System;

namespace _2._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AB = " + args[0]); // Выводим на экран AB
            double AB = Convert.ToDouble(args[0]); // Конвертируем в тип double
            Console.WriteLine("AC = " + args[1]); // Выводим на экран AC
            double AC = Convert.ToDouble(args[1]); // Конвертируем в тип double
            Console.WriteLine("DC = " + args[2]); // Конвертируем в тип double
            double DC = Convert.ToDouble(args[2]); // Выводим на экран BC
            double BC =Math.Round( Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(AC, 2)),2); // Высчитываем сторону BC и округляем до 2 цифр после запятой
            Console.WriteLine("BC = √({0}^2 + {1}^2) = {2}",AB,AC,BC); // Выводим на экран вычисление BC
            double BD =Math.Round (Math.Sqrt(Math.Pow(BC, 2) + Math.Pow(DC, 2)),2); // Высчитываем сторону BD и округляем до 2 цифр после запятой
            Console.WriteLine("BD = √({0}^2 + {1}^2) = {2}", BC, DC, BD); // Выводим на экран вычисление BD
            double P = AC + DC + BD + AB; // Вычисляем периметр
            Console.WriteLine("P = " + P); // Выводим на экран периметр
        }
    }
}
