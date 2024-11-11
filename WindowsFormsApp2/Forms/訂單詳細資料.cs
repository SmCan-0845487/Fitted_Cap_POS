using System;
using System.Collections;
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
    public partial class 訂單詳細資料 : Form
    {
        public string 訂單編號;
        List<OrderList> list詳細資訊 = new List<OrderList>();
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public 訂單詳細資料()
        {
            InitializeComponent();
        }

        private void 訂單詳細資料_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"LAPTOP-1LDJA3RM";//伺服器名稱
            scsb.InitialCatalog = "Project_Person";//資料庫名稱
            scsb.IntegratedSecurity = true;//true是windows驗證,false是sql驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            初始化訂單詳細資訊(訂單編號);
            輸出在listbox上();
        }

        void 初始化訂單詳細資訊(string OrderID)
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
                orderList.color = reader["顏色"].ToString();
                orderList.尺寸 = reader["尺寸"].ToString();
                orderList.price = (int)reader["單價"];
                orderList.數量 = (int)reader["數量"];
                orderList.單品總價 = (int)reader["單品總價"];
                list詳細資訊.Add(orderList);
            }
            reader.Close();
            con.Close();
        }

        void 輸出在listbox上()
        {
            foreach (OrderList item in list詳細資訊)
            {
                lBox詳細資訊.Items.Add($"{item.team}隊  品名:{item.name} 顏色:{item.color} [尺寸]{item.尺寸.PadLeft(7)}");
                lBox詳細資訊.Items.Add($"{item.price}元 * {item.數量}頂 = {item.單品總價}元");
                lBox詳細資訊.Items.Add(" ");
            }
        }
    }
}
