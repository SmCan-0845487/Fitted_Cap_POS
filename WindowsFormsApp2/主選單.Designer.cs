namespace WindowsFormsApp2
{
    partial class 主選單
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(主選單));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTile = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.btn營業額報告 = new System.Windows.Forms.Button();
            this.btn查詢或刪除會員資料 = new System.Windows.Forms.Button();
            this.btn管理訂單 = new System.Windows.Forms.Button();
            this.btn權限功能 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.Button();
            this.btn篩選條件 = new System.Windows.Forms.Button();
            this.btn購物車 = new System.Windows.Forms.Button();
            this.btn修改會員資料 = new System.Windows.Forms.Button();
            this.btn訂單狀態 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDropDown.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.NavajoWhite;
            this.panelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.lblTile);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(962, 112);
            this.panelTitleBar.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(853, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTile
            // 
            this.lblTile.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTile.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile.Location = new System.Drawing.Point(0, 0);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(962, 112);
            this.lblTile.TabIndex = 4;
            this.lblTile.Text = "HOME";
            this.lblTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 112);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(962, 741);
            this.panelDesktopPanel.TabIndex = 4;
            // 
            // panelDropDown
            // 
            this.panelDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.panelDropDown.Controls.Add(this.btn營業額報告);
            this.panelDropDown.Controls.Add(this.btn查詢或刪除會員資料);
            this.panelDropDown.Controls.Add(this.btn管理訂單);
            this.panelDropDown.Controls.Add(this.btn權限功能);
            this.panelDropDown.Location = new System.Drawing.Point(0, 537);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(220, 286);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(220, 85);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(220, 85);
            this.panelDropDown.TabIndex = 0;
            // 
            // btn營業額報告
            // 
            this.btn營業額報告.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn營業額報告.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn營業額報告.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn營業額報告.FlatAppearance.BorderSize = 0;
            this.btn營業額報告.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn營業額報告.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn營業額報告.ForeColor = System.Drawing.Color.Black;
            this.btn營業額報告.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn營業額報告.Location = new System.Drawing.Point(0, 219);
            this.btn營業額報告.Name = "btn營業額報告";
            this.btn營業額報告.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn營業額報告.Size = new System.Drawing.Size(220, 67);
            this.btn營業額報告.TabIndex = 13;
            this.btn營業額報告.Text = "營業額報告";
            this.btn營業額報告.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn營業額報告.UseVisualStyleBackColor = false;
            this.btn營業額報告.Click += new System.EventHandler(this.btn營業額報告_Click);
            // 
            // btn查詢或刪除會員資料
            // 
            this.btn查詢或刪除會員資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn查詢或刪除會員資料.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn查詢或刪除會員資料.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn查詢或刪除會員資料.FlatAppearance.BorderSize = 0;
            this.btn查詢或刪除會員資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn查詢或刪除會員資料.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查詢或刪除會員資料.ForeColor = System.Drawing.Color.Black;
            this.btn查詢或刪除會員資料.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn查詢或刪除會員資料.Location = new System.Drawing.Point(0, 152);
            this.btn查詢或刪除會員資料.Name = "btn查詢或刪除會員資料";
            this.btn查詢或刪除會員資料.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn查詢或刪除會員資料.Size = new System.Drawing.Size(220, 67);
            this.btn查詢或刪除會員資料.TabIndex = 12;
            this.btn查詢或刪除會員資料.Text = "查詢或刪除會員資料";
            this.btn查詢或刪除會員資料.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn查詢或刪除會員資料.UseVisualStyleBackColor = false;
            this.btn查詢或刪除會員資料.Click += new System.EventHandler(this.btn查詢或刪除會員資料_Click);
            // 
            // btn管理訂單
            // 
            this.btn管理訂單.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn管理訂單.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn管理訂單.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn管理訂單.FlatAppearance.BorderSize = 0;
            this.btn管理訂單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn管理訂單.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn管理訂單.ForeColor = System.Drawing.Color.Black;
            this.btn管理訂單.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn管理訂單.Location = new System.Drawing.Point(0, 85);
            this.btn管理訂單.Name = "btn管理訂單";
            this.btn管理訂單.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn管理訂單.Size = new System.Drawing.Size(220, 67);
            this.btn管理訂單.TabIndex = 11;
            this.btn管理訂單.Text = "管理訂單";
            this.btn管理訂單.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn管理訂單.UseVisualStyleBackColor = false;
            this.btn管理訂單.Click += new System.EventHandler(this.btn管理訂單_Click);
            // 
            // btn權限功能
            // 
            this.btn權限功能.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn權限功能.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn權限功能.FlatAppearance.BorderSize = 0;
            this.btn權限功能.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn權限功能.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn權限功能.ForeColor = System.Drawing.Color.Black;
            this.btn權限功能.Image = ((System.Drawing.Image)(resources.GetObject("btn權限功能.Image")));
            this.btn權限功能.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn權限功能.Location = new System.Drawing.Point(0, 0);
            this.btn權限功能.Name = "btn權限功能";
            this.btn權限功能.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn權限功能.Size = new System.Drawing.Size(220, 85);
            this.btn權限功能.TabIndex = 10;
            this.btn權限功能.Text = "  權限功能";
            this.btn權限功能.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn權限功能.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn權限功能.UseVisualStyleBackColor = true;
            this.btn權限功能.Click += new System.EventHandler(this.btn權限功能_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Black;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 112);
            this.panelLogo.TabIndex = 3;
            // 
            // btnhome
            // 
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnhome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhome.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnhome.ForeColor = System.Drawing.Color.Black;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(0, 112);
            this.btnhome.Name = "btnhome";
            this.btnhome.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnhome.Size = new System.Drawing.Size(220, 85);
            this.btnhome.TabIndex = 4;
            this.btnhome.Text = "  HOME";
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btn篩選條件
            // 
            this.btn篩選條件.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn篩選條件.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn篩選條件.FlatAppearance.BorderSize = 0;
            this.btn篩選條件.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn篩選條件.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn篩選條件.ForeColor = System.Drawing.Color.Black;
            this.btn篩選條件.Image = ((System.Drawing.Image)(resources.GetObject("btn篩選條件.Image")));
            this.btn篩選條件.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn篩選條件.Location = new System.Drawing.Point(0, 197);
            this.btn篩選條件.Name = "btn篩選條件";
            this.btn篩選條件.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn篩選條件.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn篩選條件.Size = new System.Drawing.Size(220, 85);
            this.btn篩選條件.TabIndex = 5;
            this.btn篩選條件.Text = "  條件篩選";
            this.btn篩選條件.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn篩選條件.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn篩選條件.UseVisualStyleBackColor = true;
            this.btn篩選條件.Click += new System.EventHandler(this.btn篩選條件_Click);
            // 
            // btn購物車
            // 
            this.btn購物車.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn購物車.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn購物車.FlatAppearance.BorderSize = 0;
            this.btn購物車.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn購物車.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn購物車.ForeColor = System.Drawing.Color.Black;
            this.btn購物車.Image = ((System.Drawing.Image)(resources.GetObject("btn購物車.Image")));
            this.btn購物車.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn購物車.Location = new System.Drawing.Point(0, 282);
            this.btn購物車.Name = "btn購物車";
            this.btn購物車.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn購物車.Size = new System.Drawing.Size(220, 85);
            this.btn購物車.TabIndex = 6;
            this.btn購物車.Text = "  購物車";
            this.btn購物車.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn購物車.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn購物車.UseVisualStyleBackColor = true;
            this.btn購物車.Click += new System.EventHandler(this.btn購物車_Click);
            // 
            // btn修改會員資料
            // 
            this.btn修改會員資料.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn修改會員資料.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn修改會員資料.FlatAppearance.BorderSize = 0;
            this.btn修改會員資料.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn修改會員資料.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改會員資料.ForeColor = System.Drawing.Color.Black;
            this.btn修改會員資料.Image = ((System.Drawing.Image)(resources.GetObject("btn修改會員資料.Image")));
            this.btn修改會員資料.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn修改會員資料.Location = new System.Drawing.Point(0, 367);
            this.btn修改會員資料.Name = "btn修改會員資料";
            this.btn修改會員資料.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn修改會員資料.Size = new System.Drawing.Size(220, 85);
            this.btn修改會員資料.TabIndex = 7;
            this.btn修改會員資料.Text = "  修改會員\r\n      資料\r\n";
            this.btn修改會員資料.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn修改會員資料.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn修改會員資料.UseVisualStyleBackColor = true;
            this.btn修改會員資料.Click += new System.EventHandler(this.btn修改會員資料_Click);
            // 
            // btn訂單狀態
            // 
            this.btn訂單狀態.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn訂單狀態.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn訂單狀態.FlatAppearance.BorderSize = 0;
            this.btn訂單狀態.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn訂單狀態.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單狀態.ForeColor = System.Drawing.Color.Black;
            this.btn訂單狀態.Image = ((System.Drawing.Image)(resources.GetObject("btn訂單狀態.Image")));
            this.btn訂單狀態.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn訂單狀態.Location = new System.Drawing.Point(0, 452);
            this.btn訂單狀態.Name = "btn訂單狀態";
            this.btn訂單狀態.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn訂單狀態.Size = new System.Drawing.Size(220, 85);
            this.btn訂單狀態.TabIndex = 8;
            this.btn訂單狀態.Text = "  訂單資訊";
            this.btn訂單狀態.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn訂單狀態.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn訂單狀態.UseVisualStyleBackColor = true;
            this.btn訂單狀態.Click += new System.EventHandler(this.btn訂單狀態_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.panelMenu.Controls.Add(this.panelDropDown);
            this.panelMenu.Controls.Add(this.btn訂單狀態);
            this.panelMenu.Controls.Add(this.btn修改會員資料);
            this.panelMenu.Controls.Add(this.btn購物車);
            this.panelMenu.Controls.Add(this.btn篩選條件);
            this.panelMenu.Controls.Add(this.btnhome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 853);
            this.panelMenu.TabIndex = 2;
            // 
            // 主選單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "主選單";
            this.Text = "主選單";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.主選單_Load);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDropDown.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Button btn營業額報告;
        private System.Windows.Forms.Button btn查詢或刪除會員資料;
        private System.Windows.Forms.Button btn管理訂單;
        private System.Windows.Forms.Button btn權限功能;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btn篩選條件;
        private System.Windows.Forms.Button btn購物車;
        private System.Windows.Forms.Button btn修改會員資料;
        private System.Windows.Forms.Button btn訂單狀態;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}