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

        }
    }
}
