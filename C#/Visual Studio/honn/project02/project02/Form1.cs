using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("使える金額を入力してね");
            }
            else
            {
                // 入力された金額をint形にする
                int pocket = Convert.ToInt32(textBox1.Text);

                // タイトルの文字列
                string caption = "どっちか選んでね";
                // メッセージボックスに「はい」「いいえ」ボタンを表示
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                // メッセージボックスの結果を取得するための列挙体
                DialogResult result1;
                DialogResult result2;

                // 1つ目の質問
                string message1 = "甘いものがいい？";
                // 2つ目の質問
                string message2 = "カロリーを気にしてる？";

                // 金額が300円に満たない場合は先に結果を表示する
                if (pocket < 300)
                {
                    label2.Text = "チョコドーナツだね";
                }
                // 300円以上ならメッセージボックスを表示して処理を開始
                else
                {
                    // 1つ目のメッセージボックスを表示
                    result1 = MessageBox.Show(
                                              message1, // メッセージ
                                              caption,  // タイトル
                                              buttons   // ボタンを指定
                                              );
                    // 2つ目のメッセージボックスを表示
                    result2 = MessageBox.Show(
                                              message2, // メッセージ
                                              caption,  // タイトル
                                              buttons   // ボタンを指定
                                              );
                    // 甘いものがYesでカロリーもYesである場合
                    if (
                        result1 == DialogResult.Yes &
                        result2 == DialogResult.Yes
                        )
                    {
                        label2.Text = "お豆腐プリンにしましょう";
                    }
                    // 甘いものがYesでカロリーがNoである場合
                    else if (
                            result1 == DialogResult.Yes &
                            result2 == DialogResult.No
                        )
                        {
                            label2.Text = "農厚キャラメルチーズタルトにしましょう";
                        }
                    // 甘いものがNoでカロリーがYesである場合
                    else if (
                            result1 == DialogResult.No &
                            result2 == DialogResult.Yes
                        )
                        {
                            label2.Text = "ダイエットコーラとこんにゃくぜりーにしましょう";
                        }
                    // 甘いものがNoでカロリーもNoである場合
                    else if (pocket >= 300 &
                            result1 == DialogResult.No &
                            result2 == DialogResult.No
                        )
                        {
                            label2.Text = "ウーロン茶とポテチにしましょう";
                        }


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "今日のおやつは？";
        }
    }
}
