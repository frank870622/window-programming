namespace Practice_7._2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pageLogin = new System.Windows.Forms.TabPage();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwardBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pageControl = new System.Windows.Forms.TabControl();
            this.pageEnglish = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pageChinese = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pageLogin.SuspendLayout();
            this.pageControl.SuspendLayout();
            this.pageEnglish.SuspendLayout();
            this.pageChinese.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageLogin
            // 
            this.pageLogin.Controls.Add(this.loginButton);
            this.pageLogin.Controls.Add(this.passwardBox);
            this.pageLogin.Controls.Add(this.nameBox);
            this.pageLogin.Controls.Add(this.label2);
            this.pageLogin.Controls.Add(this.label1);
            this.pageLogin.Location = new System.Drawing.Point(4, 22);
            this.pageLogin.Name = "pageLogin";
            this.pageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.pageLogin.Size = new System.Drawing.Size(252, 212);
            this.pageLogin.TabIndex = 0;
            this.pageLogin.Text = "輸入資料";
            this.pageLogin.UseVisualStyleBackColor = true;
            this.pageLogin.Click += new System.EventHandler(this.pageLogin_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(75, 162);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwardBox
            // 
            this.passwardBox.Location = new System.Drawing.Point(120, 100);
            this.passwardBox.Name = "passwardBox";
            this.passwardBox.Size = new System.Drawing.Size(100, 22);
            this.passwardBox.TabIndex = 3;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(120, 42);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 2;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 22F);
            this.label2.Location = new System.Drawing.Point(11, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "密碼：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號：";
            // 
            // pageControl
            // 
            this.pageControl.Controls.Add(this.pageLogin);
            this.pageControl.Controls.Add(this.pageEnglish);
            this.pageControl.Controls.Add(this.pageChinese);
            this.pageControl.Location = new System.Drawing.Point(12, 12);
            this.pageControl.Name = "pageControl";
            this.pageControl.SelectedIndex = 0;
            this.pageControl.Size = new System.Drawing.Size(260, 238);
            this.pageControl.TabIndex = 0;
            // 
            // pageEnglish
            // 
            this.pageEnglish.Controls.Add(this.label5);
            this.pageEnglish.Controls.Add(this.label4);
            this.pageEnglish.Controls.Add(this.label3);
            this.pageEnglish.Location = new System.Drawing.Point(4, 22);
            this.pageEnglish.Name = "pageEnglish";
            this.pageEnglish.Padding = new System.Windows.Forms.Padding(3);
            this.pageEnglish.Size = new System.Drawing.Size(252, 212);
            this.pageEnglish.TabIndex = 1;
            this.pageEnglish.Text = "英文";
            this.pageEnglish.UseVisualStyleBackColor = true;
            this.pageEnglish.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 16F);
            this.label5.Location = new System.Drawing.Point(38, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "全班人數： 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16F);
            this.label4.Location = new System.Drawing.Point(38, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "全班平均： 86.4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16F);
            this.label3.Location = new System.Drawing.Point(38, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "你的分數： 80";
            // 
            // pageChinese
            // 
            this.pageChinese.Controls.Add(this.label6);
            this.pageChinese.Controls.Add(this.label7);
            this.pageChinese.Controls.Add(this.label8);
            this.pageChinese.Location = new System.Drawing.Point(4, 22);
            this.pageChinese.Name = "pageChinese";
            this.pageChinese.Padding = new System.Windows.Forms.Padding(3);
            this.pageChinese.Size = new System.Drawing.Size(252, 212);
            this.pageChinese.TabIndex = 2;
            this.pageChinese.Text = "國文";
            this.pageChinese.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 16F);
            this.label6.Location = new System.Drawing.Point(46, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "全班人數： 5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 16F);
            this.label7.Location = new System.Drawing.Point(46, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "全班平均： 98";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 16F);
            this.label8.Location = new System.Drawing.Point(46, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "你的分數： 77.6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pageControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pageLogin.ResumeLayout(false);
            this.pageLogin.PerformLayout();
            this.pageControl.ResumeLayout(false);
            this.pageEnglish.ResumeLayout(false);
            this.pageEnglish.PerformLayout();
            this.pageChinese.ResumeLayout(false);
            this.pageChinese.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage pageLogin;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwardBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl pageControl;
        private System.Windows.Forms.TabPage pageEnglish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage pageChinese;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

