namespace Exo_00_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bonjour, à qui ai-je l'honneur?");
            string? username = Console.ReadLine();
            Console.Clear();
            //Console.Write(username);
            //Console.WriteLine(", c'est très joli nom!");

            //Console.WriteLine("{0}, c'est très joli nom!", username);
            
            //Console.WriteLine($"{username}, c'est très joli nom!");

            Console.WriteLine(username + ", c'est très joli nom!");
            Console.WriteLine("Appuyez sur 'Enter' pour quitter!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ho! Vous nous quittez déjà!");
            //Console.Write("Au revoir, ");
            //Console.WriteLine(username);

            //Console.WriteLine("Au revoir, {0}", username);

            //Console.WriteLine("Au revoir, " + username);

            Console.WriteLine($"Au revoir, {username}");        
        }
    }
}