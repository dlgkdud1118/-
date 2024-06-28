using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ForApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("まものたちが現れた!");

            Console.Write("お名前をどうぞ>>");
            string brave = Console.ReadLine();

            string prompt = brave + "の呪文> ";
            string attack = "";
            int counter = 0;

            //名前が入力されたら以下の処理を実行
            if (!string.IsNullOrEmpty(brave))
            {
                //attackが'ザラキン'でない限り繰り返す
                while (counter < 3)
                {
                    Console.Write(prompt);
                    attack = Console.ReadLine();
                    Console.WriteLine(brave + "は[" + attack + "]の呪文をとなえた！");
                    // attackが'ザラキン'でなければ以下を表示
                    if(attack == "ザラキン")
                    {
                        Console.WriteLine("まものたちは全滅した");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("まものたちは様子をうかがっている");
                    }
                    counter++;
                }
                if(counter == 3)
                {
                    Console.WriteLine("まものたちはどこかへ行ってしまった。。。");
                }
            }
            // 何も入力されなければゲームを終了
            else
            {
                Console.WriteLine("ゲーム終了");
            }

        }


    }
}
