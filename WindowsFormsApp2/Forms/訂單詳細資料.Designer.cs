namespace WindowsFormsApp2.Forms
{
    partial class 訂單詳細資料
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
            this.lBox詳細資訊 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lBox詳細資訊
            // 
            this.lBox詳細資訊.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lBox詳細資訊.FormattingEnabled = true;
            this.lBox詳細資訊.ItemHeight = 29;
            this.lBox詳細資訊.Location = new System.Drawing.Point(86, 36);
            this.lBox詳細資訊.Name = "lBox詳細資訊";
            this.lBox詳細資訊.Size = new System.Drawing.Size(790, 526);
            this.lBox詳細資訊.TabIndex = 0;
            // 
            // 訂單詳細資料
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(944, 625);
            this.Controls.Add(this.lBox詳細資訊);
            this.Name = "訂單詳細資料";
            this.Text = "訂單詳細資料";
            this.Load += new System.EventHandler(this.訂單詳細資料_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBox詳細資訊;
    }
}