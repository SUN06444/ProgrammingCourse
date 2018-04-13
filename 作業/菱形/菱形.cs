//菱形

namespace 菱形
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 1; i <= 4; i++) 
            {
                for (j = 0; j < 4 - i; j++) 
                {
                    Console.Write(" ");
                }
                for (k = 0; k < 2 * i - 1; k++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (i = 1; i <= 3; i++) 
            {
                for (j = 0; j < i; j++) 
                {
                    Console.Write(" ");
                }
                for (k = 0; k <= 6 - 2 * i; k++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
