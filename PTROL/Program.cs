using System;
using System.Collections.Generic;

//https://pl.spoj.com/problems/PTROL/
namespace PTROL
{
    // Zadanie rozwiązane z użyciem wbudowanej funkcji Queue => System.Collections.Generic
    internal class Program
    {
        static void Main(string[] args)
        {
            int powt = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < powt; i++)
            {
                Queue<string> kolejka = new Queue<string>(Console.ReadLine().Split()); // utworzenie kolejki i rozdzielenie wierszy
                kolejka.Dequeue(); // pierwszy wyraz wymazany z kolejki => 7, 3
                var liczba = kolejka.Dequeue(); // usunięcie pierwszej liczby z kolejki
                kolejka.Enqueue(liczba); // przypisanie usuniętej liczby ponownie do kolejki, tylko na samym końcu
                foreach (var c in kolejka)
                {
                    Console.WriteLine(c + " "); //wypisanie poszczególnych wyników po kolei, użycie .Write dla pozostawienia w jednej linii
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
