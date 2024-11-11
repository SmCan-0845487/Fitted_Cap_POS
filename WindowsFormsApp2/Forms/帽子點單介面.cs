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
using System.Data.SqlClient;
using System.Collections;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using WindowsFormsApp2.權限功能;

namespace WindowsFormsApp2.Forms
{
    public partial class 帽子點單介面 : Form
    {
        int 預購帽數 = 0; int 單價 = 0;
        int 單品總價 = 0; int 對應尺寸數量 = 0;
        public string name;
        public string team; 
        string str修改後的圖檔名稱 = "";
        bool is修改圖檔 = false;

        FittedCap list帽子 = new FittedCap();
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public 帽子點單介面()
        {
            InitializeComponent();
        }

        private void 點單介面_Load(object sender, EventArgs e)
        {
            if(GlobalVar.Permission == 0)
            {
                groupbox商品修改.Visible = false;
            }
            scsb.DataSource = @"LAPTOP-1LDJA3RM";//伺服器名稱
            scsb.InitialCatalog = "Project_Person";//資料庫名稱
            scsb.IntegratedSecurity = true;//true是windows驗證,false是sql驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString;

            list帽子 = 商品查詢資料庫(name,team);
            顯示商品詳細資訊(list帽子);
            帽子在Combobox初始化(list帽子, comBox大小);
            顯示商品圖片();
        }

