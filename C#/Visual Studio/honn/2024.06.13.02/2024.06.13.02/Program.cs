using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2024._06._13._02
{
    class Class1
    {
        public static void Main()
        {
            Console.WriteLine("Main()メソッドのスレッドを開始します。");

            ThreadPool.QueueUserWorkItem(
                new WaitCallback(MethodTest));

            Console.WriteLine("Enterキーで終了します。");
            Console.ReadLine();
        }

        private static void MethodTest(object obj)
        {
            Thread.Sleep(5000);
            Console.WriteLine("別スレッドの処理が完了しました。");
        }
    }
}
