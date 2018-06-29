namespace Pratice_11._2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showA = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textA = new System.Windows.Forms.TextBox();
            this.sendA = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.font = new System.Windows.Forms.ToolStripMenuItem();
            this.列印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printformA = new System.Windows.Forms.ToolStripMenuItem();
            this.printshowA = new System.Windows.Forms.ToolStripMenuItem();
            this.printA = new System.Windows.Forms.ToolStripMenuItem();
            this.exitA = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showA
            // 
            this.showA.Enabled = false;
            this.showA.Location = new System.Drawing.Point(0, 27);
            this.showA.Multiline = true;
            this.showA.Name = "showA";
            this.showA.Size = new System.Drawing.Size(286, 192);
            this.showA.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(0, 225);
            this.textA.Multiline = true;
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(212, 33);
            this.textA.TabIndex = 2;
            // 
            // sendA
            // 
            this.sendA.Location = new System.Drawing.Point(218, 225);
            this.sendA.Name = "sendA";
            this.sendA.Size = new System.Drawing.Size(61, 33);
            this.sendA.TabIndex = 3;
            this.sendA.Text = "傳送";
            this.sendA.UseVisualStyleBackColor = true;
            this.sendA.Click += new System.EventHandler(this.sendA_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.font,
            this.列印ToolStripMenuItem,
            this.exitA});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // font
            // 
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(44, 20);
            this.font.Text = "字形";
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // 列印ToolStripMenuItem
            // 
            this.列印ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printformA,
            this.printshowA,
            this.printA});
            this.列印ToolStripMenuItem.Name = "列印ToolStripMenuItem";
            this.列印ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.列印ToolStripMenuItem.Text = "列印";
            // 
            // printformA
            // 
            this.printformA.Name = "printformA";
            this.printformA.Size = new System.Drawing.Size(152, 22);
            this.printformA.Text = "列印格式";
            this.printformA.Click += new System.EventHandler(this.printformA_Click);
            // 
            // printshowA
            // 
            this.printshowA.Name = "printshowA";
            this.printshowA.Size = new System.Drawing.Size(152, 22);
            this.printshowA.Text = "預覽列印";
            this.printshowA.Click += new System.EventHandler(this.printshowA_Click);
            // 
            // printA
            // 
            this.printA.Name = "printA";
            this.printA.Size = new System.Drawing.Size(152, 22);
            this.printA.Text = "列印";
            this.printA.Click += new System.EventHandler(this.printA_Click);
            // 
            // exitA
            // 
            this.exitA.Name = "exitA";
            this.exitA.Size = new System.Drawing.Size(44, 20);
            this.exitA.Text = "結束";
            this.exitA.Click += new System.EventHandler(this.exitA_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.sendA);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.showA);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox showA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.Button sendA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem font;
        private System.Windows.Forms.ToolStripMenuItem 列印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitA;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem printformA;
        private System.Windows.Forms.ToolStripMenuItem printshowA;
        private System.Windows.Forms.ToolStripMenuItem printA;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

