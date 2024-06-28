using System;
using System.Collections;
using System.Collections.Generic;

namespace Field
{
    class Program
    {
     
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("1番目のリスト");
            list.Add("2番目のリスト");

            string str1 = "3番目のリスト";
            list.Add(str1);

            string str2 = list[1];
            Console.WriteLine(str2);

            foreach (string str in list)
            {
                Console.WriteLine(str);
            }

        }

    }
}