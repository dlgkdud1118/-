using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using System.IO;
using System.Globalization;

namespace ArrayList_vs_List
{

    abstract class superClass           //  基本クラスを抽象クラスにする
    {
        abstract public void disp();    //  抽象メソッド
    }

    class subClassA : superClass        //  派生クラス
    {
        public override void disp()
        {
            //  実行する
            Console.WriteLine("商品名はPRODUCTです");
        }
    }

    class subClassB : superClass    //  派生クラス
    {
        public override void disp()
        {
            //  実行する
            Console.WriteLine("商品名はMAMUFACTUREです");
        }
    }

    class subClassC : superClass    //  派生クラス
    {
        public override void disp()
        {
            //  実行する
            Console.WriteLine("商品名はGOODSです");
        }
    }

    class Program
    {
        //  派生クラスのdisp()メソッドを順番に呼び出すメソッド
        //  params 修飾子を使ってパラメーター配列にする
        static void Call(params superClass[] args)
        {
            //  配列要素のすべてインスタンスに対してdisp()実行
            foreach(superClass o in args)
            {
                o.disp();
            }
        }

        static void Main(string[] args)
        {
            //  基本クラスと派生クラスのインスタンスを配列に格納
            superClass[] a =
            {
               new superClass(), new subClassA(), new subClassB(), new subClassC()
            };
            //  配列を引数にしてCall()を実行
            Call(a);
        }
    }
}
