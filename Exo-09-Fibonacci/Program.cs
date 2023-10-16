namespace Exo_09_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f0 = 0;
            int f1 = 1;
            int n = 25;

            Console.WriteLine($"F0 : {f0}");
            Console.WriteLine($"F1 : {f1}");
            for (int i = 2; i <= n; i++)
            {
                int f = f0 + f1;
                Console.WriteLine($"F{i} : {f}");
                f0 = f1;
                f1 = f;
            }
        }
    }
}