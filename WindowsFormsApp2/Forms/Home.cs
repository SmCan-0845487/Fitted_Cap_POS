using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Data.SqlClient;
using System.Xml.Linq;
using WindowsFormsApp2.權限功能;
using System.Net.NetworkInformation;

namespace WindowsFormsApp2.Forms
{
    public partial class Home : Form
    {
        public static string meg = "" ;
        List<FittedCap> list帽子  = new List<FittedCap>();
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<string> list道奇名稱 = new List<string>();
        List<string> list洋基名稱 = new List<string>();
        List<string> list太空人名稱 = new List<string>();
        List<string> list勇士名稱 = new List<string>();
        List<string> list響尾蛇名稱 = new List<string>();

        public Home()
        {
            InitializeComponent();
            meg = ("Cap Size    CM\n-------------------\n");
            meg += ("      7          55.8\n"); meg += ("    7 1/8     56.8\n"); meg += ("    7 1/4     57.7\n");
            meg += ("    7 3/8     58.7\n"); meg += ("    7 1/2     59.6\n"); meg += ("    7 5/8     60.6\n");
            meg += ("    7 3/4     61.5\n"); meg += ("    7 7/8     62.5\n"); meg += ("       8         63.5\n");
           
            label1.Click += Label_Click;//轉換頭圍的label設定
            label2.Click += Label_Click;
            label3.Click += Label_Click;
            label4.Click += Label_Click;
            label5.Click += Label_Click;

            if (GlobalVar.Permission == 0)
            {
                btn新增商品勇士.Visible = false;
                btn新增商品道奇.Visible = false;
                btn新增商品洋基.Visible = false;
                btn新增商品太空人.Visible = false;
                btn新增商品響尾蛇.Visible = false;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"LAPTOP-1LDJA3RM";//伺服器名稱
            scsb.InitialCatalog = "Project_Person";//資料庫名稱
            scsb.IntegratedSecurity = true;//true是windows驗證,false是sql驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();

            讀取帽子資料庫("勇士", imageList勇士, list勇士名稱);
            顯示ListView圖片模式(listView勇士, imageList勇士, list勇士名稱,256,200);
            讀取帽子資料庫("道奇", imageList道奇, list道奇名稱);
            顯示ListView圖片模式(listView道奇, imageList道奇, list道奇名稱,256,200);
            讀取帽子資料庫("洋基", imageList洋基, list洋基名稱);
            顯示ListView圖片模式(listView洋基, imageList洋基, list洋基名稱,256,200);
            讀取帽子資料庫("太空人", imageList太空人, list太空人名稱);
            顯示ListView圖片模式(listView太空人, imageList太空人, list太空人名稱,256,200);
            讀取帽子資料庫("響尾蛇", imageList響尾蛇, list響尾蛇名稱);
            顯示ListView圖片模式(listView響尾蛇, imageList響尾蛇, list響尾蛇名稱, 256, 200);
        }

        void 讀取帽子資料庫(string team,System.Windows.Forms.ImageList view, List<string> name)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select top 10 * from 帽子圖檔 where team = @Team;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Team", $"{team}");
            SqlDataReader reader = cmd.ExecuteReader();
            
            int count = 0;
            while (reader.Read())
            {
                name.Add((string)reader["name"]);
                string image_name = (string)reader["pimage"];
                string 完整圖檔路徑 = $"{GlobalVar.image_dir}\\{image_name}";
                Console.WriteLine(完整圖檔路徑);
                System.IO.FileStream fs = System.IO.File.OpenRead(完整圖檔路徑);
                Image img商品圖檔 = Image.FromStream(fs);

                view.Images.Add(img商品圖檔);
                fs.Close();
                count++;
            }
            reader.Close();
            con.Close();
        }

