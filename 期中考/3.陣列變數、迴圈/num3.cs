//寫一程式，輸入一個 5位數，分別印出其個位數、十位數、百位數、千位數及萬位數。
//(ex: 12345  則個位數:5、十位數:4、百位數:2、千位數:2 及萬位數:1)  
//(使用陣列變數及迴圈，才給分) 

static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.Write("請輸入一個五位數字：");
            int b = int.Parse(Console.ReadLine());
            a[0] = b % 10;
            a[1] = (b % 100) / 10;
            a[2] = (b % 1000) / 100;
            a[3] = (b % 10000) / 1000;
            a[4] = b / 10000;
            Console.Write("{0} ", b);
            string[] c = new string[5] { "個", "十", "百", "千", "萬" };
            for (int i = 0; i <= 4; i++)
            {
                Console.Write(" {0}位數：{1}", c[i], a[i]);
            }
            Console.Read();
        }
    }
}
