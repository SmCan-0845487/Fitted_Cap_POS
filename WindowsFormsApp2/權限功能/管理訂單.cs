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
using System.Xml.Linq;

namespace WindowsFormsApp2.權限功能
{
    public partial class 管理訂單 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<OrderList> list詳細資訊 = new List<OrderList>();
        int stock,remain;
        public 管理訂單()
        {
            InitializeComponent();
        }

        private void 管理訂單_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"LAPTOP-1LDJA3RM";//伺服器名稱
            scsb.InitialCatalog = "Project_Person";//資料庫名稱
            scsb.IntegratedSecurity = true;//true是windows驗證,false是sql驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            btn完成訂單.Visible = false;
            btn審核通過.Visible = false;
            btn延遲出貨.Visible = false;
            btn訂單取消.Visible = false;
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            if (txt訂單標號.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from 訂單 where 訂單編號 = @SearchOrderID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchOrderID", $"{txt訂單標號.Text.Trim()}");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["下單會員id"].ToString();
                    lbl訂單狀態.Text = reader["訂單狀態"].ToString();
                    txt總價.Text = reader["訂單總價"].ToString();
                    txt下貨地點.Text = reader["下貨地點"].ToString();
                }
                else
                {
                    MessageBox.Show("查無此訂單");
                    清空欄位();
                }
                reader.Close();
                con.Close();
                判斷狀態顯示出按紐();
            }
        }

        void 判斷狀態顯示出按紐()
        {
            if(lbl訂單狀態.Text == "未出貨")
            {
                btn延遲出貨.Visible = true;
                btn審核通過.Visible = true;
                btn訂單取消.Visible = true;
            }
            else if(lbl訂單狀態.Text == "已出貨")
            {
                btn完成訂單.Visible=true;
            }
        }

        void 清空欄位()
        {
            txt訂單標號.Clear();
            lbl訂單狀態.Text="";
            lblID.Text = "";
            txt總價.Clear();
            txt下貨地點.Clear();
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn訂單修改_Click(object sender, EventArgs e)
        {
            if ((txt總價.Text != "") && (txt下貨地點.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "update 訂單 set 下貨地點=@NewAddress, 訂單總價=@NewPrice where 訂單編號=@SearchOrderID ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewAddress", txt下貨地點.Text);
                cmd.Parameters.AddWithValue("@NewPrice", txt總價.Text);
                cmd.Parameters.AddWithValue("@SearchOrderID", txt訂單標號.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                {
                    MessageBox.Show("資料修改成功!!");
                }
            }
        }

        private void btn完成訂單_Click(object sender, EventArgs e)
        {
            string str = "已完成";
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "update 訂單 set 訂單狀態=@NewState where 訂單編號=@SearchOrderID ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewState",str);
            cmd.Parameters.AddWithValue("@SearchOrderID", txt訂單標號.Text);
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            if (rows > 0)
            {
                lbl訂單狀態.Text = str;
            }
           
        }
        
        private void btn延遲出貨_Click(object sender, EventArgs e)
        {
            string str = "延遲出貨";
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "update 訂單 set 訂單狀態=@NewState where 訂單編號=@SearchOrderID ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewState", str);
            cmd.Parameters.AddWithValue("@SearchOrderID", txt訂單標號.Text);
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            if (rows > 0)
            {
                lbl訂單狀態.Text = str;
            }
        }

        private void btn審核通過_Click(object sender, EventArgs e)
        {
            訂單詳細資訊(txt訂單標號.Text);
            寫回庫存();
            string str = "已出貨";
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "update 訂單 set 訂單狀態=@NewState where 訂單編號=@SearchOrderID ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewState", str);
            cmd.Parameters.AddWithValue("@SearchOrderID", txt訂單標號.Text);
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            if (rows > 0)
            {
                lbl訂單狀態.Text = str;
            }
        }

        void 訂單詳細資訊(string OrderID)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from 訂單詳細資訊 where 訂單編號 = @SearchOrderID";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchOrderID", $"{OrderID}");
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                OrderList orderList = new OrderList();
                orderList.team = reader["隊伍"].ToString();
                orderList.name = reader["品項名"].ToString();
                orderList.尺寸 = reader["尺寸"].ToString();
                orderList.數量 = (int)reader["數量"];
                list詳細資訊.Add(orderList);
            }
            reader.Close();
            con.Close();
        }

        int 查詢庫存(string name,string team,string size)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from 帽子庫存 where name = @Searchname and team = @Searchteam and size = @Searchsize";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Searchname", name);
            cmd.Parameters.AddWithValue("@Searchteam", team);
            cmd.Parameters.AddWithValue("@Searchsize", size);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                stock = (int)reader["stock"];
            }
            reader.Close();
            con.Close();
            return stock;
        }

        void 寫回庫存()
        {
            foreach (OrderList item in list詳細資訊)
            {
                remain = 查詢庫存(item.name,item.team,item.尺寸)-item.數量;
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "update 帽子庫存 set stock=@Newstock where name=@Newname and team=@Newteam and size=@Newsize";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Newname", item.name);
                cmd.Parameters.AddWithValue("@Newteam", item.team);
                cmd.Parameters.AddWithValue("@Newsize", item.尺寸);
                cmd.Parameters.AddWithValue("@Newstock",remain);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                {
                    MessageBox.Show("恭喜審核通過");
                }
            }
        }

        private void btn訂單取消_Click(object sender, EventArgs e)
        {
            刪除訂單();
            刪除訂單詳細資料();
        }

        void 刪除訂單()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "delete from 訂單 where 訂單編號=@SearchOrderID ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchOrderID", txt訂單標號.Text);
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            if (rows > 0)
            {
                清空欄位();
            }
        }

        void 刪除訂單詳細資料()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "delete from 訂單詳細資訊 where 訂單編號=@SearchOrderID ";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchOrderID", txt訂單標號.Text);
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            if (rows > 0)
            {
                清空欄位();
                MessageBox.Show("訂單已取消");
            }
        }
    }
}
