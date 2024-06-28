using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2024._06._12._07
{
    class Program
    {
        public static void Main()
        {
            ClassTest obj = new ClassTest();
            obj.Transfer("ABC");

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                Console.Write(" 123 ");
            }
        }
    }

    public class ClassTest
    {
        private string textGet;

        public void Transfer(string strPar)
        {
            textGet = strPar;

            Thread threadTest =
                new Thread(new ThreadStart(ThreadMethod));
            threadTest.Start();
        }

        private void ThreadMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1);
                Console.Write(" {0} ", textGet);
            }
        }
    }
}
