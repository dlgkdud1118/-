using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot1
{
    class Responder
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value;  }
        }

        // コンストラクター
        // オブジェクト名を受け取ってnameフィールドにセット
        public Responder(string name)
        {
            this.name = name;
        }

        // オーバーライドを前提にしたメソッド
        // 応答メッセージを作成して戻り値として返す
        public virtual string Response(string input)
        {
            return "";
        }

    }
}
