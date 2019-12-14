namespace WindowsFormsApp1.Forms
{
    partial class ChangeAdressForm
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
            this.btn_ChangeAdress = new System.Windows.Forms.Button();
            this.tB_InceptionAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ChangeAdress
            // 
            this.btn_ChangeAdress.Location = new System.Drawing.Point(123, 114);
            this.btn_ChangeAdress.Name = "btn_ChangeAdress";
            this.btn_ChangeAdress.Size = new System.Drawing.Size(88, 30);
            this.btn_ChangeAdress.TabIndex = 0;
            this.btn_ChangeAdress.Text = "Adresi değiştir";
            this.btn_ChangeAdress.UseVisualStyleBackColor = true;
            // 
            // tB_InceptionAdress
            // 
            this.tB_InceptionAdress.Location = new System.Drawing.Point(123, 79);
            this.tB_InceptionAdress.Name = "tB_InceptionAdress";
            this.tB_InceptionAdress.Size = new System.Drawing.Size(100, 20);
            this.tB_InceptionAdress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç";
            // 
            // ChangeAdressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_InceptionAdress);
            this.Controls.Add(this.btn_ChangeAdress);
            this.Name = "ChangeAdressForm";
            this.Text = "Adres değiştir";
            this.Load += new System.EventHandler(this.ChangeAdressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangeAdress;
        private System.Windows.Forms.TextBox tB_InceptionAdress;
        private System.Windows.Forms.Label label1;
    }
}