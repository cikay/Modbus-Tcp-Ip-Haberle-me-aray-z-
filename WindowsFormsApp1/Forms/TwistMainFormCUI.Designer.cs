namespace WindowsFormsApp1.Forms
{
    partial class TwistMainFormCUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwistMainFormCUI));
            this.tStrip_Connection = new System.Windows.Forms.ToolStrip();
            this.tStripBtn_DisConnect = new System.Windows.Forms.ToolStripButton();
            this.tStripBtn_Connect = new System.Windows.Forms.ToolStripButton();
            this.tStripL_ConnectionStatus = new System.Windows.Forms.ToolStripLabel();
            this.tStripL_AccessSystem = new System.Windows.Forms.ToolStripLabel();
            this.tStripL_ReqData = new System.Windows.Forms.ToolStripLabel();
            this.tlStrip_Production = new System.Windows.Forms.ToolStrip();
            this.tStripBtn_Products = new System.Windows.Forms.ToolStripButton();
            this.tStripBtn_Cables = new System.Windows.Forms.ToolStripButton();
            this.tStripBtn_Accounts = new System.Windows.Forms.ToolStripButton();
            this.tStrip_Connection.SuspendLayout();
            this.tlStrip_Production.SuspendLayout();
            this.SuspendLayout();
            // 
            // tStrip_Connection
            // 
            this.tStrip_Connection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripBtn_DisConnect,
            this.tStripBtn_Connect,
            this.tStripL_ConnectionStatus,
            this.tStripL_AccessSystem,
            this.tStripL_ReqData});
            this.tStrip_Connection.Location = new System.Drawing.Point(0, 0);
            this.tStrip_Connection.Name = "tStrip_Connection";
            this.tStrip_Connection.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tStrip_Connection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tStrip_Connection.Size = new System.Drawing.Size(791, 33);
            this.tStrip_Connection.TabIndex = 3;
            // 
            // tStripBtn_DisConnect
            // 
            this.tStripBtn_DisConnect.AutoSize = false;
            this.tStripBtn_DisConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripBtn_DisConnect.Image = ((System.Drawing.Image)(resources.GetObject("tStripBtn_DisConnect.Image")));
            this.tStripBtn_DisConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripBtn_DisConnect.Name = "tStripBtn_DisConnect";
            this.tStripBtn_DisConnect.Size = new System.Drawing.Size(83, 30);
            this.tStripBtn_DisConnect.Text = "Bağlantıyı kes";
            this.tStripBtn_DisConnect.Click += new System.EventHandler(this.tStripBtn_DisConnect_Click);
            // 
            // tStripBtn_Connect
            // 
            this.tStripBtn_Connect.AutoSize = false;
            this.tStripBtn_Connect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripBtn_Connect.Image = ((System.Drawing.Image)(resources.GetObject("tStripBtn_Connect.Image")));
            this.tStripBtn_Connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripBtn_Connect.Name = "tStripBtn_Connect";
            this.tStripBtn_Connect.Size = new System.Drawing.Size(47, 30);
            this.tStripBtn_Connect.Text = "Bağlan";
            this.tStripBtn_Connect.Click += new System.EventHandler(this.tStripBtn_Connect_Click);
            // 
            // tStripL_ConnectionStatus
            // 
            this.tStripL_ConnectionStatus.Name = "tStripL_ConnectionStatus";
            this.tStripL_ConnectionStatus.Size = new System.Drawing.Size(96, 30);
            this.tStripL_ConnectionStatus.Text = "Bağlantı durumu";
            // 
            // tStripL_AccessSystem
            // 
            this.tStripL_AccessSystem.Name = "tStripL_AccessSystem";
            this.tStripL_AccessSystem.Size = new System.Drawing.Size(80, 30);
            this.tStripL_AccessSystem.Text = "Sistem Erişimi";
            // 
            // tStripL_ReqData
            // 
            this.tStripL_ReqData.Name = "tStripL_ReqData";
            this.tStripL_ReqData.Size = new System.Drawing.Size(58, 30);
            this.tStripL_ReqData.Text = "Veri talebi";
            // 
            // tlStrip_Production
            // 
            this.tlStrip_Production.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlStrip_Production.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripBtn_Products,
            this.tStripBtn_Cables,
            this.tStripBtn_Accounts});
            this.tlStrip_Production.Location = new System.Drawing.Point(0, 33);
            this.tlStrip_Production.Name = "tlStrip_Production";
            this.tlStrip_Production.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tlStrip_Production.Size = new System.Drawing.Size(56, 469);
            this.tlStrip_Production.TabIndex = 4;
            this.tlStrip_Production.Text = "tStrip_Production";
            // 
            // tStripBtn_Products
            // 
            this.tStripBtn_Products.AutoSize = false;
            this.tStripBtn_Products.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripBtn_Products.Image = ((System.Drawing.Image)(resources.GetObject("tStripBtn_Products.Image")));
            this.tStripBtn_Products.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tStripBtn_Products.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripBtn_Products.Name = "tStripBtn_Products";
            this.tStripBtn_Products.Size = new System.Drawing.Size(55, 30);
            this.tStripBtn_Products.Text = "Ürünler";
            this.tStripBtn_Products.Click += new System.EventHandler(this.tStripBtn_Products_Click);
            // 
            // tStripBtn_Cables
            // 
            this.tStripBtn_Cables.AutoSize = false;
            this.tStripBtn_Cables.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripBtn_Cables.Image = ((System.Drawing.Image)(resources.GetObject("tStripBtn_Cables.Image")));
            this.tStripBtn_Cables.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripBtn_Cables.Name = "tStripBtn_Cables";
            this.tStripBtn_Cables.Size = new System.Drawing.Size(55, 30);
            this.tStripBtn_Cables.Text = "Kablolar";
            this.tStripBtn_Cables.Click += new System.EventHandler(this.tStripBtn_Cables_Click);
            // 
            // tStripBtn_Accounts
            // 
            this.tStripBtn_Accounts.AutoSize = false;
            this.tStripBtn_Accounts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tStripBtn_Accounts.Image = ((System.Drawing.Image)(resources.GetObject("tStripBtn_Accounts.Image")));
            this.tStripBtn_Accounts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tStripBtn_Accounts.Name = "tStripBtn_Accounts";
            this.tStripBtn_Accounts.Size = new System.Drawing.Size(55, 30);
            this.tStripBtn_Accounts.Text = "Hesaplar";
            this.tStripBtn_Accounts.Click += new System.EventHandler(this.tStripBtn_Accounts_Click);
            // 
            // TwistMainFormCUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 502);
            this.Controls.Add(this.tlStrip_Production);
            this.Controls.Add(this.tStrip_Connection);
            this.IsMdiContainer = true;
            this.Name = "TwistMainFormCUI";
            this.ShowIcon = false;
            this.Text = "EKSON BURMA MAKİNESİ HABERLEŞME ARAYÜZÜ";
            this.Load += new System.EventHandler(this.TwistMainFormCUI_Load);
            this.tStrip_Connection.ResumeLayout(false);
            this.tStrip_Connection.PerformLayout();
            this.tlStrip_Production.ResumeLayout(false);
            this.tlStrip_Production.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tStrip_Connection;
        private System.Windows.Forms.ToolStripButton tStripBtn_DisConnect;
        private System.Windows.Forms.ToolStripButton tStripBtn_Connect;
        private System.Windows.Forms.ToolStripLabel tStripL_ConnectionStatus;
        private System.Windows.Forms.ToolStripLabel tStripL_AccessSystem;
        private System.Windows.Forms.ToolStripLabel tStripL_ReqData;
        private System.Windows.Forms.ToolStrip tlStrip_Production;
        private System.Windows.Forms.ToolStripButton tStripBtn_Products;
        private System.Windows.Forms.ToolStripButton tStripBtn_Cables;
        private System.Windows.Forms.ToolStripButton tStripBtn_Accounts;
    }
}