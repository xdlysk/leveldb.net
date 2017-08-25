namespace LevelDB.Viewer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LbList = new System.Windows.Forms.ListBox();
            this.TxtContent = new System.Windows.Forms.TextBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnGo = new System.Windows.Forms.Button();
            this.TxtDbPath = new System.Windows.Forms.TextBox();
            this.BtnBrowser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbList
            // 
            this.LbList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbList.FormattingEnabled = true;
            this.LbList.ItemHeight = 12;
            this.LbList.Location = new System.Drawing.Point(12, 44);
            this.LbList.Name = "LbList";
            this.LbList.Size = new System.Drawing.Size(183, 388);
            this.LbList.TabIndex = 0;
            this.LbList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbList_MouseDoubleClick);
            // 
            // TxtContent
            // 
            this.TxtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtContent.Location = new System.Drawing.Point(201, 44);
            this.TxtContent.Multiline = true;
            this.TxtContent.Name = "TxtContent";
            this.TxtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtContent.Size = new System.Drawing.Size(447, 388);
            this.TxtContent.TabIndex = 1;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(13, 13);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(136, 21);
            this.TxtSearch.TabIndex = 2;
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(155, 13);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(40, 23);
            this.BtnGo.TabIndex = 3;
            this.BtnGo.Text = "GO";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // TxtDbPath
            // 
            this.TxtDbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDbPath.Enabled = false;
            this.TxtDbPath.Location = new System.Drawing.Point(202, 14);
            this.TxtDbPath.Name = "TxtDbPath";
            this.TxtDbPath.Size = new System.Drawing.Size(383, 21);
            this.TxtDbPath.TabIndex = 4;
            // 
            // BtnBrowser
            // 
            this.BtnBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBrowser.Location = new System.Drawing.Point(592, 13);
            this.BtnBrowser.Name = "BtnBrowser";
            this.BtnBrowser.Size = new System.Drawing.Size(56, 23);
            this.BtnBrowser.TabIndex = 5;
            this.BtnBrowser.Text = "...";
            this.BtnBrowser.UseVisualStyleBackColor = true;
            this.BtnBrowser.Click += new System.EventHandler(this.BtnBrowser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 441);
            this.Controls.Add(this.BtnBrowser);
            this.Controls.Add(this.TxtDbPath);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.TxtContent);
            this.Controls.Add(this.LbList);
            this.Name = "Form1";
            this.Text = "LevelDB-Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbList;
        private System.Windows.Forms.TextBox TxtContent;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.TextBox TxtDbPath;
        private System.Windows.Forms.Button BtnBrowser;
    }
}

