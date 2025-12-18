using System;

namespace SE6
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Проверяем теорему Ферма:");

            // Проверяем разные степени
            for (int n = 2; n <= 5; n++)
            {
                Console.WriteLine($"\nДля степени n={n}:");
                Console.WriteLine($"3^{n} + 4^{n} = 5^{n} ?");

                double left = Math.Pow(3, n) + Math.Pow(4, n);
                double right = Math.Pow(5, n);

                Console.WriteLine($"{Math.Pow(3, n)} + {Math.Pow(4, n)} = {left}");
                Console.WriteLine($"{Math.Pow(3, n) + Math.Pow(4,n)} и {right}");
                Console.WriteLine($"Равны? {Math.Abs(left - right) < 0.0001}");
            }

            Console.WriteLine("\nВывод: равенство работает только для n=2!");
        }
    }
}