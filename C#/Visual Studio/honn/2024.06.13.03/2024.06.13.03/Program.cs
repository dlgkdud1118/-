using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._06._13._03
{
    class Program
    {
        public static void Main()
        {
            ClassTest obj = new ClassTest("プログラムの実行中です。");

            System.Threading.ThreadPool.QueueUserWorkItem(
                new System.Threading.WaitCallback(MethodTest),
                obj
            );

            System.Threading.Thread.Sleep(3000);
            Console.WriteLine(obj.Return);
        }

        private static void MethodTest(object parameter1)
        {
            ClassTest objParameter = (ClassTest)parameter1;

            objParameter.Return = "スレッド実行中です。";

            Console.WriteLine(objParameter.Value);
        }
    }

    class ClassTest
    {
        public string Value { get; set; }

        public string Return { get; set; }

        public ClassTest(string str)
        {
            Value = str;
            Return = null;
        }
    }
}
