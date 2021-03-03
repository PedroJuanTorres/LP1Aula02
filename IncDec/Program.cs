using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 5;
            int c = a++;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
        }
    }
}
