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
            this.components = new System.ComponentModel.Container();
            this.fighterRight = new System.Windows.Forms.Timer(this.components);
            this.fighterLeft = new System.Windows.Forms.Timer(this.components);
            this.fighterUp = new System.Windows.Forms.Timer(this.components);
            this.fighterDown = new System.Windows.Forms.Timer(this.components);
            this.bulletTimer = new System.Windows.Forms.Timer(this.components);
            this.shootTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyTimer = new System.Windows.Forms.Timer(this.components);
            this.interactTimer = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fighterRight
            // 
            this.fighterRight.Interval = 10;
            this.fighterRight.Tick += new System.EventHandler(this.fighterRight_Tick);
            // 
            // fighterLeft
            // 
            this.fighterLeft.Interval = 10;
            this.fighterLeft.Tick += new System.EventHandler(this.fighterLeft_Tick);
            // 
            // fighterUp
            // 
            this.fighterUp.Interval = 10;
            this.fighterUp.Tick += new System.EventHandler(this.fighterUp_Tick);
            // 
            // fighterDown
            // 
            this.fighterDown.Interval = 10;
            this.fighterDown.Tick += new System.EventHandler(this.fighterDown_Tick);
            // 
            // bulletTimer
            // 
            this.bulletTimer.Enabled = true;
            this.bulletTimer.Interval = 5;
            this.bulletTimer.Tick += new System.EventHandler(this.bulletTimer_Tick);
            // 
            // shootTimer
            // 
            this.shootTimer.Interval = 150;
            this.shootTimer.Tick += new System.EventHandler(this.shootTimer_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // enemyTimer
            // 
            this.enemyTimer.Interval = 10;
            this.enemyTimer.Tick += new System.EventHandler(this.enemyTimer_Tick);
            // 
            // interactTimer
            // 
            this.interactTimer.Interval = 10;
            this.interactTimer.Tick += new System.EventHandler(this.interactTimer_Tick);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("新細明體", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.titleLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.titleLabel.Location = new System.Drawing.Point(169, 131);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(229, 67);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "SPACE";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startButton.Location = new System.Drawing.Point(181, 282);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(201, 55);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(181, 379);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(201, 59);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resetButton.Location = new System.Drawing.Point(181, 278);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(201, 59);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.scoreLabel.Location = new System.Drawing.Point(13, 13);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(44, 12);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "score : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 762);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer fighterRight;
        private System.Windows.Forms.Timer fighterLeft;
        private System.Windows.Forms.Timer fighterUp;
        private System.Windows.Forms.Timer fighterDown;
        private System.Windows.Forms.Timer bulletTimer;
        private System.Windows.Forms.Timer shootTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer enemyTimer;
        private System.Windows.Forms.Timer interactTimer;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label scoreLabel;
    }
}

