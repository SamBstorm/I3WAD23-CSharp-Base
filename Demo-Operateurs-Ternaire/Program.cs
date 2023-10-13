namespace Demo_Operateurs_Ternaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez indiquer combien d'année vous reste-t-il de formation?");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                //if (year > 1)
                //{
                //    Console.WriteLine($"Waouw! Il vous reste {year} années!");
                //}
                //else
                //{
                //    Console.WriteLine($"Waouw! Il vous reste {year} année!");
                //}

                ////Avec ternaire et affectation
                //string message = (year > 1) ? "s" : "";
                //Console.WriteLine($"Waouw! Il vous reste {year} année{message}!");

                //Avec ternaire dans l'exécution
                Console.WriteLine($"Waouw! Il vous reste {year} année{((year > 1) ? "s" : "")}!");
            }
        }
    }
}