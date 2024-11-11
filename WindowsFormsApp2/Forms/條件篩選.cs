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

namespace WindowsFormsApp2.Forms
{
    public partial class 條件篩選 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        public 條件篩選()
        {
            InitializeComponent();
        }

        private void 條件篩選_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"LAPTOP-1LDJA3RM";//伺服器名稱
            scsb.InitialCatalog = "Project_Person";//資料庫名稱
            scsb.IntegratedSecurity = true;//true是windows驗證,false是sql驗證
            strDBConnectionString = scsb.ConnectionString;
        }

        private void btn搜尋_Click(object sender, EventArgs e)//查詢條件實作,之後要調一下
        {
            if(comboBox顏色.Text != "" && comboBox尺寸.Text != "" && comboBox隊伍.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from 帽子庫存 where color = @colorname and size = @sizename and team = @teamname";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@teamname", $"{comboBox隊伍.Text}");
                cmd.Parameters.AddWithValue("@colorname", $"{comboBox顏色.Text}");
                cmd.Parameters.AddWithValue("@sizename", $"{comboBox尺寸.Text}");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) 
                {
                    txtName.Text = reader["name"].ToString();
                    txtPrice.Text = reader["price"].ToString();
                    txtStock.Text = reader["stock"].ToString();
                }
                else
                {
                    MessageBox.Show("查無此條件的商品");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("條件欄位不能為空,請重新輸入條件");
            }
        }

        void 清空欄位()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
        }
    }
}
