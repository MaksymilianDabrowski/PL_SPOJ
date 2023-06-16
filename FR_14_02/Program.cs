using System;

namespace spoje_praca
{
    internal class Program
    {
        static bool CheckIfStoExists(string text)
        {
            return text.Contains("sto");
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stoExists = CheckIfStoExists(input);

            if (stoExists)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }

            Console.ReadKey();
        }
    }
}

//using System;


//namespace spoje_praca
//{
//    internal class Program
//    {
//        static void Sto()
//        {
//            string input = Console.ReadLine();

//            if (input.Contains("sto"))
//            {
//                Console.WriteLine("TAK");
//            }
//            else
//            {
//                Console.WriteLine("NIE");
//            }
//        }

//        static void Main(string[] args)
//        {
//            Sto();
//            Console.ReadKey();
//        }
//    }
//}