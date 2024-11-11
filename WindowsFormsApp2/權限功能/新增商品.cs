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
    public partial class 新增商品 : Form
    {
        public string flag;//選擇是新增帽子還是pin
        public string team;//選擇現在加入的隊伍
        string str修改後的圖檔名稱 = "";
        bool is修改圖檔 = false;
        public 新增商品()
        {
            InitializeComponent();
        }

        private void 新增商品_Load(object sender, EventArgs e)
        {
            if(flag == "pin")
            {
                lbl隊伍名.Visible = false;
                txt隊伍名.Visible = false;
                lbl顏色.Visible = false;
                txt顏色.Visible = false;
                groupbox尺寸庫存.Visible = false;
            }
            else
            {
                txt庫存量.Visible = false;
                lbl庫存量 .Visible = false;
                txt隊伍名.Text = team;
            }
        }

        void 選取商品圖片()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "檔案類型(JPEG, JPG, PNG)|*.jpeg;*.jpg;*.png";
            DialogResult R = ofd.ShowDialog();

            if (R == DialogResult.OK)
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
                pictureBox商品圖片.Image = Image.FromStream(fs);
                fs.Close();
                pictureBox商品圖片.Tag = ofd.FileName;
                string str圖檔副檔名 = System.IO.Path.GetExtension(ofd.SafeFileName).ToLower();//取得檔案副檔名,且變小寫
                Random myRnd = new Random();
                str修改後的圖檔名稱 = DateTime.Now.ToString("yyMMddHHmmss") + myRnd.Next(1000, 10000).ToString() + str圖檔副檔名;
                is修改圖檔 = true;
                Console.WriteLine(str修改後的圖檔名稱);
            }
        }

        private void btn選取商品照片_Click(object sender, EventArgs e)
        {
            選取商品圖片();
        }
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

        void 新增至Pin()
        {
            if ((txt商品名.Text != "") && (txt價格.Text != "") && (txt庫存量.Text != "") && (pictureBox商品圖片.Image != null))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "insert into Pin商品 values (@Newname, @NewPrice, @NewStock, @NewPimage);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Newname", txt商品名.Text.Trim());
                int intPrice = 0;
                Int32.TryParse(txt價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewStock", txt庫存量.Text.Trim());
                cmd.Parameters.AddWithValue("@NewPimage", str修改後的圖檔名稱);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (is修改圖檔)
                {
                    string 完整圖檔路徑 = $"{GlobalVar.image_dir}\\{str修改後的圖檔名稱}";
                    pictureBox商品圖片.Image.Save(完整圖檔路徑);
                    is修改圖檔 = false;
                }
                MessageBox.Show($"資料新增成功, 影響{rows}筆資料");
            }
        }

        void 新增至帽子庫存(string size,int stock)
        {
            if ((txt商品名.Text != "") && (txt價格.Text != "") && (txt隊伍名.Text != "") && (txt顏色.Text != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "insert into 帽子庫存 values (@Newname,@Newteam, @Newcolor,@NewPrice, @NewSize,@NewStock);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Newname", txt商品名.Text.Trim());
                cmd.Parameters.AddWithValue("@Newteam", txt隊伍名.Text.Trim());
                cmd.Parameters.AddWithValue("@Newcolor", txt顏色.Text.Trim());
                int intPrice = 0;
                Int32.TryParse(txt價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewSize",size);
                cmd.Parameters.AddWithValue("@NewStock", stock);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        void 新增至帽子圖檔()
        {
            if ((txt商品名.Text != "") && (txt價格.Text != "") && (txt隊伍名.Text != "") && (txt顏色.Text != "") && (pictureBox商品圖片.Image != null))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "insert into 帽子圖檔 values (@Newname,@Newteam, @Newcolor,@NewPrice, @NewPimage);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@Newname", txt商品名.Text.Trim());
                cmd.Parameters.AddWithValue("@Newteam", txt隊伍名.Text.Trim());
                cmd.Parameters.AddWithValue("@Newcolor", txt顏色.Text.Trim());
                int intPrice = 0;
                Int32.TryParse(txt價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPimage", str修改後的圖檔名稱);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (is修改圖檔)
                {
                    string 完整圖檔路徑 = $"{GlobalVar.image_dir}\\{str修改後的圖檔名稱}";
                    pictureBox商品圖片.Image.Save(完整圖檔路徑);
                    is修改圖檔 = false;
                }
                MessageBox.Show($"資料新增成功, 影響{rows}筆資料");
            }
        }

        List<int> 尺寸數量放進List()//將各尺寸欲修改的數量傳進一個list供新增至帽子庫存使用
        {
            int num;
            List<int> values = new List<int>();
            num = Convert.ToInt32(txt678.Text);
            values.Add(num);
            num = Convert.ToInt32(txt7.Text);
            values.Add(num);
            num = Convert.ToInt32(txt718.Text);
            values.Add(num);
            num = Convert.ToInt32(txt714.Text);
            values.Add(num);
            num = Convert.ToInt32(txt738.Text);
            values.Add(num);
            num = Convert.ToInt32(txt712.Text);
            values.Add(num);
            num = Convert.ToInt32(txt758.Text);
            values.Add(num);
            num = Convert.ToInt32(txt734.Text);
            values.Add(num);
            num = Convert.ToInt32(txt778.Text);
            values.Add(num);
            num = Convert.ToInt32(txt8.Text);
            values.Add(num);
            return values;
        }

        private void btn儲存商品_Click(object sender, EventArgs e)
        {
            string size;
            int stock;
            List<int> values = new List<int>();
            if (flag == "pin")
            {
                新增至Pin();
            }
            else if(flag == "hat")
            {
                values = 尺寸數量放進List();
                for (int i = 0;i<10;i++)
                {
                    size = 位置轉換庫存大小(i);
                    新增至帽子庫存(size, values[i]);
                }
                新增至帽子圖檔();
            }
        }
    }
}
