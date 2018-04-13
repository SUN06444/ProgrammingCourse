//寫一程式，使用巢狀迴圈，輸出以下結果.
//      5  
//    33333  
//  111111111  
//    33333   
//      5 

static void Main(string[] args)
        {
            int i, k, j;
            for (i = 1; i <= 3; i++)
            {
                for (k = 1; k <= 7 - 2 * i; k++)
                    Console.Write("{0}", ' ');
                for (j = 1; j <= (i - 1) * 4 + 1; j++)
                    Console.Write("{0}", 7 - 2 * i);
                Console.WriteLine();
            }
            for (i = 1; i <= 2; i++)
            {
                for (k = 1; k <= 2 * i + 1; k++)
                    Console.Write("{0}", ' ');
                for (j = 1; j <= 9 - 4 * i ; j++)
                    Console.Write("{0}", 2 * i + 1);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
