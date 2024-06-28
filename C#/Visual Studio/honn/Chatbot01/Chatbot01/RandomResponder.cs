using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot01
{
    class RandomResponder : Responder
    {
        // ランダム応答用の文字列
        private String[] responses =
        {
            "いい天気だね",
            "ぶっちゃけ、そういうことね",
            "10円拾った",
            "じゃあこれ知ってる?",
            "それいいじゃない",
            "それ可愛い"
        };

        //　サブクラスのコンストラクター
        public RandomResponder(string name) : base(name)
        {
        }

        // Response()メソッドをオーバーライド
        // ランダム応答用のメッセージを作成して返す
        public override string Response(string input)
        {
            // Randomのインスタンス化
            Random rnd = new Random();
            // 配列からメッセージを抽出して戻り値として返す
            return responses[rnd.Next(0, responses.Length)];
        }


    }
}
