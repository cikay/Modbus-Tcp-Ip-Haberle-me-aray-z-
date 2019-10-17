namespace WindowsFormsApp1.Forms
{
    partial class ListProductsForm
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
            this.dGV_ListProducts = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_ConnectionStatus = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_DisConnect = new System.Windows.Forms.Button();
            this.btn_ListProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_ListProducts
            // 
            this.dGV_ListProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_ListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ListProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName});
            this.dGV_ListProducts.Location = new System.Drawing.Point(12, 83);
            this.dGV_ListProducts.Name = "dGV_ListProducts";
            this.dGV_ListProducts.Size = new System.Drawing.Size(843, 353);
            this.dGV_ListProducts.TabIndex = 0;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Ürün Adı";
            this.ProductName.Name = "ProductName";
            // 
            // lb_ConnectionStatus
            // 
            this.lb_ConnectionStatus.AutoSize = true;
            this.lb_ConnectionStatus.Location = new System.Drawing.Point(508, 24);
            this.lb_ConnectionStatus.Name = "lb_ConnectionStatus";
            this.lb_ConnectionStatus.Size = new System.Drawing.Size(83, 13);
            this.lb_ConnectionStatus.TabIndex = 23;
            this.lb_ConnectionStatus.Text = "Bağlantı durumu";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(618, 12);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(86, 36);
            this.btn_Connect.TabIndex = 22;
            this.btn_Connect.Text = "Bağlan";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_DisConnect
            // 
            this.btn_DisConnect.Location = new System.Drawing.Point(710, 12);
            this.btn_DisConnect.Name = "btn_DisConnect";
            this.btn_DisConnect.Size = new System.Drawing.Size(87, 36);
            this.btn_DisConnect.TabIndex = 21;
            this.btn_DisConnect.Text = "Bağlantıyı kes";
            this.btn_DisConnect.UseVisualStyleBackColor = true;
            this.btn_DisConnect.Click += new System.EventHandler(this.btn_DisConnect_Click);
            // 
            // btn_ListProducts
            // 
            this.btn_ListProducts.Location = new System.Drawing.Point(12, 16);
            this.btn_ListProducts.Name = "btn_ListProducts";
            this.btn_ListProducts.Size = new System.Drawing.Size(103, 32);
            this.btn_ListProducts.TabIndex = 24;
            this.btn_ListProducts.Text = "Ürünleri listele";
            this.btn_ListProducts.UseVisualStyleBackColor = true;
            this.btn_ListProducts.Click += new System.EventHandler(this.btn_ListProducts_Click);
            // 
            // ListProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 522);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ListProducts);
            this.Controls.Add(this.lb_ConnectionStatus);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_DisConnect);
            this.Controls.Add(this.dGV_ListProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "ListProductsForm";
            this.ShowIcon = false;
            this.Text = "Ürün listesi";
            this.Load += new System.EventHandler(this.ListProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ListProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_ListProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.Label lb_ConnectionStatus;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_DisConnect;
        private System.Windows.Forms.Button btn_ListProducts;
    }
}