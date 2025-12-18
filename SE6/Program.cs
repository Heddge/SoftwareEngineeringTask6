using System;

namespace SE6
{
    using System;

    public class Program
    {
        public static bool CheckFerm(int a, int b, int c, int n) =>
            Math.Abs(Math.Pow(a, n) + Math.Pow(b, n) - Math.Pow(c, n)) < 0.0001;

        static void Main()
        {
            Console.WriteLine("Проверяем теорему Ферма:");

            // hello
            // Проверяем разные степени
            for (int a = 1; a <= 5; a++)
                for (int b = 1; b <= 5; b++)
                    for (int c = 1; c <= 5; c++)
                        for (int n = 3; n <= 5; n++)
                        {
                            Console.WriteLine($"{n} {a} {b} {c} {CheckFerm(a, b, c, n)}");
                        }

            Console.WriteLine("\nВывод: равенство работает только для n=2!");
        }
    }
}