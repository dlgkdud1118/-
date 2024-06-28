using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseDelegate
{
    delegate int Del(int x, int y);
    class Class1
    {
        public int Method1(int x, int y)
        {
            return x + y;
        }
        public int Method2(int x, int y)
        {
            return x - y;
        }
    }
    class Program
    {
        public static void Proc(
            int x, int y, Del proc
        )
        {
            int answer = proc(x, y);
            Console.WriteLine(answer);
        }

        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Proc(500,
                100,
                new Del(obj.Method1)
                );
            Proc(500,
                100,
                new Del(obj.Method2)
                );
        }
    }
}
