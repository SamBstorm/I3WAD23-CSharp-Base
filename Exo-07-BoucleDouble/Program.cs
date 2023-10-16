namespace Exo_07_BoucleDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (double i = 0; i <= 20; i += 0.1)
            {
                Console.WriteLine(i);
            }

            for (decimal i = 0; i <= 20M; i+= 0.1M)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 200; i++)
            {
                Console.WriteLine(i / 10D);
            }
        }
    }
}