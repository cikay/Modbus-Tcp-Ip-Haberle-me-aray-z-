namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btn_DisConnect = new System.Windows.Forms.Button();
            this.Tb_ComProtocols = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lb_ConnectionStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Write = new System.Windows.Forms.Button();
            this.tB_Adress = new System.Windows.Forms.TextBox();
            this.tB_Value = new System.Windows.Forms.TextBox();
            this.lb_Adress = new System.Windows.Forms.Label();
            this.lb_Value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_DisConnect
            // 
            this.btn_DisConnect.Location = new System.Drawing.Point(441, 115);
            this.btn_DisConnect.Name = "btn_DisConnect";
            this.btn_DisConnect.Size = new System.Drawing.Size(87, 36);
            this.btn_DisConnect.TabIndex = 0;
            this.btn_DisConnect.Text = "Disconnect";
            this.btn_DisConnect.UseVisualStyleBackColor = true;
            this.btn_DisConnect.Click += new System.EventHandler(this.btn_DisConnect_Click);
            // 
            // Tb_ComProtocols
            // 
            this.Tb_ComProtocols.Location = new System.Drawing.Point(404, 39);
            this.Tb_ComProtocols.Name = "Tb_ComProtocols";
            this.Tb_ComProtocols.Size = new System.Drawing.Size(100, 20);
            this.Tb_ComProtocols.TabIndex = 2;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(340, 115);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(86, 36);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // lb_ConnectionStatus
            // 
            this.lb_ConnectionStatus.AutoSize = true;
            this.lb_ConnectionStatus.Location = new System.Drawing.Point(421, 82);
            this.lb_ConnectionStatus.Name = "lb_ConnectionStatus";
            this.lb_ConnectionStatus.Size = new System.Drawing.Size(94, 13);
            this.lb_ConnectionStatus.TabIndex = 4;
            this.lb_ConnectionStatus.Text = "Connection Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a Communication Protocol to Connect the Machine";
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(74, 96);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(89, 29);
            this.btn_Write.TabIndex = 6;
            this.btn_Write.Text = "Write";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // tB_Adress
            // 
            this.tB_Adress.Location = new System.Drawing.Point(74, 24);
            this.tB_Adress.Name = "tB_Adress";
            this.tB_Adress.Size = new System.Drawing.Size(100, 20);
            this.tB_Adress.TabIndex = 7;
            // 
            // tB_Value
            // 
            this.tB_Value.Location = new System.Drawing.Point(74, 60);
            this.tB_Value.Name = "tB_Value";
            this.tB_Value.Size = new System.Drawing.Size(100, 20);
            this.tB_Value.TabIndex = 8;
            // 
            // lb_Adress
            // 
            this.lb_Adress.AutoSize = true;
            this.lb_Adress.Location = new System.Drawing.Point(26, 24);
            this.lb_Adress.Name = "lb_Adress";
            this.lb_Adress.Size = new System.Drawing.Size(42, 13);
            this.lb_Adress.TabIndex = 9;
            this.lb_Adress.Text = "Adress:";
            this.lb_Adress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_Value
            // 
            this.lb_Value.AutoSize = true;
            this.lb_Value.Location = new System.Drawing.Point(31, 60);
            this.lb_Value.Name = "lb_Value";
            this.lb_Value.Size = new System.Drawing.Size(37, 13);
            this.lb_Value.TabIndex = 9;
            this.lb_Value.Text = "Value:";
            this.lb_Value.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 486);
            this.Controls.Add(this.lb_Value);
            this.Controls.Add(this.lb_Adress);
            this.Controls.Add(this.tB_Value);
            this.Controls.Add(this.tB_Adress);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_ConnectionStatus);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.Tb_ComProtocols);
            this.Controls.Add(this.btn_DisConnect);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Ekson Otomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_DisConnect;
        private System.Windows.Forms.TextBox Tb_ComProtocols;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lb_ConnectionStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.TextBox tB_Adress;
        private System.Windows.Forms.TextBox tB_Value;
        private System.Windows.Forms.Label lb_Adress;
        private System.Windows.Forms.Label lb_Value;
    }
}

