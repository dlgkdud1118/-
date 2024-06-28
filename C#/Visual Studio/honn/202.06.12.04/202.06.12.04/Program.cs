using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _202._06._12._04
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart threadDelegate1 =
                new ThreadStart(DataShow.ThreadTest1);

            Thread thread1 = new Thread(threadDelegate1);
            thread1.Start();

            DataShow obj = new DataShow();
            obj.Data = 2500;

            ThreadStart threadDelegate2 =
                new ThreadStart(obj.ThreadTest2);

            Thread thread2 = new Thread(threadDelegate2);
            thread2.Start();
        }
    }

    class DataShow
    {
        public static void ThreadTest1()
        {
            Console.WriteLine("Staticなスレッドが開始されました。");
        }
        public int Data { get; set; }
        public void ThreadTest2()
        {
            Console.WriteLine("スレッドに渡されたデータは、[{0}]です。", Data);
        }
    }
}
