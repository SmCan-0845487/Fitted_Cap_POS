using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Forms
{
    public partial class 增加會員 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        List<int> SearchIDs = new List<int>();//進階搜尋結果,存id資料
        public 增加會員()
        {
            InitializeComponent();
        }

        private void 增加會員_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"LAPTOP-1LDJA3RM";//伺服器名稱
            scsb.InitialCatalog = "Project_Person";//資料庫名稱
            scsb.IntegratedSecurity = true;//true是windows驗證,false是sql驗證
            strDBConnectionString = scsb.ConnectionString;
        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            int flag = 0;
            bool emailcorrect = Regex.IsMatch(txt電子郵件.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");//正規表示式 
            bool telephonecorrect = Regex.IsMatch(txt電話.Text, @"^09[0-9]{8}");
            if (txt姓名.Text != "" && telephonecorrect && emailcorrect && txt地址.Text != "" && txtPassword.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into 會員資料 values(@NewName,@NewPhone,@NewAddress,@NewEmail,@NewBirth,@NewPassword,@NewFlag)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text.Trim());
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text.Trim());
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text.Trim());
                cmd.Parameters.AddWithValue("@NewEmail", txt電子郵件.Text.Trim());
                cmd.Parameters.AddWithValue("@NewBirth", dTP生日.Value);
                cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@NewFlag",flag);

                int rows = cmd.ExecuteNonQuery();//可傳回受影響的資料筆數
                con.Close();
                if (rows > 0)
                {
                    MessageBox.Show("註冊成功!");
                }
                
            }
            else
            {
                MessageBox.Show("請重新確認欄位資料是否符合格式");
            }
        }
    }
}
