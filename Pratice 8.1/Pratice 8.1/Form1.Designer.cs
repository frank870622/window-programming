namespace Pratice_8._1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lotteryBox = new System.Windows.Forms.CheckedListBox();
            this.lotteryLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Big Lotto-Please select six numbers";
            // 
            // lotteryBox
            // 
            this.lotteryBox.CheckOnClick = true;
            this.lotteryBox.ColumnWidth = 50;
            this.lotteryBox.FormattingEnabled = true;
            this.lotteryBox.Location = new System.Drawing.Point(47, 42);
            this.lotteryBox.MultiColumn = true;
            this.lotteryBox.Name = "lotteryBox";
            this.lotteryBox.Size = new System.Drawing.Size(313, 123);
            this.lotteryBox.TabIndex = 1;
            // 
            // lotteryLabel
            // 
            this.lotteryLabel.Location = new System.Drawing.Point(45, 168);
            this.lotteryLabel.Name = "lotteryLabel";
            this.lotteryLabel.Size = new System.Drawing.Size(315, 77);
            this.lotteryLabel.TabIndex = 2;
            this.lotteryLabel.Text = "not drawing the winning numbers of lottery in current period";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "check the numbers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 323);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lotteryLabel);
            this.Controls.Add(this.lotteryBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox lotteryBox;
        private System.Windows.Forms.Label lotteryLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

