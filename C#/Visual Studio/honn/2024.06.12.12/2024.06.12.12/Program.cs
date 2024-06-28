using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2024._06._12._12
{
    class Program
    {
        private int counter = 0;
        static void Main()
        {
            Program obj = new Program();

            Thread Thread1 = new Thread(
                        new ThreadStart(obj.MethodTest));
            Thread1.Name = "スレッド1";

            Thread Thread2 = new Thread(
                new ThreadStart(obj.MethodTest));
            Thread2.Name = "スレッド2";

            Thread1.Start();
            Thread2.Start();
        }

        public void MethodTest()
        {
            string name = Thread.CurrentThread.Name;

            Monitor.Enter(this);

            try
            {
                while (counter < 3)
                {
                    Thread.Sleep(1000);

                    counter++;

                    Console.WriteLine(name);

                    Console.WriteLine(counter);
                }
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
    }
}
