using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2024._06._13._01
{
    class Class1
    {
        private static object resource1 = new object();
        private static object resource2 = new object();

        public static void Main()
        {
            Thread ThreadTest =
                new Thread(
                new ThreadStart(MethodTest));
            ThreadTest.Start();

            lock (resource1)
            {
                Console.WriteLine("メインスレッドでresource1をロック");
                Thread.Sleep(2000);

                lock(resource2)
                {
                    Console.WriteLine("メインスレッドでresource2をロック");
                }
            }

            Console.WriteLine("メインスレッドの処理が完了しました。");
        }

        private static void MethodTest()
        {
            System.Threading.Thread.Sleep(1000);

            lock (resource2)
            {
                Console.WriteLine("別スレッドでresouce2をロック");

                lock(resource1)
                {
                    Console.WriteLine("別スレッドでresource2をロック");
                }
            }
            Console.WriteLine("別スレッドの処理が完了しました。");
        }

    }
}
