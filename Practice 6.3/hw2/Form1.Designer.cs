namespace hw2
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
            this.loginButton = new System.Windows.Forms.Button();
            this.loginName = new System.Windows.Forms.Label();
            this.loginPassward = new System.Windows.Forms.Label();
            this.loginNameBox = new System.Windows.Forms.TextBox();
            this.loginPasswordBox = new System.Windows.Forms.TextBox();
            this.added = new System.Windows.Forms.Button();
            this.inquire = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.genderBox = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.checkdelete = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.checkLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(359, 345);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "登入";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginName
            // 
            this.loginName.AutoSize = true;
            this.loginName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginName.Location = new System.Drawing.Point(281, 262);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(59, 26);
            this.loginName.TabIndex = 1;
            this.loginName.Text = "帳號:";
            // 
            // loginPassward
            // 
            this.loginPassward.AutoSize = true;
            this.loginPassward.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginPassward.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginPassward.Location = new System.Drawing.Point(281, 301);
            this.loginPassward.Name = "loginPassward";
            this.loginPassward.Size = new System.Drawing.Size(59, 26);
            this.loginPassward.TabIndex = 2;
            this.loginPassward.Text = "密碼:";
            // 
            // loginNameBox
            // 
            this.loginNameBox.Location = new System.Drawing.Point(359, 265);
            this.loginNameBox.Name = "loginNameBox";
            this.loginNameBox.Size = new System.Drawing.Size(100, 22);
            this.loginNameBox.TabIndex = 3;
            // 
            // loginPasswordBox
            // 
            this.loginPasswordBox.Location = new System.Drawing.Point(359, 301);
            this.loginPasswordBox.Name = "loginPasswordBox";
            this.loginPasswordBox.Size = new System.Drawing.Size(100, 22);
            this.loginPasswordBox.TabIndex = 4;
            // 
            // added
            // 
            this.added.Location = new System.Drawing.Point(616, 25);
            this.added.Name = "added";
            this.added.Size = new System.Drawing.Size(96, 30);
            this.added.TabIndex = 5;
            this.added.Text = "新增";
            this.added.UseVisualStyleBackColor = true;
            this.added.Visible = false;
            this.added.Click += new System.EventHandler(this.added_Click);
            // 
            // inquire
            // 
            this.inquire.Location = new System.Drawing.Point(616, 83);
            this.inquire.Name = "inquire";
            this.inquire.Size = new System.Drawing.Size(96, 30);
            this.inquire.TabIndex = 6;
            this.inquire.Text = "查詢";
            this.inquire.UseVisualStyleBackColor = true;
            this.inquire.Visible = false;
            this.inquire.Click += new System.EventHandler(this.inquire_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(616, 196);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(96, 30);
            this.logout.TabIndex = 7;
            this.logout.Text = "登出";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Visible = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(616, 142);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(96, 30);
            this.delete.TabIndex = 8;
            this.delete.Text = "刪除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 9;
            this.label1.Visible = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ID.Location = new System.Drawing.Point(215, 29);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(117, 26);
            this.ID.TabIndex = 10;
            this.ID.Text = "身分證字號";
            this.ID.Visible = false;
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.location.ForeColor = System.Drawing.SystemColors.Highlight;
            this.location.Location = new System.Drawing.Point(278, 180);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(54, 26);
            this.location.TabIndex = 11;
            this.location.Text = "地址";
            this.location.Visible = false;
            this.location.Click += new System.EventHandler(this.label4_Click);
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.phone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.phone.Location = new System.Drawing.Point(278, 131);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(54, 26);
            this.phone.TabIndex = 12;
            this.phone.Text = "電話";
            this.phone.Visible = false;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gender.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gender.Location = new System.Drawing.Point(278, 81);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(54, 26);
            this.gender.TabIndex = 13;
            this.gender.Text = "性別";
            this.gender.Visible = false;
            this.gender.Click += new System.EventHandler(this.label6_Click);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(356, 29);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 22);
            this.IDBox.TabIndex = 14;
            this.IDBox.Visible = false;
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(356, 180);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(100, 22);
            this.locationBox.TabIndex = 15;
            this.locationBox.Visible = false;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(356, 131);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 22);
            this.phoneBox.TabIndex = 16;
            this.phoneBox.Visible = false;
            // 
            // genderBox
            // 
            this.genderBox.Location = new System.Drawing.Point(356, 81);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(100, 22);
            this.genderBox.TabIndex = 17;
            this.genderBox.Visible = false;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(488, 196);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(96, 30);
            this.check.TabIndex = 18;
            this.check.Text = "確認";
            this.check.UseVisualStyleBackColor = true;
            this.check.Visible = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(488, 25);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(96, 30);
            this.search.TabIndex = 19;
            this.search.Text = "搜尋";
            this.search.UseVisualStyleBackColor = true;
            this.search.Visible = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // checkdelete
            // 
            this.checkdelete.Location = new System.Drawing.Point(488, 83);
            this.checkdelete.Name = "checkdelete";
            this.checkdelete.Size = new System.Drawing.Size(96, 30);
            this.checkdelete.TabIndex = 20;
            this.checkdelete.Text = "確認刪除";
            this.checkdelete.UseVisualStyleBackColor = true;
            this.checkdelete.Visible = false;
            this.checkdelete.Click += new System.EventHandler(this.checkdelete_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(219, 64);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(60, 12);
            this.IDLabel.TabIndex = 21;
            this.IDLabel.Text = "errorLabel1";
            this.IDLabel.Visible = false;
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.Location = new System.Drawing.Point(486, 245);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(33, 12);
            this.checkLabel.TabIndex = 22;
            this.checkLabel.Text = "label8";
            this.checkLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 395);
            this.Controls.Add(this.checkLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.checkdelete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.check);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.location);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.inquire);
            this.Controls.Add(this.added);
            this.Controls.Add(this.loginPasswordBox);
            this.Controls.Add(this.loginNameBox);
            this.Controls.Add(this.loginPassward);
            this.Controls.Add(this.loginName);
            this.Controls.Add(this.loginButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label loginName;
        private System.Windows.Forms.Label loginPassward;
        private System.Windows.Forms.TextBox loginNameBox;
        private System.Windows.Forms.TextBox loginPasswordBox;
        private System.Windows.Forms.Button added;
        private System.Windows.Forms.Button inquire;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox genderBox;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button checkdelete;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label checkLabel;
    }
}

