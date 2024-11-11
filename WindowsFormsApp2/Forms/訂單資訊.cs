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
using System.Xml.Linq;

namespace WindowsFormsApp2.Forms
{
    public partial class 訂單資訊 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        List<Order> list訂單 = new List<Order>();
        int flag1,flag2;
        int page = 0;//翻到第幾訂單
        public 訂單資訊()
        {
            InitializeComponent();
        }

        private void 訂單狀態_Load(object sender, EventArgs e)
        {
            page = 0;
            scsb.DataSource = @"LAPTOP-1LDJA3RM";//伺服器名稱
            scsb.InitialCatalog = "Project_Person";//資料庫名稱
            scsb.IntegratedSecurity = true;//true是windows驗證,false是sql驗證
            GlobalVar.strDBConnectionString = scsb.ConnectionString;
            btn上一頁.Visible = false;
            btn下一頁.Visible = false;
            if(GlobalVar.Permission > 0)
            {
                rdBtn完成訂單.Visible = false;
                rdBtn未出貨訂單.Visible = false;
                rdBtn全部訂單.Visible = false ;
                會員全部訂單();
                清空listbox();
                page = 0;
                初始化listbox增加會員();
                if (list訂單.Count < 5)
                {
                    btn下一頁.Visible = false;
                }
                else
                {
                    btn下一頁.Visible = true;
                }
            }
            else
            {
                初始化訂單();
            }
            
        }

