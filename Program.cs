//using System;
//using System.Text;
//using static System.Console;

//namespace Lessons11
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            int minValue = MathExtensions.Min(15, 8, 22);
//            int maxValue = MathExtensions.Max(15, 8, 22);

//            WriteLine($"Мінімум з трьох чисел: {minValue}");
//            WriteLine($"Максимум з трьох чисел: {maxValue}");

//            ReadKey();
//        }
//    }
//}

//ex2
//using Lessons11;
//using System;
//using System.Text;
//using static System.Console;

//namespace Lessons11
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            int[] intArray = { 10, 20, 30, 40, 50 };
//            int intSum = MathExtensions.SumArray(intArray);
//            WriteLine($"Сума елементів масиву int: {intSum}");

//            double[] doubleArray = { 1.5, 2.5, 3.0 };
//            double doubleSum = MathExtensions.SumArray(doubleArray);
//            WriteLine($"Сума елементів масиву double: {doubleSum}");

//            ReadKey();
//        }
//    }
//}


//ex3
//using Lessons11;
//using System;
//using System.Text;
//using static System.Console;

//namespace Lessons11
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            Point<double> p1 = new Point<double>(0.0, 0.0);
//            Point<double> p2 = new Point<double>(3.0, 4.0);

//            Line<double> line = new Line<double>(p1, p2);

//            WriteLine(line);
//            WriteLine($"Довжина відрізка: {line.GetLength()}");

//            Point<double> testPoint = new Point<double>(1.5, 2.0);
//            WriteLine($"Точка {testPoint} належить прямій: {line.ContainsPoint(testPoint)}");

//            ReadKey();
//        }
//    }
//}

//ex4
using System;
using System.Text;
using static System.Console;

namespace Lessons11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;

            SeaCreature[] animals = new SeaCreature[]
            {
                new Dolphin("Flipper", 5, "Стрибки через кільце"),
                new Shark("Sharp", 8, 4.5),
                new Dolphin("Aqua", 3, "Сальто назад")
            };

            Oceanarium oceanarium = new Oceanarium(animals);

            WriteLine("Мешканці океанаріуму:");
            foreach (var creature in oceanarium)
            {
                WriteLine(creature);
                creature.MakeSound();
                WriteLine(new string('-', 30));
            }

            ReadKey();
        }
    }
}