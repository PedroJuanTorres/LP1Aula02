using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string heightStr, radiusStr;
            float height, radius;
            float vol, supArea;

            // Ask the user for height 
            Console.Write("Input height: ");
            heightStr = Console.ReadLine();

            // Ask the user for radios
            Console.Write("Input radius: ");
            radiusStr = Console.ReadLine();

            // Convert height string to float
            height = float.Parse(heightStr);

            // Convert radios string to float
            radius = float.Parse(radiusStr);

            // Calculate Volume
            vol = (float)Math.PI * (float)Math.Pow(radius) * height;

            // Calculate superficial area
            supArea = 2 * (float)Math.Pi *  radius * (radius + height);

            // Show volume
            Console.WriteLine($"Volume is {vol:f2}");
            
            //Show superficial area
            Console.WriteLine("Sup. area is {0:f2}",supArea);

        }
    }
}
