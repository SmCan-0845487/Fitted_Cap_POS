using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Forms
{
    public partial class 購物車 : Form
    {
        /*private ListBox productListBox;
        private ListBox cartListBox;
        private Button addToCartButton;
        private Button removeFromCartButton;*/
        int 訂單總價 = 0;
        public 購物車()
        {
            InitializeComponent();
        }

        private void 購物車_Load(object sender, EventArgs e)
        {
            foreach (ArrayList item in GlobalVar.購物車)
            {
                string 隊伍 = (string)item[0];
                string 品項名 = (string)item[1];
                string 顏色 = (string)item[2];
                string 尺寸 = (string)item[3];
                int 單價 = (int)item[4];
                int 帽數 = (int)item[5];
                int 單品總價 = (int)item[6];

                listBox購物車.Items.Add($"{隊伍}隊  [{品項名}] [顏色]{顏色} [尺寸]{尺寸.PadLeft(7)} [單價]{單價}元 {帽數}頂 {單品總價}元");
            }
            計算購物車總價();
        }

        void 計算購物車總價()
        {
            訂單總價 = 0;
            foreach (ArrayList item in GlobalVar.購物車)
            {
                int 單品總價 = (int)item[6];
                訂單總價 += 單品總價;
            }
            lbl訂單總價.Text = $"訂單總價 {訂單總價}元";
        }

        private void btn移除所選_Click(object sender, EventArgs e)
        {
            if(listBox購物車.SelectedIndex >= 0)
            {
                int selindex = listBox購物車.SelectedIndex;
                listBox購物車.Items.RemoveAt(selindex);
                GlobalVar.購物車.RemoveAt(selindex);
                計算購物車總價();
            }
            else
            {
                MessageBox.Show("請選擇移除品項");
            }
        }

        private void btn清空_Click(object sender, EventArgs e)
        {
            listBox購物車.Items.Clear();
            GlobalVar.購物車.Clear();
            計算購物車總價();
        }

        private void btn結帳_Click(object sender, EventArgs e)
        {
            結帳選擇地址及配送方式 address = new 結帳選擇地址及配送方式();
            address.訂單總價 = 訂單總價;
            address.ShowDialog();
        }
    }

}

