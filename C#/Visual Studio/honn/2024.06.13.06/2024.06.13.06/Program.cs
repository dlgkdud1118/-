using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._06._13._06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var a in arrayData)
            {
                Console.WriteLine("serialで順次処理");

                Parallel.ForEach(
                    arrayData,
                    (n) => Console.Write("{0} ", n)
                );
                Console.WriteLine("parallelで並行処理");
            }
        }
    }
}
