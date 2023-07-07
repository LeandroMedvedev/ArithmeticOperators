using System;

namespace ArithmeticOperators
{
    class Program
    {
        #pragma warning disable IDE0060
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            Console.WriteLine($"n1: {n1}");    // 11

            int n2 = (3 + 4) * 2;
            Console.WriteLine($"n2: {n2}");    // 14

            int n3 = 17 % 3;  // mod operator
            Console.WriteLine($"n3: {n3}");    // 2

            int n4 = 10 / 8;
            double _n4 = 10 / 8;  // divisão de ints, ainda que atribuída a double, resultado int
            double n4_ = (double) 10 / 8;  // necessário CAST ou pôr 10.0, indicando número decimal
            double n_4 = 10.0 / 8;  // 10.0 / 8.0

            Console.WriteLine($"n4: {n4}");    // 1
            Console.WriteLine($"_n4: {_n4}");  // 1
            Console.WriteLine($"n4_: {n4_}");  // 1,25
            Console.WriteLine($"n_4: {n_4}");  // 1,25

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) -4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine($"delta: {delta}");
            Console.WriteLine($"x1: {x1}");
            Console.WriteLine($"x2: {x2}");
        }
    }
}
