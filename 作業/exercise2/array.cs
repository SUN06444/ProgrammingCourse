//輸入5個朋友的姓名及電話，然後輸入要查詢的朋友之姓名，輸出朋友的電話。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            string name;
            string [] avg = new string [5] {"小強", "志明", "春嬌", "阿榮","蒙哥"};
            string[] phone = new string[5] {"0911223344","0955667788","0912345678","0990123456","0987654382"};
            Console.Write("輸入欲查詢的聯絡人:");
            name = Console.ReadLine();
            index = Array.BinarySearch(avg, name);
            Console.WriteLine("查詢結果:");
            if (index < 0)
            {
                Console.WriteLine("該聯絡人不存在!");
            }
            else
            {
                Console.WriteLine("該聯絡人電話位於陣列中phone[{0}]={1}", index, phone[index]);
                Console.WriteLine("相當於陣列中的第{0}個元素...", index + 1);
            }
            Console.Read();
        }
    }
}
