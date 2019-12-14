namespace WindowsFormsApp1.Forms
{
    partial class AccountsForm
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
            this.lV_Users = new System.Windows.Forms.ListView();
            this.userName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.barcodPin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.protection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_AddAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lV_Users
            // 
            this.lV_Users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userName,
            this.barcodPin,
            this.pin,
            this.level,
            this.protection});
            this.lV_Users.HideSelection = false;
            this.lV_Users.Location = new System.Drawing.Point(71, 66);
            this.lV_Users.Name = "lV_Users";
            this.lV_Users.Size = new System.Drawing.Size(430, 374);
            this.lV_Users.TabIndex = 0;
            this.lV_Users.UseCompatibleStateImageBehavior = false;
            this.lV_Users.View = System.Windows.Forms.View.Details;
            // 
            // userName
            // 
            this.userName.Text = "Kullanıcı Adı";
            this.userName.Width = 103;
            // 
            // barcodPin
            // 
            this.barcodPin.Text = "Barkod Pin";
            this.barcodPin.Width = 102;
            // 
            // pin
            // 
            this.pin.Text = "Pin";
            this.pin.Width = 56;
            // 
            // level
            // 
            this.level.Text = "Yetki";
            this.level.Width = 61;
            // 
            // protection
            // 
            this.protection.Text = "Koruma Bilgisi";
            this.protection.Width = 99;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(651, 21);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 31);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_AddAccount
            // 
            this.btn_AddAccount.Location = new System.Drawing.Point(570, 21);
            this.btn_AddAccount.Name = "btn_AddAccount";
            this.btn_AddAccount.Size = new System.Drawing.Size(75, 31);
            this.btn_AddAccount.TabIndex = 2;
            this.btn_AddAccount.Text = "Hesap Ekle";
            this.btn_AddAccount.UseVisualStyleBackColor = true;
            this.btn_AddAccount.Click += new System.EventHandler(this.btn_AddAccount_Click);
            // 
            // AccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 496);
            this.Controls.Add(this.btn_AddAccount);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lV_Users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountsForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AccountsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lV_Users;
        private System.Windows.Forms.ColumnHeader userName;
        private System.Windows.Forms.ColumnHeader barcodPin;
        private System.Windows.Forms.ColumnHeader pin;
        private System.Windows.Forms.ColumnHeader level;
        private System.Windows.Forms.ColumnHeader protection;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_AddAccount;
    }
}