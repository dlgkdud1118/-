using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace rennsyuu
{
            interface ISample
            {
                void Show();    //抽象メソッド
            }

            class SampleCls : ISample
            {
                public void Show()  //抽象メソッドのオーバーライド
                {
                Console.WriteLine("SampleClsのShowメソッドです");  // 実行
                }
            }

        class Program
        {
            static void Main(string[] args)
            {
                SampleCls sc = new SampleCls();
                sc.Show();
            }
        }
        
    
}
