namespace WindowsFormsApp1
{
    partial class Plc
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_ConnectionStatus = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_DisConnect = new System.Windows.Forms.Button();
            this.tLp_PlcMemory = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // lb_ConnectionStatus
            // 
            this.lb_ConnectionStatus.AutoSize = true;
            this.lb_ConnectionStatus.Location = new System.Drawing.Point(797, 13);
            this.lb_ConnectionStatus.Name = "lb_ConnectionStatus";
            this.lb_ConnectionStatus.Size = new System.Drawing.Size(83, 13);
            this.lb_ConnectionStatus.TabIndex = 20;
            this.lb_ConnectionStatus.Text = "Bağlantı durumu";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(907, 1);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(86, 36);
            this.btn_Connect.TabIndex = 19;
            this.btn_Connect.Text = "Bağlan";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click_1);
            // 
            // btn_DisConnect
            // 
            this.btn_DisConnect.Location = new System.Drawing.Point(999, 1);
            this.btn_DisConnect.Name = "btn_DisConnect";
            this.btn_DisConnect.Size = new System.Drawing.Size(87, 36);
            this.btn_DisConnect.TabIndex = 18;
            this.btn_DisConnect.Text = "Bağlantıyı kes";
            this.btn_DisConnect.UseVisualStyleBackColor = true;
            this.btn_DisConnect.Click += new System.EventHandler(this.btn_DisConnect_Click_1);
            // 
            // tLp_PlcMemory
            // 
            this.tLp_PlcMemory.ColumnCount = 12;
            this.tLp_PlcMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tLp_PlcMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tLp_PlcMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tLp_PlcMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tLp_PlcMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tLp_PlcMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tLp_PlcMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tLp_PlcMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tLp_PlcMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tLp_PlcMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tLp_PlcMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tLp_PlcMemory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tLp_PlcMemory.Location = new System.Drawing.Point(12, 81);
            this.tLp_PlcMemory.Name = "tLp_PlcMemory";
            this.tLp_PlcMemory.RowCount = 12;
            this.tLp_PlcMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLp_PlcMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLp_PlcMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLp_PlcMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLp_PlcMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLp_PlcMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLp_PlcMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLp_PlcMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLp_PlcMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLp_PlcMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLp_PlcMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLp_PlcMemory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLp_PlcMemory.Size = new System.Drawing.Size(991, 366);
            this.tLp_PlcMemory.TabIndex = 23;
            // 
            // Plc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 560);
            this.ControlBox = false;
            this.Controls.Add(this.tLp_PlcMemory);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb_ConnectionStatus);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_DisConnect);
            this.Name = "Plc";
            this.Load += new System.EventHandler(this.Plc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb_ConnectionStatus;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_DisConnect;
        private System.Windows.Forms.TableLayoutPanel tLp_PlcMemory;
    }
}