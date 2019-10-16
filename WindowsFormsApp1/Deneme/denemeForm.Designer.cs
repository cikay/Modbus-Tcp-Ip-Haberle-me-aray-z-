namespace WindowsFormsApp1
{
    partial class denemeForm
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
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_DisConnect = new System.Windows.Forms.Button();
            this.btn_Write = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ConnectionStatus = new System.Windows.Forms.Label();
            this.tB_Adress = new System.Windows.Forms.TextBox();
            this.tB_Value = new System.Windows.Forms.TextBox();
            this.lb_ReadingValue = new System.Windows.Forms.Label();
            this.btn_Read = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(463, 32);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(86, 36);
            this.btn_Connect.TabIndex = 17;
            this.btn_Connect.Text = "Bağlan";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_DisConnect
            // 
            this.btn_DisConnect.Location = new System.Drawing.Point(562, 32);
            this.btn_DisConnect.Name = "btn_DisConnect";
            this.btn_DisConnect.Size = new System.Drawing.Size(87, 36);
            this.btn_DisConnect.TabIndex = 16;
            this.btn_DisConnect.Text = "Bağlantıyı kes";
            this.btn_DisConnect.UseVisualStyleBackColor = true;
            this.btn_DisConnect.Click += new System.EventHandler(this.btn_DisConnect_Click);
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(73, 87);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(86, 30);
            this.btn_Write.TabIndex = 18;
            this.btn_Write.Text = "Yaz";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Değer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Adres:";
            // 
            // lb_ConnectionStatus
            // 
            this.lb_ConnectionStatus.AutoSize = true;
            this.lb_ConnectionStatus.Location = new System.Drawing.Point(512, 12);
            this.lb_ConnectionStatus.Name = "lb_ConnectionStatus";
            this.lb_ConnectionStatus.Size = new System.Drawing.Size(105, 13);
            this.lb_ConnectionStatus.TabIndex = 19;
            this.lb_ConnectionStatus.Text = "lb_ConnectionStatus";
            // 
            // tB_Adress
            // 
            this.tB_Adress.Location = new System.Drawing.Point(73, 25);
            this.tB_Adress.Name = "tB_Adress";
            this.tB_Adress.Size = new System.Drawing.Size(100, 20);
            this.tB_Adress.TabIndex = 20;
            // 
            // tB_Value
            // 
            this.tB_Value.Location = new System.Drawing.Point(73, 61);
            this.tB_Value.Name = "tB_Value";
            this.tB_Value.Size = new System.Drawing.Size(100, 20);
            this.tB_Value.TabIndex = 20;
            // 
            // lb_ReadingValue
            // 
            this.lb_ReadingValue.AutoSize = true;
            this.lb_ReadingValue.Location = new System.Drawing.Point(70, 250);
            this.lb_ReadingValue.Name = "lb_ReadingValue";
            this.lb_ReadingValue.Size = new System.Drawing.Size(75, 13);
            this.lb_ReadingValue.TabIndex = 21;
            this.lb_ReadingValue.Text = "Okunan değer";
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(73, 285);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(85, 29);
            this.btn_Read.TabIndex = 22;
            this.btn_Read.Text = "Oku";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // denemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 405);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.lb_ReadingValue);
            this.Controls.Add(this.tB_Value);
            this.Controls.Add(this.tB_Adress);
            this.Controls.Add(this.lb_ConnectionStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_DisConnect);
            this.Name = "denemeForm";
            this.Text = "denemeForm";
            this.Load += new System.EventHandler(this.denemeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_DisConnect;
        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ConnectionStatus;
        private System.Windows.Forms.TextBox tB_Adress;
        private System.Windows.Forms.TextBox tB_Value;
        private System.Windows.Forms.Label lb_ReadingValue;
        private System.Windows.Forms.Button btn_Read;
    }
}