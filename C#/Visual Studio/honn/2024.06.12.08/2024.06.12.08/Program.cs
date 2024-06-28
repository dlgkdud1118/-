using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2024._06._12._08
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("処理を開始しました。");

            Thread ThreadTest = new Thread(
                new ThreadStart(MethodTest));

            ThreadTest.IsBackground = true;

            ThreadTest.Start();

            Console.WriteLine("Enterキーを押して下さい。");

            Console.ReadLine();
        }

        private static void MethodTest()
        {
            for (int i = 0; i < 100000; i++)
            Console.WriteLine("処理中です");
            Console.WriteLine("処理が完了しました。");   
        }
    }
}
