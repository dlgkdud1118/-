using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2024._06._12._06
{
    public class List1_1
    {
        public static void Main()
        {
            Thread threadA = new Thread(
                new ThreadStart(ThreadMethod));

            threadA.Start();

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(5);
                Console.Write(" 123 ");
            }
        }

        private static void ThreadMethod()
        {
            for(int i = 0; i < 100; i++)
            {
                Thread.Sleep(5);
                Console.Write(" ABC ");
            }
        }
    }
}
