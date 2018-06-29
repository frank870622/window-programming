namespace Pratice_11._2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.sendB = new System.Windows.Forms.Button();
            this.textB = new System.Windows.Forms.TextBox();
            this.showB = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.font = new System.Windows.Forms.ToolStripMenuItem();
            this.列印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitB = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.printformB = new System.Windows.Forms.ToolStripMenuItem();
            this.printshowB = new System.Windows.Forms.ToolStripMenuItem();
            this.printB = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog2 = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendB
            // 
            this.sendB.Location = new System.Drawing.Point(217, 227);
            this.sendB.Name = "sendB";
            this.sendB.Size = new System.Drawing.Size(61, 33);
            this.sendB.TabIndex = 6;
            this.sendB.Text = "傳送";
            this.sendB.UseVisualStyleBackColor = true;
            this.sendB.Click += new System.EventHandler(this.sendB_Click);
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(-1, 227);
            this.textB.Multiline = true;
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(212, 33);
            this.textB.TabIndex = 5;
            // 
            // showB
            // 
            this.showB.Enabled = false;
            this.showB.Location = new System.Drawing.Point(-1, 27);
            this.showB.Multiline = true;
            this.showB.Name = "showB";
            this.showB.Size = new System.Drawing.Size(286, 194);
            this.showB.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.font,
            this.列印ToolStripMenuItem,
            this.exitB});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 7;
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
            this.printformB,
            this.printshowB,
            this.printB});
            this.列印ToolStripMenuItem.Name = "列印ToolStripMenuItem";
            this.列印ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.列印ToolStripMenuItem.Text = "列印";
            // 
            // exitB
            // 
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(44, 20);
            this.exitB.Text = "結束";
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // printformB
            // 
            this.printformB.Name = "printformB";
            this.printformB.Size = new System.Drawing.Size(152, 22);
            this.printformB.Text = "列印格式";
            this.printformB.Click += new System.EventHandler(this.printformB_Click);
            // 
            // printshowB
            // 
            this.printshowB.Name = "printshowB";
            this.printshowB.Size = new System.Drawing.Size(152, 22);
            this.printshowB.Text = "預覽列印";
            this.printshowB.Click += new System.EventHandler(this.printshowB_Click);
            // 
            // printB
            // 
            this.printB.Name = "printB";
            this.printB.Size = new System.Drawing.Size(152, 22);
            this.printB.Text = "列印";
            this.printB.Click += new System.EventHandler(this.printB_Click);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog1";
            this.printPreviewDialog2.Visible = false;
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.sendB);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.showB);
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendB;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox showB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem font;
        private System.Windows.Forms.ToolStripMenuItem 列印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitB;
        private System.Windows.Forms.FontDialog fontDialog2;
        private System.Windows.Forms.ToolStripMenuItem printformB;
        private System.Windows.Forms.ToolStripMenuItem printshowB;
        private System.Windows.Forms.ToolStripMenuItem printB;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog2;
    }
}