using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chatbot1
{ 

    public partial class Form1 : Form
    {
        // CSharpchanクラスをインスタンス化
        private CSharpchan chan = new CSharpchan("c#ちゃん");
        public Form1()
        {
            InitializeComponent();
        }
        
        // 対話ログをテキストボックスに追加するメソッド
        // str 入力文字または応答メッセージ
        private void PutLog(string str)
        {
            textBox2.AppendText(str + "\n");
        }

        // C#ちゃんのプロンプトを作る関数
        // 戻り値 プロンプト用の文字列
        private string Prompt()
        {
            string p = chan.Name + ":" + chan.GetName();
            return p + "> ";
        }

        // [話す]ボタンのイベントハンドラー
        private void button1_Click(object sender, EventArgs e)
        {
            // テキストボックスに入力された文字列を取得
            string value = textBox1.Text;
            //　未入力の場合の応答
            if (string.IsNullOrEmpty(value))
            {
                label1.Text = "何?";
            }
            // 入力されていたら絶対処理を実行
            else
            {
                //入力文字列を引数にしてDialogue()の結果を取得
                string response = chan.Dialogue(value);
                //　応答メッセージをラベルに表示
                label1.Text = response;
                // 入力文字列を引数にしてPutLog()を実行
                PutLog("> " + value);
                // 応答メッセージを引数にしてPutLog()を実行
                PutLog(Prompt() + response);
                //　テキストボックスをクリア
                textBox1.Clear();
            }

        }
    }
}
