using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2024._06._12._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("スレッドの処理を開始します。");

            obj.ThreadTest();
        }

        public void ThreadTest()
        {
            Thread thread1 = new Thread(
                        new ThreadStart(CountUp));

            Thread thread2 = new Thread(
                        new ThreadStart(CountDown));
            thread1.Start();
            thread2.Start();
        }

        public void CountUp()
        {
            for (int i = 0; i <= 10; i++)
                Console.WriteLine(
                    "CountUp: {0}", i);
        }

        public void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(
                    "CountDown: {0}", i);
            }
        }
    }
}
