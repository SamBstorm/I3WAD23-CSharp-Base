namespace Demo_Variable_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Conversion avec Parse / TryParse
            Console.WriteLine("Bonjour, veuillez entrer un nombre :");
            string? reponse = Console.ReadLine();
            Console.WriteLine($"Vous avez répondu : {reponse}");
            //int nombre = int.Parse( reponse );
            //Console.WriteLine($"Votre nombre est : {nombre}");

            int nombre;
            bool isConverted = int.TryParse(reponse, out nombre);
            Console.WriteLine($"La conversion s'est bien passée : {isConverted}; voici le résultat : {nombre}.");


            //Convertion implicite
            //int i = 5;
            //long l = i;

            //Conversion explicite (casting)
            //short s = (short)i;

            //double d = 3.14;
            //int r = (int)d;
        }
    }
}