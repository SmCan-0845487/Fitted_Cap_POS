namespace WindowsFormsApp2.Forms
{
    partial class 條件篩選
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(條件篩選));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblteam = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblstock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox尺寸 = new System.Windows.Forms.ComboBox();
            this.comboBox顏色 = new System.Windows.Forms.ComboBox();
            this.comboBox隊伍 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt條件顏色 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(179, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(378, 43);
            this.txtName.TabIndex = 0;
            // 
            // lblname
            // 
            this.lblname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(59, 60);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(105, 43);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblteam
            // 
            this.lblteam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblteam.BackColor = System.Drawing.Color.DarkBlue;
            this.lblteam.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteam.ForeColor = System.Drawing.Color.White;
            this.lblteam.Location = new System.Drawing.Point(34, 42);
            this.lblteam.Name = "lblteam";
            this.lblteam.Size = new System.Drawing.Size(105, 43);
            this.lblteam.TabIndex = 3;
            this.lblteam.Text = "Team";
            this.lblteam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblprice
            // 
            this.lblprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblprice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(57, 137);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(107, 43);
            this.lblprice.TabIndex = 5;
            this.lblprice.Text = "Price";
            this.lblprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(179, 137);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(217, 43);
            this.txtPrice.TabIndex = 4;
            // 
            // lblstock
            // 
            this.lblstock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblstock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.Location = new System.Drawing.Point(437, 137);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(113, 43);
            this.lblstock.TabIndex = 7;
            this.lblstock.Text = "Stock";
            this.lblstock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStock.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStock.Location = new System.Drawing.Point(565, 137);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(142, 43);
            this.txtStock.TabIndex = 6;
            // 
            // btn搜尋
            // 
            this.btn搜尋.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn搜尋.BackColor = System.Drawing.Color.DarkBlue;
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.ForeColor = System.Drawing.Color.White;
            this.btn搜尋.Location = new System.Drawing.Point(685, 68);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(166, 83);
            this.btn搜尋.TabIndex = 8;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.comboBox尺寸);
            this.groupBox1.Controls.Add(this.comboBox顏色);
            this.groupBox1.Controls.Add(this.comboBox隊伍);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn搜尋);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblteam);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(52, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 177);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜尋條件";
            // 
            // comboBox尺寸
            // 
            this.comboBox尺寸.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBox尺寸.FormattingEnabled = true;
            this.comboBox尺寸.Items.AddRange(new object[] {
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
            this.comboBox尺寸.Location = new System.Drawing.Point(504, 46);
            this.comboBox尺寸.Name = "comboBox尺寸";
            this.comboBox尺寸.Size = new System.Drawing.Size(120, 43);
            this.comboBox尺寸.TabIndex = 16;
            // 
            // comboBox顏色
            // 
            this.comboBox顏色.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBox顏色.FormattingEnabled = true;
            this.comboBox顏色.Items.AddRange(new object[] {
            "Blue",
            "Black",
            "Beige",
            "Brown",
            "Green",
            "Red",
            "White",
            "Purple"});
            this.comboBox顏色.Location = new System.Drawing.Point(161, 110);
            this.comboBox顏色.Name = "comboBox顏色";
            this.comboBox顏色.Size = new System.Drawing.Size(186, 43);
            this.comboBox顏色.TabIndex = 15;
            // 
            // comboBox隊伍
            // 
            this.comboBox隊伍.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBox隊伍.FormattingEnabled = true;
            this.comboBox隊伍.Items.AddRange(new object[] {
            "勇士",
            "道奇",
            "洋基",
            "太空人",
            "響尾蛇"});
            this.comboBox隊伍.Location = new System.Drawing.Point(161, 42);
            this.comboBox隊伍.Name = "comboBox隊伍";
            this.comboBox隊伍.Size = new System.Drawing.Size(158, 43);
            this.comboBox隊伍.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkBlue;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 43);
            this.label2.TabIndex = 13;
            this.label2.Text = "Size";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 43);
            this.label1.TabIndex = 11;
            this.label1.Text = "Color";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt條件顏色
            // 
            this.txt條件顏色.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt條件顏色.Location = new System.Drawing.Point(136, 58);
            this.txt條件顏色.Name = "txt條件顏色";
            this.txt條件顏色.Size = new System.Drawing.Size(224, 43);
            this.txt條件顏色.TabIndex = 10;
            // 
            // 條件篩選
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(969, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblstock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtName);
            this.DoubleBuffered = true;
            this.Name = "條件篩選";
            this.Text = "條件篩選";
            this.Load += new System.EventHandler(this.條件篩選_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblteam;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt條件顏色;
        private System.Windows.Forms.ComboBox comboBox隊伍;
        private System.Windows.Forms.ComboBox comboBox顏色;
        private System.Windows.Forms.ComboBox comboBox尺寸;
    }
}