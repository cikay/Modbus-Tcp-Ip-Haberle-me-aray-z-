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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plcToolStripMenuItem,
            this.ürünleriListeleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1290, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // plcToolStripMenuItem
            // 
            this.plcToolStripMenuItem.Name = "plcToolStripMenuItem";
            this.plcToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.plcToolStripMenuItem.Text = "Plc";
            this.plcToolStripMenuItem.Click += new System.EventHandler(this.plcToolStripMenuItem_Click);
            // 
            // ürünleriListeleToolStripMenuItem
            // 
            this.ürünleriListeleToolStripMenuItem.Name = "ürünleriListeleToolStripMenuItem";
            this.ürünleriListeleToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.ürünleriListeleToolStripMenuItem.Text = "Ürünleri Listele";
            this.ürünleriListeleToolStripMenuItem.Click += new System.EventHandler(this.ürünleriListeleToolStripMenuItem_Click);
            // 
            // MainFormCUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 584);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainFormCUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Ekson Otomasyon";
            this.Load += new System.EventHandler(this.MainFormCUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünleriListeleToolStripMenuItem;
    }
}



