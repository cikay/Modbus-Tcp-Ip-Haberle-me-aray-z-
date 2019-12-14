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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListProductsForm));
            this.lb_ConnectionStatus = new System.Windows.Forms.Label();
            this.btn_DisConnect = new System.Windows.Forms.Button();
            this.lV_UrunListele = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Quantity = new System.Windows.Forms.TextBox();
            this.btn_Write = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAccesSystem = new System.Windows.Forms.Label();
            this.lbRequestData = new System.Windows.Forms.Label();
            this.lbCurrentProduct = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCurrentAccount = new System.Windows.Forms.Label();
            this.lV_Users = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bPin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Koruma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lb_ConnectionStatus
            // 
            this.lb_ConnectionStatus.AutoSize = true;
            this.lb_ConnectionStatus.Location = new System.Drawing.Point(12, 9);
            this.lb_ConnectionStatus.Name = "lb_ConnectionStatus";
            this.lb_ConnectionStatus.Size = new System.Drawing.Size(83, 13);
            this.lb_ConnectionStatus.TabIndex = 23;
            this.lb_ConnectionStatus.Text = "Bağlantı durumu";
            // 
            // btn_DisConnect
            // 
            this.btn_DisConnect.Location = new System.Drawing.Point(12, 31);
            this.btn_DisConnect.Name = "btn_DisConnect";
            this.btn_DisConnect.Size = new System.Drawing.Size(83, 36);
            this.btn_DisConnect.TabIndex = 21;
            this.btn_DisConnect.Text = "Bağlantıyı kes";
            this.btn_DisConnect.UseVisualStyleBackColor = true;
            this.btn_DisConnect.Click += new System.EventHandler(this.btn_DisConnect_Click);
            // 
            // lV_UrunListele
            // 
            this.lV_UrunListele.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lV_UrunListele.FullRowSelect = true;
            this.lV_UrunListele.GridLines = true;
            this.lV_UrunListele.HideSelection = false;
            this.lV_UrunListele.Location = new System.Drawing.Point(15, 137);
            this.lV_UrunListele.Name = "lV_UrunListele";
            this.lV_UrunListele.Size = new System.Drawing.Size(273, 358);
            this.lV_UrunListele.TabIndex = 25;
            this.lV_UrunListele.UseCompatibleStateImageBehavior = false;
            this.lV_UrunListele.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 266;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Üretilecek ürün adedi";
            // 
            // tB_Quantity
            // 
            this.tB_Quantity.Location = new System.Drawing.Point(131, 111);
            this.tB_Quantity.Name = "tB_Quantity";
            this.tB_Quantity.Size = new System.Drawing.Size(100, 20);
            this.tB_Quantity.TabIndex = 27;
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(237, 104);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(66, 27);
            this.btn_Write.TabIndex = 28;
            this.btn_Write.Text = "Yazdır";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(101, 31);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(73, 36);
            this.btn_Connect.TabIndex = 29;
            this.btn_Connect.Text = "Bağlan";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Şuan Üretimdeki Ürün:";
            // 
            // lbAccesSystem
            // 
            this.lbAccesSystem.AutoSize = true;
            this.lbAccesSystem.Location = new System.Drawing.Point(441, 9);
            this.lbAccesSystem.Name = "lbAccesSystem";
            this.lbAccesSystem.Size = new System.Drawing.Size(64, 13);
            this.lbAccesSystem.TabIndex = 34;
            this.lbAccesSystem.Text = "Sitem erişimi";
            // 
            // lbRequestData
            // 
            this.lbRequestData.AutoSize = true;
            this.lbRequestData.Location = new System.Drawing.Point(587, 9);
            this.lbRequestData.Name = "lbRequestData";
            this.lbRequestData.Size = new System.Drawing.Size(53, 13);
            this.lbRequestData.TabIndex = 37;
            this.lbRequestData.Text = "Veri talebi";
            // 
            // lbCurrentProduct
            // 
            this.lbCurrentProduct.AutoSize = true;
            this.lbCurrentProduct.Location = new System.Drawing.Point(319, 54);
            this.lbCurrentProduct.Name = "lbCurrentProduct";
            this.lbCurrentProduct.Size = new System.Drawing.Size(78, 13);
            this.lbCurrentProduct.TabIndex = 38;
            this.lbCurrentProduct.Text = "x numaralı ürün";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Şuan Açık Sayfa:";
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.Location = new System.Drawing.Point(294, 31);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(83, 13);
            this.lbCurrentPage.TabIndex = 39;
            this.lbCurrentPage.Text = "2 numaralı sayfa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Şuan Açık Hesap:";
            // 
            // lbCurrentAccount
            // 
            this.lbCurrentAccount.AutoSize = true;
            this.lbCurrentAccount.Location = new System.Drawing.Point(294, 8);
            this.lbCurrentAccount.Name = "lbCurrentAccount";
            this.lbCurrentAccount.Size = new System.Drawing.Size(48, 13);
            this.lbCurrentAccount.TabIndex = 39;
            this.lbCurrentAccount.Text = "Muzaffer";
            // 
            // lV_Users
            // 
            this.lV_Users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.Password,
            this.bPin,
            this.Level,
            this.Koruma});
            this.lV_Users.HideSelection = false;
            this.lV_Users.Location = new System.Drawing.Point(308, 137);
            this.lV_Users.Name = "lV_Users";
            this.lV_Users.Size = new System.Drawing.Size(369, 358);
            this.lV_Users.TabIndex = 40;
            this.lV_Users.UseCompatibleStateImageBehavior = false;
            this.lV_Users.View = System.Windows.Forms.View.Details;
            // 
            // UserName
            // 
            this.UserName.Text = "Kullanıcı Adı";
            this.UserName.Width = 81;
            // 
            // Password
            // 
            this.Password.Text = "Şifre";
            // 
            // bPin
            // 
            this.bPin.Text = "Şifre2";
            // 
            // Level
            // 
            this.Level.Text = "Yetki";
            // 
            // Koruma
            // 
            this.Koruma.Text = "Koruma Bilgisi";
            this.Koruma.Width = 101;
            // 
            // ListProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(783, 526);
            this.Controls.Add(this.lV_Users);
            this.Controls.Add(this.lbCurrentAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCurrentPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCurrentProduct);
            this.Controls.Add(this.lbRequestData);
            this.Controls.Add(this.lbAccesSystem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.tB_Quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lV_UrunListele);
            this.Controls.Add(this.lb_ConnectionStatus);
            this.Controls.Add(this.btn_DisConnect);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ListProductsForm";
            this.Load += new System.EventHandler(this.ListProductsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_ConnectionStatus;
        private System.Windows.Forms.Button btn_DisConnect;
        private System.Windows.Forms.ListView lV_UrunListele;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Quantity;
        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAccesSystem;
        private System.Windows.Forms.Label lbRequestData;
        private System.Windows.Forms.Label lbCurrentProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCurrentPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCurrentAccount;
        private System.Windows.Forms.ListView lV_Users;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader bPin;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader Koruma;
    }
}