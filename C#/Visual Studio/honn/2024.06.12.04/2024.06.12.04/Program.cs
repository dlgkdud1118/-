using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2024._06._12._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Program.ThreadTest1);
            thread1.Start(5000);

            Program obj = new Program();

            Thread thread2 = new Thread(obj.ThreadTest2);

            thread2.Start("スレッド実行中");
        }

        public static void ThreadTest1(object data)
        {
            Console.WriteLine(
                "スレッドに渡されたデータは,[{0}]です。",
                data
                );
        }

        public void ThreadTest2(object data)
        {
            Console.WriteLine(
                "スレッドに渡されたデータは、[{0}]です。",
                data
                );
        }
    }
}
