namespace WindowsFormsApp2.Forms
{
    partial class 帽子點單介面
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
            this.txt商品名 = new System.Windows.Forms.TextBox();
            this.lbl商品名 = new System.Windows.Forms.Label();
            this.lbl隊伍名 = new System.Windows.Forms.Label();
            this.txt隊伍名 = new System.Windows.Forms.TextBox();
            this.lbl顏色 = new System.Windows.Forms.Label();
            this.txt顏色 = new System.Windows.Forms.TextBox();
            this.lbl價格 = new System.Windows.Forms.Label();
            this.txt價格 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt庫存量 = new System.Windows.Forms.TextBox();
            this.商品數量 = new System.Windows.Forms.Panel();
            this.comBox大小 = new System.Windows.Forms.ComboBox();
            this.btn加 = new System.Windows.Forms.Button();
            this.btn減 = new System.Windows.Forms.Button();
            this.txt數量 = new System.Windows.Forms.TextBox();
            this.btnAddBag = new System.Windows.Forms.Button();
            this.groupbox商品修改 = new System.Windows.Forms.GroupBox();
            this.btn庫存設定 = new System.Windows.Forms.Button();
            this.btn資料修改 = new System.Windows.Forms.Button();
            this.pictureBox顯示圖片 = new System.Windows.Forms.PictureBox();
            this.btn商品下架 = new System.Windows.Forms.Button();
            this.商品數量.SuspendLayout();
            this.groupbox商品修改.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox顯示圖片)).BeginInit();
            this.SuspendLayout();
            // 
            // txt商品名
            // 
            this.txt商品名.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt商品名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt商品名.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt商品名.Location = new System.Drawing.Point(353, 46);
            this.txt商品名.Name = "txt商品名";
            this.txt商品名.Size = new System.Drawing.Size(356, 38);
            this.txt商品名.TabIndex = 0;
            // 
            // lbl商品名
            // 
            this.lbl商品名.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl商品名.AutoSize = true;
            this.lbl商品名.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl商品名.Location = new System.Drawing.Point(265, 52);
            this.lbl商品名.Name = "lbl商品名";
            this.lbl商品名.Size = new System.Drawing.Size(82, 29);
            this.lbl商品名.TabIndex = 1;
            this.lbl商品名.Text = "商品名";
            // 
            // lbl隊伍名
            // 
            this.lbl隊伍名.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl隊伍名.AutoSize = true;
            this.lbl隊伍名.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl隊伍名.Location = new System.Drawing.Point(35, 55);
            this.lbl隊伍名.Name = "lbl隊伍名";
            this.lbl隊伍名.Size = new System.Drawing.Size(82, 29);
            this.lbl隊伍名.TabIndex = 3;
            this.lbl隊伍名.Text = "隊伍名";
            // 
            // txt隊伍名
            // 
            this.txt隊伍名.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt隊伍名.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt隊伍名.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt隊伍名.Location = new System.Drawing.Point(133, 46);
            this.txt隊伍名.Name = "txt隊伍名";
            this.txt隊伍名.Size = new System.Drawing.Size(98, 38);
            this.txt隊伍名.TabIndex = 2;
            // 
            // lbl顏色
            // 
            this.lbl顏色.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl顏色.AutoSize = true;
            this.lbl顏色.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl顏色.Location = new System.Drawing.Point(45, 134);
            this.lbl顏色.Name = "lbl顏色";
            this.lbl顏色.Size = new System.Drawing.Size(59, 29);
            this.lbl顏色.TabIndex = 5;
            this.lbl顏色.Text = "顏色";
            // 
            // txt顏色
            // 
            this.txt顏色.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt顏色.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt顏色.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt顏色.Location = new System.Drawing.Point(133, 131);
            this.txt顏色.Name = "txt顏色";
            this.txt顏色.Size = new System.Drawing.Size(153, 38);
            this.txt顏色.TabIndex = 4;
            // 
            // lbl價格
            // 
            this.lbl價格.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl價格.AutoSize = true;
            this.lbl價格.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl價格.Location = new System.Drawing.Point(316, 134);
            this.lbl價格.Name = "lbl價格";
            this.lbl價格.Size = new System.Drawing.Size(59, 29);
            this.lbl價格.TabIndex = 7;
            this.lbl價格.Text = "價格";
            // 
            // txt價格
            // 
            this.txt價格.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt價格.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt價格.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt價格.Location = new System.Drawing.Point(401, 131);
            this.txt價格.Name = "txt價格";
            this.txt價格.Size = new System.Drawing.Size(125, 38);
            this.txt價格.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(585, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "庫存量";
            // 
            // txt庫存量
            // 
            this.txt庫存量.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt庫存量.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt庫存量.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt庫存量.Location = new System.Drawing.Point(675, 134);
            this.txt庫存量.Name = "txt庫存量";
            this.txt庫存量.Size = new System.Drawing.Size(98, 38);
            this.txt庫存量.TabIndex = 8;
            // 
            // 商品數量
            // 
            this.商品數量.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.商品數量.Controls.Add(this.comBox大小);
            this.商品數量.Controls.Add(this.btn加);
            this.商品數量.Controls.Add(this.btn減);
            this.商品數量.Controls.Add(this.txt數量);
            this.商品數量.Location = new System.Drawing.Point(70, 227);
            this.商品數量.Name = "商品數量";
            this.商品數量.Size = new System.Drawing.Size(277, 98);
            this.商品數量.TabIndex = 12;
            // 
            // comBox大小
            // 
            this.comBox大小.BackColor = System.Drawing.Color.White;
            this.comBox大小.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBox大小.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.comBox大小.FormattingEnabled = true;
            this.comBox大小.Location = new System.Drawing.Point(3, 3);
            this.comBox大小.Name = "comBox大小";
            this.comBox大小.Size = new System.Drawing.Size(263, 35);
            this.comBox大小.TabIndex = 6;
            this.comBox大小.Text = "Size";
            this.comBox大小.SelectedIndexChanged += new System.EventHandler(this.comBox大小_SelectedIndexChanged);
            // 
            // btn加
            // 
            this.btn加.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn加.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn加.Location = new System.Drawing.Point(194, 53);
            this.btn加.Name = "btn加";
            this.btn加.Size = new System.Drawing.Size(72, 34);
            this.btn加.TabIndex = 12;
            this.btn加.Text = "+";
            this.btn加.UseVisualStyleBackColor = true;
            this.btn加.Click += new System.EventHandler(this.btn加_Click);
            // 
            // btn減
            // 
            this.btn減.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn減.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn減.Location = new System.Drawing.Point(6, 53);
            this.btn減.Name = "btn減";
            this.btn減.Size = new System.Drawing.Size(72, 34);
            this.btn減.TabIndex = 10;
            this.btn減.Text = "-";
            this.btn減.UseVisualStyleBackColor = true;
            this.btn減.Click += new System.EventHandler(this.btn減_Click);
            // 
            // txt數量
            // 
            this.txt數量.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt數量.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txt數量.Location = new System.Drawing.Point(93, 54);
            this.txt數量.Name = "txt數量";
            this.txt數量.ShortcutsEnabled = false;
            this.txt數量.Size = new System.Drawing.Size(84, 34);
            this.txt數量.TabIndex = 9;
            this.txt數量.Text = "0";
            this.txt數量.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddBag
            // 
            this.btnAddBag.BackColor = System.Drawing.Color.Black;
            this.btnAddBag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddBag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBag.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBag.ForeColor = System.Drawing.Color.White;
            this.btnAddBag.Location = new System.Drawing.Point(0, 543);
            this.btnAddBag.Name = "btnAddBag";
            this.btnAddBag.Size = new System.Drawing.Size(944, 82);
            this.btnAddBag.TabIndex = 7;
            this.btnAddBag.Text = "Add To Bag";
            this.btnAddBag.UseVisualStyleBackColor = false;
            this.btnAddBag.Click += new System.EventHandler(this.btnAddBag_Click);
            // 
            // groupbox商品修改
            // 
            this.groupbox商品修改.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupbox商品修改.Controls.Add(this.btn商品下架);
            this.groupbox商品修改.Controls.Add(this.btn庫存設定);
            this.groupbox商品修改.Controls.Add(this.btn資料修改);
            this.groupbox商品修改.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupbox商品修改.ForeColor = System.Drawing.Color.Black;
            this.groupbox商品修改.Location = new System.Drawing.Point(40, 345);
            this.groupbox商品修改.Name = "groupbox商品修改";
            this.groupbox商品修改.Size = new System.Drawing.Size(362, 174);
            this.groupbox商品修改.TabIndex = 13;
            this.groupbox商品修改.TabStop = false;
            this.groupbox商品修改.Text = "商品修改";
            // 
            // btn庫存設定
            // 
            this.btn庫存設定.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn庫存設定.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn庫存設定.Location = new System.Drawing.Point(30, 37);
            this.btn庫存設定.Name = "btn庫存設定";
            this.btn庫存設定.Size = new System.Drawing.Size(146, 60);
            this.btn庫存設定.TabIndex = 2;
            this.btn庫存設定.Text = "庫存設定";
            this.btn庫存設定.UseVisualStyleBackColor = true;
            this.btn庫存設定.Click += new System.EventHandler(this.btn庫存設定_Click);
            // 
            // btn資料修改
            // 
            this.btn資料修改.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn資料修改.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn資料修改.Location = new System.Drawing.Point(193, 37);
            this.btn資料修改.Name = "btn資料修改";
            this.btn資料修改.Size = new System.Drawing.Size(142, 60);
            this.btn資料修改.TabIndex = 1;
            this.btn資料修改.Text = "資料修改";
            this.btn資料修改.UseVisualStyleBackColor = true;
            this.btn資料修改.Click += new System.EventHandler(this.btn資料修改_Click);
            // 
            // pictureBox顯示圖片
            // 
            this.pictureBox顯示圖片.Location = new System.Drawing.Point(477, 216);
            this.pictureBox顯示圖片.Name = "pictureBox顯示圖片";
            this.pictureBox顯示圖片.Size = new System.Drawing.Size(407, 287);
            this.pictureBox顯示圖片.TabIndex = 14;
            this.pictureBox顯示圖片.TabStop = false;
            // 
            // btn商品下架
            // 
            this.btn商品下架.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn商品下架.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn商品下架.Location = new System.Drawing.Point(30, 103);
            this.btn商品下架.Name = "btn商品下架";
            this.btn商品下架.Size = new System.Drawing.Size(146, 60);
            this.btn商品下架.TabIndex = 3;
            this.btn商品下架.Text = "商品下架";
            this.btn商品下架.UseVisualStyleBackColor = true;
            this.btn商品下架.Click += new System.EventHandler(this.btn商品下架_Click);
            // 
            // 帽子點單介面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(944, 625);
            this.Controls.Add(this.pictureBox顯示圖片);
            this.Controls.Add(this.groupbox商品修改);
            this.Controls.Add(this.btnAddBag);
            this.Controls.Add(this.商品數量);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt庫存量);
            this.Controls.Add(this.lbl價格);
            this.Controls.Add(this.txt價格);
            this.Controls.Add(this.lbl顏色);
            this.Controls.Add(this.txt顏色);
            this.Controls.Add(this.lbl隊伍名);
            this.Controls.Add(this.txt隊伍名);
            this.Controls.Add(this.lbl商品名);
            this.Controls.Add(this.txt商品名);
            this.Name = "帽子點單介面";
            this.Text = "點單介面";
            this.Load += new System.EventHandler(this.點單介面_Load);
            this.商品數量.ResumeLayout(false);
            this.商品數量.PerformLayout();
            this.groupbox商品修改.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox顯示圖片)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt商品名;
        private System.Windows.Forms.Label lbl商品名;
        private System.Windows.Forms.Label lbl隊伍名;
        private System.Windows.Forms.TextBox txt隊伍名;
        private System.Windows.Forms.Label lbl顏色;
        private System.Windows.Forms.TextBox txt顏色;
        private System.Windows.Forms.Label lbl價格;
        private System.Windows.Forms.TextBox txt價格;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt庫存量;
        private System.Windows.Forms.Panel 商品數量;
        private System.Windows.Forms.Button btn加;
        private System.Windows.Forms.ComboBox comBox大小;
        private System.Windows.Forms.Button btn減;
        private System.Windows.Forms.Button btnAddBag;
        private System.Windows.Forms.TextBox txt數量;
        private System.Windows.Forms.Button btn資料修改;
        private System.Windows.Forms.GroupBox groupbox商品修改;
        private System.Windows.Forms.Button btn庫存設定;
        private System.Windows.Forms.PictureBox pictureBox顯示圖片;
        private System.Windows.Forms.Button btn商品下架;
    }
}