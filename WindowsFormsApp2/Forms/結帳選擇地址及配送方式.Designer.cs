namespace WindowsFormsApp2.Forms
{
    partial class 結帳選擇地址及配送方式
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
            this.lbl寄送資訊 = new System.Windows.Forms.Label();
            this.cBox寄送方式 = new System.Windows.Forms.ComboBox();
            this.groupBox選擇店家 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.lbl到府地址 = new System.Windows.Forms.Label();
            this.txt地址 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt運費 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt商品金額 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt總金額 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn下訂單 = new System.Windows.Forms.Button();
            this.groupBox選擇店家.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl寄送資訊
            // 
            this.lbl寄送資訊.AutoSize = true;
            this.lbl寄送資訊.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl寄送資訊.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl寄送資訊.Location = new System.Drawing.Point(29, 19);
            this.lbl寄送資訊.Name = "lbl寄送資訊";
            this.lbl寄送資訊.Size = new System.Drawing.Size(136, 38);
            this.lbl寄送資訊.TabIndex = 0;
            this.lbl寄送資訊.Text = "寄送資訊 ";
            // 
            // cBox寄送方式
            // 
            this.cBox寄送方式.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cBox寄送方式.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cBox寄送方式.FormattingEnabled = true;
            this.cBox寄送方式.Items.AddRange(new object[] {
            "蝦皮店到店",
            "7-ELEVEN",
            "全家",
            "萊爾富",
            "送貨到府"});
            this.cBox寄送方式.Location = new System.Drawing.Point(29, 76);
            this.cBox寄送方式.Name = "cBox寄送方式";
            this.cBox寄送方式.Size = new System.Drawing.Size(313, 46);
            this.cBox寄送方式.TabIndex = 1;
            this.cBox寄送方式.TabStop = false;
            this.cBox寄送方式.Text = "選擇寄送方式";
            this.cBox寄送方式.SelectedIndexChanged += new System.EventHandler(this.cBox寄送方式_SelectedIndexChanged);
            // 
            // groupBox選擇店家
            // 
            this.groupBox選擇店家.Controls.Add(this.radioButton4);
            this.groupBox選擇店家.Controls.Add(this.radioButton3);
            this.groupBox選擇店家.Controls.Add(this.radioButton2);
            this.groupBox選擇店家.Controls.Add(this.radioButton1);
            this.groupBox選擇店家.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox選擇店家.Location = new System.Drawing.Point(399, 56);
            this.groupBox選擇店家.Name = "groupBox選擇店家";
            this.groupBox選擇店家.Size = new System.Drawing.Size(473, 127);
            this.groupBox選擇店家.TabIndex = 2;
            this.groupBox選擇店家.TabStop = false;
            this.groupBox選擇店家.Text = " 選擇店家";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton1.Location = new System.Drawing.Point(31, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton2.Location = new System.Drawing.Point(31, 80);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton3.Location = new System.Drawing.Point(237, 24);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton4.Location = new System.Drawing.Point(237, 80);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(17, 16);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // lbl到府地址
            // 
            this.lbl到府地址.AutoSize = true;
            this.lbl到府地址.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl到府地址.Location = new System.Drawing.Point(23, 158);
            this.lbl到府地址.Name = "lbl到府地址";
            this.lbl到府地址.Size = new System.Drawing.Size(141, 36);
            this.lbl到府地址.TabIndex = 3;
            this.lbl到府地址.Text = "到府地址 :";
            // 
            // txt地址
            // 
            this.txt地址.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt地址.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt地址.Location = new System.Drawing.Point(29, 209);
            this.txt地址.Name = "txt地址";
            this.txt地址.Size = new System.Drawing.Size(838, 47);
            this.txt地址.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "運費 :";
            // 
            // txt運費
            // 
            this.txt運費.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt運費.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt運費.Location = new System.Drawing.Point(29, 336);
            this.txt運費.Name = "txt運費";
            this.txt運費.Size = new System.Drawing.Size(86, 47);
            this.txt運費.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(122, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "元";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(220, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "商品金額 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(369, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "元";
            // 
            // txt商品金額
            // 
            this.txt商品金額.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt商品金額.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品金額.Location = new System.Drawing.Point(225, 336);
            this.txt商品金額.Name = "txt商品金額";
            this.txt商品金額.Size = new System.Drawing.Size(138, 47);
            this.txt商品金額.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(609, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "元";
            // 
            // txt總金額
            // 
            this.txt總金額.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt總金額.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt總金額.Location = new System.Drawing.Point(465, 336);
            this.txt總金額.Name = "txt總金額";
            this.txt總金額.Size = new System.Drawing.Size(138, 47);
            this.txt總金額.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(460, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "總金額 :";
            // 
            // btn下訂單
            // 
            this.btn下訂單.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn下訂單.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn下訂單.ForeColor = System.Drawing.Color.White;
            this.btn下訂單.Location = new System.Drawing.Point(651, 494);
            this.btn下訂單.Name = "btn下訂單";
            this.btn下訂單.Size = new System.Drawing.Size(231, 76);
            this.btn下訂單.TabIndex = 14;
            this.btn下訂單.Text = "下訂單";
            this.btn下訂單.UseVisualStyleBackColor = false;
            this.btn下訂單.Click += new System.EventHandler(this.btn下訂單_Click);
            // 
            // 結帳選擇地址及配送方式
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(944, 625);
            this.Controls.Add(this.btn下訂單);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt總金額);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt商品金額);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt運費);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt地址);
            this.Controls.Add(this.lbl到府地址);
            this.Controls.Add(this.groupBox選擇店家);
            this.Controls.Add(this.cBox寄送方式);
            this.Controls.Add(this.lbl寄送資訊);
            this.Name = "結帳選擇地址及配送方式";
            this.Text = " ";
            this.Load += new System.EventHandler(this.結帳選擇地址及配送方式_Load);
            this.groupBox選擇店家.ResumeLayout(false);
            this.groupBox選擇店家.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl寄送資訊;
        private System.Windows.Forms.ComboBox cBox寄送方式;
        private System.Windows.Forms.GroupBox groupBox選擇店家;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lbl到府地址;
        private System.Windows.Forms.TextBox txt地址;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt運費;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt商品金額;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt總金額;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn下訂單;
    }
}