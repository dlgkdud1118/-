using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._06._13._04
{
    class Program
    {
        private delegate int Del(string msg, int sleepTime);

        public static void Main()
        {
            Del asyDel = new Del(MethodTest);

            Console.WriteLine("非同期の処理を開始します。");

            IAsyncResult ar =
                asyDel.BeginInvoke(
                    "VisualC#",
                    3000,
                    null,
                    null);

            Console.WriteLine("非同期で実行されているので別の処理が行えます。");

            int result = asyDel.EndInvoke(ar);
            Console.WriteLine("渡された文字の数は{0}です。", result);
        }

        private static int MethodTest(string msg, int sleepTime)
        {
            System.Threading.Thread.Sleep(sleepTime);
            Console.WriteLine("非同期スレッドで取得した値;" + msg);
            return msg.Length;
        }
    }
}
