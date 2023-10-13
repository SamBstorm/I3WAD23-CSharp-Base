namespace Exo_02_PairImpair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez indiquer un nombre : ");
            string reponse = Console.ReadLine();
            bool isConverted = int.TryParse(reponse, out int nombre1);

            if (isConverted)
            {
                if (nombre1 == (nombre1 / 2) * 2)
                {
                    Console.WriteLine($"Le nombre {nombre1} est pair.");
                }
                else
                {
                    Console.WriteLine($"Le nombre {nombre1} est impair.");
                }
            }
            else
            {
                Console.WriteLine($"La valeur {reponse}, n'est pas un nombre. Veuillez introduire un nombre!");
            }
        }
    }
}