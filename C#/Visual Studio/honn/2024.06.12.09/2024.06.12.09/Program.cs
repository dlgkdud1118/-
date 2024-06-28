using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2024._06._12._09
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

            ThreadTest.Join();

            Console.WriteLine("Enterキーを押して下さい。");

            Console.ReadLine();
        }

        private static void MethodTest()
        {
            for (long i = 0; i < 5; i++)
                Console.WriteLine("処理中");

            Console.WriteLine("処理が完了しました。");
        }

    }
}
