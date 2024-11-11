namespace WindowsFormsApp2.Forms
{
    partial class 購物車
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
            this.btn移除所選 = new System.Windows.Forms.Button();
            this.btn清空 = new System.Windows.Forms.Button();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.listBox購物車 = new System.Windows.Forms.ListBox();
            this.btn結帳 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "訂購資訊 : ";
            // 
            // btn移除所選
            // 
            this.btn移除所選.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn移除所選.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選.Location = new System.Drawing.Point(37, 521);
            this.btn移除所選.Name = "btn移除所選";
            this.btn移除所選.Size = new System.Drawing.Size(191, 92);
            this.btn移除所選.TabIndex = 2;
            this.btn移除所選.Text = "移除所選項目";
            this.btn移除所選.UseVisualStyleBackColor = true;
            this.btn移除所選.Click += new System.EventHandler(this.btn移除所選_Click);
            // 
            // btn清空
            // 
            this.btn清空.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn清空.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空.Location = new System.Drawing.Point(244, 522);
            this.btn清空.Name = "btn清空";
            this.btn清空.Size = new System.Drawing.Size(191, 92);
            this.btn清空.TabIndex = 3;
            this.btn清空.Text = "清空購物車";
            this.btn清空.UseVisualStyleBackColor = true;
            this.btn清空.Click += new System.EventHandler(this.btn清空_Click);
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl訂單總價.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl訂單總價.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl訂單總價.Location = new System.Drawing.Point(684, 520);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(219, 92);
            this.lbl訂單總價.TabIndex = 4;
            this.lbl訂單總價.Text = "訂單總價 0000元";
            this.lbl訂單總價.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox購物車
            // 
            this.listBox購物車.AllowDrop = true;
            this.listBox購物車.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox購物車.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox購物車.FormattingEnabled = true;
            this.listBox購物車.ItemHeight = 29;
            this.listBox購物車.Location = new System.Drawing.Point(12, 79);
            this.listBox購物車.Name = "listBox購物車";
            this.listBox購物車.Size = new System.Drawing.Size(920, 410);
            this.listBox購物車.TabIndex = 5;
            // 
            // btn結帳
            // 
            this.btn結帳.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn結帳.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn結帳.Location = new System.Drawing.Point(456, 522);
            this.btn結帳.Name = "btn結帳";
            this.btn結帳.Size = new System.Drawing.Size(191, 92);
            this.btn結帳.TabIndex = 6;
            this.btn結帳.Text = "結帳";
            this.btn結帳.UseVisualStyleBackColor = true;
            this.btn結帳.Click += new System.EventHandler(this.btn結帳_Click);
            // 
            // 購物車
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(944, 625);
            this.Controls.Add(this.btn結帳);
            this.Controls.Add(this.listBox購物車);
            this.Controls.Add(this.lbl訂單總價);
            this.Controls.Add(this.btn清空);
            this.Controls.Add(this.btn移除所選);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "購物車";
            this.Text = "購物車";
            this.Load += new System.EventHandler(this.購物車_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn移除所選;
        private System.Windows.Forms.Button btn清空;
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.ListBox listBox購物車;
        private System.Windows.Forms.Button btn結帳;
    }
}