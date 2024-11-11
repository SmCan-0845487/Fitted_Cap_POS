using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp2.Forms;

namespace WindowsFormsApp2
{
    public partial class 登入系統 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        //string strDBConnectionString = "";
        public 登入系統()
        {
            InitializeComponent();
        }

        private void 登入系統_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"LAPTOP-1LDJA3RM";//伺服器名稱
            scsb.InitialCatalog = "Project_Person";//資料庫名稱
            scsb.IntegratedSecurity = true;//true是windows驗證,false是sql驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            if(txt登入郵件.Text != "" &&　txt登入密碼.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from 會員資料 where email = @Logemail and 登入密碼 = @Logpassword";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Logemail", $"{txt登入郵件.Text}");
                cmd.Parameters.AddWithValue("@Logpassword", $"{txt登入密碼.Text}");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    GlobalVar.ID = (int)reader["id"];
                    GlobalVar.Permission = (int)reader["權限"];
                    reader.Close();
                    con.Close();
                    this.Hide();
                    主選單 obj = new 主選單();
                    obj.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("登入有誤");
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("登入郵件及密碼不得為空");
            }
        }

        private void lbl會員註冊_Click(object sender, EventArgs e)
        {
            增加會員 obj = new 增加會員();
            obj.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }
    }
}
