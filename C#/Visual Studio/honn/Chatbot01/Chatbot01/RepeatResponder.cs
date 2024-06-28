
using System;

namespace Chatbot01
{
    class RepeatResponder : Responder
    {
        // サブクラスのコンストラクター
        public RepeatResponder(string name) : base(name)
        {
        }

        // Response()メソッドをオーバーライド
        // オウム返しのメッセージを作成して返す
        public override string Response(string input)
        {
            return String.Format("{0}って何?", input);
        }
    }
}
