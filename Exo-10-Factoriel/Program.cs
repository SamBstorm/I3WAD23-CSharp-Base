namespace Exo_10_Factoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez indiquer un entier naturel à mettre sous factoriel :");
            string? reponse = Console.ReadLine();
            int facto;
            bool isConverted = int.TryParse(reponse, out facto);
            while (!isConverted)
            {
                Console.WriteLine($"La valeur {reponse} n'est pas un entier naturel!");
                Console.WriteLine("Veuillez indiquer un entier naturel à mettre sous factoriel :");
                reponse = Console.ReadLine();
                isConverted = int.TryParse(reponse, out facto);
            }
            long result = 1;
            for (int i = facto; i > 1 ; i--)
            {
                result *= i;
            }
            Console.WriteLine($"Le Factoriel de {facto} est : {result}");
        }
    }
}