//寫一程式，使用亂數模擬小學老師出四則運算的數學題.先由亂數決定要做四則運算(+,‐,*,/)中的哪一種，
//然後再使用亂數產生兩個整數，接著由鍵盤輸入一個 整數，
//最後判斷由鍵盤輸入的整數是否與亂數產生兩個整數配合四則運算產生的結果相同.
//( ex: 1+2 = 3  答對  ; 2*4 = 7 答錯) 

class Program
    {
        static void Main(string[] args)
        {
            
            string[] a = new string[4] { "+", "－", "×", "÷" };
            Random b = new Random();
            int c = b.Next(0, 4);
            Console.Write("亂數{0}，代表四則運算符號為{1}", c, a[c]);
            Console.WriteLine();
            Console.WriteLine();
           
            Random k = new Random();
            int j = k.Next(0, 256);
            Console.Write("第一個整數為:{0}", j);
            int y = k.Next(0, 256);
            Console.Write("第一個整數為:{0}", y);
            Console.WriteLine();
               
            int p;
            Console.Write("輸入一整數:");
            p = Convert.ToInt16(Console.ReadLine());
            if (c == 0 && p ==j+y)
                Console.Write("答對");
            else if (c == 1 && p == j - y)
                Console.Write("答對");
            else if (c == 2 && p == j * y)
                Console.Write("答對");
            else if (c == 3 && p == j / y)
                Console.Write("答對");
            else 
                Console.Write("答錯"); 
            Console.Read();
        }
    } 
} 
