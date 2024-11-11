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

namespace WindowsFormsApp2.權限功能
{
    public partial class 管理會員資料 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        public 管理會員資料()
        {
            InitializeComponent();
        }

        private void 查詢會員資料_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"LAPTOP-1LDJA3RM";//伺服器名稱
            scsb.InitialCatalog = "Project_Person";//資料庫名稱
            scsb.IntegratedSecurity = true;//true是windows驗證,false是sql驗證
            strDBConnectionString = scsb.ConnectionString;
        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            if(txt電話.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from 會員資料 where 電話 = @SearchTelephone";
                SqlCommand cmd = new SqlCommand(strSQL, con); 
                cmd.Parameters.AddWithValue("@SearchTelephone", $"{txt電話.Text}");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                { 
                    txtID.Text = reader["id"].ToString();
                    txtName.Text = reader["姓名"].ToString();
                    txtAdress.Text = reader["地址"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    dtp生日.Value = (DateTime)reader["生日"];
                }
                else
                {
                    MessageBox.Show("查無此會員");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
        }

        void 清空欄位()
        {
            txt電話.Clear();
            txtName.Clear();
            txtAdress.Clear();
            txtEmail.Clear();
            txtID.Clear();
            txt刪除會員ID.Clear();
            dtp生日.Value = DateTime.Now;
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn刪除會員_Click(object sender, EventArgs e)
        {
            int ID = 0;
            Int32.TryParse(txt刪除會員ID.Text, out ID);

            if (ID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from 會員資料 where id = @DeleteId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteId",ID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                {
                    清空欄位();
                    MessageBox.Show("資料已刪除");
                }
            }
        }

        private void btn修改資料_Click(object sender, EventArgs e)
        {
            int ID = 0;
            Int32.TryParse(txtID.Text, out ID);

            if ((ID > 0) && (txtName.Text != "") && (txt電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update 會員資料 set 姓名=@NewName, 電話=@NewPhone, 地址=@NewAddress, email=@NewEmail where id=@SearchID ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", ID);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
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
