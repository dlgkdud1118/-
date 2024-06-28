using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2024._06._12._10
{
    class Program
    {
        public static void Main()
        {
            Thread ThreadTest =
                new Thread(new ThreadStart(MethodTest));

            ThreadTest.Start();

            Thread.Sleep(1000);

            Console.WriteLine("スレッドを破棄します。");

            ThreadTest.Abort();

            ThreadTest.Join();

            Console.WriteLine("指定したスレッドが破棄されました。"); 
        }

        static void MethodTest()
        {
            Console.WriteLine("新規のスレッドを実行中です。");
            Thread.Sleep(1000);
        }
    }
}
