namespace Exo_03_JeuxHasard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Veuillez indiquer votre année de naissance (YYYY) :");

            if (int.TryParse(Console.ReadLine(), out year))
            {
                //if(year <= DateTime.Now.Year - 18)
                if (DateTime.Now.Year - year >= 18)
                {
                    Console.WriteLine("Veuillez indiquer votre nationalité SVP :");
                    switch (Console.ReadLine())
                    {
                        case "Belge":
                            Console.WriteLine("Bienvenue sur le site de la loterie nationale, une fois!");
                            break;
                        case "Français":
                        case "Française":
                            Console.WriteLine("Bienvenue sur le site de la loterie nationale! Cocorico!");
                            break;
                        case "Suisse":
                            Console.WriteLine("Bienvenuuuuue sur le siteeeeuhhh de la loterie nationaleeeeeuhhh!");
                            break;
                        case "Canadien":
                        case "Canadienne":
                            Console.WriteLine("Bienvenue sur le site de la loterie nationale! Tabernacle!");
                            break;
                        default:
                            Console.WriteLine("Malheureusement, vous n'êtes pas éligible...");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Vous êtes trop jeune, il vous reste {18 - (DateTime.Now.Year - year)} ans à attendre...");
                }
            }
            else
            {
                Console.WriteLine("Vous n'avez pas entrer une année valable.");
            }
        }
    }
}