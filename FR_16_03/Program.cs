using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

//https://pl.spoj.com/problems/FR_16_03/
namespace FR_16_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string snake = Console.ReadLine();
            //string camel = snake.Replace("_", "").ToUpper();

            while (snake.IndexOf("_") != -1)
            {
                int camel = snake.IndexOf("_");
                List<char> chars = snake.ToList();
                chars.RemoveAt(camel);
                chars[camel] = Convert.ToChar(chars[camel].ToString().ToUpper());

                string snake2 = "";
                foreach (char letter in chars)
                {
                    snake2 += letter;
                }
                snake = snake2;


            }


            Console.WriteLine(snake);
        }
    }
}
