using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class FrmSlot : Form
    {
        private String[] img = new String[10];

        public FrmSlot()
        {
            InitializeComponent();

            lblMsg.Visible = false;

            btnStop1.Enabled = false;
            btnStop2.Enabled = false;
            btnStop3.Enabled = false;

            img[0] = @"C:\\Users\\3030897\\Pictures\\image01.jpg";
            img[1] = @"C:\\Users\\3030897\\Pictures\\image02.jpg";
            img[2] = @"C:\\Users\\3030897\\Pictures\\image03.jpg";
            img[3] = @"C:\\Users\\3030897\\Pictures\\image04.jpg";
            img[4] = @"C:\\Users\\3030897\\Pictures\\image05.jpg";
            img[5] = @"C:\\Users\\3030897\\Pictures\\image06.jpg";
            img[6] = @"C:\\Users\\3030897\\Pictures\\image07.jpg";
            img[7] = @"C:\\Users\\3030897\\Pictures\\image08.jpg";
            img[8] = @"C:\\Users\\3030897\\Pictures\\image09.jpg";
            img[9] = @"C:\\Users\\3030897\\Pictures\\image10.jpg";
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = false;

            btnStart.Enabled = false;

            btnStop1.Enabled = true;
            btnStop2.Enabled = true;
            btnStop3.Enabled = true;

            Random r = new Random();
            int index = 0;

            while(true)
            {
                if (btnStop1.Enabled == false &&
                   btnStop2.Enabled == false &&
                   btnStop3.Enabled == false)
                    {
                        if (pb1.ImageLocation == pb2.ImageLocation &&
                           pb2.ImageLocation == pb3.ImageLocation)
                            {
                                lblMsg.Visible = true;
                                lblMsg.Text = "あたり";
                            }
                        else
                            {
                                lblMsg.Visible = true;
                                lblMsg.Text = "外れ";
                            }

                        btnStart.Enabled = true;
                        break;
                    }

                if (btnStop1.Enabled)
                    {
                        index = r.Next(10);
                        pb1.ImageLocation = img[index];
                    }
                if (btnStop2.Enabled)
                    {
                        index = r.Next(10);
                        pb2.ImageLocation = img[index];
                    }
                if(btnStop3.Enabled)
                    {
                        index = r.Next(10);
                        pb3.ImageLocation = img[index];
                    }

                await Task.Delay(100);
                

                
                
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
        }
    }
}
