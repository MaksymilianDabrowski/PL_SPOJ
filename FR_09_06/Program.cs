using System;
using System.Linq;

//https://pl.spoj.com/problems/PA05_POT/
namespace FR_09_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iterations = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < iterations; i++)
            {
                string input = Console.ReadLine();
                char[] chars = input.ToCharArray();

                var minValue = chars.Min(x => x);
                var maxValue = chars.Max(x => x);

                Console.WriteLine(maxValue - minValue);
            }

            Console.ReadKey();
        }
    }
}
