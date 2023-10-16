namespace Exo_08_Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int table = 1; table <= 5 ; table++)
            {
                for (int multiple = 1; multiple <= 20; multiple++)
                {
                    Console.Write($"{table} * {multiple} = {table*multiple} ;\t");
                }
                Console.WriteLine();
            }
        }
    }
}