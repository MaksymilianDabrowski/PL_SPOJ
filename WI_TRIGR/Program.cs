using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;

//https://pl.spoj.com/problems/WI_TRIGR/
namespace spoje_praca
{
    internal class Program
    {
        static void Dictionary()
        {
            string input = Console.ReadLine();

            // C# 7.0 Dictionary<TKey,TValue>
            Dictionary<string, string> operators = new Dictionary<string, string>();
            operators.Add("??=", "#");
            operators.Add("??/", "\\");
            operators.Add("??'", "^");
            operators.Add("??(", "[");
            operators.Add("??)", "]");
            operators.Add("??!", "|");
            operators.Add("??<", "}");
            operators.Add("??>", "{");
            operators.Add("??-", "~");

            //for (int i = 0; i < operators; i++)
            //{
            //   string output = operators.Aggregate(input, (old, _new) => old.Replace(_new.Key, _new.Value));
            //Console.WriteLine(output);
            //}
        }
        static void Main(string[] args)
        {
            Dictionary();
        }
    }

}