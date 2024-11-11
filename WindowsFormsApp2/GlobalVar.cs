using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class GlobalVar
    {
        public static List<ArrayList> 購物車 = new List<ArrayList>();
        public static string image_dir = @"C:\Users\User\Desktop\資展國際\個人專題\圖片放置區\商品";
        public static string strDBConnectionString = "";
        public static int ID = 0;
        public static int Permission = 0;//權限
    }
}
