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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2.權限功能
{
    public partial class 帽子庫存設定 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public string name;
        public string team;
        string size = "";
        public 帽子庫存設定()
        {
            InitializeComponent();
        }

        private void 帽子庫存設定_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"LAPTOP-1LDJA3RM";//伺服器名稱
            scsb.InitialCatalog = "Project_Person";//資料庫名稱
            scsb.IntegratedSecurity = true;//true是windows驗證,false是sql驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
        }

        private void btn修改_Click(object sender, EventArgs e)
        {
            if(comboBoxt尺寸選擇.SelectedIndex >= 0)
            {
                if(txt數量 != null)
                {
                    int number;
                    Int32.TryParse(txt數量.Text, out number);
                    SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                    con.Open();
                    string strSQL = "update 帽子庫存 set stock=@NewStack where name=@Sname and team=@Steam and size=@Ssize ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Sname", name);
                    cmd.Parameters.AddWithValue("@Steam", team);
                    cmd.Parameters.AddWithValue("@Ssize", size);
                    cmd.Parameters.AddWithValue("@NewStack", number);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rows > 0)
                    {
                        MessageBox.Show("資料修改成功!!");
                    }
                }
                else
                {
                    MessageBox.Show("請選擇欲修改的庫存數量");
                }
            }
            else
            {
                MessageBox.Show("請選擇欲修改的尺寸");
            }
        }

        private void comboBoxt尺寸選擇_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = (string)comboBoxt尺寸選擇.SelectedItem;
        }
    }
}
