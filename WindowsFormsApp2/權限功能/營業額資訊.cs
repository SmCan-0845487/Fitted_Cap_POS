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
    public partial class 營業額資訊 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> 隊伍 = new List<string>();
        List<int> 數量 = new List<int>();
        int[] total = new int[] {0,0,0,0,0};
        string 大聯盟隊伍;
        int 帽子數量;
        public 營業額資訊()
        {
            InitializeComponent();
        }

        private void 營業額資訊_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"LAPTOP-1LDJA3RM";//伺服器名稱
            scsb.InitialCatalog = "Project_Person";//資料庫名稱
            scsb.IntegratedSecurity = true;//true是windows驗證,false是sql驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            執行長條圖();
        }

        void 執行長條圖()
        {
            產出每天營業額();
            加總處理(隊伍,數量);
            if(total[0]>0)
            {
                chart每隊賣出.Series["team"].Points.AddXY("勇士", total[0]);
            }
            if (total[1] > 0) 
            {
                chart每隊賣出.Series["team"].Points.AddXY("道奇", total[1]);
            }
            if (total[2] > 0)
            {
                chart每隊賣出.Series["team"].Points.AddXY("洋基", total[2]);
            }
            if(total[3] > 0)
            {
                chart每隊賣出.Series["team"].Points.AddXY("太空人", total[3]);
            }
            if( total[4] > 0)
            {
                chart每隊賣出.Series["team"].Points.AddXY("響尾蛇", total[4]);
            }
        }

        void 加總處理(List<string> 隊伍, List<int> 數量)
        {
            int i = 0;
            while (i< 隊伍.Count)
            {
                switch (隊伍[i])
                {
                    case"勇士":
                        total[0] += 數量[i];
                        break;
                    case "道奇":
                        total[1] += 數量[i];
                        break;
                    case "洋基":
                        total[2] += 數量[i];
                        break;
                    case "太空人":
                        total[3] += 數量[i];
                        break;
                    case "響尾蛇":
                        total[4] += 數量[i];
                        break;
                }
                i++;
            }
        }

        void 產出每天營業額()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from 訂單詳細資訊";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                大聯盟隊伍 = reader["隊伍"].ToString();
                帽子數量 = (int)reader["數量"];

                隊伍.Add(大聯盟隊伍);
                數量.Add(帽子數量);
            }
            reader.Close();
            con.Close();
        }
    }
}
