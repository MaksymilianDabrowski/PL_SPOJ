using System;

//https://pl.spoj.com/problems/KC001/
namespace spoje_praca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba = Convert.ToInt16(Console.ReadLine());
            int liczba1 = Convert.ToInt16(Console.ReadLine());
            int liczba2 = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine(liczba + liczba1 + liczba2);
            Console.ReadKey();
        }
    }
}