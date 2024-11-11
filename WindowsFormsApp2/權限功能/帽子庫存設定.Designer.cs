namespace WindowsFormsApp2.權限功能
{
    partial class 帽子庫存設定
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
            this.comboBoxt尺寸選擇 = new System.Windows.Forms.ComboBox();
            this.txt數量 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn修改 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxt尺寸選擇
            // 
            this.comboBoxt尺寸選擇.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBoxt尺寸選擇.FormattingEnabled = true;
            this.comboBoxt尺寸選擇.Items.AddRange(new object[] {
            "6 7/8",
            "7",
            "7 1/8",
            "7 1/4",
            "7 3/8",
            "7 1/2",
            "7 5/8",
            "7 3/4",
            "7 7/8",
            "8"});
            this.comboBoxt尺寸選擇.Location = new System.Drawing.Point(49, 78);
            this.comboBoxt尺寸選擇.Name = "comboBoxt尺寸選擇";
            this.comboBoxt尺寸選擇.Size = new System.Drawing.Size(209, 46);
            this.comboBoxt尺寸選擇.TabIndex = 0;
            this.comboBoxt尺寸選擇.SelectedIndexChanged += new System.EventHandler(this.comboBoxt尺寸選擇_SelectedIndexChanged);
            // 
            // txt數量
            // 
            this.txt數量.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt數量.Location = new System.Drawing.Point(352, 77);
            this.txt數量.Name = "txt數量";
            this.txt數量.Size = new System.Drawing.Size(94, 47);
            this.txt數量.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(321, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "數量\r\n:";
            // 
            // btn修改
            // 
            this.btn修改.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改.Location = new System.Drawing.Point(317, 166);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(149, 56);
            this.btn修改.TabIndex = 3;
            this.btn修改.Text = "修改";
            this.btn修改.UseVisualStyleBackColor = true;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 76);
            this.label2.TabIndex = 4;
            this.label2.Text = "欲修改庫存的尺寸\r\n:";
            // 
            // 帽子庫存設定
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(500, 246);
            this.Controls.Add(this.txt數量);
            this.Controls.Add(this.comboBoxt尺寸選擇);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn修改);
            this.Controls.Add(this.label1);
            this.Name = "帽子庫存設定";
            this.Text = "帽子庫存設定";
            this.Load += new System.EventHandler(this.帽子庫存設定_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxt尺寸選擇;
        private System.Windows.Forms.TextBox txt數量;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Label label2;
    }
}