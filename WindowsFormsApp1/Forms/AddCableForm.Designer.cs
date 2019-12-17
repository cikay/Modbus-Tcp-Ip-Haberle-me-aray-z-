namespace WindowsFormsApp1.Forms
{
    partial class AddCableForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CableName = new System.Windows.Forms.TextBox();
            this.txt_CableSection = new System.Windows.Forms.TextBox();
            this.txt_OuterDiameter = new System.Windows.Forms.TextBox();
            this.txt_Direction = new System.Windows.Forms.TextBox();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.btn_AddCable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kablo Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kesiti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yön:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dış Çap:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Renk:";
            // 
            // txt_CableName
            // 
            this.txt_CableName.Location = new System.Drawing.Point(106, 42);
            this.txt_CableName.Name = "txt_CableName";
            this.txt_CableName.Size = new System.Drawing.Size(100, 20);
            this.txt_CableName.TabIndex = 1;
            // 
            // txt_CableSection
            // 
            this.txt_CableSection.Location = new System.Drawing.Point(106, 71);
            this.txt_CableSection.Name = "txt_CableSection";
            this.txt_CableSection.Size = new System.Drawing.Size(100, 20);
            this.txt_CableSection.TabIndex = 1;
            // 
            // txt_OuterDiameter
            // 
            this.txt_OuterDiameter.Location = new System.Drawing.Point(106, 97);
            this.txt_OuterDiameter.Name = "txt_OuterDiameter";
            this.txt_OuterDiameter.Size = new System.Drawing.Size(100, 20);
            this.txt_OuterDiameter.TabIndex = 1;
            // 
            // txt_Direction
            // 
            this.txt_Direction.Location = new System.Drawing.Point(106, 123);
            this.txt_Direction.Name = "txt_Direction";
            this.txt_Direction.Size = new System.Drawing.Size(100, 20);
            this.txt_Direction.TabIndex = 1;
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(106, 149);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(100, 20);
            this.txt_Color.TabIndex = 1;
            // 
            // btn_AddCable
            // 
            this.btn_AddCable.Location = new System.Drawing.Point(106, 188);
            this.btn_AddCable.Name = "btn_AddCable";
            this.btn_AddCable.Size = new System.Drawing.Size(75, 29);
            this.btn_AddCable.TabIndex = 2;
            this.btn_AddCable.Text = "Ekle";
            this.btn_AddCable.UseVisualStyleBackColor = true;
            this.btn_AddCable.Click += new System.EventHandler(this.btn_AddCable_Click);
            // 
            // AddCableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 272);
            this.Controls.Add(this.btn_AddCable);
            this.Controls.Add(this.txt_Color);
            this.Controls.Add(this.txt_Direction);
            this.Controls.Add(this.txt_OuterDiameter);
            this.Controls.Add(this.txt_CableSection);
            this.Controls.Add(this.txt_CableName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCableForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AddCableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CableName;
        private System.Windows.Forms.TextBox txt_CableSection;
        private System.Windows.Forms.TextBox txt_OuterDiameter;
        private System.Windows.Forms.TextBox txt_Direction;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.Button btn_AddCable;
    }
}