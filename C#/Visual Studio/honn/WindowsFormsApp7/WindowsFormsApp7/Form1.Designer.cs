using System.Windows.Forms;

namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRun = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.manuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuRun});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.manuSave});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(71, 20);
            this.menuFile.Text = "ファイル＆F";
            // 
            // menuRun
            // 
            this.menuRun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClose});
            this.menuRun.Name = "menuRun";
            this.menuRun.Size = new System.Drawing.Size(62, 20);
            this.menuRun.Text = "実行＆R";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.menuOpen.Size = new System.Drawing.Size(180, 22);
            this.menuOpen.Text = "開く";
            this.menuOpen.Click += MenuOpen_Click;
            // 
            // manuSave
            // 
            this.manuSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewSave,
            this.menuUpdate});
            this.manuSave.Name = "manuSave";
            this.manuSave.Size = new System.Drawing.Size(180, 22);
            this.manuSave.Text = "保存";
            // 
            // menuNewSave
            // 
            this.menuNewSave.Name = "menuNewSave";
            this.menuNewSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuNewSave.Size = new System.Drawing.Size(193, 22);
            this.menuNewSave.Text = "新規保存";
            this.menuNewSave.Click += MenuNewSave_Click;
            // 
            // menuUpdate
            // 
            this.menuUpdate.Name = "menuUpdate";
            this.menuUpdate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuUpdate.Size = new System.Drawing.Size(193, 22);
            this.menuUpdate.Text = "上書保存";
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(98, 22);
            this.menuClose.Text = "終了";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 310);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MenuClose_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("終了してよろしいですか？", "通知", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)== DialogResult.OK)
            { 
                this.Close();
            }
        }

        private void MenuUpdate_Click(object sender, System.EventArgs e)


        private void MenuSave_Click(object sender, System.EventArgs e)
        {
                MessageBox.Show("保存しました", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void MenuNewSave_Click(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Title = "保存するファイルを指定してください";
            dialog.FileName = "default.txt";
            dialog.InitialDirectory = @"C:\";
            dialog.OverwritePrompt = false;
            dialog.CheckPathExists = false;

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dialog.FileName + "を新規保存しました", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void MenuOpen_Click(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "ファイルを選択して下さい";
            dialog.FileName = "defalut.txt";
            dialog.InitialDirectory = @"C:\";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dialog.FileName + "を開きました。", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return;
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem manuSave;
        private System.Windows.Forms.ToolStripMenuItem menuRun;
        private System.Windows.Forms.ToolStripMenuItem menuNewSave;
        private System.Windows.Forms.ToolStripMenuItem menuUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
    }
}

