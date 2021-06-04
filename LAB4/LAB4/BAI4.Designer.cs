namespace LAB4
{
    partial class BAI4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BAI4));
            this.backward = new System.Windows.Forms.ToolStripButton();
            this.forward = new System.Windows.Forms.ToolStripButton();
            this.reload = new System.Windows.Forms.ToolStripButton();
            this.LocationBar = new System.Windows.Forms.ToolStripComboBox();
            this.viewSource = new System.Windows.Forms.ToolStripButton();
            this.downPage = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.home = new System.Windows.Forms.ToolStripButton();
            this.search = new System.Windows.Forms.ToolStripButton();
            this.myBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backward
            // 
            this.backward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backward.Image = ((System.Drawing.Image)(resources.GetObject("backward.Image")));
            this.backward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backward.Name = "backward";
            this.backward.Size = new System.Drawing.Size(29, 28);
            this.backward.Text = "Go back one page";
            // 
            // forward
            // 
            this.forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forward.Image = ((System.Drawing.Image)(resources.GetObject("forward.Image")));
            this.forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(29, 28);
            this.forward.Text = "Go forward one page";
            // 
            // reload
            // 
            this.reload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reload.Image = ((System.Drawing.Image)(resources.GetObject("reload.Image")));
            this.reload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(29, 28);
            this.reload.Text = "Reload current page";
            // 
            // LocationBar
            // 
            this.LocationBar.Name = "LocationBar";
            this.LocationBar.Size = new System.Drawing.Size(800, 31);
            // 
            // viewSource
            // 
            this.viewSource.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.viewSource.Image = ((System.Drawing.Image)(resources.GetObject("viewSource.Image")));
            this.viewSource.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewSource.Name = "viewSource";
            this.viewSource.Size = new System.Drawing.Size(29, 28);
            this.viewSource.Text = "View Source";
            this.viewSource.Click += new System.EventHandler(this.viewSource_Click);
            // 
            // downPage
            // 
            this.downPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.downPage.Image = ((System.Drawing.Image)(resources.GetObject("downPage.Image")));
            this.downPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.downPage.Name = "downPage";
            this.downPage.Size = new System.Drawing.Size(29, 28);
            this.downPage.Text = "Download HTML source";
            this.downPage.Click += new System.EventHandler(this.downPage_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backward,
            this.forward,
            this.home,
            this.reload,
            this.LocationBar,
            this.search,
            this.viewSource,
            this.downPage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1250, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // home
            // 
            this.home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(29, 28);
            this.home.Text = "Home Page";
            // 
            // search
            // 
            this.search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(29, 28);
            this.search.Text = "Go to the address in the Location Bar";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // myBrowser
            // 
            this.myBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myBrowser.Location = new System.Drawing.Point(0, 31);
            this.myBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.myBrowser.Name = "myBrowser";
            this.myBrowser.Size = new System.Drawing.Size(1250, 555);
            this.myBrowser.TabIndex = 1;
            // 
            // BAI4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 586);
            this.Controls.Add(this.myBrowser);
            this.Controls.Add(this.toolStrip1);
            this.Name = "BAI4";
            this.Text = "Web Browser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton backward;
        private System.Windows.Forms.ToolStripButton forward;
        private System.Windows.Forms.ToolStripButton reload;
        private System.Windows.Forms.ToolStripComboBox LocationBar;
        private System.Windows.Forms.ToolStripButton viewSource;
        private System.Windows.Forms.ToolStripButton downPage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton home;
        private System.Windows.Forms.ToolStripButton search;
        private System.Windows.Forms.WebBrowser myBrowser;
    }
}