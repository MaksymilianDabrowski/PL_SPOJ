using System;

//https://pl.spoj.com/problems/POTSAM/
namespace spoje_praca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            var n1 = int.Parse(s[0]);
            var k1 = int.Parse(s[1]);
            var n2 = int.Parse(s[2]);
            var k2 = int.Parse(s[3]);

            Console.WriteLine(n1 * k1 + n2 * k2);
            Console.ReadKey();
        }
    }
}