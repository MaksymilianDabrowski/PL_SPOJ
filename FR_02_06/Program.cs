using System;
using System.Collections.Generic;
using System.Globalization;

namespace FR_02_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int powt = Convert.ToInt16(Console.ReadLine());
            List<string> imionaNiedowagi = new List<string>();
            List<string> imionaPrawidlowe = new List<string>();
            List<string> imionaNadwagi = new List<string>();
            string imie;
            float masa, wzrost, BMI;
            for (int i = 0; i < powt; i++)
            {
                var split = Console.ReadLine().Split();
                imie = split[0];
                masa = float.Parse(split[1]);
                wzrost = float.Parse(split[2]);
                wzrost /= 100;

                BMI = masa / (wzrost * wzrost);

                if (BMI < 18.5)
                {
                    imionaNiedowagi.Add(imie);
                }
                else if (BMI >= 18.5 && BMI < 25)
                {
                    imionaPrawidlowe.Add(imie);
                }
                else if (BMI >= 25)
                {
                    imionaNadwagi.Add(imie);
                }
            }
            Console.WriteLine("niedowaga");
            foreach (var imieNiedowaga in imionaNiedowagi)
            {
                Console.WriteLine(imieNiedowaga);
            }
            Console.WriteLine();
            Console.WriteLine("wartosc prawidlowa");
            foreach (var imiePrawidlowe in imionaPrawidlowe)
            {
                Console.WriteLine(imiePrawidlowe);
            }
            Console.WriteLine();
            Console.WriteLine("nadwaga");
            foreach (var imieNadwagi in imionaNadwagi)
            {
                Console.WriteLine(imieNadwagi);
            }
        }
    }
}
