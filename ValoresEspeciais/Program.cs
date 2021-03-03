using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int max = {int.MaxValue}");
            Console.WriteLine($"int min = {int.MinValue}");
            Console.WriteLine($"double max = {double.MaxValue}");
            Console.WriteLine($"double min = {double.MaxValue}");
            Console.WriteLine($"byte max = {byte.MaxValue}");
            Console.WriteLine($"byte min = {byte.MaxValue}");

            Console.WriteLine($"double +infinity = {double.PositiveInfinity}");
            Console.WriteLine($"double -infinity = {double.NegativeInfinity}");
            Console.WriteLine($"double NaN = {double.NaN}");

            byte b = byte.MaxValue;
            Console.WriteLine($"byte max = {b}");
            b++;
            Console.WriteLine($"byte max + 1= {b}");

            short s = byte.MinValue;
            Console.WriteLine($"short min = {s}");
            s--;
            Console.WriteLine($"short min - 1= {s}");

            float f1;
            f1 = 10000f;
            f1 += 0.0001f;
            Console.WriteLine($"f1 = {f1}");

            double d1;
            d1 = 10000f;
            d1 += 0.0001f;
            Console.WriteLine($"d1 = {d1}");

        }
    }
}
