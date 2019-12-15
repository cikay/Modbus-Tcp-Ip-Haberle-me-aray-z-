namespace WindowsFormsApp1.Forms
{
    partial class ListProductForm
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
            this.components = new System.ComponentModel.Container();
            this.listView_Products = new System.Windows.Forms.ListView();
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cable2Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cable1Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CabloSection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CableDiameter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CableDirection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cms_ProductDetails = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_ProductDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Products
            // 
            this.listView_Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductName,
            this.LabelName,
            this.Cable2Color,
            this.Cable1Color,
            this.Quantity,
            this.CabloSection,
            this.CableDiameter,
            this.CableDirection});
            this.listView_Products.ContextMenuStrip = this.cms_ProductDetails;
            this.listView_Products.HideSelection = false;
            this.listView_Products.Location = new System.Drawing.Point(36, 33);
            this.listView_Products.Name = "listView_Products";
            this.listView_Products.Size = new System.Drawing.Size(639, 452);
            this.listView_Products.TabIndex = 39;
            this.listView_Products.UseCompatibleStateImageBehavior = false;
            this.listView_Products.View = System.Windows.Forms.View.Details;
            // 
            // ProductName
            // 
            this.ProductName.Tag = "ProductName";
            this.ProductName.Text = "Ürün Adı";
            this.ProductName.Width = 75;
            // 
            // LabelName
            // 
            this.LabelName.Tag = "LabelName";
            this.LabelName.Text = "Etiket Adı";
            this.LabelName.Width = 73;
            // 
            // Cable2Color
            // 
            this.Cable2Color.DisplayIndex = 3;
            this.Cable2Color.Tag = "LabelName";
            this.Cable2Color.Text = "Kablo 2 renk";
            this.Cable2Color.Width = 83;
            // 
            // Cable1Color
            // 
            this.Cable1Color.DisplayIndex = 2;
            this.Cable1Color.Tag = "LabelName";
            this.Cable1Color.Text = "Kablo 1 Renk";
            this.Cable1Color.Width = 90;
            // 
            // Quantity
            // 
            this.Quantity.Tag = "LabelName";
            this.Quantity.Text = "Ürün Miktarı";
            this.Quantity.Width = 83;
            // 
            // CabloSection
            // 
            this.CabloSection.Tag = "LabelName";
            this.CabloSection.Text = "Kablo Kesiti";
            this.CabloSection.Width = 83;
            // 
            // CableDiameter
            // 
            this.CableDiameter.Tag = "LabelName";
            this.CableDiameter.Text = "Kablo Çapı";
            this.CableDiameter.Width = 73;
            // 
            // CableDirection
            // 
            this.CableDirection.Tag = "LabelName";
            this.CableDirection.Text = "Kablo Yönü";
            this.CableDirection.Width = 75;
            // 
            // cms_ProductDetails
            // 
            this.cms_ProductDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem});
            this.cms_ProductDetails.Name = "cms_ProductDetails";
            this.cms_ProductDetails.Size = new System.Drawing.Size(181, 48);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detailsToolStripMenuItem.Text = "Detaylar";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // ListProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.listView_Products);
            this.Name = "ListProductForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ListProductForm_Load);
            this.cms_ProductDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Products;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader LabelName;
        private System.Windows.Forms.ColumnHeader Cable2Color;
        private System.Windows.Forms.ColumnHeader Cable1Color;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader CabloSection;
        private System.Windows.Forms.ColumnHeader CableDiameter;
        private System.Windows.Forms.ColumnHeader CableDirection;
        private System.Windows.Forms.ContextMenuStrip cms_ProductDetails;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
    }
}