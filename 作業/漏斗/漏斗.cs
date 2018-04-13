//漏斗

namespace 漏斗
{
    class Program
    {
        static void Main(string[] args)
        {
             for (int i = 1; i <= 3; i++) 
            {
                for (int j = 0; j < i; j++) 
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= 6 - 2 * i; k++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 2; i++) 
            {
                for (int j = 0; j < 3 - i; j++) 
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
