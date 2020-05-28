namespace quanlybanhang_1205
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMChatLieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dMHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnNhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.hóaĐơnNhapToolStripMenuItem,
            this.hóaĐơnBánToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dMChatLieuToolStripMenuItem,
            this.dMHangToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // dMChatLieuToolStripMenuItem
            // 
            this.dMChatLieuToolStripMenuItem.Name = "dMChatLieuToolStripMenuItem";
            this.dMChatLieuToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.dMChatLieuToolStripMenuItem.Text = "DM ChatLieu";
            this.dMChatLieuToolStripMenuItem.Click += new System.EventHandler(this.dMChatLieuToolStripMenuItem_Click);
            // 
            // dMHangToolStripMenuItem
            // 
            this.dMHangToolStripMenuItem.Name = "dMHangToolStripMenuItem";
            this.dMHangToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.dMHangToolStripMenuItem.Text = "DMHang";
            this.dMHangToolStripMenuItem.Click += new System.EventHandler(this.dMHangToolStripMenuItem_Click);
            // 
            // hóaĐơnNhapToolStripMenuItem
            // 
            this.hóaĐơnNhapToolStripMenuItem.Name = "hóaĐơnNhapToolStripMenuItem";
            this.hóaĐơnNhapToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.hóaĐơnNhapToolStripMenuItem.Text = "Hóa Đơn Nhap";
            // 
            // hóaĐơnBánToolStripMenuItem
            // 
            this.hóaĐơnBánToolStripMenuItem.Name = "hóaĐơnBánToolStripMenuItem";
            this.hóaĐơnBánToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.hóaĐơnBánToolStripMenuItem.Text = "Hóa Đơn Bán";
            this.hóaĐơnBánToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnBánToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMChatLieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dMHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnNhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBánToolStripMenuItem;
    }
}