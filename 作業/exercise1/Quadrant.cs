//寫一程式，輸入平面座標上的一點(x,y)，判斷(x,y)位於哪一個象限或在x軸上或在y軸上。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5._10
{
    class Program
    {
        static void Main(string[] args)
        {
            float X, Y;
            Console.Write("請輸入 x 數值:");
            X = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入 y 數值:");
            Y = Convert.ToInt32(Console.ReadLine());
            if (X > 0 && Y > 0)
                Console.WriteLine("({0},{1})位於第{2}象限", X, Y, '一');
            else if (X<0 && Y>0)
                Console.WriteLine("({0},{1})位於第{2}象限", X, Y, '二');
            else if (X < 0 && Y < 0)
                Console.WriteLine("({0},{1})位於第{2}象限", X, Y, '三');
            else if (X > 0 && Y < 0)
                Console.WriteLine("({0},{1})位於第{2}象限", X, Y, '四');
            else if (Y==0)
                Console.WriteLine("({0},{1})位於 x 軸上", X, Y);
            else 
                Console.WriteLine("({0},{1})位於 y 軸上", X, Y);
            Console.Read();
        }
    }
}