        FittedCap 商品查詢資料庫(string name, string team)//返回一個FittedCap,包含的屬性為name,team,color,price,size,stock
        {
            int stock, price, flag = 0;
            string color;
            FittedCap list = new FittedCap();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from 帽子庫存 where name = @SearchName and team = @SearchTeam";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", $"{name}");
            cmd.Parameters.AddWithValue("@SearchTeam", $"{team}");
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                if (flag == 0)
                {
                    price = (int)reader["price"];
                    color = reader["color"].ToString();
                    list.price = price;
                    list.color = color;
                    list.name = name;
                    list.team = team;
                }
                stock = (int)reader["stock"];
                list.Sizecount[flag] = stock;
                flag++;
            }
            return list;
        }

        void 顯示商品圖片()//pictureBox顯示商品圖片
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from 帽子圖檔 where name = @SearchName and team = @SearchTeam";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", $"{name}");
            cmd.Parameters.AddWithValue("@SearchTeam", $"{team}");
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                str修改後的圖檔名稱 = reader["pimage"].ToString();
                string str完整圖檔路徑 = $"{GlobalVar.image_dir}\\{str修改後的圖檔名稱}";
                System.IO.FileStream fs = System.IO.File.OpenRead(str完整圖檔路徑);
                pictureBox顯示圖片.Image = Image.FromStream(fs);
                fs.Close();
                pictureBox顯示圖片.Tag = str完整圖檔路徑;
            }
            reader.Close();
            con.Close();
        }


        void 顯示商品詳細資訊(FittedCap fittedCap)
        {
            txt商品名.Text = fittedCap.name;
            txt隊伍名.Text = fittedCap.team;
            txt庫存量.Text = "0";
            txt顏色.Text = fittedCap.color;
            txt價格.Text = fittedCap.price.ToString();
        }//剛開始load欄位用


        void 帽子在Combobox初始化(FittedCap fittedCap, System.Windows.Forms.ComboBox box)
        {
            int i = 0;
            string str = "";
            for (i = 0; i < 10; i++)
            {
                if (fittedCap.Sizecount[i] > 0)
                {
                    str = 位置轉換庫存大小(i);
                    box.Items.Add(str);
                }
            }
        }//將combox依庫存數量初始化

        public string 位置轉換庫存大小(int num)//做尺寸轉換
        {
            string mrg = "";
            switch (num)
            {
                case 0: mrg = "6 7/8"; break;
                case 1: mrg = "7"; break;
                case 2: mrg = "7 1/8"; break;
                case 3: mrg = "7 1/4"; break;
                case 4: mrg = "7 3/8"; break;
                case 5: mrg = "7 1/2"; break;
                case 6: mrg = "7 5/8"; break;
                case 7: mrg = "7 3/4"; break;
                case 8: mrg = "7 7/8"; break;
                case 9: mrg = "8"; break;
            }
            return mrg;
        }

        public int 尺寸轉換庫存位置(string size)
        {
            int site = 0;
            switch (size)
            {
                case "6 7/8": site = 0; break;
                case "7": site = 1; break;
                case "7 1/8": site = 2; break;
                case "7 1/4": site = 3; break;
                case "7 3/8": site = 4; break;
                case "7 1/2": site = 5; break;
                case "7 5/8": site = 6; break;
                case "7 3/4": site = 7; break;
                case "7 7/8": site = 8; break;
                case "8": site = 9; break;
            }
            return site;
        }//string尺寸轉換陣列位子

        void 帽子數量txtBox(System.Windows.Forms.TextBox textBox, int max)//確認目前textbox是否超過庫存數量
        {
            if (textBox.Text != "")
            {//用於嘗試將字符串轉換為特定數據類型。如果轉換成功，它會返回 true，並將轉換後的值存儲在輸出參數中
                bool 數量輸入正確 = Int32.TryParse(textBox.Text, out 預購帽數);
                if ((數量輸入正確) && 預購帽數 > 0)
                {
                    if (max < 預購帽數)
                    {
                        MessageBox.Show("對不起,欲訂購商品數量已超過庫存");
                    }
                    預購帽數 = Convert.ToInt32(textBox.Text);
                }
                else
                {
                    MessageBox.Show("輸入錯誤請,重新輸入");
                }
            }
        }

        void 計算單品總價()
        {
            單品總價 = 預購帽數 * 單價;
        }

        private void comBox大小_SelectedIndexChanged(object sender, EventArgs e)//找出對應尺寸的庫存量
        {
            string flag;
            int site = 0;
            flag = comBox大小.Text;
            site = 尺寸轉換庫存位置(flag);
            txt庫存量.Text = list帽子.Sizecount[site].ToString();
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            if ((txt隊伍名.Text != "") && (txt商品名.Text != "") && (txt顏色.Text != "") && (txt價格.Text != null))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "update 帽子庫存 set name=@Newname, team=@Newteam, color=@Newcolor, price=@NewPrice where team=@Searchteam and name=@Searchname";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("Searchteam", team);
                cmd.Parameters.AddWithValue("@Searchname", name);
                cmd.Parameters.AddWithValue("@Newname", txt商品名.Text);
                cmd.Parameters.AddWithValue("@Newteam", txt隊伍名.Text);
                cmd.Parameters.AddWithValue("@Newcolor", txt顏色.Text);
                int intPrice = 0;
                Int32.TryParse(txt價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料修改成功, 影響{rows}筆資料");
            }
            else
            {
                MessageBox.Show("所有欄位必填!");
            }
        }

        private void btn庫存設定_Click(object sender, EventArgs e)
        {
            帽子庫存設定 hat = new 帽子庫存設定();
            hat.name = txt商品名.Text;
            hat.team = txt隊伍名.Text;
            hat.ShowDialog();
        }

        private void btn商品下架_Click(object sender, EventArgs e)
        {
            刪除圖檔();
            刪除庫存();
            this.Close();
        }

        void 刪除圖檔()
        {
            if (txt隊伍名.Text != "" && txt商品名.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "delete from 帽子圖檔 where name = @Deletename and team = @Deleteteam";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Deletename", txt商品名.Text);
                cmd.Parameters.AddWithValue("@Deleteteam", txt隊伍名.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        void 刪除庫存()
        {
            if (txt隊伍名.Text != "" && txt商品名.Text != "")
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "delete from 帽子庫存 where name = @Deletename and team = @Deleteteam";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Deletename", txt商品名.Text);
                cmd.Parameters.AddWithValue("@Deleteteam", txt隊伍名.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                {
                    MessageBox.Show("商品已下架");
                }
            }
        }

        private void btnAddBag_Click(object sender, EventArgs e)
        {
            預購帽數 = Convert.ToInt32(txt數量.Text);
            if(預購帽數>0)
            {
                單價 = list帽子.price;
                計算單品總價();
                if (comBox大小.SelectedIndex >= 0 && txt數量.Text != "")
                {
                    ArrayList 訂購品項 = new ArrayList();
                    訂購品項.Add(list帽子.team);
                    訂購品項.Add(list帽子.name);
                    訂購品項.Add(list帽子.color);
                    訂購品項.Add(comBox大小.Text);//尺寸
                    訂購品項.Add(list帽子.price);
                    訂購品項.Add(預購帽數);
                    訂購品項.Add(單品總價);
                    GlobalVar.購物車.Add(訂購品項);//購物車裡面放的是FittedCap類別
                    MessageBox.Show("所選品項已加入購物車");
                }
                else
                {
                    MessageBox.Show("請選擇尺寸以及欲加入購物車的數量");
                }
            }
            else
            {
                MessageBox.Show("購買數量不可為 0");
            }
        }

        private void btn加_Click(object sender, EventArgs e)
        {
            int add;
            string number;
            int site = 尺寸轉換庫存位置(comBox大小.Text);
            add = Convert.ToInt32(txt數量.Text);
            if (add < list帽子.Sizecount[site])
            {
                add++;
                number = add.ToString();
                txt數量.Text = number;
            }
            else
            {
                MessageBox.Show("對不起,欲訂購商品數量已超過庫存");
            }
        }

        private void btn減_Click(object sender, EventArgs e)
        {
            int minus;
            string number;
            minus = Convert.ToInt32(txt數量.Text);
            if(minus > 0)
            {
                minus--;
                number = minus.ToString();
                txt數量.Text = number;
            }
            else
            {
                MessageBox.Show("對不起,欲訂購商品數量不得為負");
            }
        }
    }
}
