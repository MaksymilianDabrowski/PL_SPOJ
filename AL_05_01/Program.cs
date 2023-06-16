using System;

namespace AL_05_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    return;
                }

                if (input == "0")
                {
                    Console.WriteLine("0");
                    continue;
                }

                ulong value = Convert.ToUInt64(input);
                string binary = Convert.ToString((long)value, 2);

                char[] chars = binary.ToCharArray();
                Array.Reverse(chars);
                string reversedBinary = new string(chars);

                ulong reversedDecimal = Convert.ToUInt64(reversedBinary, 2);

                Console.WriteLine(reversedDecimal);
            }
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace AL_05_01
//{
//    internal class Program
//    {
//        static void Convertion()
//        {
//            //int n = Convert.ToInt32(Console.ReadLine());
//            ////int divisor = 2;
//            //int[] binaryNum = new int[32];

//            //int i = 0;
//            //while (n > 0)
//            //{

//            //    binaryNum[i] = n % 2;
//            //    n = n / 2;
//            //    i++;
//            //}

//            //for (int j = i + 1; j >= 0; j--)
//            //{
//            //    Console.Write(binaryNum[j]);
//            //}

//            //from dec to bin
//            ulong value = Convert.ToUInt64(Console.ReadLine());
//            string binary = Convert.ToString((long)value, 2);

//            //char[] chars = binary.ToCharArray();
//            //Array.Reverse(chars);
//            //string reversedBinary = new string(chars);

//            string reversedBinary = string.Empty;
//            for (int i = binary.Length - 1; i >= 0; i--)
//            {
//                reversedBinary += binary[i];
//            }

//            //Console.WriteLine(reversedBinary);

//            ulong reversedDecimal = Convert.ToUInt64(reversedBinary, 2);

//            Console.WriteLine(reversedDecimal);


//        }

//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Convertion();
//            }
//        }
//    }
//}
