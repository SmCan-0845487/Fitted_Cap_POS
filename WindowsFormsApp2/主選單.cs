using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WindowsFormsApp2.Forms;

namespace WindowsFormsApp2
{
    public partial class 主選單 : Form
    {
        private Button currentButton;
        private Form activeForm;
        private bool isCollapsed = true;
        public 主選單()
        {
            InitializeComponent();
        }

        private void 主選單_Load(object sender, EventArgs e)
        {
            Home frm = new Home();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Clear();
            this.panelDesktopPanel.Controls.Add(frm);
            frm.Show();
            if(GlobalVar.Permission == 0)
            {
                panelDropDown.Visible = false;
            }
            btn營業額報告.Visible = false;
            if(GlobalVar.Permission == 2)
            {
                btn營業額報告.Visible = true;
            }
        }

        private void ActivateButton(object btnSender)//點擊欄位時修改
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.White;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("微軟正黑體", 13.0F, System.Drawing.FontStyle.Bold,System.Drawing.GraphicsUnit.Point,((byte)(0)));
                }
            }
        }

        private void DisableButton()//默認的欄位格式,回覆時用這初始化
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(245, 176, 65);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm,object btnSender)
        {
            if(activeForm != null)//如果當前有執行的子表單，先關閉它
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);//按鈕特效
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;//標題欄不顯示
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);//將設計的視窗添加到panel裡
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTile.Font = ()
            lblTile.Text = childForm.Text;

        }//開新視窗設定

        private void timer1_Tick(object sender, EventArgs e)//設定權限功能下拉選單的timer
        {
            if (isCollapsed)
            {
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                { 
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btn權限功能_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Home(), sender);
            lblTile.BackColor = Color.NavajoWhite;
        }

        private void btn篩選條件_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.條件篩選(), sender);
            lblTile.BackColor = Color.LightCyan;
        }

        private void btn購物車_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.購物車(), sender);
            lblTile.BackColor = Color.NavajoWhite;
        }

        private void btn修改會員資料_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.修改會員資料(), sender);
            lblTile.BackColor = Color.LightCyan;
        }

        private void btn訂單狀態_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.訂單資訊(), sender);
            lblTile.BackColor = Color.NavajoWhite;
        }

        private void btn查詢或刪除會員資料_Click(object sender, EventArgs e)
        {
            OpenChildForm(new 權限功能.管理會員資料(), sender);
            lblTile.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void btn管理訂單_Click(object sender, EventArgs e)
        {
            OpenChildForm(new 權限功能.管理訂單(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            登入系統 newForm = new 登入系統();
            newForm.Show();
        }

        private void btn營業額報告_Click(object sender, EventArgs e)
        {
            OpenChildForm(new 權限功能.營業額資訊(), sender);
            lblTile.BackColor = Color.NavajoWhite;
        }
    }
}
