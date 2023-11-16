namespace Demo_Enumeration_FeuRouge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight feu1;
            feu1.currentColor = TrafficLightColor.Rouge;

            Console.WriteLine($"Le feu est de couleur : {feu1.currentColor}");
            feu1.ChangeColor();
            Console.WriteLine($"Le feu est de couleur : {feu1.currentColor}");
            feu1.ChangeColor();
            Console.WriteLine($"Le feu est de couleur : {feu1.currentColor}");
            feu1.ChangeColor();
            Console.WriteLine($"Le feu est de couleur : {feu1.currentColor}");

            Console.WriteLine("Une console windows peut avoir les couleurs :");
            //string[] couleurs = Enum.GetNames(typeof(ConsoleColor));
            //string[] couleurs = Enum.GetNames<ConsoleColor>();
            //foreach (string couleur in couleurs)
            //{
            //    Console.BackgroundColor = Enum.Parse<ConsoleColor>( couleur );
            //    Console.WriteLine(couleur);
            //}


            ConsoleColor[] couleurs = Enum.GetValues<ConsoleColor>();
            foreach (ConsoleColor couleur in couleurs)
            {
                Console.ForegroundColor = couleur;
                Console.WriteLine(couleur);
            }
            Console.ResetColor();
        }
    }
}