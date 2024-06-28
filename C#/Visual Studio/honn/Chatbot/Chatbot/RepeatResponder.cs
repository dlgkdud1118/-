using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot
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
