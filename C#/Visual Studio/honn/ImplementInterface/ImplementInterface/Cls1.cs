using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementInterface
{
    class Cls1 : SuperCls
    {
        public override void Multiplier(int n)
        {
            Val = n * 2; // パラメーターの値を2倍する
            MessageBox.Show("処理結果は" + Val);
        }
        public override void Divider(int n)
        {
            Val = n / 2;
            MessageBox.Show("処理結果は" + Val);
        }
    }
}
