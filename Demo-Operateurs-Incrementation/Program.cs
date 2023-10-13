namespace Demo_Operateurs_Incrementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;

            //int j = i++;

            //Equivalent
            int j = i;
            i++;

            Console.WriteLine($"i : {i} | j : {j}");

            Console.WriteLine($"i + j => {i+j}");

            j += i;
            Console.WriteLine($"i : {i} | j : {j}");
        }
    }
}