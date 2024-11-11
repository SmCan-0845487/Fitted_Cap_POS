using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class hat
    {//類別變數
        public string name;
        public string team;
        public string color;
        public int stock = 0;
        public int price = 0;

    }
    class FittedCap : hat
    {
        public int[] Sizecount = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    }

    class OrderList : hat
    {
        public string 訂單編號;
        public string 尺寸;
        public int 數量;
        public int 單品總價;
    }

    class Order : hat
    {
        public string 訂單編號;
        public string 訂單狀態;
        public string 下單時間;
        public string 下貨地點;
        public string 訂單總價;
        public string 下單會員id;
    }
}
