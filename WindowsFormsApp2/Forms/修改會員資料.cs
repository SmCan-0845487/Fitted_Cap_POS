using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Forms
{
    public partial class 修改會員資料 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        public 修改會員資料()
        {
            InitializeComponent();
        }

        private void 修改會員資料_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"LAPTOP-1LDJA3RM";//伺服器名稱
            scsb.InitialCatalog = "Project_Person";//資料庫名稱
            scsb.IntegratedSecurity = true;//true是windows驗證,false是sql驗證
            strDBConnectionString = scsb.ConnectionString;
            載入會員資料();
        }

        void 載入會員資料()
        {
            if (GlobalVar.ID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from 會員資料 where id = @Searchid";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Searchid", $"{GlobalVar.ID}");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    txtName.Text = reader["姓名"].ToString();
                    txtAdress.Text = reader["地址"].ToString();
                    txtPhone.Text = reader["電話"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    dtp生日.Value = (DateTime)reader["生日"];
                }
                con.Close();
            }
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtPhone.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update 會員資料 set 姓名=@NewName, 電話=@NewPhone, 地址=@NewAddress, email=@NewEmail where id=@SearchID ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", GlobalVar.ID);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAdress.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                {
                    MessageBox.Show("資料修改成功!!");
                }
            }
        }
    }
}