        void 顯示ListView圖片模式(System.Windows.Forms.ListView list, System.Windows.Forms.ImageList view,List<string> name,int width,int height)
        {
            list.Clear();
            list.View = View.LargeIcon; //LargeIcon, Tile, List, SmallIcon
            view.ImageSize = new Size(width,height);
            list.LargeImageList = view; //LargeIcon, Tile

            for (int i = 0; i < name.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = $"{name[i]}";
                item.Tag = $"{name[i]}";
                item.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                list.Items.Add(item);
            }
        }
        
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)//tabControl標籤自訂顏色
        {
            // 設定筆刷
            SolidBrush one = new SolidBrush(Color.FromArgb(255, 229, 204));
            SolidBrush two = new SolidBrush(Color.FromArgb(255, 204, 153));
            SolidBrush three = new SolidBrush(Color.FromArgb(255, 165, 79));
            SolidBrush four = new SolidBrush(Color.FromArgb(255, 140, 0));
            SolidBrush five = new SolidBrush(Color.FromArgb(255, 120, 0));
            SolidBrush black = new SolidBrush(Color.Black);

            // 設定標籤文字水平垂直中
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;  // 水平方向居中
            stringFormat.LineAlignment = StringAlignment.Center;  // 垂直方向居中

            // 逐個繪制各個標籤頁的背景顏色
            Rectangle rec1 = tabControl1.GetTabRect(0);
            e.Graphics.FillRectangle(one, rec1);

            Rectangle rec2 = tabControl1.GetTabRect(1);
            e.Graphics.FillRectangle(two, rec2);

            Rectangle rec3 = tabControl1.GetTabRect(2);
            e.Graphics.FillRectangle(three, rec3);

            Rectangle rec4 = tabControl1.GetTabRect(3);
            e.Graphics.FillRectangle(four, rec4);

            Rectangle rec5 = tabControl1.GetTabRect(4);
            e.Graphics.FillRectangle(five, rec5);

            // 設置文字顏色
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                Rectangle rec = tabControl1.GetTabRect(i);
                // 設置標簽文字大小
                e.Graphics.DrawString(tabControl1.TabPages[i].Text,
                new Font("新細明體", 16, System.Drawing.FontStyle.Bold), black, rec, stringFormat);
            }
        }

        private void Label_Click(object sender, EventArgs e)//轉換頭圍
        {
            MessageBox.Show($"{meg}", "轉換頭圍", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void listView道奇_ItemActivate(object sender, EventArgs e)
        {
            帽子點單介面 menu = new 帽子點單介面();
            menu.team = ("道奇");
            menu.name = listView道奇.SelectedItems[0].Tag as string;
            menu.ShowDialog();
        }

        private void listView勇士_ItemActivate(object sender, EventArgs e)
        {
            帽子點單介面 menu = new 帽子點單介面();
            menu.team = ("勇士");
            menu.name = listView勇士.SelectedItems[0].Tag as string;
            menu.ShowDialog();
        }

        private void listView洋基_ItemActivate(object sender, EventArgs e)
        {
            帽子點單介面 menu = new 帽子點單介面();
            menu.team = ("洋基");
            menu.name = listView洋基.SelectedItems[0].Tag as string;
            menu.ShowDialog();
        }

        private void listView太空人_ItemActivate(object sender, EventArgs e)
        {
            帽子點單介面 menu = new 帽子點單介面();
            menu.team = ("太空人");
            menu.name = listView太空人.SelectedItems[0].Tag as string;
            menu.ShowDialog();
        }

        private void listView響尾蛇_ItemActivate(object sender, EventArgs e)
        {
            帽子點單介面 menu = new 帽子點單介面();
            menu.team = ("響尾蛇");
            menu.name = listView響尾蛇.SelectedItems[0].Tag as string;
            menu.ShowDialog();
        }

        private void btn新增商品勇士_Click(object sender, EventArgs e)
        {
            新增商品 newpurchase = new 新增商品();
            newpurchase.flag = "hat";
            newpurchase.team = "勇士";
            newpurchase.ShowDialog();
        }

        private void btn新增商品道奇_Click(object sender, EventArgs e)
        {
            新增商品 newpurchase = new 新增商品();
            newpurchase.flag = "hat";
            newpurchase.team = "道奇";
            newpurchase.ShowDialog();
        }

        private void btn新增商品洋基_Click(object sender, EventArgs e)
        {
            新增商品 newpurchase = new 新增商品();
            newpurchase.flag = "hat";
            newpurchase.team = "洋基";
            newpurchase.ShowDialog();
        }

        private void btn新增商品太空人_Click(object sender, EventArgs e)
        {
            新增商品 newpurchase = new 新增商品();
            newpurchase.flag = "hat";
            newpurchase.team = "太空人";
            newpurchase.ShowDialog();
        }
        private void btn新增商品響尾蛇_Click(object sender, EventArgs e)
        {
            新增商品 newpurchase = new 新增商品();
            newpurchase.flag = "hat";
            newpurchase.team = "響尾蛇";
            newpurchase.ShowDialog();
        }
    }
}
