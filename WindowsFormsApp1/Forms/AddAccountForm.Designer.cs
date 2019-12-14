namespace WindowsFormsApp1.Forms
{
    partial class AddAccountForm
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
            this.btn_AddAccount = new System.Windows.Forms.Button();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_Pin = new System.Windows.Forms.TextBox();
            this.txt_BarcodPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Level = new System.Windows.Forms.ComboBox();
            this.cb_ProtecInfo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_AddAccount
            // 
            this.btn_AddAccount.Location = new System.Drawing.Point(120, 147);
            this.btn_AddAccount.Name = "btn_AddAccount";
            this.btn_AddAccount.Size = new System.Drawing.Size(81, 29);
            this.btn_AddAccount.TabIndex = 0;
            this.btn_AddAccount.Text = "Hesap Ekle";
            this.btn_AddAccount.UseVisualStyleBackColor = true;
            this.btn_AddAccount.Click += new System.EventHandler(this.btn_AddAccount_Click);
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(120, 19);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(100, 20);
            this.txt_userName.TabIndex = 1;
            // 
            // txt_Pin
            // 
            this.txt_Pin.Location = new System.Drawing.Point(120, 45);
            this.txt_Pin.Name = "txt_Pin";
            this.txt_Pin.Size = new System.Drawing.Size(100, 20);
            this.txt_Pin.TabIndex = 1;
            // 
            // txt_BarcodPin
            // 
            this.txt_BarcodPin.Location = new System.Drawing.Point(120, 71);
            this.txt_BarcodPin.Name = "txt_BarcodPin";
            this.txt_BarcodPin.Size = new System.Drawing.Size(100, 20);
            this.txt_BarcodPin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pin:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barkod Pin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yetki:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Koruma bilgisi:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cb_Level
            // 
            this.cb_Level.FormattingEnabled = true;
            this.cb_Level.Location = new System.Drawing.Point(120, 97);
            this.cb_Level.Name = "cb_Level";
            this.cb_Level.Size = new System.Drawing.Size(100, 21);
            this.cb_Level.TabIndex = 3;
            // 
            // cb_ProtecInfo
            // 
            this.cb_ProtecInfo.FormattingEnabled = true;
            this.cb_ProtecInfo.Location = new System.Drawing.Point(120, 120);
            this.cb_ProtecInfo.Name = "cb_ProtecInfo";
            this.cb_ProtecInfo.Size = new System.Drawing.Size(100, 21);
            this.cb_ProtecInfo.TabIndex = 3;
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 254);
            this.Controls.Add(this.cb_ProtecInfo);
            this.Controls.Add(this.cb_Level);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BarcodPin);
            this.Controls.Add(this.txt_Pin);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.btn_AddAccount);
            this.Name = "AddAccountForm";
            this.ShowIcon = false;
            this.Text = "Hesap Ekle";
            this.Load += new System.EventHandler(this.AddAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddAccount;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_Pin;
        private System.Windows.Forms.TextBox txt_BarcodPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Level;
        private System.Windows.Forms.ComboBox cb_ProtecInfo;
    }
}