        void 會員全部訂單()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from 訂單";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                Order order = new Order();
                order.訂單編號 = reader["訂單編號"].ToString();
                order.訂單狀態 = reader["訂單狀態"].ToString();
                order.下單時間 = reader["下單時間"].ToString();
                order.下貨地點 = reader["下貨地點"].ToString();
                order.訂單總價 = reader["訂單總價"].ToString();
                order.下單會員id = reader["下單會員id"].ToString();
                list訂單.Add(order);
            }
            reader.Close();
            con.Close();
        }

        void 初始化訂單()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from 訂單 where 下單會員id = @Searchid";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@Searchid", $"{GlobalVar.ID}");
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                Order order = new Order();
                order.訂單編號 = reader["訂單編號"].ToString();
                order.訂單狀態 = reader["訂單狀態"].ToString();
                order.下單時間 = reader["下單時間"].ToString();
                order.下貨地點 = reader["下貨地點"].ToString();
                order.訂單總價 = reader["訂單總價"].ToString();
                list訂單.Add(order);
            }
            reader.Close();
            con.Close();
        }

        void 輸出listbox(ListBox box, Order order)
        {
            if (order.訂單編號 != "")//有東西在訂單裡
            {
                box.Items.Add($"[訂單編號]");
                box.Items.Add($"      {order.訂單編號}");
                box.Items.Add($"[訂單狀態 : {order.訂單狀態}]");
                box.Items.Add($"[下單時間]");
                box.Items.Add($"      {order.下單時間}");
                box.Items.Add($"[下貨地點]");
                box.Items.Add($"      {order.下貨地點}");
                box.Items.Add($"[訂單總價]");
                box.Items.Add($"      {order.訂單總價}");
            }
        }

        void 輸出listbox加入訂單人(ListBox box, Order order)
        {
            if (order.訂單編號 != "")//有東西在訂單裡
            {
                box.Items.Add($"[訂單編號]");
                box.Items.Add($"      {order.訂單編號}");
                box.Items.Add($"[訂單狀態 : {order.訂單狀態}]");
                box.Items.Add($"[下單會員 : {order.下單會員id}]");
                box.Items.Add($"[下單時間]");
                box.Items.Add($"      {order.下單時間}");
                box.Items.Add($"[下貨地點]");
                box.Items.Add($"      {order.下貨地點}");
                box.Items.Add($"[訂單總價]");
                box.Items.Add($"      {order.訂單總價}");
            }
        }
        void 初始化listbox()
        {
            if(page<list訂單.Count)
            {
                輸出listbox(listBox訂單1, list訂單[page]);
                page++;
            }
            if (page < list訂單.Count)
            {
                輸出listbox(listBox訂單2, list訂單[page]);
                page++;
            }
            if (page < list訂單.Count)
            {
                輸出listbox(listBox訂單3, list訂單[page]);
                page++;
            }
            if (page < list訂單.Count)
            {
                輸出listbox(listBox訂單4, list訂單[page]);
                page++;
            }
        }

        void 初始化listbox增加會員()
        {
            if (page < list訂單.Count)
            {
                輸出listbox加入訂單人(listBox訂單1, list訂單[page]);
                page++;
            }
            if (page < list訂單.Count)
            {
                輸出listbox加入訂單人(listBox訂單2, list訂單[page]);
                page++;
            }
            if (page < list訂單.Count)
            {
                輸出listbox加入訂單人(listBox訂單3, list訂單[page]);
                page++;
            }
            if (page < list訂單.Count)
            {
                輸出listbox加入訂單人(listBox訂單4, list訂單[page]);
                page++;
            }
        }

        void 初始化listbox已完成()
        {
            flag1=1;
            while (page < list訂單.Count)
            {
                if(list訂單[page].訂單狀態 == "已完成")
                {
                    if( flag1 ==1)
                    {
                        輸出listbox(listBox訂單1, list訂單[page]);
                        flag1++;
                    }
                    else if (flag1 == 2)
                    {
                        輸出listbox(listBox訂單2, list訂單[page]);
                        flag1++;
                    }
                    else if (flag1 == 3)
                    {
                        輸出listbox(listBox訂單3, list訂單[page]);
                        flag1++;
                    }
                    else if (flag1 == 4)
                    {
                        輸出listbox(listBox訂單4, list訂單[page]);
                    }
                }
                page++;
            }
        }

        void 初始化listbox未出貨()
        {
            int flag2 = 1;
            while (page < list訂單.Count)
            {
                if (list訂單[page].訂單狀態 == "未出貨")
                {
                    if (flag2 == 1)
                    {
                        輸出listbox(listBox訂單1, list訂單[page]);
                        flag2++;
                    }
                    else if (flag2 == 2)
                    {
                        輸出listbox(listBox訂單2, list訂單[page]);
                        flag2++;
                    }
                    else if (flag2 == 3)
                    {
                        輸出listbox(listBox訂單3, list訂單[page]);
                        flag2++;
                    }
                    else if (flag2 == 4)
                    {
                        輸出listbox(listBox訂單4, list訂單[page]);
                    }
                }
                page++;
            }
        }

        private void btn下一頁_Click(object sender, EventArgs e)
        {
            if (rdBtn完成訂單.Checked)
            {
                清空listbox();
                初始化listbox已完成();
            }
            else if (rdBtn未出貨訂單.Checked)
            {
                清空listbox();
                初始化listbox未出貨();
            }
            else if (rdBtn全部訂單.Checked)
            {
                清空listbox();
                初始化listbox();
            }
            else
            {
                清空listbox();
                初始化listbox增加會員();
            }
            if (page == list訂單.Count)
            {
                btn下一頁.Visible = false;
            }
            btn上一頁.Visible = true;
        }

        private void btn上一頁_Click(object sender, EventArgs e)
        {
            int numflag;
            numflag = page % 4;
            if (numflag == 0 && page>4)
            {
                page = page - 8;
            }
            else
            {
                page = page-numflag - 4;
            }
            
            btn下一頁.Visible = true;
            if (page==0)
            {
                btn上一頁.Visible=false;
            }
            if(rdBtn完成訂單.Checked)
            {
                清空listbox();
                初始化listbox已完成();
            }
            else if(rdBtn未出貨訂單.Checked)
            {
                清空listbox();
                初始化listbox未出貨();
            }
            else if(rdBtn全部訂單.Checked)
            {
                清空listbox();
                初始化listbox();
            }
            else
            {
                清空listbox();
                初始化listbox增加會員();
            }
        }

        void 清空listbox()
        {
            listBox訂單1.Items.Clear();
            listBox訂單2.Items.Clear();
            listBox訂單3.Items.Clear();
            listBox訂單4.Items.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            訂單詳細資料 orderlist = new 訂單詳細資料();
            try
            {
                orderlist.訂單編號 = listBox訂單1.Items[1].ToString().Trim();
                orderlist.ShowDialog();
            }
            catch
            {
                MessageBox.Show("錯誤");
            }
        }//顯示詳細資訊

        private void btn2_Click(object sender, EventArgs e)
        {
            訂單詳細資料 orderlist = new 訂單詳細資料();
            try
            {
                orderlist.訂單編號 = listBox訂單2.Items[1].ToString().Trim();
                orderlist.ShowDialog();
            }
            catch
            {
                MessageBox.Show("錯誤");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            訂單詳細資料 orderlist = new 訂單詳細資料();
            try
            {
                orderlist.訂單編號 = listBox訂單3.Items[1].ToString().Trim();
                orderlist.ShowDialog();
            }
            catch
            {
                MessageBox.Show("錯誤");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            訂單詳細資料 orderlist = new 訂單詳細資料();
            try
            {
                orderlist.訂單編號 = listBox訂單4.Items[1].ToString().Trim();
                orderlist.ShowDialog();
            }
            catch
            {
                MessageBox.Show("錯誤");
            }
        }

        private void rdBtn完成訂單_CheckedChanged(object sender, EventArgs e)
        {
            清空listbox();
            page = 0;
            初始化listbox已完成();
            if(flag1 < 5)
            {
                btn下一頁.Visible = false;
            }
            else
            {
                btn下一頁.Visible = true;
            }
        }

        private void rdBtn未出貨訂單_CheckedChanged(object sender, EventArgs e)
        {
            清空listbox();
            page = 0;
            初始化listbox未出貨();
            if (flag2 < 5)
            {
                btn下一頁.Visible = false;
            }
            else
            {
                btn下一頁.Visible = true;
            }
        }

        private void rdBtn全部訂單_CheckedChanged(object sender, EventArgs e)
        {
            清空listbox();
            page = 0;
            初始化listbox();
            if (list訂單.Count < 5)
            {
                btn下一頁.Visible = false;
            }
            else
            {
                btn下一頁.Visible = true;
            }
        }
    }
}
