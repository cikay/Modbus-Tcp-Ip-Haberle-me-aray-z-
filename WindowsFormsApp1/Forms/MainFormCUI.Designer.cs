namespace WindowsFormsApp1
{
    partial class MainFormCUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlantıDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sitemErişimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriTalebiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.lb_ConnectionStatus = new System.Windows.Forms.Label();
            this.lbRequestData = new System.Windows.Forms.Label();
            this.lbAccesSystem = new System.Windows.Forms.Label();
            this.panelFill = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.menuStrip1);
            this.panelTop.Controls.Add(this.panelTopRight);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(860, 47);
            this.panelTop.TabIndex = 22;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductsToolStripMenuItem,
            this.CablesToolStripMenuItem,
            this.AccountsToolStripMenuItem,
            this.ConnectToolStripMenuItem,
            this.DisConnectToolStripMenuItem,
            this.bağlantıDurumuToolStripMenuItem,
            this.sitemErişimiToolStripMenuItem,
            this.veriTalebiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 47);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProductsToolStripMenuItem
            // 
            this.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem";
            this.ProductsToolStripMenuItem.Size = new System.Drawing.Size(58, 43);
            this.ProductsToolStripMenuItem.Text = "Ürünler";
            this.ProductsToolStripMenuItem.Click += new System.EventHandler(this.ProductsToolStripMenuItem_Click);
            // 
            // CablesToolStripMenuItem
            // 
            this.CablesToolStripMenuItem.Name = "CablesToolStripMenuItem";
            this.CablesToolStripMenuItem.Size = new System.Drawing.Size(62, 43);
            this.CablesToolStripMenuItem.Text = "Kablolar";
            // 
            // AccountsToolStripMenuItem
            // 
            this.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem";
            this.AccountsToolStripMenuItem.Size = new System.Drawing.Size(65, 43);
            this.AccountsToolStripMenuItem.Text = "Hesaplar";
            this.AccountsToolStripMenuItem.Click += new System.EventHandler(this.AccountsToolStripMenuItem_Click);
            // 
            // ConnectToolStripMenuItem
            // 
            this.ConnectToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem";
            this.ConnectToolStripMenuItem.Size = new System.Drawing.Size(55, 43);
            this.ConnectToolStripMenuItem.Text = "Bağlan";
            this.ConnectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
            // 
            // DisConnectToolStripMenuItem
            // 
            this.DisConnectToolStripMenuItem.Name = "DisConnectToolStripMenuItem";
            this.DisConnectToolStripMenuItem.Size = new System.Drawing.Size(92, 43);
            this.DisConnectToolStripMenuItem.Text = "Bağlantıyı Kes";
            this.DisConnectToolStripMenuItem.Click += new System.EventHandler(this.DisConnectToolStripMenuItem_Click);
            // 
            // bağlantıDurumuToolStripMenuItem
            // 
            this.bağlantıDurumuToolStripMenuItem.Name = "bağlantıDurumuToolStripMenuItem";
            this.bağlantıDurumuToolStripMenuItem.Size = new System.Drawing.Size(108, 43);
            this.bağlantıDurumuToolStripMenuItem.Text = "Bağlantı durumu";
            // 
            // sitemErişimiToolStripMenuItem
            // 
            this.sitemErişimiToolStripMenuItem.Name = "sitemErişimiToolStripMenuItem";
            this.sitemErişimiToolStripMenuItem.Size = new System.Drawing.Size(87, 43);
            this.sitemErişimiToolStripMenuItem.Text = "Sitem Erişimi";
            // 
            // veriTalebiToolStripMenuItem
            // 
            this.veriTalebiToolStripMenuItem.Name = "veriTalebiToolStripMenuItem";
            this.veriTalebiToolStripMenuItem.Size = new System.Drawing.Size(70, 43);
            this.veriTalebiToolStripMenuItem.Text = "Veri talebi";
            // 
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.lb_ConnectionStatus);
            this.panelTopRight.Controls.Add(this.lbRequestData);
            this.panelTopRight.Controls.Add(this.lbAccesSystem);
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopRight.Location = new System.Drawing.Point(455, 0);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(405, 47);
            this.panelTopRight.TabIndex = 0;
            // 
            // lb_ConnectionStatus
            // 
            this.lb_ConnectionStatus.AutoSize = true;
            this.lb_ConnectionStatus.Location = new System.Drawing.Point(15, 10);
            this.lb_ConnectionStatus.Name = "lb_ConnectionStatus";
            this.lb_ConnectionStatus.Size = new System.Drawing.Size(85, 13);
            this.lb_ConnectionStatus.TabIndex = 40;
            this.lb_ConnectionStatus.Text = "Bağlantı Durumu";
            // 
            // lbRequestData
            // 
            this.lbRequestData.AutoSize = true;
            this.lbRequestData.Location = new System.Drawing.Point(311, 10);
            this.lbRequestData.Name = "lbRequestData";
            this.lbRequestData.Size = new System.Drawing.Size(53, 13);
            this.lbRequestData.TabIndex = 39;
            this.lbRequestData.Text = "Veri talebi";
            // 
            // lbAccesSystem
            // 
            this.lbAccesSystem.AutoSize = true;
            this.lbAccesSystem.Location = new System.Drawing.Point(168, 9);
            this.lbAccesSystem.Name = "lbAccesSystem";
            this.lbAccesSystem.Size = new System.Drawing.Size(64, 13);
            this.lbAccesSystem.TabIndex = 38;
            this.lbAccesSystem.Text = "Sitem erişimi";
            // 
            // panelFill
            // 
            this.panelFill.Location = new System.Drawing.Point(0, 47);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(860, 537);
            this.panelFill.TabIndex = 23;
            this.panelFill.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFill_Paint);
            // 
            // MainFormCUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 584);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.IsMdiContainer = true;
            this.Name = "MainFormCUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.Text = "Ekson Otomasyon";
            this.Load += new System.EventHandler(this.MainFormCUI_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTopRight.ResumeLayout(false);
            this.panelTopRight.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.ToolStripMenuItem ProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisConnectToolStripMenuItem;
        private System.Windows.Forms.Label lbRequestData;
        private System.Windows.Forms.Label lbAccesSystem;
        private System.Windows.Forms.Label lb_ConnectionStatus;
        private System.Windows.Forms.ToolStripMenuItem bağlantıDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sitemErişimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriTalebiToolStripMenuItem;
    }
}



