namespace WindowsFormsApp2.權限功能
{
    partial class 管理訂單
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
            this.txt訂單標號 = new System.Windows.Forms.TextBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt下貨地點 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt總價 = new System.Windows.Forms.TextBox();
            this.btn訂單修改 = new System.Windows.Forms.Button();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn完成訂單 = new System.Windows.Forms.Button();
            this.btn審核通過 = new System.Windows.Forms.Button();
            this.btn延遲出貨 = new System.Windows.Forms.Button();
            this.lbl訂單狀態 = new System.Windows.Forms.Label();
            this.btn訂單取消 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt訂單標號
            // 
            this.txt訂單標號.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt訂單標號.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt訂單標號.ForeColor = System.Drawing.Color.Black;
            this.txt訂單標號.Location = new System.Drawing.Point(265, 35);
            this.txt訂單標號.Name = "txt訂單標號";
            this.txt訂單標號.Size = new System.Drawing.Size(305, 43);
            this.txt訂單標號.TabIndex = 0;
            // 
            // btn搜尋
            // 
            this.btn搜尋.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Location = new System.Drawing.Point(588, 35);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(104, 43);
            this.btn搜尋.TabIndex = 1;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(31, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "下單會員ID";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.ForeColor = System.Drawing.Color.Red;
            this.lblID.Location = new System.Drawing.Point(195, 110);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(99, 36);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "            ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(31, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "訂單狀態";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(31, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "下貨地點";
            // 
            // txt下貨地點
            // 
            this.txt下貨地點.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt下貨地點.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt下貨地點.ForeColor = System.Drawing.Color.Black;
            this.txt下貨地點.Location = new System.Drawing.Point(164, 244);
            this.txt下貨地點.Name = "txt下貨地點";
            this.txt下貨地點.Size = new System.Drawing.Size(690, 43);
            this.txt下貨地點.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(350, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "總價";
            // 
            // txt總價
            // 
            this.txt總價.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt總價.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt總價.ForeColor = System.Drawing.Color.Black;
            this.txt總價.Location = new System.Drawing.Point(427, 173);
            this.txt總價.Name = "txt總價";
            this.txt總價.Size = new System.Drawing.Size(137, 43);
            this.txt總價.TabIndex = 9;
            // 
            // btn訂單修改
            // 
            this.btn訂單修改.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn訂單修改.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單修改.Location = new System.Drawing.Point(742, 406);
            this.btn訂單修改.Name = "btn訂單修改";
            this.btn訂單修改.Size = new System.Drawing.Size(161, 69);
            this.btn訂單修改.TabIndex = 10;
            this.btn訂單修改.Text = "訂單修改";
            this.btn訂單修改.UseVisualStyleBackColor = true;
            this.btn訂單修改.Click += new System.EventHandler(this.btn訂單修改_Click);
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn清空欄位.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空欄位.Location = new System.Drawing.Point(563, 406);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(161, 69);
            this.btn清空欄位.TabIndex = 11;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(31, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "請輸入訂單編號";
            // 
            // btn完成訂單
            // 
            this.btn完成訂單.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn完成訂單.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn完成訂單.Location = new System.Drawing.Point(387, 406);
            this.btn完成訂單.Name = "btn完成訂單";
            this.btn完成訂單.Size = new System.Drawing.Size(161, 69);
            this.btn完成訂單.TabIndex = 13;
            this.btn完成訂單.Text = "完成訂單";
            this.btn完成訂單.UseVisualStyleBackColor = true;
            this.btn完成訂單.Click += new System.EventHandler(this.btn完成訂單_Click);
            // 
            // btn審核通過
            // 
            this.btn審核通過.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn審核通過.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn審核通過.Location = new System.Drawing.Point(28, 318);
            this.btn審核通過.Name = "btn審核通過";
            this.btn審核通過.Size = new System.Drawing.Size(161, 69);
            this.btn審核通過.TabIndex = 14;
            this.btn審核通過.Text = "審核通過";
            this.btn審核通過.UseVisualStyleBackColor = true;
            this.btn審核通過.Click += new System.EventHandler(this.btn審核通過_Click);
            // 
            // btn延遲出貨
            // 
            this.btn延遲出貨.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn延遲出貨.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn延遲出貨.Location = new System.Drawing.Point(201, 318);
            this.btn延遲出貨.Name = "btn延遲出貨";
            this.btn延遲出貨.Size = new System.Drawing.Size(161, 69);
            this.btn延遲出貨.TabIndex = 15;
            this.btn延遲出貨.Text = "延遲出貨";
            this.btn延遲出貨.UseVisualStyleBackColor = true;
            this.btn延遲出貨.Click += new System.EventHandler(this.btn延遲出貨_Click);
            // 
            // lbl訂單狀態
            // 
            this.lbl訂單狀態.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl訂單狀態.AutoSize = true;
            this.lbl訂單狀態.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單狀態.ForeColor = System.Drawing.Color.Red;
            this.lbl訂單狀態.Location = new System.Drawing.Point(164, 176);
            this.lbl訂單狀態.Name = "lbl訂單狀態";
            this.lbl訂單狀態.Size = new System.Drawing.Size(120, 36);
            this.lbl訂單狀態.TabIndex = 16;
            this.lbl訂單狀態.Text = "               ";
            // 
            // btn訂單取消
            // 
            this.btn訂單取消.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn訂單取消.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單取消.Location = new System.Drawing.Point(387, 318);
            this.btn訂單取消.Name = "btn訂單取消";
            this.btn訂單取消.Size = new System.Drawing.Size(161, 69);
            this.btn訂單取消.TabIndex = 17;
            this.btn訂單取消.Text = "訂單取消";
            this.btn訂單取消.UseVisualStyleBackColor = true;
            this.btn訂單取消.Click += new System.EventHandler(this.btn訂單取消_Click);
            // 
            // 管理訂單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(944, 625);
            this.Controls.Add(this.btn訂單取消);
            this.Controls.Add(this.lbl訂單狀態);
            this.Controls.Add(this.btn延遲出貨);
            this.Controls.Add(this.btn審核通過);
            this.Controls.Add(this.btn完成訂單);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn清空欄位);
            this.Controls.Add(this.btn訂單修改);
            this.Controls.Add(this.txt總價);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt下貨地點);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.txt訂單標號);
            this.Name = "管理訂單";
            this.Text = "管理訂單";
            this.Load += new System.EventHandler(this.管理訂單_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt訂單標號;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt下貨地點;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt總價;
        private System.Windows.Forms.Button btn訂單修改;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn完成訂單;
        private System.Windows.Forms.Button btn審核通過;
        private System.Windows.Forms.Button btn延遲出貨;
        private System.Windows.Forms.Label lbl訂單狀態;
        private System.Windows.Forms.Button btn訂單取消;
    }
}