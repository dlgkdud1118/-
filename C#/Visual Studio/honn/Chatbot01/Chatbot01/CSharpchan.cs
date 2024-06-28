namespace Chatbot01
{
    class CSharpchan
    {
        private string name;
        private RandomResponder res_random;
        private RepeatResponder res_repeat;
        private Responder responder;

        public string Name

        {
            get { return name; }
            set { name = value; }
        }

        // コンストラクター
        public CSharpchan(string name)
        {
            this.name = name;
            res_random = new RandomResponder("Random");

            res_repeat = new RepeatResponder("Repeat");
        }

        // 応対メッセージを返すメソッド
        public string Dialogue(string input)
        {
            System.Random rnd = new System.Random();
            int num = rnd.Next(0, 10);
            if (num < 6)
            {
                this.responder = res_random;
            }
            else
            {
                this.responder = res_repeat;
            }
            //  チョイスしたオブジェクトのResponse()メソッドを実行し
            //  応答メッセジを戻り値として返す
            return this.responder.Response(input);
        }

        //  チョイスしたオブジェクトの名前を返すメソッド
        public string GetName()
        {
            return responder.Name;
        }
    }
}
