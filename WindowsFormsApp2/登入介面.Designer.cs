namespace WindowsFormsApp2
{
    partial class 登入系統
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(登入系統));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt登入郵件 = new System.Windows.Forms.TextBox();
            this.txt登入密碼 = new System.Windows.Forms.TextBox();
            this.btn登入 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl會員註冊 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt登入郵件
            // 
            this.txt登入郵件.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt登入郵件.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt登入郵件.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt登入郵件.Location = new System.Drawing.Point(39, 223);
            this.txt登入郵件.Margin = new System.Windows.Forms.Padding(4);
            this.txt登入郵件.Name = "txt登入郵件";
            this.txt登入郵件.Size = new System.Drawing.Size(311, 41);
            this.txt登入郵件.TabIndex = 1;
            // 
            // txt登入密碼
            // 
            this.txt登入密碼.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt登入密碼.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt登入密碼.Location = new System.Drawing.Point(39, 363);
            this.txt登入密碼.Margin = new System.Windows.Forms.Padding(4);
            this.txt登入密碼.Name = "txt登入密碼";
            this.txt登入密碼.PasswordChar = '*';
            this.txt登入密碼.Size = new System.Drawing.Size(311, 41);
            this.txt登入密碼.TabIndex = 3;
            // 
            // btn登入
            // 
            this.btn登入.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn登入.AutoSize = true;
            this.btn登入.BackColor = System.Drawing.Color.White;
            this.btn登入.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn登入.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn登入.ForeColor = System.Drawing.Color.Black;
            this.btn登入.Location = new System.Drawing.Point(113, 480);
            this.btn登入.Margin = new System.Windows.Forms.Padding(4);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(153, 65);
            this.btn登入.TabIndex = 4;
            this.btn登入.Text = "LOGIN";
            this.btn登入.UseVisualStyleBackColor = false;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(35, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(35, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password :";
            // 
            // lbl會員註冊
            // 
            this.lbl會員註冊.AutoSize = true;
            this.lbl會員註冊.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl會員註冊.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lbl會員註冊.Location = new System.Drawing.Point(138, 601);
            this.lbl會員註冊.Name = "lbl會員註冊";
            this.lbl會員註冊.Size = new System.Drawing.Size(128, 15);
            this.lbl會員註冊.TabIndex = 7;
            this.lbl會員註冊.Text = "Become a member";
            this.lbl會員註冊.Click += new System.EventHandler(this.lbl會員註冊_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label4.Location = new System.Drawing.Point(13, 601);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Not a member ?";
            // 
            // 登入系統
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(393, 635);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl會員註冊);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.txt登入密碼);
            this.Controls.Add(this.txt登入郵件);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "登入系統";
            this.Text = "登入系統";
            this.Load += new System.EventHandler(this.登入系統_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt登入郵件;
        private System.Windows.Forms.TextBox txt登入密碼;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl會員註冊;
        private System.Windows.Forms.Label label4;
    }
}

