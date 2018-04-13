//寫一程式，使用亂數模擬人擲四個骰子，印出執行結果.遊戲規則如下:  
//1. 若 4 顆骰子的點數均相同，則印出”通殺”. (ex: 1 1 1 1)  
//2. 若任3顆骰子的點數相同或四顆點數均不相同，則印出無意義. (ex: 1 2 3 4)  
//3. 只要其中任2顆骰子的點數相同時，才需計算點數，點數即為另兩個點數相加
//，若另兩個也一樣，則取較大的一組相加. 則印出點數.  
//(ex: 1 2 2 3 印出 4 (1+3) ; 5 3 5 3 印出 10 (5+5)  

static void Main(string[] args)
        {
            Random tran = new Random();
            int[] dice = new int[4];
            int i;
            for (i = 0; i < 4; i++)
            {
                dice[i] = tran.Next(1, 7);
                Console.WriteLine("第{0}個數:{1}",i+1,dice[i]);  
            }
                Array.Sort(dice);
                if (dice[0] == dice[3]) 
                    Console.WriteLine("通殺");
                if (dice[0] != dice[1] && dice[1] != dice[2] && dice[2] != dice[3])
                    Console.WriteLine("無意義");
                if (dice[0] != dice[1] && dice[1] == dice[2] && dice[2] == dice[3])
                    Console.WriteLine("無意義");
                if (dice[0] == dice[1] && dice[1] == dice[2] && dice[2] != dice[3])
                    Console.WriteLine("無意義");
                if (dice[0] == dice[1] && dice[2] != dice[1] && dice[2] != dice[3])
                    Console.WriteLine("{0}+{1}={2}", dice[2], dice[3], dice[2] + dice[3]);
                if (dice[1] == dice[2] && dice[0] != dice[1] && dice[3]!=dice[1])
                    Console.WriteLine("{0}+{1}={2}", dice[0], dice[3], dice[0] + dice[3]);
                if (dice[2] == dice[3] && dice[0] != dice[1] && dice[1]!=dice[2])
                    Console.WriteLine("{0}+{1}={2}", dice[0], dice[1], dice[0] + dice[1]);
                if (dice[0] == dice[1] && dice[2] == dice[3] && dice[1]!=dice[2])
                    Console.WriteLine("{0}+{1}={2}", dice[2], dice[3], dice[2] + dice[3]);
           Console.Read(); 
        }  
    }
}
