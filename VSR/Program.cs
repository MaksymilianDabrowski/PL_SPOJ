using System;

//https://pl.spoj.com/problems/VSR/
namespace VSR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int powt = int.Parse(Console.ReadLine());
            int wynik = 0;
            for (int i = 0; i < powt; i++)
            {
                var split = Console.ReadLine().Split(); //output w jednej linijce
                var v1 = int.Parse(split[0]);
                var v2 = int.Parse(split[1]);
                wynik = ((2 * v1 * v2) / (v1 + v2));
                Console.WriteLine(wynik);
            }
        }
    }
}
