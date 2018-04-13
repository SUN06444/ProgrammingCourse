//寫一程式，建立一個內含求兩個整數的最大公因數之非靜態方法的類別(名稱叫solvegcd)，
//程式執行時,輸入兩個整數，然後顯示兩個整數的最大公因數。
//(例: 輸入:120 與 24 ,顯示 120 與 24 的最大公因數=24 ). 

namespace GCD
{
    class solvegcd
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入第一個數：");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入第二個數：");
            int b = Convert.ToInt32(Console.ReadLine());
            int gcd = GCD(a, b);
                Console.WriteLine("({0},{1})的最大公因數 = {2}", a, b, gcd);
          Console.Read();
        }

        private static int GCD(int a,int b)
         {
            if(a % b == 0)
              return b;
            else
             return GCD(b, a % b);
        }
    }
}
