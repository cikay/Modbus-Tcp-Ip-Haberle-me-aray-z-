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
            this.lb_ConnectionStatus = new System.Windows.Forms.Label();
            this.btn_DisConnect = new System.Windows.Forms.Button();
            this.btn_ListProducts = new System.Windows.Forms.Button();
            this.lV_UrunListele = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Quantity = new System.Windows.Forms.TextBox();
            this.btn_Write = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // btn_DisConnect
            // 
            this.btn_DisConnect.Location = new System.Drawing.Point(721, 12);
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
            // lV_UrunListele
            // 
            this.lV_UrunListele.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lV_UrunListele.FullRowSelect = true;
            this.lV_UrunListele.GridLines = true;
            this.lV_UrunListele.HideSelection = false;
            this.lV_UrunListele.Location = new System.Drawing.Point(128, 73);
            this.lV_UrunListele.Name = "lV_UrunListele";
            this.lV_UrunListele.Size = new System.Drawing.Size(273, 358);
            this.lV_UrunListele.TabIndex = 25;
            this.lV_UrunListele.UseCompatibleStateImageBehavior = false;
            this.lV_UrunListele.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 265;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Üretilecek ürün adedi";
            // 
            // tB_Quantity
            // 
            this.tB_Quantity.Location = new System.Drawing.Point(528, 73);
            this.tB_Quantity.Name = "tB_Quantity";
            this.tB_Quantity.Size = new System.Drawing.Size(100, 20);
            this.tB_Quantity.TabIndex = 27;
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(528, 99);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(86, 32);
            this.btn_Write.TabIndex = 28;
            this.btn_Write.Text = "Yazdır";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(618, 12);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(84, 36);
            this.btn_Connect.TabIndex = 29;
            this.btn_Connect.Text = "Bağlan";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click_1);
            // 
            // ListProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(836, 522);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.tB_Quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lV_UrunListele);
            this.Controls.Add(this.btn_ListProducts);
            this.Controls.Add(this.lb_ConnectionStatus);
            this.Controls.Add(this.btn_DisConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "ListProductsForm";
            this.ShowIcon = false;
            this.Text = "Ürün listesi";
            this.Load += new System.EventHandler(this.ListProductsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_ConnectionStatus;
        private System.Windows.Forms.Button btn_DisConnect;
        private System.Windows.Forms.Button btn_ListProducts;
        private System.Windows.Forms.ListView lV_UrunListele;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Quantity;
        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.Button btn_Connect;
    }
}