namespace WindowsFormsApp8
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
            this.radioButton_Ａ = new System.Windows.Forms.RadioButton();
            this.radioButton_Ｂ = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_A = new System.Windows.Forms.Button();
            this.button_B = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_Ａ
            // 
            this.radioButton_Ａ.AutoSize = true;
            this.radioButton_Ａ.Location = new System.Drawing.Point(6, 29);
            this.radioButton_Ａ.Name = "radioButton_Ａ";
            this.radioButton_Ａ.Size = new System.Drawing.Size(64, 16);
            this.radioButton_Ａ.TabIndex = 0;
            this.radioButton_Ａ.TabStop = true;
            this.radioButton_Ａ.Text = "Aを選択";
            this.radioButton_Ａ.UseVisualStyleBackColor = true;
            this.radioButton_Ａ.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_Ｂ
            // 
            this.radioButton_Ｂ.AutoSize = true;
            this.radioButton_Ｂ.Location = new System.Drawing.Point(213, 29);
            this.radioButton_Ｂ.Name = "radioButton_Ｂ";
            this.radioButton_Ｂ.Size = new System.Drawing.Size(65, 16);
            this.radioButton_Ｂ.TabIndex = 1;
            this.radioButton_Ｂ.TabStop = true;
            this.radioButton_Ｂ.Text = "Ｂを選択";
            this.radioButton_Ｂ.UseVisualStyleBackColor = true;
            this.radioButton_Ｂ.CheckedChanged += new System.EventHandler(this.radioButton_Ｂ_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Ａ);
            this.groupBox1.Controls.Add(this.radioButton_Ｂ);
            this.groupBox1.Location = new System.Drawing.Point(203, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button_A
            // 
            this.button_A.Location = new System.Drawing.Point(209, 212);
            this.button_A.Name = "button_A";
            this.button_A.Size = new System.Drawing.Size(75, 23);
            this.button_A.TabIndex = 2;
            this.button_A.Text = "Ａボタン";
            this.button_A.UseVisualStyleBackColor = true;
            // 
            // button_B
            // 
            this.button_B.Enabled = false;
            this.button_B.Location = new System.Drawing.Point(424, 212);
            this.button_B.Name = "button_B";
            this.button_B.Size = new System.Drawing.Size(75, 23);
            this.button_B.TabIndex = 3;
            this.button_B.Text = "Ｂボタン";
            this.button_B.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_A);
            this.Controls.Add(this.button_B);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Ａ;
        private System.Windows.Forms.RadioButton radioButton_Ｂ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_A;
        private System.Windows.Forms.Button button_B;
    }
}

