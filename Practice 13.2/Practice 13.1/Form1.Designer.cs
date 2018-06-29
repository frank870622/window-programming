namespace Practice_13._1
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
            this.textbox = new System.Windows.Forms.TextBox();
            this.pathTextbox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.readBox = new System.Windows.Forms.TextBox();
            this.writeBinaryButton = new System.Windows.Forms.Button();
            this.readBinaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(94, 12);
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(149, 111);
            this.textbox.TabIndex = 0;
            // 
            // pathTextbox
            // 
            this.pathTextbox.Font = new System.Drawing.Font("新細明體", 12F);
            this.pathTextbox.Location = new System.Drawing.Point(210, 138);
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.Size = new System.Drawing.Size(189, 27);
            this.pathTextbox.TabIndex = 1;
            this.pathTextbox.Text = "..\\..\\..\\text.txt";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.pathLabel.Location = new System.Drawing.Point(91, 141);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(120, 16);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "搬移目的路徑：";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(94, 174);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "建立檔案";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(210, 174);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "存檔";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(324, 174);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(75, 23);
            this.moveButton.TabIndex = 5;
            this.moveButton.Text = "搬移";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // readBox
            // 
            this.readBox.Enabled = false;
            this.readBox.Location = new System.Drawing.Point(250, 12);
            this.readBox.Multiline = true;
            this.readBox.Name = "readBox";
            this.readBox.ReadOnly = true;
            this.readBox.Size = new System.Drawing.Size(149, 111);
            this.readBox.TabIndex = 6;
            // 
            // writeBinaryButton
            // 
            this.writeBinaryButton.Location = new System.Drawing.Point(94, 214);
            this.writeBinaryButton.Name = "writeBinaryButton";
            this.writeBinaryButton.Size = new System.Drawing.Size(149, 23);
            this.writeBinaryButton.TabIndex = 7;
            this.writeBinaryButton.Text = "寫入二進位檔";
            this.writeBinaryButton.UseVisualStyleBackColor = true;
            this.writeBinaryButton.Click += new System.EventHandler(this.writeBinaryButton_Click);
            // 
            // readBinaryButton
            // 
            this.readBinaryButton.Location = new System.Drawing.Point(250, 214);
            this.readBinaryButton.Name = "readBinaryButton";
            this.readBinaryButton.Size = new System.Drawing.Size(149, 23);
            this.readBinaryButton.TabIndex = 8;
            this.readBinaryButton.Text = "從二進位檔讀出";
            this.readBinaryButton.UseVisualStyleBackColor = true;
            this.readBinaryButton.Click += new System.EventHandler(this.readBinaryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 262);
            this.Controls.Add(this.readBinaryButton);
            this.Controls.Add(this.writeBinaryButton);
            this.Controls.Add(this.readBox);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathTextbox);
            this.Controls.Add(this.textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.TextBox pathTextbox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.TextBox readBox;
        private System.Windows.Forms.Button writeBinaryButton;
        private System.Windows.Forms.Button readBinaryButton;
    }
}

