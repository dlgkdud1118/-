using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2024._06._13._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                Action,
                () =>
                    {
                        Console.WriteLine("MethodB, Thread={0}",
                            Thread.CurrentThread.ManagedThreadId);
                    },
                delegate ()
                    {
                        Console.WriteLine("MethodC, Thread={0}",
                            Thread.CurrentThread.ManagedThreadId);
                    });
        }
        static void Action()
        {
                Console.WriteLine("MethodA, Thread={0}",
                    Thread.CurrentThread.ManagedThreadId);    
        }
        
    }
}
