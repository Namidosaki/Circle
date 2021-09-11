using System;
using FindingInCircle;

namespace ConsoleApp
{
    static class Program
    {
        private static IInCircleService service;

        static Program()
        {
            service = new InCircleService();
        }

        static void Main(string[] args)
        {
            int x, y, r, d, o;
            Console.WriteLine("Введите координаты центра окружности:");
            Console.Write("По X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("По Y:"); 
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите радиус окружности:");
            Console.Write("R:");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты точки:");
            Console.Write("По X:");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("По Y:");
            o = Convert.ToInt32(Console.ReadLine());

            if ( service.Affiliation(x, y, r, d, o))
                Console.WriteLine($"Точка {d},{o} входит в окружность с центром {x},{y} и радиусом {r}.");
            else Console.WriteLine($"Точка {d},{o} НЕ входит в окружность с центром {x},{y} и радиусом {r}.");

            Console.ReadKey();
        }
    }
}
