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
using static System.Windows.Forms.AxHost;

namespace WindowsFormsApp2.Forms
{
    public partial class 結帳選擇地址及配送方式 : Form
    {
        public int 訂單總價 = 0;
        int 總金額 = 0;
        int 運費 = 0;
        string 訂單編號,出貨地點;
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public 結帳選擇地址及配送方式()
        {
            InitializeComponent();
        }

        private void 結帳選擇地址及配送方式_Load(object sender, EventArgs e)
        {
            groupBox選擇店家.Visible = false;
            lbl到府地址.Visible = false;
            txt地址.Visible = false;
            txt商品金額.Text = 訂單總價.ToString();

            scsb.DataSource = @"LAPTOP-1LDJA3RM";//伺服器名稱
            scsb.InitialCatalog = "Project_Person";//資料庫名稱
            scsb.IntegratedSecurity = true;//true是windows驗證,false是sql驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
        }

        void 計算總金額()
        {
            運費 = Convert.ToInt32(txt運費.Text);
            總金額 = 訂單總價 + 運費;
        }

        private void cBox寄送方式_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBox寄送方式.SelectedIndex >= 0)
            {
                switch (cBox寄送方式.SelectedIndex)
                {
                    case 0:
                        radioButton1.Text = "西屯福星店";radioButton2.Text = "梧棲中央店";
                        radioButton3.Text = "鼓山西藏店";radioButton4.Text = "左營博愛店";
                        groupBox選擇店家.Visible = true;
                        lbl到府地址.Visible = false;
                        txt地址.Visible = false;
                        txt運費.Text = "60";
                        計算總金額();txt總金額.Text = 總金額.ToString();
                        break;
                    case 1:
                        radioButton1.Text = "巨龍門市";radioButton2.Text = "逢吉門市";
                        radioButton3.Text = "廣洽門市";radioButton4.Text = "西子灣門市";
                        groupBox選擇店家.Visible = true;
                        lbl到府地址.Visible = false;
                        txt地址.Visible = false;
                        txt運費.Text = "45";
                        計算總金額(); txt總金額.Text = 總金額.ToString();
                        break;
                    case 2:
                        radioButton1.Text = "巨龍門市"; radioButton2.Text = "逢吉門市";
                        radioButton3.Text = "廣洽門市"; radioButton4.Text = "西子灣門市";
                        groupBox選擇店家.Visible = true;
                        lbl到府地址.Visible = false;
                        txt地址.Visible = false;
                        txt運費.Text = "45";
                        計算總金額(); txt總金額.Text = 總金額.ToString();
                        break;
                    case 3:
                        radioButton1.Text = "巨龍門市"; radioButton2.Text = "逢吉門市";
                        radioButton3.Text = "廣洽門市"; radioButton4.Text = "西子灣門市";
                        groupBox選擇店家.Visible = true;
                        lbl到府地址.Visible = false;
                        txt地址.Visible = false;
                        txt運費.Text = "45";
                        計算總金額(); txt總金額.Text = 總金額.ToString();
                        break;
                    case 4:
                        lbl到府地址.Visible = true;
                        txt地址.Visible = true;
                        groupBox選擇店家.Visible = false;
                        txt運費.Text = "120";
                        計算總金額(); txt總金額.Text = 總金額.ToString();
                        break;
                    default:
                        break;
                }
            }
        }

        void 確認出貨地點()
        {
            if (radioButton1.Checked)
            {
                出貨地點 = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                出貨地點 = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                出貨地點 = radioButton3.Text;
            }
            else if(radioButton4.Checked)
            {
                出貨地點 = radioButton4.Text;
            }

            if(cBox寄送方式.SelectedIndex == 4 && txt地址.Text != "")
            {
                出貨地點 = txt地址.Text;
            }
        }
        private void btn下訂單_Click(object sender, EventArgs e)
        {
            string now;
            now = DateTime.Now.ToString();
            Random myRnd = new Random();
            訂單編號 = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(100, 10000).ToString();
            確認出貨地點();//找出出貨地點
            訂單資料庫(訂單編號,"未出貨", now, 出貨地點);
            foreach (ArrayList item in GlobalVar.購物車)
            {
                string 隊伍 = (string)item[0];
                string 品項名 = (string)item[1];
                string 顏色 = (string)item[2];
                string 尺寸 = (string)item[3];
                int 單價 = (int)item[4];
                int 帽數 = (int)item[5];
                int 單品總價 = (int)item[6];
                訂單詳細資料庫(訂單編號,隊伍,品項名,顏色,尺寸,單價,帽數,單品總價);
            }
        }

        void 訂單資料庫(string orderid,string state,string ordertime,string adr)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "insert into 訂單 values (@NewOrderId,@NewPersonId,@state,@time,@address,@AddFare);";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            cmd.Parameters.AddWithValue("NewOrderId",orderid);
            cmd.Parameters.AddWithValue("NewPersonId",GlobalVar.ID);//會員ID
            cmd.Parameters.AddWithValue("state", state);
            cmd.Parameters.AddWithValue("time", ordertime);
            cmd.Parameters.AddWithValue("address",adr);
            cmd.Parameters.AddWithValue("AddFare",txt總金額.Text);
            int rows = cmd.ExecuteNonQuery();
            if(rows>0)
            {
                MessageBox.Show("下訂成功");
            }
            con.Close();
        }

        void 訂單詳細資料庫(string orderid,string team,string name,string color,string size,int price,int num,int 單品總價)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "insert into 訂單詳細資訊 values (@NewOrderId,@NewPersonId,@team,@name,@color,@size,@price,@number,@total);";
            SqlCommand cmd = new SqlCommand(strSQL, con);

            cmd.Parameters.AddWithValue("NewOrderId", orderid);
            cmd.Parameters.AddWithValue("NewPersonId", GlobalVar.ID);//會員ID
            cmd.Parameters.AddWithValue("team",team);
            cmd.Parameters.AddWithValue("name",name);
            cmd.Parameters.AddWithValue("color",color);
            cmd.Parameters.AddWithValue("size", size);
            cmd.Parameters.AddWithValue("price", price);
            cmd.Parameters.AddWithValue("number", num);
            cmd.Parameters.AddWithValue("total",單品總價);

            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                Console.WriteLine("訂單詳細資料加入");
            }
            con.Close();
        }
    }
}
