namespace WebPreglednik
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wb = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstxtBox = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtnHome = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnForward = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wb
            // 
            this.wb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wb.Location = new System.Drawing.Point(3, 28);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.ScriptErrorsSuppressed = true;
            this.wb.Size = new System.Drawing.Size(944, 514);
            this.wb.TabIndex = 6;
            this.wb.Url = new System.Uri("http://www.Google.com", System.UriKind.Absolute);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tstxtBox,
            this.tsbtnGo,
            this.toolStripSeparator3,
            this.tsbtnHome,
            this.toolStripSeparator1,
            this.tsbtnBack,
            this.toolStripSeparator2,
            this.tsbtnForward});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(952, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "URL:";
            // 
            // tstxtBox
            // 
            this.tstxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtBox.Name = "tstxtBox";
            this.tstxtBox.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbtnHome
            // 
            this.tsbtnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHome.Name = "tsbtnHome";
            this.tsbtnHome.Size = new System.Drawing.Size(44, 22);
            this.tsbtnHome.Text = "Home";
            this.tsbtnHome.ToolTipText = "Home\r\n";
            this.tsbtnHome.Click += new System.EventHandler(this.tsbtnHome_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnBack
            // 
            this.tsbtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnBack.Image")));
            this.tsbtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBack.Name = "tsbtnBack";
            this.tsbtnBack.Size = new System.Drawing.Size(36, 22);
            this.tsbtnBack.Text = "Back";
            this.tsbtnBack.Click += new System.EventHandler(this.tsbtnBack_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnForward
            // 
            this.tsbtnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnForward.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnForward.Image")));
            this.tsbtnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnForward.Name = "tsbtnForward";
            this.tsbtnForward.Size = new System.Drawing.Size(54, 22);
            this.tsbtnForward.Text = "Forward";
            this.tsbtnForward.Click += new System.EventHandler(this.tsbtnForward_Click);
            // 
            // tsbtnGo
            // 
            this.tsbtnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnGo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGo.Image")));
            this.tsbtnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGo.Name = "tsbtnGo";
            this.tsbtnGo.Size = new System.Drawing.Size(46, 22);
            this.tsbtnGo.Text = "Search";
            this.tsbtnGo.Click += new System.EventHandler(this.tsbtnGo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 544);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.wb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstxtBox;
        private System.Windows.Forms.ToolStripButton tsbtnHome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnForward;
        private System.Windows.Forms.ToolStripButton tsbtnGo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

